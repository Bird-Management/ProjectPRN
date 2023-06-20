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
    public partial class ViewCart : Form
    {
        BirdManagementContext context = new BirdManagementContext();
        public ViewCart()
        {
            InitializeComponent();
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to back Shopping Page", "BirdShop",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Customer();
                form.Show();

            }
        }

        public void loadData()
        {
            CartServices cartServices = new CartServices(context);
            var listCart = cartServices.getCarts();

            dgvListCart.DataSource = new BindingSource() { DataSource = listCart };
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
