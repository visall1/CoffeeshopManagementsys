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
using EntityCoffeeShop.Table;
using Microsoft.EntityFrameworkCore;

namespace EntityCoffeeShop
{
    public partial class UsersManagement : Form
    {
        public UsersManagement()
        {
            InitializeComponent();

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userRegister = new UserRegistration();
            addUserControl(userRegister);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var manageUser = new ManageUser();
            addUserControl(manageUser);
        }
    }
}
