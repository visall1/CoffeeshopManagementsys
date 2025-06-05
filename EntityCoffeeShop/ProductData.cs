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
using Microsoft.EntityFrameworkCore;

namespace EntityCoffeeShop
{
    public partial class ProductData : UserControl
    {
        public DataGridView ProductsGrid => dataGridView1;

        public ProductData()
        {
            InitializeComponent();
            LoadOProducts_Explicit();


        }
        public void LoadOProducts_Explicit()
        {
            try
            {
                using (var context = new CoffeeShopContext())
                {
                    var products = context.Products
                        .Include(p => p.Categories)
                        .Select(p => new 
                        {
                            p.ProductId,
                            p.Name,
                            p.Price,
                            p.Image,
                            Category_Name = p.Categories.Name
                        })
                        .ToList();

                    dataGridView1.DataSource = products;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }
        public void SearchProducts(string searchTerm, string searchType)
        {
            using var context = new CoffeeShopContext();

            IQueryable<Product> query = context.Products.Include(p => p.Categories);

            searchTerm = searchTerm.ToLower();

            switch (searchType)
            {
                case "By_Name":
                    query = query.Where(p => p.Name.ToLower().Contains(searchTerm));
                    break;

                case "By_ID":
                    if (int.TryParse(searchTerm, out int id))
                        query = query.Where(p => p.ProductId == id);
                    else
                        query = query.Where(p => false); // No match if invalid ID
                    break;

                case "By_Category":
                    query = query.Where(p => p.Categories.Name.ToLower().Contains(searchTerm));
                    break;
            }

            var results = query.Select(p => new
            {
                p.ProductId,
                p.Name,
                p.Price,
                p.Image,
                Category_Name = p.Categories.Name
            }).ToList();

            dataGridView1.DataSource = results;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                int id = (int)row.Cells["ProductId"].Value;
                string name = row.Cells["Name"].Value?.ToString();
                string price = row.Cells["Price"].Value?.ToString();
                byte[] imageBytes = row.Cells["Image"].Value as byte[];
                string categoryName = row.Cells["Category_Name"].Value?.ToString();

                using (var context = new CoffeeShopContext())
                {
                    var category = context.Categories.FirstOrDefault(c => c.Name == categoryName);
                    if (category != null)
                    {
                        var form = this.FindForm() as InventoryBoard;
                        if (form != null)
                        {
                            var addMenu = form.AddMenuControl;
                            addMenu.SetProductDetails(id, name, price, imageBytes, category.CategoryId);
                            addMenu.BringToFront();
                            addMenu.Visible = true;
                        }
                    }
                }
            }
        }

    }
}
