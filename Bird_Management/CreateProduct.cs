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
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            // Get the values from the form controls
            string id = txtId.Text;
            string name = txtName.Text;
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            Category selectedCategory = (Category)cbCategory.SelectedItem;

            // Create a new Product object
            Product newProduct = new Product
            {
                ProductId = id.ToString(),
                ProductName = name,
                Title = title,
                Description = description,
                Price = (double?)price,
                CategoryId = selectedCategory.CategoryId
            };

            // Save the new product to the database
            dbContext.Product.Add(newProduct);
            dbContext.SaveChanges();

            // Display a success message
            MessageBox.Show("New bird created successfully!", "Notification", MessageBoxButtons.OK);

            // Clear the form controls
            ClearForm();
        }


        private void ClearForm()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtTitle.Text = "";
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
            DialogResult result = MessageBox.Show("Do you want to go back to the Sell Page?", "Bird Management",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Seller();
                form.Show();
            }
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

                // Display the resized image in the PictureBox
                pbImage.Image = resizedImage;

                // Dispose the original image
                originalImage.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
