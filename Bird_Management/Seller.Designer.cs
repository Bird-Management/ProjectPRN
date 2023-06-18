namespace Bird_Management
{
    partial class Seller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seller));
            label1 = new Label();
            dgvListProduct = new DataGridView();
            btnCreateProduct = new Button();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            toolStrip1 = new ToolStrip();
            btLogout = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(235, 57);
            label1.Name = "label1";
            label1.Size = new Size(527, 46);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO SELL PAGE";
            // 
            // dgvListProduct
            // 
            dgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.Location = new Point(115, 122);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowHeadersWidth = 62;
            dgvListProduct.RowTemplate.Height = 33;
            dgvListProduct.Size = new Size(771, 225);
            dgvListProduct.TabIndex = 1;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateProduct.Location = new Point(115, 383);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(111, 57);
            btnCreateProduct.TabIndex = 2;
            btnCreateProduct.Text = "Create";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateProduct.Location = new Point(303, 384);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(111, 55);
            btnUpdateProduct.TabIndex = 3;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteProduct.Location = new Point(494, 384);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(111, 56);
            btnDeleteProduct.TabIndex = 4;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btLogout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(979, 41);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // btLogout
            // 
            btLogout.Checked = true;
            btLogout.CheckState = CheckState.Checked;
            btLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btLogout.Image = (Image)resources.GetObject("btLogout.Image");
            btLogout.ImageTransparentColor = Color.Magenta;
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(123, 36);
            btLogout.Text = "Logout";
            btLogout.Click += btLogout_Click_1;
            // 
            // Sell
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 523);
            Controls.Add(toolStrip1);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnCreateProduct);
            Controls.Add(dgvListProduct);
            Controls.Add(label1);
            Name = "Sell";
            Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvListProduct;
        private Button btnCreateProduct;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private ToolStrip toolStrip1;
        private ToolStripButton btLogout;
    }
}