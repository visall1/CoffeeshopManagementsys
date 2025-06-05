using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EntityCoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace EntityCoffeeShop
{
    public partial class ProductList : UserControl
    {
        private int? _lastSavedPaymentId;
        private Payment _currentPayment;

        public ProductList()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        public void AddOrder(Product product, int quantity)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == product.Name)
                {
                    int existingQty = Convert.ToInt32(row.Cells[1].Value);
                    int newQty = existingQty + quantity;
                    row.Cells[1].Value = existingQty + quantity;
                    row.Cells[2].Value = (product.Price * newQty).ToString("0.00");
                    CalculateTotal();
                    return;
                }
            }

            dataGridView1.Rows.Add(product.Name, quantity, (product.Price * quantity).ToString("0.00"));
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = dataGridView1.Rows.Cast<DataGridViewRow>()
        .Where(row => row.Cells[2].Value != null)
        .Sum(row => Convert.ToDecimal(row.Cells[2].Value));

            lbTotal.Text = $"Total :    ${total:F2}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before paying.");
                return;
            }

            if (!decimal.TryParse(lbTotal.Text.Replace("Total :    $", "").Trim(), out decimal total))
            {
                MessageBox.Show("Invalid total amount format.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amountPaid))
            {
                MessageBox.Show("Please enter a valid amount paid.");
                return;
            }

            if (amountPaid < total)
            {
                MessageBox.Show("Amount paid is not enough to complete the purchase.");
                return;
            }

            SaveOrder();
            ClearUI();
        }

        private void ClearUI()
        {
            dataGridView1.Rows.Clear();
            lbTotal.Text = "Total : $0.00";
            txtAmount.Text = string.Empty;
            lbChange.Text = "Change: $0.00";
        }

        private void SaveOrder()
        {
            using var context = new CoffeeShopContext();

            if (!decimal.TryParse(lbTotal.Text.Replace("Total :    $", "").Trim(), out decimal total) ||
                !decimal.TryParse(txtAmount.Text, out decimal amountPaid))
            {
                MessageBox.Show("Invalid total or paid amount.");
                return;
            }

            decimal change = amountPaid - total;

            var order = new Order
            {
                OrderTime = DateTime.Now,
                CustomerId = null,
                OrderItems = new List<OrderItem>()
            };

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value is string productName &&
                    context.Products.FirstOrDefault(p => p.Name == productName) is Product product)
                {
                    int quantity = Convert.ToInt32(row.Cells[1].Value);
                    order.OrderItems.Add(new OrderItem
                    {
                        ProductId = product.ProductId,
                        Quantity = quantity,
                        UnitPrice = product.Price
                    });
                }
            }

            if (order.OrderItems.Count == 0)
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            var payment = new Payment
            {
                Amount = amountPaid,
                Method = "Cash",
                PaidAt = DateTime.Now,
                Order = order
            };

            context.Orders.Add(order);
            context.Payments.Add(payment);
            context.SaveChanges();

            _lastSavedPaymentId = payment.PaymentId;
            LoadCurrentPayment();

            if (MessageBox.Show("Order saved successfully.\nDo you want to print the receipt?", "INFO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                PrintReceipt();
            }
        }

        private void LoadCurrentPayment()
        {
            if (_lastSavedPaymentId == null) return;

            using var context = new CoffeeShopContext();
            _currentPayment = context.Payments
                .Include(p => p.Order)
                .ThenInclude(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefault(p => p.PaymentId == _lastSavedPaymentId);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            lbChange.Text = "Change :   $0.00";

            if (!decimal.TryParse(txtAmount.Text, out decimal amountPaid)) return;
            if (!decimal.TryParse(lbTotal.Text.Replace("Total :    $", "").Trim(), out decimal total)) return;

            if (amountPaid < total)
            {
                lbChange.Text = $"Change :  Nahh-Nahh amount not valid!";
                return;
            }

            lbChange.Text = $"Change :  ${amountPaid - total:F2}";
        }

        private void PrintReceipt()
        {
            using SaveFileDialog saveDialog = new SaveFileDialog
            {
                Title = "Save Receipt as PDF",
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                PrintReceiptToPdf(saveDialog.FileName);
            }
        }

        
        private void PrintReceiptToPdf(string filePath)
        {
            PdfDocument document = new PdfDocument { Info = { Title = "Coffee Shop Receipt" } };
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12);

            int y = 40;
            gfx.DrawString("Coffee Shop Receipt", new XFont("Verdana", 14, XFontStyle.Bold), XBrushes.Black,
                new XRect(0, y, page.Width, 20), XStringFormats.TopCenter);
            y += 40;

            gfx.DrawString("Product    Qty    Price", font, XBrushes.Black, 40, y);
            y += 25;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string productName = row.Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[1].Value);
                    decimal price = Convert.ToDecimal(row.Cells[2].Value);
                    gfx.DrawString($"{productName}    {quantity}    ${price:F2}", font, XBrushes.Black, 40, y);
                    y += 20;
                }
            }

            gfx.DrawString($"Total: ${lbTotal.Text.Replace("Total :    $", "").Trim()}", font, XBrushes.Black, 40, y += 20);
            gfx.DrawString($"Change: ${lbChange.Text.Replace("Change :    $", "").Trim()}", font, XBrushes.Black, 40, y += 20);
            gfx.DrawString("Thank you for visiting!", font, XBrushes.Black, 40, y += 40);

            document.Save(filePath);
            MessageBox.Show("PDF receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearUI();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
