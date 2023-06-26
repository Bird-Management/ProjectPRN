namespace Bird_Management
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            pbImage = new PictureBox();
            btnImage = new Button();
            btnUpdateProduct = new Button();
            dgvProduct = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            label7 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            cbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(434, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 46);
            label1.TabIndex = 0;
            label1.Text = "Update Bird ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 233);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 271);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 311);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 349);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 5;
            label6.Text = "Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantity.Location = new Point(153, 265);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(258, 34);
            txtQuantity.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(153, 227);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 34);
            txtName.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.Location = new Point(153, 303);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(258, 34);
            txtDescription.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(153, 341);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(258, 34);
            txtPrice.TabIndex = 9;
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(152, 37);
            pbImage.Margin = new Padding(2);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(184, 119);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 10;
            pbImage.TabStop = false;
            // 
            // btnImage
            // 
            btnImage.BackColor = SystemColors.ControlDark;
            btnImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImage.Location = new Point(340, 71);
            btnImage.Margin = new Padding(2);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(90, 34);
            btnImage.TabIndex = 11;
            btnImage.Text = "Browser";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateProduct.Location = new Point(551, 341);
            btnUpdateProduct.Margin = new Padding(2);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(183, 34);
            btnUpdateProduct.TabIndex = 12;
            btnUpdateProduct.Text = "Update Bird";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            btnUpdateProduct.KeyDown += btnUpdateProduct_KeyDown;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(434, 71);
            dgvProduct.Margin = new Padding(2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowTemplate.Height = 33;
            dgvProduct.Size = new Size(416, 258);
            dgvProduct.TabIndex = 13;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(861, 35);
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
            label7.Location = new Point(32, 195);
            label7.Name = "label7";
            label7.Size = new Size(33, 28);
            label7.TabIndex = 15;
            label7.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 161);
            label8.Name = "label8";
            label8.Size = new Size(98, 28);
            label8.TabIndex = 16;
            label8.Text = "Category";
            // 
            // txtID
            // 
            txtID.Location = new Point(153, 195);
            txtID.Name = "txtID";
            txtID.Size = new Size(258, 27);
            txtID.TabIndex = 17;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(153, 161);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(258, 28);
            cbCategory.TabIndex = 18;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 386);
            Controls.Add(cbCategory);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(toolStrip1);
            Controls.Add(dgvProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnImage);
            Controls.Add(pbImage);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
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
        private TextBox txtQuantity;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private PictureBox pbImage;
        private Button btnImage;
        private Button btnUpdateProduct;
        private DataGridView dgvProduct;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private Label label7;
        private Label label8;
        private TextBox txtID;
        private ComboBox cbCategory;
    }
}