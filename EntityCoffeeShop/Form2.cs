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
    public partial class Form2 : Form
    {
        private ProductList productList;
        public Form2()
        {
            InitializeComponent();
            productList = new ProductList();
            flowLayoutPanel4.Controls.Add(productList);
            LoadProduct();
        }

        private void LoadProduct()
        {
            using (var db = new CoffeeShopContext())
            {
                var products = db.Products.ToList();

                foreach (var product in products)
                {
                    var card = new ProductCards(product);
                    card.OnAddClicked += ProductCard_OnAddClicked;

                    flowLayoutPanel3.Controls.Add(card);
                }
            }
        }
        private void ProductCard_OnAddClicked(Product product, int quantity)
        {
            // Forward the added product to cart control
            productList.AddOrder(product, quantity);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }

}
