namespace Bird_Management
{
    partial class SignUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chbSell = new CheckBox();
            chbAdmin = new CheckBox();
            btSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign Up for BirdShop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(115, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(115, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(202, 59);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(134, 26);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(202, 96);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(134, 26);
            txtPassword.TabIndex = 6;
            // 
            // chbSell
            // 
            chbSell.AutoSize = true;
            chbSell.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            chbSell.ForeColor = Color.Black;
            chbSell.Location = new Point(200, 126);
            chbSell.Margin = new Padding(2, 2, 2, 2);
            chbSell.Name = "chbSell";
            chbSell.Size = new Size(56, 23);
            chbSell.TabIndex = 7;
            chbSell.Text = "Sell";
            chbSell.UseVisualStyleBackColor = true;
            // 
            // chbAdmin
            // 
            chbAdmin.AutoSize = true;
            chbAdmin.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            chbAdmin.ForeColor = Color.Black;
            chbAdmin.Location = new Point(259, 126);
            chbAdmin.Margin = new Padding(2, 2, 2, 2);
            chbAdmin.Name = "chbAdmin";
            chbAdmin.Size = new Size(77, 23);
            chbAdmin.TabIndex = 8;
            chbAdmin.Text = "Admin";
            chbAdmin.UseVisualStyleBackColor = true;
            // 
            // btSignUp
            // 
            btSignUp.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btSignUp.ForeColor = Color.Black;
            btSignUp.Location = new Point(202, 149);
            btSignUp.Margin = new Padding(2, 2, 2, 2);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(78, 26);
            btSignUp.TabIndex = 9;
            btSignUp.Text = "SignUp";
            btSignUp.UseVisualStyleBackColor = true;
            btSignUp.Click += btSignUp_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btSignUp);
            Controls.Add(chbAdmin);
            Controls.Add(chbSell);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Margin = new Padding(2, 2, 2, 2);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chbSell;
        private CheckBox chbAdmin;
        private Button btSignUp;
    }
}