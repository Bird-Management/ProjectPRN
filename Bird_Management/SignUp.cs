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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bird_Management
{
    public partial class SignUp : Form
    {
        BirdManagementContext context = new BirdManagementContext();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                AccountServices accountServices = new AccountServices(context);

                string user = txtUsername.Text;
                string password = txtPassword.Text;

                if (chbAdmin.Checked == true)
                {
                    var newAccount = accountServices.NewAccountAdmin(user, password);
                    MessageBox.Show("Sign Up Success", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    var newAccount = accountServices.NewAccountSeller(user, password);
                    MessageBox.Show("Sign Up Success", "Notification", MessageBoxButtons.OK);
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to back Login Page?", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Login();
                form.Show();
            }
        }
    }
}
