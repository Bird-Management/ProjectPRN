namespace Bird_Management
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            label1 = new Label();
            dgvListAccount = new DataGridView();
            btnCreate = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            chbSeller = new CheckBox();
            chbAdmin = new CheckBox();
            toolStrip1 = new ToolStrip();
            btLogout = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGoldenrod;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 34);
            label1.Name = "label1";
            label1.Size = new Size(553, 46);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO ADMIN PAGE";
            // 
            // dgvListAccount
            // 
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAccount.Location = new Point(196, 94);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.RowHeadersWidth = 62;
            dgvListAccount.RowTemplate.Height = 33;
            dgvListAccount.Size = new Size(831, 257);
            dgvListAccount.TabIndex = 1;
            dgvListAccount.CellDoubleClick += dgvListAccount_CellDoubleClick;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(51, 94);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 62);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(51, 163);
            button2.Name = "button2";
            button2.Size = new Size(111, 62);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(51, 231);
            button3.Name = "button3";
            button3.Size = new Size(111, 58);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(51, 296);
            button4.Name = "button4";
            button4.Size = new Size(111, 55);
            button4.TabIndex = 5;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(333, 409);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 35);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(333, 479);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 35);
            txtPassword.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(199, 411);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(199, 483);
            label3.Name = "label3";
            label3.Size = new Size(126, 29);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(718, 354);
            label6.Name = "label6";
            label6.Size = new Size(86, 37);
            label6.TabIndex = 14;
            label6.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(333, 354);
            label7.Name = "label7";
            label7.Size = new Size(144, 37);
            label7.TabIndex = 15;
            label7.Text = "Account";
            // 
            // chbSeller
            // 
            chbSeller.AutoSize = true;
            chbSeller.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            chbSeller.Location = new Point(688, 413);
            chbSeller.Name = "chbSeller";
            chbSeller.Size = new Size(104, 33);
            chbSeller.TabIndex = 16;
            chbSeller.Text = "Seller";
            chbSeller.UseVisualStyleBackColor = true;
            // 
            // chbAdmin
            // 
            chbAdmin.AutoSize = true;
            chbAdmin.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            chbAdmin.Location = new Point(688, 478);
            chbAdmin.Name = "chbAdmin";
            chbAdmin.Size = new Size(114, 33);
            chbAdmin.TabIndex = 17;
            chbAdmin.Text = "Admin";
            chbAdmin.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btLogout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1039, 41);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // btLogout
            // 
            btLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btLogout.Image = (Image)resources.GetObject("btLogout.Image");
            btLogout.ImageTransparentColor = Color.Magenta;
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(123, 36);
            btLogout.Text = "Logout";
            btLogout.Click += btLogout_Click_1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 573);
            Controls.Add(toolStrip1);
            Controls.Add(chbAdmin);
            Controls.Add(chbSeller);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCreate);
            Controls.Add(dgvListAccount);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvListAccount;
        private Button btnCreate;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private CheckBox chbSeller;
        private CheckBox chbAdmin;
        private ToolStrip toolStrip1;
        private ToolStripButton btLogout;
    }
}