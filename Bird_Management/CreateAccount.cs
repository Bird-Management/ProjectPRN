using Repository.Services;
using Respository.Models;
using System;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class CreateAccount : Form
    {
        private readonly BirdManagementContext _context;

        public CreateAccount()
        {
            InitializeComponent();
            _context = new BirdManagementContext();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Admin Page?", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
                Form form = new Admin();
                form.Show();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create an instance of the AccountServices class, passing the _context as a parameter
            var accountServices = new AccountServices(_context);

            // Retrieve input values from text boxes
            string accountID = txtAccountID.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            // Validate the input values
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(accountID))
            {
                MessageBox.Show("Please fill in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the accountID format
            if (!accountServices.IsValidAccountIDFormat(accountID))
            {
                MessageBox.Show("Invalid accountID format. It should be in the format A-01 or higher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if the accountID already exists
            if (accountServices.AccountIDExists(accountID))
            {
                MessageBox.Show("AccountID already exists. Please choose a different AccountID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username already exists
            if (accountServices.UsernameExists(username))
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!accountServices.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number format
            if (!accountServices.IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if the email already exists
            if (accountServices.EmailExists(email))
            {
                MessageBox.Show("Email already exists. Please choose a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if the phone number already exists
            if (accountServices.PhoneExists(phone))
            {
                MessageBox.Show("Phone number already exists. Please choose a different phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected role from the combo box
            string role = cbRole.SelectedItem?.ToString();

            // Validate the selected role
            if (string.IsNullOrEmpty(role))
            {
                // Display an error message if no role is selected
                MessageBox.Show("Please select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Account object
            var account = new Account
            {
                AccountId = accountID,
                UserName = username,
                Password = password,
                Email = email,
                Phone = phone,
                Role = role
            };

            try
            {
                // Call the NewAccountAdmin method to create the account
                accountServices.NewAccountAdmin(accountID, username, password, role, email, phone);
                MessageBox.Show("Account added successfully", "Notification", MessageBoxButtons.OK);

                ClearInputFields(); // Clear input fields after successful account creation
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create the account. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            // Clear the input fields (textboxes and combo box)
            txtAccountID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbRole.SelectedIndex = -1;
        }
    }
}
