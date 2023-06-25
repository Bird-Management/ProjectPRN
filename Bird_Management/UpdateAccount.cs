using Repository.Services;
using Respository.Models;
using System;
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
            InitializeServices();
            LoadAccountData();
        }

        private void InitializeServices()
        {
            _context = new BirdManagementContext();
            _accountServices = new AccountServices(_context);
        }

        private void LoadAccountData()
        {
            var accountList = _accountServices.GetAccounts();
            dgvUpdateAccount.DataSource = new BindingSource { DataSource = accountList };
        }

        private void ClearInputFields()
        {
            txtAccountID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbRole.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Admin Page?", "BirdShop", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Close();
                Form form = new Admin();
                form.Show();
            }
        }

        private void dgvUpdateAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedAccount = dgvUpdateAccount.Rows[e.RowIndex].DataBoundItem as Account;

                txtAccountID.Text = selectedAccount.AccountId;
                txtUsername.Text = selectedAccount.UserName;
                txtPassword.Text = selectedAccount.Password;
                txtPhone.Text = selectedAccount.Phone;
                txtEmail.Text = selectedAccount.Email;
                cbRole.SelectedItem = selectedAccount.Role;

                txtAccountID.ReadOnly = true;
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtEmail.ReadOnly = false;
                cbRole.Enabled = true;
            }
            else
            {
                ClearInputFields();

                txtAccountID.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cbRole.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string accountId = txtAccountID.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please double click in Data Grid View or Search Account by ID to Update.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account updatedAccount = new Account
            {
                AccountId = accountId,
                UserName = username,
                Password = password,
                Phone = phone,
                Email = email,
                Role = role
            };

            try
            {
                _accountServices.UpdateAccountAdmin(updatedAccount);

                MessageBox.Show("Account updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccountData();

                ClearInputFields();
                txtAccountID.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cbRole.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the account. Error: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string accountId = txtSearchAccountByID.Text.Trim();
            LoadAccountData();
            txtAccountID.ReadOnly = true;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cbRole.Enabled = true;

            if (string.IsNullOrEmpty(accountId))
            {
                MessageBox.Show("Please enter an account ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var account = _accountServices.GetAccountById(accountId);

            if (account != null)
            {
                txtAccountID.Text = account.AccountId;
                txtUsername.Text = account.UserName;
                txtPassword.Text = account.Password;
                txtPhone.Text = account.Phone;
                txtEmail.Text = account.Email;
                cbRole.SelectedItem = account.Role;
            }
            else
            {
                MessageBox.Show("Account not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
