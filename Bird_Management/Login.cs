﻿using Repository.Services;
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
    public partial class Login : Form
    {
        public BirdManagementContext _context = new BirdManagementContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AccountServices _accountServices = new AccountServices(_context);
                string us = txtUsername.Text;
                string pas = txtPassword.Text;

                Account ac = _accountServices.LoginAccount(us, pas);
                if (ac.IsAdmin == true)
                {
                    this.Hide();

                    Form form = new Admin();
                    form.ShowDialog();
                }
                else if (ac.IsSell == true)
                {
                    this.Hide();

                    Form form = new Seller();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formSignUp = new SignUp();
            formSignUp.ShowDialog();

        }
<<<<<<< HEAD
        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += btLogin_KeyDown;
        }
=======
>>>>>>> 1062abc77efa1e2dd0233f09b1315691e0f0ae58

        private void btLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }
<<<<<<< HEAD
=======

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += btLogin_KeyDown;
        }
>>>>>>> 1062abc77efa1e2dd0233f09b1315691e0f0ae58
    }
}
