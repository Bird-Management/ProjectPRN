using Respository.Models;
using Respository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class CreateProduct : Form
    {
        private BirdManagementContext dbContext;
        private ProductServices productServices;

        public CreateProduct()
        {
            InitializeComponent();

            // Initialize the DbContext
            dbContext = new BirdManagementContext();
            productServices = new ProductServices(dbContext);

            // Populate the Category ComboBox
            PopulateCategories();

            DisableFields();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg); // Change the format if needed
                return ms.ToArray();
            }
        }

        private int GetNextProductId()
        {
            // Retrieve the last product ID from the database
            string lastProductId = dbContext.Product
                .OrderByDescending(p => p.ProductId)
                .Select(p => p.ProductId)
                .FirstOrDefault();

            // Extract the numeric part of the last product ID
            if (!string.IsNullOrEmpty(lastProductId) && lastProductId.StartsWith("D-"))
            {
                if (int.TryParse(lastProductId.Substring(2), out int lastIdNumber))
                {
                    // Increment the last ID number and return the next product ID
                    return lastIdNumber + 1;
                }
            }

            // If no valid ID found, return 1 as the default starting value
            return 1;
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the form controls
                string name = txtName.Text;
                string quantityText = txtQuantity.Text;
                string description = txtDescription.Text;
                string priceText = txtPrice.Text;
                Category selectedCategory = (Category)cbCategory.SelectedItem;
                Image image = pbImage.Image;

                // Validate the inputs
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(quantityText) ||
                    string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(priceText) || selectedCategory == null)
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int quantity;
                if (!int.TryParse(quantityText, out quantity) || quantity < 0)
                {
                    MessageBox.Show("Invalid quantity format. Please enter a whole number greater than or equal to zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal price;
                if (!decimal.TryParse(priceText, out price) || price < 0)
                {
                    MessageBox.Show("Invalid price format. Please enter a valid decimal number greater than or equal to zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] imageData = null;
                if (image != null)
                {
                    // Convert the image to byte array
                    imageData = ImageToByteArray(image);
                }
                else
                {
                    MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate the next product ID
                int nextProductId = GetNextProductId();
                string id = "D-0" + nextProductId;

                // Create a new Product object
                Product newProduct = new Product
                {
                    ProductId = id,
                    ProductName = name,
                    Quantity = quantity,
                    Description = description,
                    Price = (double?)price,
                    CategoryId = selectedCategory.CategoryId,
                    Image = imageData // Assign the image byte array to the Product's Image property
                };

                // Save the new product to the database
                dbContext.Product.Add(newProduct);
                dbContext.SaveChanges();

                // Display a success message
                MessageBox.Show("New bird created successfully!", "Notification", MessageBoxButtons.OK);

                // Clear the form controls
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            pbImage.Image = null;
            cbCategory.SelectedIndex = -1;
        }

        private void PopulateCategories()
        {
            try
            {
                // Retrieve all categories from the database
                List<Category> categories = dbContext.Category.ToList();

                // Bind the categories to the ComboBox
                cbCategory.DataSource = categories;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Seller();
            form.Show();
        }

        private void btnCreateProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateProduct_Click(sender, e);
            }
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += btnCreateProduct_KeyDown;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                ResizeAndDisplayImage(selectedFilePath);
            }
        }

        private void ResizeAndDisplayImage(string filePath)
        {
            try
            {
                // Load the original image
                Image originalImage = Image.FromFile(filePath);

                // Define the maximum width and height for the resized image
                int maxWidth = pbImage.Width;
                int maxHeight = pbImage.Height;

                // Calculate the new dimensions while maintaining the aspect ratio
                int newWidth, newHeight;
                if (originalImage.Width > originalImage.Height)
                {
                    newWidth = maxWidth;
                    newHeight = (int)((double)originalImage.Height / originalImage.Width * maxWidth);
                }
                else
                {
                    newWidth = (int)((double)originalImage.Width / originalImage.Height * maxHeight);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisableFields()
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            txtQuantity.Enabled = true;
            txtDescription.Enabled = true;
            txtPrice.Enabled = true;
            cbCategory.Enabled = true;
        }
    }
}