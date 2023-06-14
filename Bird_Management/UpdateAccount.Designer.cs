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
            ((System.ComponentModel.ISupportInitialize)dgvUpdateAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(398, 31);
            label1.Name = "label1";
            label1.Size = new Size(327, 54);
            label1.TabIndex = 0;
            label1.Text = "Update Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 113);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(75, 171);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(75, 236);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // dgvUpdateAccount
            // 
            dgvUpdateAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateAccount.Location = new Point(558, 114);
            dgvUpdateAccount.Name = "dgvUpdateAccount";
            dgvUpdateAccount.RowHeadersWidth = 62;
            dgvUpdateAccount.RowTemplate.Height = 33;
            dgvUpdateAccount.Size = new Size(632, 311);
            dgvUpdateAccount.TabIndex = 4;
            dgvUpdateAccount.CellDoubleClick += dgvUpdateAccount_CellDoubleClick;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(228, 113);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(308, 39);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(228, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(308, 39);
            txtPassword.TabIndex = 6;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAccount.Location = new Point(228, 300);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(308, 47);
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
            toolStrip1.Size = new Size(1213, 41);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageTransparentColor = Color.Magenta;
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 36);
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // chbSeller
            // 
            chbSeller.AutoSize = true;
            chbSeller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbSeller.Location = new Point(228, 243);
            chbSeller.Name = "chbSeller";
            chbSeller.Size = new Size(99, 36);
            chbSeller.TabIndex = 10;
            chbSeller.Text = "Seller";
            chbSeller.UseVisualStyleBackColor = true;
            // 
            // chbAdmin
            // 
            chbAdmin.AutoSize = true;
            chbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbAdmin.Location = new Point(379, 243);
            chbAdmin.Name = "chbAdmin";
            chbAdmin.Size = new Size(110, 36);
            chbAdmin.TabIndex = 11;
            chbAdmin.Text = "Admin";
            chbAdmin.UseVisualStyleBackColor = true;
            // 
            // UpdateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 464);
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
    }
}