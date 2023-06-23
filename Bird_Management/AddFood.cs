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
            DialogResult result = MessageBox.Show("Do you want to back Shopping Page", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Staff();
                form.Show();

            }
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
            string fID = txtFoodID.Text.Trim();
            string fName = txtFoodName.Text.Trim();
            string startD = txtStartDate.Text.Trim();
            string endD = txtEndDate.Text.Trim();
            string producer = cboProducer.Text;
            string price = txtPrice.Text.Trim();
            string amount = txtAmount.Text.Trim();

            // check fID follow Fxxxx format
            string pattern = @"^F\d{4}$";
            if (!Regex.IsMatch(fID, pattern) && string.IsNullOrEmpty(fID))
            {
                MessageBox.Show("Please enter in the blank \nFollowing format Fxxxx", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(fName))
            {
                MessageBox.Show("Please enter in the blank", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter in the numeric", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(amount, out int amountF))
            {
                MessageBox.Show("Please enter in the numeric", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chbOutOfStock.Checked)
            {
                bool status = false;
                FoodServices foodServices = new FoodServices(context);
                foodServices.AddNewFood(fID, fName, startDate, endDate, amountF, priceF, producer, status);
                MessageBox.Show("Food added successfully", "Notification", MessageBoxButtons.OK);
            }
            else if (chbStoking.Checked)
            {
                bool status = true;
                FoodServices foodServices = new FoodServices(context);
                foodServices.AddNewFood(fID, fName, startDate, endDate, amountF, priceF, producer, status);
                MessageBox.Show("Food added successfully", "Notification", MessageBoxButtons.OK);
            }

            //clear text
            txtFoodID.Clear();
            txtFoodName.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtAmount.Clear();
            txtPrice.Clear();
            cboProducer.SelectedIndex = -1;
            chbOutOfStock.Checked = false;
            chbStoking.Checked = false;
        }


    }
}
