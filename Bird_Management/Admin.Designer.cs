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
            dgvListAccount = new DataGridView();
            btnCreate = new Button();
            button2 = new Button();
            button3 = new Button();
            toolStrip1 = new ToolStrip();
            btLogout = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListAccount
            // 
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAccount.Location = new Point(87, 152);
            dgvListAccount.Margin = new Padding(2, 2, 2, 2);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.RowHeadersWidth = 62;
            dgvListAccount.RowTemplate.Height = 33;
            dgvListAccount.Size = new Size(634, 206);
            dgvListAccount.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(87, 371);
            btnCreate.Margin = new Padding(2, 2, 2, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(89, 50);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(256, 371);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(89, 50);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(426, 373);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(89, 46);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btLogout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(780, 35);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // btLogout
            // 
            btLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btLogout.Image = (Image)resources.GetObject("btLogout.Image");
            btLogout.ImageTransparentColor = Color.Magenta;
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(106, 32);
            btLogout.Text = "Logout";
            btLogout.Click += btLogout_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(463, 46);
            label1.TabIndex = 19;
            label1.Text = "WELCOME TO ADMIN PAGE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(87, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 20;
            label2.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(160, 102);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(460, 34);
            txtSearch.TabIndex = 21;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 468);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCreate);
            Controls.Add(dgvListAccount);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListAccount;
        private Button btnCreate;
        private Button button2;
        private Button button3;
        private ToolStrip toolStrip1;
        private ToolStripButton btLogout;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
    }
}