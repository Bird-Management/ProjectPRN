using Repository.Services;
using Respository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class AddFood : Form
    {
        BirdManagementContext context = new BirdManagementContext();
        public AddFood()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Staff();
            form.Show();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            FoodServices foodServices = new FoodServices(context);
            var listProducer = foodServices.GetProducerList();
            foreach (var item in listProducer)
            {
                cboProducer.Items.Add(item.ProducerName);
            }
        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FoodServices foodServices = new FoodServices(context);

            string fID = txtFoodID.Text.Trim();
            string fName = txtFoodName.Text.Trim();
            string startD = txtStartDate.Text.Trim();
            string endD = txtEndDate.Text.Trim();
            string producer = cboProducer.Text;
            string price = txtPrice.Text.Trim();
            string amount = txtAmount.Text.Trim();

            if (foodServices.FoodIdIsExist(fID))
            {
                MessageBox.Show("Food ID is exist \nPlease enter other ID", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!foodServices.IsValidFoodID(fID))
            {
                MessageBox.Show("Please enter Food ID \nFollowing format Fxxxx", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(fName))
            {
                MessageBox.Show("Please enter Food Name", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(startD, out DateTime startDate))
            {
                MessageBox.Show("Please enter the Manufacturing Date \nThe format is yyyy-mm-dd", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(endD, out DateTime endDate))
            {
                MessageBox.Show("Please enter Expiry Date \nThe format is yyyy-mm-dd", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(producer))
            {
                MessageBox.Show("Please select the producer for your food", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(price, out float priceF))
            {
                MessageBox.Show("Please enter Price of product", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(amount, out int amountF))
            {
                MessageBox.Show("Please enter Amount of product", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool status;
            if (chbOutOfStock.Checked && chbStocking.Checked)
            {
                MessageBox.Show("Please select only one food status", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (chbOutOfStock.Checked)
            {
                status = false;
            }
            else if (chbStocking.Checked)
            {
                status = true;
            }
            else
            {
                MessageBox.Show("Please select the food status", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update the food?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foodServices.AddNewFood(fID, fName, startDate, endDate, amountF, priceF, producer, status);
                MessageBox.Show("Food added successfully", "Notification", MessageBoxButtons.OK);

                // Xóa nội dung trong các textbox
                txtFoodID.Clear();
                txtFoodName.Clear();
                txtStartDate.Clear();
                txtEndDate.Clear();
                txtAmount.Clear();
                txtPrice.Clear();
                cboProducer.SelectedIndex = -1;
                chbOutOfStock.Checked = false;
                chbStocking.Checked = false;
            }
        }
    }
}
