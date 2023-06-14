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
    public partial class Sell : Form
    {
        BirdManagementContext _context = new BirdManagementContext();
        public Sell()
        {
            ProductServices _productServices = new ProductServices(_context);
            InitializeComponent();
            var listAllProduct = _productServices.GetProducts();
            dgvListProduct.DataSource = new BindingSource() { DataSource = listAllProduct };
        }

        private void btLogout_Click_1(object sender, EventArgs e)
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

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fo = new CreateProduct();
            fo.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fo = new UpdateProduct();
            fo.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fo = new DeleteProduct();
            fo.Show();
        }
    }
}
