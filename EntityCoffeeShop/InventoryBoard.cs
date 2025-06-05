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
    public partial class InventoryBoard : Form
    {
        private AddMenu addMenuCard;
        private OrderDetailsInfo OrderDetails;
        private ProductData productData;

        public ProductData ProductDataControl => productData;


        public InventoryBoard()
        {
            InitializeComponent();
            addMenuCard = new AddMenu();
            panel3.Controls.Add(addMenuCard);


            productData = new ProductData();
            panel2.Controls.Add(productData);
        }
        public AddMenu AddMenuControl => addMenuCard;

        private void InventoryBoard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged_1(sender, e);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (cmbSearchType.SelectedItem == null)
            {
                MessageBox.Show("Invalid Search. Please choose a search type.");
                return;
            }

            string searchType = cmbSearchType.SelectedItem.ToString();

            productData.SearchProducts(searchTerm, searchType);
        }
    }
}
