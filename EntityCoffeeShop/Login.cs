using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCoffeeShop.Model;
using EntityCoffeeShop.Table;
using Microsoft.EntityFrameworkCore;

namespace EntityCoffeeShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new CoffeeShopContext();

            try
            {
                var user = await context.Users
                    .Include(u => u.Profile)
                    .FirstOrDefaultAsync(u => u.Username == username);

                if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (user.role == Role.Admin || user.role == Role.User)
                {
                    MessageBox.Show($"Welcome {user.Profile?.FullName ?? user.Username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var dashboardForm = new Form1(user.Username, user.role);
                    this.Hide();
                    dashboardForm.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("You are not authorized to access this system.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forgetPassword = new ForgetPassword();
            this.Hide();
            forgetPassword.Show();
        }


        /*public async Task<bool> RegisterUserWithProfileAsync()
        {
            using var context = new CoffeeShopContext();

            if (await context.Users.AnyAsync(u => u.Username == username))
                return false;

            var newUser = new User
            {
                Username = username,
                Password = BCrypt.Net.BCrypt.HashPassword(password),
                role = Role.User, // Default to User
                Profile = new UserProfile
                {
                    FullName = fullName,
                    Email = email,
                    PhoneNumber,
                    Address,
                    BirthDate = DateTime.Parse("2000-01-01") // You can parameterize this
                }
            };

            context.Users.Add(newUser);
            await context.SaveChangesAsync();
            return true;
        }*/
    }
}
