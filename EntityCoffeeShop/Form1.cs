using System;
using EntityCoffeeShop.Model;
using EntityCoffeeShop.Table;

namespace EntityCoffeeShop
{
    public partial class Form1 : Form
    {
        private Form2 dashboard;
        private InventoryBoard inventorycard;
        private Form currentChildForm;
        private string _username;
        private Role _userRole;
        public Form1(string username, Role role)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            _username = username;
            _userRole = role;

        }
        public static byte[] GetImageBytes(string imagePath)
        {
            return File.ReadAllBytes(imagePath);
        }
        private void OpenChildForm(Form childForm)
        {
            // Close current child form if it's open
            if (currentChildForm != null)
                currentChildForm.Close();

            // Open the new form
            currentChildForm = childForm;
            currentChildForm.MdiParent = this;
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.FormClosed += (s, e) => currentChildForm = null;
            currentChildForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InventoryBoard());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
             "Are you sure you want to logout?",
             "Confirm Logout",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UsersManagement());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, {_username}";

            // Disable button if role is User
            if (_userRole == Role.User)
            {
                button3.Enabled = false;
                button3.Visible = false;
            }
        }
    }
}
