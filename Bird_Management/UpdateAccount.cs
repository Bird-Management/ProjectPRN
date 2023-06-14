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
        BirdManagementContext _context = new BirdManagementContext();
        public UpdateAccount()
        {
            InitializeComponent();
            AccountServices _acc = new AccountServices(_context);
            var listAll = _acc.GetAccounts();

            dgvUpdateAccount.DataSource = new BindingSource() { DataSource = listAll };
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void dgvUpdateAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AccountServices _accountServices = new AccountServices(_context);
            var listAccount = _accountServices.GetAccounts();
            var listDetails = listAccount[e.RowIndex];
            txtUsername.Text = listDetails.User.ToString();
            txtPassword.Text = listDetails.Pass.ToString();
            if (listDetails.IsSell == true)
            {
                chbSeller.Checked = true;
                chbAdmin.Checked = false;
            }
            else if (listDetails.IsAdmin == true)
            {
                chbAdmin.Checked = true;
                chbSeller.Checked = false;
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            AccountServices _accountServices = new AccountServices(_context);
            DialogResult result = MessageBox.Show("Are you sure you want to update this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please can't be left blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var isUpdated = _accountServices.UpdateAccount;

                if (isUpdated != null)
                {
                    MessageBox.Show("Account Update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the text fields and reset checkbox states
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    chbAdmin.Checked = false;
                    chbSeller.Checked = false;

                    //load data
                    var loadData = _accountServices.GetAccounts();
                    dgvUpdateAccount.DataSource = new BindingSource() { DataSource = loadData };
                }
                else
                {
                    MessageBox.Show("Failed to update the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
