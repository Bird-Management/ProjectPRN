using Microsoft.EntityFrameworkCore;
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

namespace Bird_Management
{
    public partial class DeleteFood : Form
    {
        BirdManagementContext context = new BirdManagementContext();
        public DeleteFood()
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
            FoodServices foodServices = new FoodServices(context);
            var listFood = foodServices.GetFoodsOther();

            dgvDeleteFood.DataSource = new BindingSource() { DataSource = listFood };
        }

        private void dgvDeleteFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FoodServices _foodServices = new FoodServices(context);
            var details = _foodServices.GetFoodsOther();

            if (e.RowIndex < details.Count)
            {
                var select = details[e.RowIndex];

                txtFoodID.Text = select.FoodId;
                txtFoodName.Text = select.FoodName;
                txtStartDate.Text = select.StartDate.ToShortDateString();
                txtEndDate.Text = select.EndDate.ToShortDateString();
                txtProducer.Text = select.Producer;
                txtAmount.Text = select.Amount.ToString();
                txtPrice.Text = select.Price.ToString();

                if (select.Status == true)
                {
                    txtStatus.Text = "Stocking";
                }
                else
                {
                    txtStatus.Text = "Out of stock";
                }

                // set read only
                txtFoodID.Enabled = false;
                txtFoodName.Enabled = false;
                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;
                txtProducer.Enabled = false;
                txtPrice.Enabled = false;
                txtAmount.Enabled = false;
                txtStatus.Enabled = false;
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            FoodServices foodServices = new FoodServices(context);

            string foodIDToDelete = txtFoodID.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this food?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool isDelete = foodServices.DeleteFood(foodIDToDelete);

                if (isDelete)
                {
                    MessageBox.Show("Food deleted successfully", "Bird Management", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Food not found or could not be deleted", "Bird Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
            txtProducer.Clear();
            txtPrice.Clear();
            txtAmount.Clear();
            txtStatus.Clear();
        }

        private void RefreshData()
        {
            FoodServices _foodServices = new FoodServices(context);
            var list = _foodServices.GetFoodsOther();
            dgvDeleteFood.DataSource = new BindingSource() { DataSource = list };
        }

    }
}
