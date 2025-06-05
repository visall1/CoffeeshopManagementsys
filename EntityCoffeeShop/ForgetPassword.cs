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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = txtUsernameOrEmail.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtconfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(usernameOrEmail) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new CoffeeShopContext();

            // Find user by username or email
            var user = await context.Users
                .Include(u => u.Profile)
                .FirstOrDefaultAsync(u => u.Username == usernameOrEmail || (u.Profile != null && u.Profile.Email == usernameOrEmail));

            if (user == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash and update password
            user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            btnReset.Enabled = false;
            try
            {
                await context.SaveChangesAsync();
                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var loginForm = new Login();
                Hide();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnReset.Enabled = true;
                txtNewPassword.Clear();
                txtconfirmPassword.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            Hide();
            loginForm.Show();
        }
    }

}
