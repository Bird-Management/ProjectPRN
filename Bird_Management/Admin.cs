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
    public partial class Admin : Form
    {
        BirdManagementContext _context = new BirdManagementContext();

        public Admin()
        {
            InitializeComponent();
            AccountServices _accountServices = new AccountServices(_context);
            var listAll = _accountServices.GetAccounts();
            dgvListAccount.DataSource = new BindingSource() { DataSource = listAll };

        }

        private void dgvListAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            chbAdmin.Enabled = false;
            chbSeller.Enabled = false;
            AccountServices accountServices = new AccountServices(_context);
            var id = dgvListAccount[0, e.RowIndex].Value;
            var allAccount = accountServices.GetAccounts().Where(x => x.UId.Equals(id)).FirstOrDefault();
            if (allAccount != null)
            {
                txtUsername.Text = allAccount.User;
                txtPassword.Text = allAccount.Pass;
                if (allAccount.IsAdmin == true)
                {
                    chbAdmin.Checked = true;
                    chbSeller.Checked = false;
                }
                else
                {
                    chbAdmin.Checked = false;
                    chbSeller.Checked = true;
                }
            }

        }

        private void btLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit BirdShop", "BirdShop",
                MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Login();
                form.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            Form fo = new CreateAccount();
            fo.ShowDialog();
        }
    }
}
