namespace Bird_Management
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnCreateAccount = new Button();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            btBack = new ToolStripButton();
            label5 = new Label();
            lable = new Label();
            label7 = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            cbRole = new ComboBox();
            label6 = new Label();
            txtAccountID = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(125, 161);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 208);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 249);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(312, 161);
            txtUsername.Margin = new Padding(2, 3, 2, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 34);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(312, 208);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(289, 34);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(313, 249);
            txtConfirmPassword.Margin = new Padding(2, 3, 2, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(287, 34);
            txtConfirmPassword.TabIndex = 7;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateAccount.Location = new Point(311, 444);
            btnCreateAccount.Margin = new Padding(2, 3, 2, 3);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(289, 36);
            btnCreateAccount.TabIndex = 10;
            btnCreateAccount.Text = "Create account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Peru;
            label4.Location = new Point(173, 35);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(388, 50);
            label4.TabIndex = 11;
            label4.Text = "Create Account Form";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(765, 35);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btBack.Image = (Image)resources.GetObject("btBack.Image");
            btBack.ImageTransparentColor = Color.Magenta;
            btBack.Name = "btBack";
            btBack.Size = new Size(85, 32);
            btBack.Text = "Back";
            btBack.Click += btBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(125, 295);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lable.Location = new Point(125, 344);
            lable.Margin = new Padding(2, 0, 2, 0);
            lable.Name = "lable";
            lable.Size = new Size(67, 28);
            lable.TabIndex = 14;
            lable.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(125, 391);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 28);
            label7.TabIndex = 15;
            label7.Text = "Role";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(312, 344);
            txtPhone.Margin = new Padding(2, 3, 2, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(287, 34);
            txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(312, 295);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 34);
            txtEmail.TabIndex = 17;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Seller", "Staff" });
            cbRole.Location = new Point(311, 391);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(289, 28);
            cbRole.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(125, 115);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 19;
            label6.Text = "AccountID";
            // 
            // txtAccountID
            // 
            txtAccountID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountID.Location = new Point(311, 115);
            txtAccountID.Margin = new Padding(2, 3, 2, 3);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(289, 34);
            txtAccountID.TabIndex = 20;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 528);
            Controls.Add(txtAccountID);
            Controls.Add(label6);
            Controls.Add(cbRole);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(label7);
            Controls.Add(lable);
            Controls.Add(label5);
            Controls.Add(toolStrip1);
            Controls.Add(label4);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CreateAccount";
            Text = "CreateAccount";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtEmail;
        private TextBox textBox3;
        private Button btnCreateAccount;
        private Label label4;
        private ToolStrip toolStrip1;
        private ToolStripButton btBack;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label5;
        private Label label7;
        private ComboBox cbRole;
        private Label lable;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtAccountID;
    }
}