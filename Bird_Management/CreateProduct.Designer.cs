namespace Bird_Management
{
    partial class CreateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProduct));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnCreateProduct = new Button();
            btnImage = new Button();
            pbImage = new PictureBox();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            label7 = new Label();
            cbCategory = new ComboBox();
            label8 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 383);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(205, 183);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(205, 436);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(205, 489);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(205, 542);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(454, 23);
            label6.Name = "label6";
            label6.Size = new Size(282, 46);
            label6.TabIndex = 5;
            label6.Text = "Create New Bird";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(454, 383);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 34);
            txtName.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(454, 436);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(324, 34);
            txtQuantity.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(454, 483);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(324, 34);
            txtDescription.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(453, 536);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(324, 34);
            txtPrice.TabIndex = 10;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateProduct.Location = new Point(834, 469);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(324, 48);
            btnCreateProduct.TabIndex = 11;
            btnCreateProduct.Text = "Create new Bird";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            btnCreateProduct.KeyDown += btnCreateProduct_KeyDown;
            // 
            // btnImage
            // 
            btnImage.BackColor = SystemColors.ScrollBar;
            btnImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImage.Location = new Point(825, 176);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(135, 43);
            btnImage.TabIndex = 12;
            btnImage.Text = "Browser";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(454, 94);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(323, 208);
            pbImage.TabIndex = 13;
            pbImage.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(1224, 35);
            toolStrip1.TabIndex = 14;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(923, 294);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 15;
            label7.Text = "Category";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(834, 375);
            cbCategory.Margin = new Padding(4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(294, 36);
            cbCategory.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(205, 327);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(33, 28);
            label8.TabIndex = 17;
            label8.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(454, 327);
            txtId.Name = "txtId";
            txtId.Size = new Size(324, 34);
            txtId.TabIndex = 18;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 599);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(cbCategory);
            Controls.Add(label7);
            Controls.Add(toolStrip1);
            Controls.Add(pbImage);
            Controls.Add(btnImage);
            Controls.Add(btnCreateProduct);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "CreateProduct";
            Text = "CreateProduct";
            Load += CreateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
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
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnCreateProduct;
        private Button btnImage;
        private PictureBox pbImage;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private Label label7;
        private ComboBox cbCategory;
        private Label label8;
        private TextBox txtId;
    }
}