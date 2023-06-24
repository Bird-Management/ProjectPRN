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



        private void btLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit Bird Management", "Bird Management",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Login();
                form.Show();

            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fo = new CreateAccount();
            fo.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fo = new UpdateAccount();
            fo.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fo = new DeleteAccount();
            fo.Show();
        }
    }
}
