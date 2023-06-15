namespace Bird_Management
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
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(327, 138);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 35);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(327, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 35);
            txtPassword.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.Location = new Point(327, 277);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(111, 57);
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(189, 38);
            label1.Name = "label1";
            label1.Size = new Size(527, 46);
            label1.TabIndex = 3;
            label1.Text = "WELCOME TO BIRD SHOP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(189, 145);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(189, 218);
            label3.Name = "label3";
            label3.Size = new Size(126, 29);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btRegister
            // 
            btRegister.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btRegister.Location = new Point(444, 277);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(134, 57);
            btRegister.TabIndex = 6;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 440);
            Controls.Add(btRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Login";
            Text = "Login";
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
    }
}