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

        public CreateProduct()
        {
            InitializeComponent();

            // Initialize the DbContext
            dbContext = new BirdManagementContext();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            // Get the values from the form controls
            string name = txtName.Text;
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            decimal price = decimal.Parse(txtPrice.Text);

            // Create a new Product object
            Product newProduct = new Product
            {
                Name = name,
                Title = title,
                Description = description,
                Price = price
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
            txtName.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            pbImage.Image = null;
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

    }
}
