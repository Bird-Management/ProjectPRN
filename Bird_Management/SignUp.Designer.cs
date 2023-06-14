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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btSignUp = new Button();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            label4 = new Label();
            textBox1 = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(230, 60);
            label1.Name = "label1";
            label1.Size = new Size(422, 46);
            label1.TabIndex = 0;
            label1.Text = "Sign Up for BirdShop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(180, 137);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(180, 198);
            label3.Name = "label3";
            label3.Size = new Size(126, 29);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(411, 137);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 35);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(411, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(199, 35);
            txtPassword.TabIndex = 6;
            // 
            // btSignUp
            // 
            btSignUp.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btSignUp.ForeColor = Color.Black;
            btSignUp.Location = new Point(411, 311);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(199, 54);
            btSignUp.TabIndex = 9;
            btSignUp.Text = "SignUp";
            btSignUp.UseVisualStyleBackColor = true;
            btSignUp.Click += btSignUp_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageTransparentColor = Color.Magenta;
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 36);
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(180, 251);
            label4.Name = "label4";
            label4.Size = new Size(222, 32);
            label4.TabIndex = 11;
            label4.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(411, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 35);
            textBox1.TabIndex = 12;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(toolStrip1);
            Controls.Add(btSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "SignUp";
            Text = "SignUp";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btSignUp;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private Label label4;
        private TextBox textBox1;
    }
}