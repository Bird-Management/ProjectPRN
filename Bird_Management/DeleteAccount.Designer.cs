namespace Bird_Management
{
    partial class DeleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAccount));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chkSeller = new CheckBox();
            chkAdmin = new CheckBox();
            Delete = new Button();
            dgvDeleteAccount = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            chkCustomer = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(335, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 46);
            label1.TabIndex = 0;
            label1.Text = "Delete Acccount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 173);
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
            label3.Location = new Point(20, 215);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 127);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(139, 127);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(308, 34);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(139, 173);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(308, 34);
            txtPassword.TabIndex = 5;
            // 
            // chkSeller
            // 
            chkSeller.AutoSize = true;
            chkSeller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkSeller.Location = new Point(139, 223);
            chkSeller.Margin = new Padding(2);
            chkSeller.Name = "chkSeller";
            chkSeller.Size = new Size(82, 32);
            chkSeller.TabIndex = 6;
            chkSeller.Text = "Seller";
            chkSeller.UseVisualStyleBackColor = true;
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkAdmin.Location = new Point(233, 223);
            chkAdmin.Margin = new Padding(2);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(92, 32);
            chkAdmin.TabIndex = 7;
            chkAdmin.Text = "Admin";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(139, 263);
            Delete.Margin = new Padding(2);
            Delete.Name = "Delete";
            Delete.Size = new Size(308, 33);
            Delete.TabIndex = 8;
            Delete.Text = "Delete account";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            Delete.KeyDown += btnDeleteAccount_KeyDown;
            // 
            // dgvDeleteAccount
            // 
            dgvDeleteAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteAccount.Location = new Point(468, 106);
            dgvDeleteAccount.Margin = new Padding(2);
            dgvDeleteAccount.Name = "dgvDeleteAccount";
            dgvDeleteAccount.RowHeadersWidth = 62;
            dgvDeleteAccount.RowTemplate.Height = 33;
            dgvDeleteAccount.Size = new Size(523, 232);
            dgvDeleteAccount.TabIndex = 9;
            dgvDeleteAccount.CellDoubleClick += dgvDeleteAccount_CellDoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1025, 35);
            toolStrip1.TabIndex = 10;
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
            // chkCustomer
            // 
            chkCustomer.AutoSize = true;
            chkCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkCustomer.Location = new Point(329, 223);
            chkCustomer.Margin = new Padding(2);
            chkCustomer.Name = "chkCustomer";
            chkCustomer.Size = new Size(118, 32);
            chkCustomer.TabIndex = 11;
            chkCustomer.Text = "Customer";
            chkCustomer.UseVisualStyleBackColor = true;
            // 
            // DeleteAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 412);
            Controls.Add(chkCustomer);
            Controls.Add(toolStrip1);
            Controls.Add(dgvDeleteAccount);
            Controls.Add(Delete);
            Controls.Add(chkAdmin);
            Controls.Add(chkSeller);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "DeleteAccount";
            Text = "DeleteAccount";
            Load += DeleteAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeleteAccount).EndInit();
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
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkSeller;
        private CheckBox chkAdmin;
        private Button Delete;
        private DataGridView dgvDeleteAccount;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private CheckBox chkCustomer;
    }
}