using Respository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bird_Management
{
    public partial class CreateProduct : Form
    {
        // Constructor
        public CreateProduct()
        {
            InitializeComponent();
        }

        // Event handler for the "Create new Bird" button
        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string name = txtName.Text;
            string title = txtTitle.Text;
            string description = txtDescription.Text;

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price value. Please enter a valid number.");
                return;
            }

            // Create a new instance of the Product class and populate its properties
            Product newProduct = new Product
            {
                Name = name,
                Title = title,
                Description = description,
                Price = price
            };

            // TODO: Save the newProduct to your data repository or perform any other desired operations

            // Show a success message
            MessageBox.Show("New product created successfully!");

            // Clear the text boxes for the next product creation
            ClearTextBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Sell Page?", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Sell();
                form.Show();
            }
        }
        // Helper method to clear the text boxes
        private void ClearTextBoxes()
        {
            txtName.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }
    }
}
