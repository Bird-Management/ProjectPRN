using Microsoft.EntityFrameworkCore;
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
    public partial class DeleteProduct : Form
    {
        private readonly ProductServices _productServices;
        private readonly BirdManagementContext _context;

        public DeleteProduct()
        {
            InitializeComponent();
            _context = new BirdManagementContext();
            _productServices = new ProductServices(_context);
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            this.KeyPreview = true;
            this.KeyDown += btnDeleteProduct_KeyDown;
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProduct.Rows.Count)
            {
                var productId = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["Id"].Value);
                //var product = _productServices.GetProductById(productId);

                //if (product != null)
                //{
                //    //txtName.Text = product.ProductNames;
                //    txtTitle.Text = product.Title;
                //    txtDescription.Text = product.Description;
                //    txtPrice.Text = product.Price.ToString();
                //}
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = dgvProduct.CurrentRow?.DataBoundItem as Product;

            if (selectedProduct != null)
            {
                var productName = selectedProduct.ProductName;

                var result = MessageBox.Show($"Are you sure you want to delete the product '{productName}'?", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        var productId = selectedProduct.ProductId;
                        //var success = _productServices.DeleteProduct(productId);

                        //if (success)
                        //{
                        //    MessageBox.Show("Product deleted successfully.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    LoadProducts();
                        //    ClearTextBoxes();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Failed to delete the product.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadProducts()
        {
            dgvProduct.DataSource = _productServices.GetProducts();
        }

        private void ClearTextBoxes()
        {
            txtName.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Sell Page?", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Seller();
                form.Show();
            }
        }

        private void btnDeleteProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDeleteProduct_Click(sender, e);
            }
        }
    }
}
