using Respository.Models;
using Respository.Services;
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
        private BirdManagementContext _context;
        private AccountServices _accountServices;

        public DeleteAccount()
        {
            InitializeComponent();
            _context = new BirdManagementContext();
            _accountServices = new AccountServices(_context);

            LoadAccountData();
        }

        private void LoadAccountData()
        {
            var accountList = _accountServices.GetAccounts();
            dgvDeleteAccount.DataSource = new BindingSource() { DataSource = accountList };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Admin Page?", "BirdShop", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Admin();
                form.Show();
            }
        }

        private void dgvDeleteAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is double-clicked
            {
                var accountList = _accountServices.GetAccounts();

                if (e.RowIndex < accountList.Count) // Check if the row index is within the range of the account list
                {
                    var selectedAccount = accountList[e.RowIndex]; // Retrieve the selected account details

                    // Populate the text fields
                    txtUsername.Text = selectedAccount.User;
                    txtPassword.Text = selectedAccount.Pass;

                    // Set TextBoxes as read-only
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;

                    // Set checkboxes as read-only
                    chkAdmin.Enabled = false;
                    chkSeller.Enabled = false;

                    // Clear checkbox selections
                    chkAdmin.Checked = false;
                    chkSeller.Checked = false;

                    // Set checkbox selections based on account type
                    if (selectedAccount.IsAdmin.HasValue && selectedAccount.IsAdmin.Value)
                    {
                        chkAdmin.Checked = true; // Check the Admin checkbox
                    }

                    if (selectedAccount.IsSell.HasValue && selectedAccount.IsSell.Value)
                    {
                        chkSeller.Checked = true; // Check the Seller checkbox
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform validation
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please select an account to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete the account
                bool isDeleted = _accountServices.DeleteAccountAdmin(username, password);

                if (isDeleted)
                {
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the text fields and reset checkbox states
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    chkAdmin.Checked = false;
                    chkSeller.Checked = false;

                    // Refresh the data grid view
                    LoadAccountData();
                }
                else
                {
                    MessageBox.Show("Failed to delete the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
