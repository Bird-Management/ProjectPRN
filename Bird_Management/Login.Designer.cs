﻿namespace Bird_Management
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btRegister = new Button();
            btnShoppingCart = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            txtUsername.Location = new Point(293, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 35);
=======
            txtUsername.Location = new Point(262, 110);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 30);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            txtPassword.Location = new Point(293, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 35);
=======
            txtPassword.Location = new Point(262, 170);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(201, 30);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            txtPassword.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btLogin.Location = new Point(293, 278);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(111, 57);
=======
            btLogin.Location = new Point(262, 222);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(89, 46);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            btLogin.KeyDown += btLogin_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
<<<<<<< HEAD
            label1.Location = new Point(155, 39);
            label1.Name = "label1";
            label1.Size = new Size(527, 46);
=======
            label1.Location = new Point(151, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(452, 39);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            label1.TabIndex = 3;
            label1.Text = "WELCOME TO BIRD SHOP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            label2.Location = new Point(155, 146);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
=======
            label2.Location = new Point(151, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            label3.Location = new Point(155, 219);
            label3.Name = "label3";
            label3.Size = new Size(126, 29);
=======
            label3.Location = new Point(151, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btRegister
            // 
            btRegister.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btRegister.Location = new Point(410, 278);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(134, 57);
=======
            btRegister.Location = new Point(355, 222);
            btRegister.Margin = new Padding(2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(107, 46);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            btRegister.TabIndex = 6;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // btnShoppingCart
            // 
            btnShoppingCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShoppingCart.Location = new Point(293, 350);
            btnShoppingCart.Name = "btnShoppingCart";
            btnShoppingCart.Size = new Size(251, 45);
            btnShoppingCart.TabIndex = 7;
            btnShoppingCart.Text = "Shopping here";
            btnShoppingCart.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 448);
            Controls.Add(btnShoppingCart);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 352);
>>>>>>> 60c2d3dbde5943b4c3a70dd550e590dd58d56718
            Controls.Add(btRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btRegister;
        private Button btnShoppingCart;
    }
}