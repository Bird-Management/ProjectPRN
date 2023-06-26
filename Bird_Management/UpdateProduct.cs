using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Services;
using System.IO;
using Respository.Models;
using Respository.Services;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Image = System.Drawing.Image;
using System.Drawing.Imaging;

namespace Bird_Management
{
    public partial class UpdateProduct : Form
    {
        private readonly ProductServices _productServices;
        private readonly ProductServices _categoryServices;
        private Product _selectedProduct;

        public UpdateProduct()
        {
            InitializeComponent();

            _productServices = new ProductServices(new BirdManagementContext());
            _categoryServices = new ProductServices(new BirdManagementContext());

            LoadCategory();
            UpdateProducts_Load();
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string productId = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                _selectedProduct = _productServices.GetProductById(productId);

                if (_selectedProduct != null)
                {
                    txtID.Text = _selectedProduct.ProductId;
                    txtName.Text = _selectedProduct.ProductName;
                    txtQuantity.Text = _selectedProduct.Quantity.ToString();
                    txtDescription.Text = _selectedProduct.Description;
                    txtPrice.Text = _selectedProduct.Price.ToString();

                    // Find the category with the corresponding CategoryId
                    Category selectedCategory = cbCategory.Items.Cast<Category>().FirstOrDefault(category => category.CategoryId == _selectedProduct.CategoryId);
                    cbCategory.SelectedItem = selectedCategory;

                    if (_selectedProduct.Image != null)
                    {
                        using (MemoryStream memoryStream = new MemoryStream(_selectedProduct.Image))
                        {
                            Image originalImage = Image.FromStream(memoryStream);
                            Image resizedImage = originalImage.GetThumbnailImage(pbImage.Width, pbImage.Height, null, IntPtr.Zero);
                            pbImage.Image = resizedImage;
                        }
                    }
                    else
                    {
                        pbImage.Image = null;
                    }
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image File";
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);

                        // Resize the image to fit the picture box
                        Image resizedImage = selectedImage.GetThumbnailImage(pbImage.Width, pbImage.Height, null, IntPtr.Zero);

                        pbImage.Image = resizedImage;

                        // Convert the image to byte array for storing in the database
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            resizedImage.Save(memoryStream, ImageFormat.Jpeg);
                            _selectedProduct.Image = memoryStream.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("Please select a product.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedProduct != null)
            {
                // Validate the input fields
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a product name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please enter a product description.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if any fields have been modified
                if (txtName.Text == _selectedProduct.ProductName &&
                    quantity == _selectedProduct.Quantity &&
                    txtDescription.Text == _selectedProduct.Description &&
                    price == (decimal)_selectedProduct.Price &&
                    ((Category)cbCategory.SelectedItem).CategoryId == _selectedProduct.CategoryId)
                {
                    MessageBox.Show("No changes have been made to the product.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to update the product?", "Notification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _selectedProduct.ProductName = txtName.Text;
                        _selectedProduct.Quantity = quantity;
                        _selectedProduct.Description = txtDescription.Text;
                        _selectedProduct.Price = (double?)price;
                        _selectedProduct.CategoryId = ((Category)cbCategory.SelectedItem).CategoryId;

                        if (_productServices.UpdateProduct(_selectedProduct))
                        {
                            MessageBox.Show("Product updated successfully!", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            UpdateProducts_Load();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update product. Please try again.", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void UpdateProducts_Load()
        {
            dgvProduct.DataSource = _productServices.GetProducts();
        }

        private void LoadCategory()
        {
            List<Category> category = _productServices.GetAllCategories();

            if (category != null && category.Count > 0)
            {
                cbCategory.DataSource = category;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryId";
            }
        }

        private void ClearFields()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cbCategory.SelectedIndex = -1;
            pbImage.Image = null;
            _selectedProduct = null;
        }

        private void btnUpdateProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdateProduct_Click(sender, e);
            }
        }
    }
}