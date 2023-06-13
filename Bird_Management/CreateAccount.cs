﻿using System;
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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to back Admin Page?", "BirdShop",
                MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Login();
                form.Show();
            }
    }
}
