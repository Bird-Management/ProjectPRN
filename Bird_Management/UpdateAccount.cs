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
    public partial class UpdateAccount : Form
    {
        private BirdManagementContext _context; // Database context
        private AccountServices _accountServices; // Account service for database operations

        public UpdateAccount()
        {
            InitializeComponent();

            // Initialize the database context and account services
            _context = new BirdManagementContext();
            _accountServices = new AccountServices(_context);

            LoadAccountData(); // Load account data into the DataGridView
        }

        private void LoadAccountData()
        {
            // Retrieve the list of accounts from the database
            var accountList = _accountServices.GetAccounts();

            // Set the DataGridView's data source to the account list
            dgvUpdateAccount.DataSource = new BindingSource() { DataSource = accountList };
        }

        private void ClearInputFields()
        {
            // Clear the input fields (textboxes and checkboxes)
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            chbAdmin.Checked = false;
            chbSeller.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Prompt the user with a confirmation dialog
            DialogResult result = MessageBox.Show("Do you want to go back to the Admin Page?", "BirdShop", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
                Form form = new Admin(); // Create a new instance of the Admin form
                form.Show(); // Show the Admin form
            }
        }

        private void dgvUpdateAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is double-clicked
            {
                // Retrieve the list of accounts from the database
                var accountList = _accountServices.GetAccounts();

                if (e.RowIndex < accountList.Count) // Check if the row index is within the range of the account list
                {
                    var selectedAccount = accountList[e.RowIndex]; // Retrieve the selected account details

                    // Populate the text fields with the selected account details
                    txtUsername.Text = selectedAccount.User;
                    txtPassword.Text = selectedAccount.Pass;

                    // Set TextBoxes as editable
                    txtUsername.ReadOnly = false;
                    txtPassword.ReadOnly = false;

                    // Set checkboxes as editable
                    chbAdmin.Enabled = true;
                    chbSeller.Enabled = true;

                    // Set checkbox selections based on account type
                    if (selectedAccount.IsAdmin.HasValue && selectedAccount.IsAdmin.Value)
                    {
                        chbAdmin.Checked = true; // Check the Admin checkbox
                    }
                    else
                    {
                        chbAdmin.Checked = false; // Uncheck the Admin checkbox
                    }

                    if (selectedAccount.IsSell.HasValue && selectedAccount.IsSell.Value)
                    {
                        chbSeller.Checked = true; // Check the Seller checkbox
                    }
                    else
                    {
                        chbSeller.Checked = false; // Uncheck the Seller checkbox
                    }
                }
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            // Get the selected account from the DataGridView
            var selectedAccount = dgvUpdateAccount.CurrentRow?.DataBoundItem as Account;

            // Check if the required fields are not empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution if fields are empty
            }

            // Check if both checkboxes are checked or none of them are checked
            if ((chbAdmin.Checked && chbSeller.Checked) || (!chbAdmin.Checked && !chbSeller.Checked))
            {
                MessageBox.Show("Please select either Admin or Seller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution if both checkboxes are checked or none of them are checked
            }

            // Update the account properties with the values from the text boxes and checkboxes
            selectedAccount.User = txtUsername.Text;
            selectedAccount.Pass = txtPassword.Text;
            selectedAccount.IsAdmin = chbAdmin.Checked;
            selectedAccount.IsSell = chbSeller.Checked;

            try
            {
                // Call the UpdateAccountAdmin method from the AccountServices class to update the account
                _accountServices.UpdateAccountAdmin(selectedAccount);

                // Display success message
                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields (textboxes and checkboxes)
                ClearInputFields();

                LoadAccountData(); // Reload the account data in the DataGridView
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Failed to update the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
