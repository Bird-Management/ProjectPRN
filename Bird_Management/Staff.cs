﻿using Microsoft.Data.SqlClient;
using Repository.Services;
using Respository.Models;
using Respository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class Staff : Form
    {
        BirdManagementContext context = new BirdManagementContext();

        public Staff()
        {
            InitializeComponent();
            loadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit Bird Management", "Bird Management",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Login();
                form.Show();

            }
        }

        public void loadData()
        {
            FoodServices foodServices = new FoodServices(context);
            var list = foodServices.GetFoodsOther();

            dgvFood.DataSource = new BindingSource() { DataSource = list };
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AddFood();
            form.ShowDialog();
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new UpdateFood();
            form.ShowDialog();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DeleteFood();
            form.ShowDialog();
        }
    }
}
