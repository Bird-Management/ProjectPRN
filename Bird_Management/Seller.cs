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
    public partial class Seller : Form
    {
        private BirdManagementContext _context;
        private ProductServices _productServices;

        public Seller()
        {
            InitializeComponent();
            _context = new BirdManagementContext();
            _productServices = new ProductServices(_context);
            LoadProducts();
        }

        private void LoadProducts()
        {
            var listAllProduct = _productServices.GetProducts();
            dgvListProduct.DataSource = listAllProduct;
        }

        private void DisplayProductPhoto(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    Image originalImage = Image.FromStream(ms);

                    // Calculate the new dimensions while maintaining the aspect ratio
                    int maxWidth = pbImage.Width;
                    int maxHeight = pbImage.Height;
                    int newWidth, newHeight;
                    double aspectRatio = (double)originalImage.Width / originalImage.Height;

                    if (aspectRatio > 1)
                    {
                        newWidth = maxWidth;
                        newHeight = (int)(maxWidth / aspectRatio);
                    }
                    else
                    {
                        newWidth = (int)(maxHeight * aspectRatio);
                        newHeight = maxHeight;
                    }

                    // Create a new bitmap with the resized dimensions
                    Bitmap resizedImage = new Bitmap(newWidth, newHeight);

                    // Create a Graphics object to perform the resizing
                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        // Set the interpolation mode to high quality
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        // Draw the original image onto the resized bitmap
                        graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                    }

                    // Dispose the previous image in the PictureBox, if any
                    pbImage.Image?.Dispose();

                    // Display the resized image in the PictureBox
                    pbImage.Image = resizedImage;
                }
            }
            else
            {
                pbImage.Image = null;
            }
        }

        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListProduct.Rows[e.RowIndex];
                string productId = row.Cells["ProductId"].Value.ToString();

                var selectedProduct = _productServices.GetProductById(productId);
                if (selectedProduct != null)
                {
                    DisplayProductPhoto(selectedProduct.Image);
                }
            }
        }

        private void dgvListProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListProduct.SelectedRows.Count > 0)
            {
                var selectedRow = dgvListProduct.SelectedRows[0];
                var selectedProduct = (Product)selectedRow.DataBoundItem;
                DisplayProductPhoto(selectedProduct.Image);
            }
            else
            {
                pbImage.Image = null;
            }
        }

        private void btLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit Bird Management", "Bird Management", MessageBoxButtons.YesNo);
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