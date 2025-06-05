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
    public partial class ManageUser : UserControl
    {
        public ManageUser()
        {
            InitializeComponent();
            LoadUserData();
        }
        public void LoadUserData()
        {
            try
            {
                using (var context = new CoffeeShopContext())
                {
                    var User = context.UserProfiles
                        .Include(p => p.User)
                        .Select(p => new
                        {
                            p.UserId,
                            Username = p.User.Username,
                            //Password = p.User.Password,
                            p.FullName,
                            p.Email,
                            Role = p.User.role,
                            p.PhoneNumber,
                            p.Address,
                            p.BirthDate,

                        })
                        .ToList();

                    dataGridView1.DataSource = User;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }
    }
}
