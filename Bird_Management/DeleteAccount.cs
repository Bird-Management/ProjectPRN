using Repository.Services;
using Respository.Models;
using Respository.Services;
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
    public partial class DeleteAccount : Form
    {
        private BirdManagementContext _context; // Database context
        private AccountServices _accountServices; // Account service for database operations

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
            dgvDeleteAccount.DataSource = new BindingSource() { DataSource = accountList }; // Set the DataGridView's data source to the account list
        }

        private void ClearInputFields()
        {
            // Clear the input fields (textboxes and checkboxes)
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            chkAdmin.Checked = false;
            chkSeller.Checked = false;
            chkCustomer.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box before going back to the Admin Page
            DialogResult result = MessageBox.Show("Do you want to go back to the Admin Page?", "BirdShop", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
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
                    txtUsername.Text = selectedAccount.User;
                    txtPassword.Text = selectedAccount.Pass;

                    // Set TextBoxes as read-only
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;

                    // Set checkboxes as read-only
                    chkAdmin.Enabled = false;
                    chkSeller.Enabled = false;
                    chkCustomer.Enabled = false;
                    // Set checkbox selections based on account type
                    if (selectedAccount.IsAdmin.HasValue && selectedAccount.IsAdmin.Value)
                    {
                        chkAdmin.Checked = true; // Check the Admin checkbox
                    }
                    else
                    {
                        chkAdmin.Checked = false; // Uncheck the Admin checkbox
                    }

                    if (selectedAccount.IsSell.HasValue && selectedAccount.IsSell.Value)
                    {
                        chkSeller.Checked = true; // Check the Seller checkbox
                    }
                    else
                    {
                        chkSeller.Checked = false; // Uncheck the Seller checkbox
                    }

                    if (selectedAccount.IsCustomer.HasValue && selectedAccount.IsCustomer.Value)
                    {
                        chkCustomer.Checked = true; // Check the Customer checkbox
                    }
                    else
                    {
                        chkCustomer.Checked = false; // Uncheck the Customer checkbox
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box before deleting the account
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform validation
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    // Display an error message if the username or password is empty
                    MessageBox.Show("Please select an account to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete the account
                bool isDeleted = _accountServices.DeleteAccountAdmin(username, password);

                if (isDeleted)
                {
                    // Display a success message if the account is deleted successfully

                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the text fields and reset checkbox states
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
    }
}
