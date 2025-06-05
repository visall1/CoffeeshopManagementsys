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
    public partial class OrderDetailsInfo : UserControl
    {
        public OrderDetailsInfo()
        {
            InitializeComponent();
            LoadOrderItems_Explicit();
        }
        private void LoadOrderItems_Explicit()
        {
            using (var context = new CoffeeShopContext())
            {
                var orderItems = context.OrderItems.ToList();

                // Explicitly load related Product for each OrderItem
                foreach (var item in orderItems)
                {
                    context.Entry(item).Reference(oi => oi.Product).Load();
                    context.Entry(item).Reference(oi => oi.Order).Load();
                }

                // access Product.Name
                var displayList = orderItems.Select(oi => new
                {
                    oi.OrderItemId,
                    oi.Order.OrderTime,
                    ProductName = oi.Product?.Name,
                    oi.Quantity,
                    oi.UnitPrice,
                    Subtotal = oi.Quantity * oi.UnitPrice
                }).ToList();

                dataGridView1.DataSource = displayList;
            }
        }

    }
}
