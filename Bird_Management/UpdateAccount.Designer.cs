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
            dgvUpdateAccount = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            cbRole = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lable = new Label();
            label5 = new Label();
            txtAccountID = new TextBox();
            d = new Label();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSearch = new Button();
            txtSearchAccountByID = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(393, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 47);
            label1.TabIndex = 0;
            label1.Text = "Update Account";
            // 
            // dgvUpdateAccount
            // 
            dgvUpdateAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateAccount.Location = new Point(521, 133);
            dgvUpdateAccount.Margin = new Padding(2);
            dgvUpdateAccount.Name = "dgvUpdateAccount";
            dgvUpdateAccount.RowHeadersWidth = 62;
            dgvUpdateAccount.RowTemplate.Height = 33;
            dgvUpdateAccount.Size = new Size(554, 299);
            dgvUpdateAccount.TabIndex = 4;
            dgvUpdateAccount.CellDoubleClick += dgvUpdateAccount_CellDoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1159, 31);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageTransparentColor = Color.Magenta;
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(74, 28);
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Seller", "Staff" });
            cbRole.Location = new Point(216, 334);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(270, 23);
            cbRole.TabIndex = 35;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(216, 258);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 29);
            txtEmail.TabIndex = 34;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(216, 295);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(270, 29);
            txtPhone.TabIndex = 33;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lable.Location = new Point(112, 287);
            lable.Margin = new Padding(2, 0, 2, 0);
            lable.Name = "lable";
            lable.Size = new Size(54, 21);
            lable.TabIndex = 32;
            lable.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(112, 258);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 31;
            label5.Text = "Email";
            // 
            // txtAccountID
            // 
            txtAccountID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountID.Location = new Point(216, 147);
            txtAccountID.Margin = new Padding(2);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(270, 29);
            txtAccountID.TabIndex = 30;
            // 
            // d
            // 
            d.AutoSize = true;
            d.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            d.Location = new Point(112, 147);
            d.Margin = new Padding(2, 0, 2, 0);
            d.Name = "d";
            d.Size = new Size(81, 21);
            d.TabIndex = 29;
            d.Text = "AccountID";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(216, 376);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(270, 25);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(216, 218);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 29);
            txtPassword.TabIndex = 27;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(216, 184);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 29);
            txtUsername.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(112, 184);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 25;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(112, 334);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 24;
            label7.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(112, 218);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 23;
            label8.Text = "Password";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(748, 89);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(172, 25);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchAccountByID
            // 
            txtSearchAccountByID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchAccountByID.Location = new Point(438, 88);
            txtSearchAccountByID.Margin = new Padding(2);
            txtSearchAccountByID.Name = "txtSearchAccountByID";
            txtSearchAccountByID.Size = new Size(270, 29);
            txtSearchAccountByID.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(239, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 36;
            label2.Text = "SearchAccountByID";
            // 
            // UpdateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 460);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchAccountByID);
            Controls.Add(label2);
            Controls.Add(cbRole);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(lable);
            Controls.Add(label5);
            Controls.Add(txtAccountID);
            Controls.Add(d);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(toolStrip1);
            Controls.Add(dgvUpdateAccount);
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
        private DataGridView dgvUpdateAccount;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private ComboBox cbRole;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lable;
        private Label label5;
        private TextBox txtAccountID;
        private Label d;
        private Button btnUpdate;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSearch;
        private TextBox txtSearchAccountByID;
        private Label label2;
    }
}