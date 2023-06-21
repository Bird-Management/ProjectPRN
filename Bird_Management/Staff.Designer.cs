namespace Bird_Management
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnLogout = new ToolStripButton();
            dgvFood = new DataGridView();
            btnAddFood = new Button();
            btnUpdateFood = new Button();
            btnDeleteFood = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(290, 41);
            label1.Name = "label1";
            label1.Size = new Size(340, 54);
            label1.TabIndex = 0;
            label1.Text = "WELCOME STAFF";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLogout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(878, 41);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageTransparentColor = Color.Magenta;
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 36);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(12, 115);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 62;
            dgvFood.RowTemplate.Height = 33;
            dgvFood.Size = new Size(854, 225);
            dgvFood.TabIndex = 12;
            // 
            // btnAddFood
            // 
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(12, 374);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(147, 42);
            btnAddFood.TabIndex = 13;
            btnAddFood.Text = "Add food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateFood.Location = new Point(202, 374);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(167, 42);
            btnUpdateFood.TabIndex = 14;
            btnUpdateFood.Text = "Update food";
            btnUpdateFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.Location = new Point(413, 374);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(167, 42);
            btnDeleteFood.TabIndex = 15;
            btnDeleteFood.Text = "Delete food";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 487);
            Controls.Add(btnDeleteFood);
            Controls.Add(btnUpdateFood);
            Controls.Add(btnAddFood);
            Controls.Add(dgvFood);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Name = "Staff";
            Text = "Customer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnLogout;
        private DataGridView dgvFood;
        private Button btnAddFood;
        private Button btnUpdateFood;
        private Button btnDeleteFood;
    }
}