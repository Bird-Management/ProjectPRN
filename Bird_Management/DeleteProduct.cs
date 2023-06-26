using Microsoft.EntityFrameworkCore;
using Respository.Models;
using Respository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class DeleteProduct : Form
    {
        private BirdManagementContext dbContext;
        private ProductServices productServices;
        private Product selectedProduct;

        public DeleteProduct()
        {
            InitializeComponent();

            // Initialize the DbContext
            dbContext = new BirdManagementContext();
            productServices = new ProductServices(dbContext);

            // Load the products and categories
            DeleteProduct_Load();
        }

        private void DeleteProduct_Load()
        {
            try
            {
                this.KeyPreview = true;
                this.KeyDown += btnDeleteProduct_KeyDown;

                // Retrieve all products from the database
                List<Product> products = productServices.GetProducts();

                // Bind the products to the DataGridView
                dgvProduct.DataSource = products;

                // Set the active control explicitly
                ActiveControl = btnDeleteProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProductPhoto(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pbImage.Image = Image.FromStream(ms);
                    pbImage.SizeMode = PictureBoxSizeMode.Zoom; // Set the size mode to Zoom
                }
            }
            else
            {
                pbImage.Image = null;
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProduct.Rows.Count)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                Product clickedProduct = (Product)row.DataBoundItem;

                // Check if the clicked product is the same as the previously selected product
                if (selectedProduct == clickedProduct)
                {
                    // Unselect the product
                    selectedProduct = null;
                    dgvProduct.ClearSelection();
                    ClearForm();
                }
                else
                {
                    // Select the new product
                    selectedProduct = clickedProduct;

                    // Display the product details
                    txtID.Text = selectedProduct.ProductId.ToString();
                    txtName.Text = selectedProduct.ProductName;
                    txtQuantity.Text = selectedProduct.Quantity.ToString();
                    txtDescription.Text = selectedProduct.Description;
                    txtPrice.Text = selectedProduct.Price.ToString();

                    // Display the category
                    Category selectedCategory = productServices.GetCategoryById(selectedProduct.CategoryId);
                    if (selectedCategory != null)
                    {
                        txtCategory.Text = selectedCategory.CategoryName;
                    }
                    else
                    {
                        txtCategory.Text = string.Empty;
                    }

                    // Display the product image
                    DisplayProductPhoto(selectedProduct.Image);

                    // Disable editing of fields
                    DisableFields();
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvProduct.SelectedRows;

            if (selectedRow.Count > 0)
            {
                var selectedProduct = selectedRow[0].DataBoundItem as Product;

                if (selectedProduct != null)
                {
                    // Confirm the deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Delete the product from the database
                            productServices.DeleteProduct(selectedProduct.ProductId);

                            // Display a success message
                            MessageBox.Show("Product deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the form controls
                            ClearForm();

                            // Refresh the products list
                            DeleteProduct_Load();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearForm()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            pbImage.Image = null;
            txtCategory.Text = string.Empty;
            selectedProduct = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Sell Page?", "Bird Management",
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

        private void DisableFields()
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtQuantity.Enabled = false;
            txtDescription.Enabled = false;
            txtPrice.Enabled = false;
            txtCategory.Enabled = false;
        }
    }
}
