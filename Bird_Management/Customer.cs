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
    public partial class Customer : Form
    {
        BirdManagementContext context = new BirdManagementContext();

        public Customer()
        {
            InitializeComponent();
            loadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit BirdShop", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Login();
                form.Show();

            }
        }

        public void loadData()
        {
            ProductServices productServices = new ProductServices(context);
            var listProduct = productServices.GetProducts();
            DataTable dtProduct = new DataTable();
            dtProduct.Columns.Add("Image", Type.GetType("System.Byte[]"));
            foreach ( DataRow dr in listProduct )
            {

            }
            dgvProduct.DataSource = new BindingSource() { DataSource = listProduct };

        }


    }
}
