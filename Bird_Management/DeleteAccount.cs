using Repository.Services;
using Respository.Models;
using Respository.Services;
using System;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class DeleteAccount : Form
    {
        private readonly BirdManagementContext _context; // Database context
        private readonly AccountServices _accountServices; // Account service for database operations

        public DeleteAccount()
        {
            InitializeComponent();

            // Initialize the database context and account services
            _context = new BirdManagementContext();
            _accountServices = new AccountServices(_context);

            LoadAccountData(); // Load account data into the DataGridView
        }

        private void LoadAccountData()
        {
            var accountList = _accountServices.GetAccounts(); // Retrieve the list of accounts from the database
            dgvDeleteAccount.DataSource = accountList; // Set the DataGridView's data source to the account list
        }

        private void ClearInputFields()
        {
            // Clear the input fields (textboxes and combo box)
            txtAccountID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbRole.SelectedItem = null;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box before going back to the Admin Page
            DialogResult result = MessageBox.Show("Do you want to go back to the Admin Page?", "BirdShop", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close(); // Close the current form
                Form form = new Admin(); // Create a new instance of the Admin form
                form.Show(); // Show the Admin form
            }
        }

        private void dgvDeleteAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is double-clicked
            {
                var accountList = _accountServices.GetAccounts(); // Retrieve the list of accounts from the database

                if (e.RowIndex < accountList.Count) // Check if the row index is within the range of the account list
                {
                    var selectedAccount = accountList[e.RowIndex]; // Retrieve the selected account details

                    // Populate the text fields with the selected account details
                    txtAccountID.Text = selectedAccount.AccountId;
                    txtUsername.Text = selectedAccount.UserName;
                    txtPassword.Text = selectedAccount.Password;
                    cbRole.Text = selectedAccount.Role;
                    txtPhone.Text = selectedAccount.Phone;
                    txtEmail.Text = selectedAccount.Email;

                    // Set TextBoxes as read-only
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    txtAccountID.ReadOnly = true;
                    cbRole.Enabled = false;
                    txtEmail.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box before deleting the account
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform validation
                string accountID = txtAccountID.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string role = cbRole.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(accountID) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(role) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
                {
                    // Display an error message if any required field is empty
                    MessageBox.Show("Please select an account to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete the account
                bool isDeleted = _accountServices.DeleteAccountAdmin(accountID, username, password, role, phone, email);

                if (isDeleted)
                {
                    // Display a success message if the account is deleted successfully
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the text fields and reset the combo box selection
                    ClearInputFields();

                    // Refresh the data grid view
                    LoadAccountData();
                }
                else
                {
                    // Display an error message if the account deletion fails
                    MessageBox.Show("Failed to delete the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string accountId = txtSearchAccountByID.Text.Trim();

            if (string.IsNullOrEmpty(accountId))
            {
                MessageBox.Show("Please enter an account ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var account = _accountServices.GetAccountById(accountId);

            if (account != null)
            {
                // Display the found account details
                txtAccountID.Text = account.AccountId;
                txtUsername.Text = account.UserName;
                txtPassword.Text = account.Password;
                cbRole.Text = account.Role;
                txtPhone.Text = account.Phone;
                txtEmail.Text = account.Email;

                // Set TextBoxes as read-only
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtAccountID.ReadOnly = true;
                cbRole.Enabled = false;
                txtEmail.ReadOnly = true;
                txtPhone.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Account not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
