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
    public partial class UserRegistration : UserControl
    {
        public UserRegistration()
        {
            InitializeComponent();

        }
        private void clearForm()
        {
            txtUsername.Text = "";
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtConform.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

 

        private async void button1_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string fullname = txtFullName.Text;
            DateTime birthDate = dateTimePicker1.Value;
            string newPassword = txtPassword.Text.Trim();
            string confirmPassword = txtConform.Text.Trim();
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string add = txtAddress.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(fullname) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(add))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check age
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age)) age--;
            if (age < 17)
            {
                MessageBox.Show("You must be at least 17 years old to register.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new CoffeeShopContext();

            if (await context.Users.AnyAsync(u => u.Username == username))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new User
            {
                Username = username,
                Password = BCrypt.Net.BCrypt.HashPassword(newPassword),
                role = Role.User,
                Profile = new UserProfile
                {
                    FullName = fullname,
                    Email = email,
                    PhoneNumber = phone,
                    Address = add,
                    BirthDate = birthDate
                }
            };

            try
            {
                context.Users.Add(newUser);
                await context.SaveChangesAsync();
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
