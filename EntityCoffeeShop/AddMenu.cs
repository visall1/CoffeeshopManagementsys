using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCoffeeShop.Model;

namespace EntityCoffeeShop
{
    public partial class AddMenu : UserControl
    {
        private byte[]? uploadedImageBytes = null;
        private int? currentProductId = null;
        
        public AddMenu()
        {
            InitializeComponent();
        }
        public void SetProductDetails(int id, string name, string price, byte[] imageBytes, int categoryId)
        {
            currentProductId = id;
            txtName.Text = name;
            txtPrice.Text = price;
            comboCategories.SelectedValue = categoryId;

            uploadedImageBytes = imageBytes;
            if (imageBytes != null)
            {
                using (var ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
            label1.Text = "UPDATE MENU: ";
            btnSave.Text = "Update";
        }
        public void SwitchToCreateMode()
        {
            currentProductId = null;
            clearMenu();
            btnSave.Text = "Save";
            label1.Text = "ADD NEW PRODUCT MENU:";
        }



        private void AddMenu_Load(object sender, EventArgs e)
        {
            using (var context = new CoffeeShopContext())
            {
                var categories = context.Categories
                    .Select(c => new { c.CategoryId, c.Name })
                    .ToList();

                comboCategories.DataSource = categories;
                comboCategories.DisplayMember = "Name";
                comboCategories.ValueMember = "CategoryId";
            }

            comboCategories.SelectedIndex = -1;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    uploadedImageBytes = File.ReadAllBytes(openFileDialog.FileName);

                    if (uploadedImageBytes == null || uploadedImageBytes.Length < 1000) // sanity check for minimum image size
                    {
                        MessageBox.Show("Please upload a valid image.");
                        return;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SwitchToCreateMode();
        }
        private void clearMenu()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            comboCategories.SelectedIndex = -1;
            pictureBox1.Image = null;
            uploadedImageBytes = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            if (comboCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return;
            }

            using (var context = new CoffeeShopContext())
            {
                if (currentProductId.HasValue)
                {
                    // UPDATE
                    var product = context.Products.Find(currentProductId.Value);
                    if (product != null)
                    {
                        product.Name = txtName.Text.Trim();
                        product.Price = price;
                        product.CategoryId = (int)comboCategories.SelectedValue;
                        product.Image = uploadedImageBytes;
                        context.SaveChanges();

                        MessageBox.Show("Product updated successfully!");
                    }
                }
                else
                {
                    // SAVE
                    var newProduct = new Product
                    {
                        Name = txtName.Text.Trim(),
                        Price = price,
                        CategoryId = (int)comboCategories.SelectedValue,
                        Image = uploadedImageBytes
                    };

                    context.Products.Add(newProduct);
                    context.SaveChanges();

                    MessageBox.Show("Product saved successfully!");
                }
            }

            var form = this.FindForm() as InventoryBoard;
            if (form != null)
            {
                var productDataControl = form.Controls.OfType<ProductData>().FirstOrDefault();
                productDataControl?.LoadOProducts_Explicit();
            }
            SwitchToCreateMode();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as InventoryBoard;

            if (form != null)
            {
                var productGrid = form.ProductDataControl.ProductsGrid;

                if (productGrid.SelectedRows.Count == 1)
                {
                    var selectedRow = productGrid.SelectedRows[0];
                    int productId = (int)selectedRow.Cells["ProductId"].Value;

                    var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        using (var context = new CoffeeShopContext())
                        {
                            var product = context.Products.Find(productId);
                            if (product != null)
                            {
                                context.Products.Remove(product);
                                context.SaveChanges();
                                MessageBox.Show("Product deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        form.ProductDataControl.LoadOProducts_Explicit(); // Refresh the grid
                    }
                }
                else
                {
                    MessageBox.Show("Please select a single row to delete.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Unable to find the parent form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
