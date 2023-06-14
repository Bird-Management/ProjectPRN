using Microsoft.EntityFrameworkCore;
using Respository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to back Admin Page?", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Admin();
                form.Show();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BirdManagementContext
            /*sing (BirdManagementContext _context = new BirdManagementContext())*/
            {
                BirdManagementContext _context = new BirdManagementContext();
                // Get the trimmed username, password, and confirm password from the textboxes
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                // Check if the username is blank
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the username already exists in the database
                bool usernameExists = _context.Account.Any(a => a.User == username);
                if (usernameExists)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the password is blank
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the confirm password is blank
                if (string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please enter the confirm password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the password and confirm password match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if both checkboxes are checked or unchecked
                if (chbAdmin.Checked == chbSeller.Checked)
                {
                    MessageBox.Show("Please select either Admin or Seller.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new Account instance
                Account account = new Account();
                account.User = username;
                account.Pass = password;
                account.IsAdmin = chbAdmin.Checked;
                account.IsSell = chbSeller.Checked;

                // Add the account to the context and save changes to the database
                _context.Account.Add(account);
                _context.SaveChanges();

                // Display a success message
                MessageBox.Show("Account added successfully", "Notification", MessageBoxButtons.OK);

                // Clear the input fields and reset the checkboxes
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                chbAdmin.Checked = false;
                chbSeller.Checked = false;
            }
        }
    }
}

