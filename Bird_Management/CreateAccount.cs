using Microsoft.EntityFrameworkCore;
using Respository.Models;
using Respository.Services;
using Respository.Models;
using Respository.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using Repository.Services;

namespace Bird_Management
{
    public partial class CreateAccount : Form
    {
        private BirdManagementContext _context;

        public CreateAccount()
        {
            InitializeComponent();
            _context = new BirdManagementContext();
        }

        // Handle the Back button click event
        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Admin Page?", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
                Form form = new Admin(); // Create a new instance of the Admin form
                form.Show(); // Show the Admin form
            }
        }

        // Handle the Create Account button click event
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            AccountServices accountServices = new AccountServices(_context);

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

            // Check if checkboxes are checked or unchecked
            if (chbAdmin.Checked == chbSeller.Checked && chbSeller.Checked == chbCustomer.Checked)
            {
                MessageBox.Show("Please select either Admin, Seller, or Customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new account using the appropriate method based on the selected checkbox
            Account account;

            // Check if one and only one checkbox is selected
            if ((chbAdmin.Checked && !chbSeller.Checked && !chbCustomer.Checked) ||  // Only admin checkbox is checked
                (!chbAdmin.Checked && chbSeller.Checked && !chbCustomer.Checked) ||  // Only seller checkbox is checked
                (!chbAdmin.Checked && !chbSeller.Checked && chbCustomer.Checked))    // Only customer checkbox is checked
            {
                // Valid selection: only one checkbox is checked

                // Create the account based on the checked checkbox
                if (chbAdmin.Checked)
                {
                    account = accountServices.NewAccountAdmin(username, password); // Create an admin account
<<<<<<< HEAD
<<<<<<< HEAD

                }else if (chbSeller.Checked)
=======
                }
                else if (chbSeller.Checked)
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
=======
                }
                else if (chbSeller.Checked)
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
                {
                    account = accountServices.NewAccountSeller(username, password); // Create a seller account
                }
                else
                {
                    account = accountServices.NewAccountCustomer(username, password); // Create a customer account
                }
            }
            else
            {
                // Invalid selection: either no checkbox or multiple checkboxes are checked

                // Display validation error message
                MessageBox.Show("Please select only one option: Admin, Seller, or Customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display a success message
            MessageBox.Show("Account added successfully", "Notification", MessageBoxButtons.OK);

            // Clear the input fields and reset the checkboxes
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chbAdmin.Checked = false;
            chbSeller.Checked = false;
            chbCustomer.Checked = false;
<<<<<<< HEAD
<<<<<<< HEAD
        }


        // Handle the Enter key press event on the Create Account button
        private void btnCreateAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateAccount_KeyDown(sender, e);
            }
        }


        private void CreateAccount_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += btnCreateAccount_KeyDown;
=======
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
        }

=======
        }

>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
        // Handle the Enter key press event on the Create Account button
        private void btnCreateAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateAccount_KeyDown(sender, e);
            }
        }

    }
}
