namespace Bird_Management
{
    partial class UpdateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAccount));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvUpdateAccount = new DataGridView();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnUpdateAccount = new Button();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            chbSeller = new CheckBox();
            chbAdmin = new CheckBox();
            chbCustomer = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(411, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 46);
            label1.TabIndex = 0;
            label1.Text = "Update Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 165);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 216);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // dgvUpdateAccount
            // 
            dgvUpdateAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateAccount.Location = new Point(574, 86);
            dgvUpdateAccount.Margin = new Padding(2);
            dgvUpdateAccount.Name = "dgvUpdateAccount";
            dgvUpdateAccount.RowHeadersWidth = 62;
            dgvUpdateAccount.RowTemplate.Height = 33;
            dgvUpdateAccount.Size = new Size(506, 249);
            dgvUpdateAccount.TabIndex = 4;
            dgvUpdateAccount.CellDoubleClick += dgvUpdateAccount_CellDoubleClick;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(190, 118);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(349, 34);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(190, 165);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(349, 34);
            txtPassword.TabIndex = 6;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAccount.Location = new Point(190, 262);
            btnUpdateAccount.Margin = new Padding(2);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(349, 38);
            btnUpdateAccount.TabIndex = 8;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1144, 35);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageTransparentColor = Color.Magenta;
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 32);
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // chbSeller
            // 
            chbSeller.AutoSize = true;
            chbSeller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbSeller.Location = new Point(190, 216);
            chbSeller.Margin = new Padding(2);
            chbSeller.Name = "chbSeller";
            chbSeller.Size = new Size(82, 32);
            chbSeller.TabIndex = 10;
            chbSeller.Text = "Seller";
            chbSeller.UseVisualStyleBackColor = true;
            // 
            // chbAdmin
            // 
            chbAdmin.AutoSize = true;
            chbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbAdmin.Location = new Point(309, 216);
            chbAdmin.Margin = new Padding(2);
            chbAdmin.Name = "chbAdmin";
            chbAdmin.Size = new Size(92, 32);
            chbAdmin.TabIndex = 11;
            chbAdmin.Text = "Admin";
            chbAdmin.UseVisualStyleBackColor = true;
            // 
            // chbCustomer
            // 
            chbCustomer.AutoSize = true;
            chbCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbCustomer.Location = new Point(421, 216);
            chbCustomer.Margin = new Padding(2);
            chbCustomer.Name = "chbCustomer";
            chbCustomer.Size = new Size(118, 32);
            chbCustomer.TabIndex = 12;
            chbCustomer.Text = "Customer";
            chbCustomer.UseVisualStyleBackColor = true;
            // 
            // UpdateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 433);
            Controls.Add(chbCustomer);
            Controls.Add(chbAdmin);
            Controls.Add(chbSeller);
            Controls.Add(toolStrip1);
            Controls.Add(btnUpdateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(dgvUpdateAccount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UpdateAccount";
            Text = "UpdateAccount";
            ((System.ComponentModel.ISupportInitialize)dgvUpdateAccount).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvUpdateAccount;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnUpdateAccount;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private CheckBox chbSeller;
        private CheckBox chbAdmin;
        private CheckBox chbCustomer;
    }
}