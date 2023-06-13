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
            BirdManagementContext _context = new BirdManagementContext();

            Account account = new Account();
            account.User = txtUsername.Text;
            account.Pass = txtPassword.Text;
            account.Pass = txtConfirmPassword.Text;
            account.IsAdmin = chbAdmin.Checked;
            account.IsSell = chbSeller.Checked;
            _context.Account.Add(account);
            _context.SaveChanges();

            // Clear the text fields or reset their Text properties
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chbAdmin.Checked = false;
            chbSeller.Checked = false;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                (!chbSeller.Checked && !chbAdmin.Checked))
            {
                MessageBox.Show("Invalid Account Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show("Add Account Successfully", "Notification", MessageBoxButtons.OK);
            }

        }


    }
}
