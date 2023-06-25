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
            btnDelete = new Button();
            dgvDeleteAccount = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            d = new Label();
            txtAccountID = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lable = new Label();
            label5 = new Label();
            cbRole = new ComboBox();
            label6 = new Label();
            txtSearchAccountByID = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(338, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 60);
            label1.TabIndex = 0;
            label1.Text = "Delete Acccount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 280);
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
            label3.Location = new Point(29, 434);
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
            label4.Location = new Point(29, 234);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(148, 234);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(308, 34);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(148, 280);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(308, 34);
            txtPassword.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(148, 490);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(308, 33);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Account";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvDeleteAccount
            // 
            dgvDeleteAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteAccount.Location = new Point(477, 167);
            dgvDeleteAccount.Margin = new Padding(2);
            dgvDeleteAccount.Name = "dgvDeleteAccount";
            dgvDeleteAccount.RowHeadersWidth = 62;
            dgvDeleteAccount.RowTemplate.Height = 33;
            dgvDeleteAccount.Size = new Size(670, 356);
            dgvDeleteAccount.TabIndex = 9;
            dgvDeleteAccount.CellDoubleClick += dgvDeleteAccount_CellDoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1181, 35);
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
            // d
            // 
            d.AutoSize = true;
            d.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            d.Location = new Point(29, 185);
            d.Margin = new Padding(2, 0, 2, 0);
            d.Name = "d";
            d.Size = new Size(103, 28);
            d.TabIndex = 11;
            d.Text = "AccountID";
            // 
            // txtAccountID
            // 
            txtAccountID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountID.Location = new Point(148, 185);
            txtAccountID.Margin = new Padding(2);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(308, 34);
            txtAccountID.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(148, 333);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 34);
            txtEmail.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(148, 382);
            txtPhone.Margin = new Padding(2, 3, 2, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(308, 34);
            txtPhone.TabIndex = 20;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lable.Location = new Point(29, 372);
            lable.Margin = new Padding(2, 0, 2, 0);
            lable.Name = "lable";
            lable.Size = new Size(67, 28);
            lable.TabIndex = 19;
            lable.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 333);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 18;
            label5.Text = "Email";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Seller", "Staff" });
            cbRole.Location = new Point(148, 434);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(308, 28);
            cbRole.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(178, 108);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 28);
            label6.TabIndex = 23;
            label6.Text = "SearchAccountByID";
            // 
            // txtSearchAccountByID
            // 
            txtSearchAccountByID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchAccountByID.Location = new Point(405, 108);
            txtSearchAccountByID.Margin = new Padding(2);
            txtSearchAccountByID.Name = "txtSearchAccountByID";
            txtSearchAccountByID.Size = new Size(308, 34);
            txtSearchAccountByID.TabIndex = 24;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(760, 109);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(197, 33);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // DeleteAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1181, 556);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchAccountByID);
            Controls.Add(label6);
            Controls.Add(cbRole);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(lable);
            Controls.Add(label5);
            Controls.Add(txtAccountID);
            Controls.Add(d);
            Controls.Add(toolStrip1);
            Controls.Add(dgvDeleteAccount);
            Controls.Add(btnDelete);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "DeleteAccount";
            Text = "DeleteAccount";
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
        private Button btnDelete;
        private DataGridView dgvDeleteAccount;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private Label d;
        private TextBox txtAccountID;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lable;
        private Label label5;
        private ComboBox cbRole;
        private Label label6;
        private TextBox txtSearchAccountByID;
        private Button btnSearch;
    }
}