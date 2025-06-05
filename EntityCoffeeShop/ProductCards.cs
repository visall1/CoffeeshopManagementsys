using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityCoffeeShop
{
    public partial class ProductCards : UserControl
    {
        private Product _product;

        public delegate void AddClickedHandler(Product product, int quantity);
        public event AddClickedHandler OnAddClicked;
        public ProductCards(Product product)
        {
            InitializeComponent();
            _product = product;


            numericUpDown1.Value = 1;
            // Display product data in UI
            lbName.Text = product.Name;
            lbPrice.Text = $"${product.Price}";
            if (_product.Image != null && _product.Image.Length > 0)
            {
                try
                {
                    using (var ms = new System.IO.MemoryStream(_product.Image))
                    {
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                    pictureBox1.Image = Image.FromFile("images\\c1.jpg");
                }
            }
            else
            {
                //  pictureBox1.Image = Image.FromFile("images\\c1.jpg");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown1.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OnAddClicked?.Invoke(_product, quantity);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
