using Repository.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bird_Management
{
    public partial class UpdateFood : Form
    {
        BirdManagementContext _context = new BirdManagementContext();
        public UpdateFood()
        {
            InitializeComponent();
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Staff();
            form.ShowDialog();
        }

        public void loadData()
        {
            FoodServices _foodServices = new FoodServices(_context);
            var list = _foodServices.GetFoodsOther();

            dgvUpdateFood.DataSource = new BindingSource() { DataSource = list };
        }

        private void dgvUpdateFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FoodServices foodServices = new FoodServices(_context);
            var list = foodServices.GetFoodsOther();

            if (e.RowIndex < list.Count)
            {
                var selectFood = list[e.RowIndex];

                txtFoodID.Text = selectFood.FoodId;
                txtFoodName.Text = selectFood.FoodName;
                txtStartDate.Text = selectFood.StartDate.ToShortDateString();
                txtEndDate.Text = selectFood.EndDate.ToShortDateString();
                txtAmount.Text = selectFood.Amount.ToString();
                txtPrice.Text = selectFood.Price.ToString();
                cboProducer.Text = selectFood.Producer.ToString();

                if (selectFood.Status == true)
                {
                    chbStocking.Checked = true;
                    chbOutOfStock.Checked = false;
                }
                else
                {
                    chbOutOfStock.Checked = true;
                    chbStocking.Checked = false;
                }

                // Set read only
                txtFoodID.Enabled = false;
            }
        }

        private void UpdateFood_Load(object sender, EventArgs e)
        {
            FoodServices _foodServices = new FoodServices(_context);
            var listProducer = _foodServices.GetProducerList();
            foreach (var producer in listProducer)
            {
                cboProducer.Items.Add(producer.ProducerName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FoodServices foodServices = new FoodServices(_context);

            string foodID = txtFoodID.Text;
            string foodName = txtFoodName.Text;
            string startDate = txtStartDate.Text;
            string endDate = txtEndDate.Text;
            string producer = cboProducer.Text;
            string price = txtPrice.Text;
            string amount = txtAmount.Text;

            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("Please enter Food Name", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startDateTime;
            if (!DateTime.TryParse(startDate, out startDateTime))
            {
                MessageBox.Show("Please enter a valid Start Date in the format yyyy-mm-dd", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime endDateTime;
            if (!DateTime.TryParse(endDate, out endDateTime))
            {
                MessageBox.Show("Please enter a valid End Date in the format yyyy-mm-dd", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(price, out float priceValue))
            {
                MessageBox.Show("Please enter a valid Price", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(amount, out int amountValue))
            {
                MessageBox.Show("Please enter a valid Amount", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                foodServices.UpdateFood(foodID, foodName, startDateTime, endDateTime, producer, priceValue, amountValue, status);

                MessageBox.Show("Food updated successfully", "Bird Management", MessageBoxButtons.OK);
                ClearFoodFields();
                RefreshData();
            }
        }

        private void ClearFoodFields()
        {
            txtFoodID.Clear();
            txtFoodName.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            cboProducer.SelectedIndex = -1;
            txtPrice.Clear();
            txtAmount.Clear();
            chbOutOfStock.Checked = false;
            chbStocking.Checked = false;
            txtSearchFood.Clear();
        }

        private void RefreshData()
        {
            FoodServices _foodServices = new FoodServices(_context);
            var list = _foodServices.GetFoodsOther();
            dgvUpdateFood.DataSource = new BindingSource() { DataSource = list };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearchFood.Text;

            if (!string.IsNullOrEmpty(input))
            {
                FoodServices foodServices = new FoodServices(_context);
                var searchResults = foodServices.SearchFood(input);

                if (searchResults != null)
                {
                    txtFoodID.Text = searchResults.FoodId.ToString();
                    txtFoodName.Text = searchResults.FoodName.ToString();
                    txtStartDate.Text = searchResults.StartDate.ToString();
                    txtEndDate.Text = searchResults.EndDate.ToString();
                    txtPrice.Text = searchResults.Price.ToString();
                    txtAmount.Text = searchResults.Amount.ToString();
                    cboProducer.Text = searchResults.Producer.ToString();
                    if (searchResults.Status == true)
                    {
                        chbStocking.Checked = true;
                    }
                    else
                    {
                        chbOutOfStock.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Food is not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a ID you want to search.", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
