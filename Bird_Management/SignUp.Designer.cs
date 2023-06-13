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
            chbSell = new CheckBox();
            chbAdmin = new CheckBox();
            btSignUp = new Button();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
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
            txtUsername.Location = new Point(305, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 35);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(305, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(199, 35);
            txtPassword.TabIndex = 6;
            // 
            // chbSell
            // 
            chbSell.AutoSize = true;
            chbSell.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            chbSell.ForeColor = Color.Black;
            chbSell.Location = new Point(306, 244);
            chbSell.Name = "chbSell";
            chbSell.Size = new Size(82, 33);
            chbSell.TabIndex = 7;
            chbSell.Text = "Sell";
            chbSell.UseVisualStyleBackColor = true;
            // 
            // chbAdmin
            // 
            chbAdmin.AutoSize = true;
            chbAdmin.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            chbAdmin.ForeColor = Color.Black;
            chbAdmin.Location = new Point(390, 244);
            chbAdmin.Name = "chbAdmin";
            chbAdmin.Size = new Size(114, 33);
            chbAdmin.TabIndex = 8;
            chbAdmin.Text = "Admin";
            chbAdmin.UseVisualStyleBackColor = true;
            // 
            // btSignUp
            // 
            btSignUp.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btSignUp.ForeColor = Color.Black;
            btSignUp.Location = new Point(305, 283);
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
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(btSignUp);
            Controls.Add(chbAdmin);
            Controls.Add(chbSell);
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
        private CheckBox chbSell;
        private CheckBox chbAdmin;
        private Button btSignUp;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
    }
}