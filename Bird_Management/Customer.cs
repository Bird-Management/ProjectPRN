using Microsoft.Data.SqlClient;
using Repository.Services;
using Respository.Models;
using Respository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            dgvProduct.DataSource = new BindingSource() { DataSource = listProduct };
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductServices productServices2 = new ProductServices(context);
            if (e.RowIndex >= 0)
            {
                var listProduct = productServices2.GetProducts();
                if (e.RowIndex < listProduct.Count)
                {
                    var product = listProduct[e.RowIndex];

                    txtName.Text = product.Name;
                    txtDescription.Text = product.Description;
                    txtTitle.Text = product.Title;

                    //convert int to string
                    int stringPrice;
                    stringPrice = e.RowIndex;
                    txtPrice.Text = dgvProduct.Rows[stringPrice].Cells[3].Value.ToString();

                    int stringID;
                    stringID = e.RowIndex;
                    txtID.Text = dgvProduct.Rows[stringID].Cells[0].Value.ToString();

                    // set readOnly
                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    txtDescription.Enabled = false;
                    txtTitle.Enabled = false;
                    txtPrice.Enabled = false;
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Create an instance of the CartServices class
            CartServices cartServices = new CartServices(context);

            // Retrieve the values from textboxes
            string title = txtTitle.Text.Trim();
            string sPrice = txtPrice.Text.Trim();
            string sId = txtID.Text.Trim();

            // Validate and convert the price
            if (!decimal.TryParse(sPrice, out decimal dPrice))
            {
                MessageBox.Show("Invalid price format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and convert the product ID
            if (!int.TryParse(sId, out int id))
            {
                MessageBox.Show("Invalid product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the product to the cart
            cartServices.addToCart(id, title, dPrice);

            // Display success message
            MessageBox.Show("Added to cart successfully", "Notification", MessageBoxButtons.OK);
        }


        private void btnViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new ViewCart();
            form.ShowDialog();
        }

    }
}
