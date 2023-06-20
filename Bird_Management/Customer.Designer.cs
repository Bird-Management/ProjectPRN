namespace Bird_Management
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            label1 = new Label();
            dgvProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            _Name = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            toolStrip1 = new ToolStrip();
            btnLogout = new ToolStripButton();
            btnAddToCart = new Button();
            btnViewCart = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(250, 41);
            label1.Name = "label1";
            label1.Size = new Size(608, 54);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO SHOPPING PAGE";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Id, _Name, Image, Price, Title, Description });
            dgvProduct.Location = new Point(489, 122);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowTemplate.Height = 33;
            dgvProduct.Size = new Size(729, 407);
            dgvProduct.TabIndex = 1;
            dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // _Name
            // 
            _Name.DataPropertyName = "name";
            _Name.HeaderText = "Name";
            _Name.MinimumWidth = 8;
            _Name.Name = "_Name";
            _Name.Width = 150;
            // 
            // Image
            // 
            Image.DataPropertyName = "image";
            Image.HeaderText = "Image";
            Image.MinimumWidth = 8;
            Image.Name = "Image";
            Image.Resizable = DataGridViewTriState.True;
            Image.SortMode = DataGridViewColumnSortMode.NotSortable;
            Image.Width = 150;
            // 
            // Price
            // 
            Price.DataPropertyName = "price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Resizable = DataGridViewTriState.True;
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            Price.Width = 150;
            // 
            // Title
            // 
            Title.DataPropertyName = "title";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            Title.Resizable = DataGridViewTriState.True;
            Title.SortMode = DataGridViewColumnSortMode.NotSortable;
            Title.Width = 150;
            // 
            // Description
            // 
            Description.DataPropertyName = "description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 291);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 336);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 3;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 427);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 382);
            label5.Name = "label5";
            label5.Size = new Size(146, 32);
            label5.TabIndex = 5;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(9, 151);
            label6.Name = "label6";
            label6.Size = new Size(85, 32);
            label6.TabIndex = 6;
            label6.Text = "Image";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(155, 291);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 39);
            txtName.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(155, 336);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(317, 39);
            txtTitle.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(155, 427);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(317, 39);
            txtPrice.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.Location = new Point(155, 382);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(317, 39);
            txtDescription.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLogout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1264, 41);
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
            // btnAddToCart
            // 
            btnAddToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddToCart.Location = new Point(155, 485);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(156, 44);
            btnAddToCart.TabIndex = 12;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCart.Location = new Point(318, 485);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(152, 44);
            btnViewCart.TabIndex = 13;
            btnViewCart.Text = "View cart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(155, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 243);
            label7.Name = "label7";
            label7.Size = new Size(40, 32);
            label7.TabIndex = 15;
            label7.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtID.Location = new Point(155, 243);
            txtID.Name = "txtID";
            txtID.Size = new Size(315, 39);
            txtID.TabIndex = 16;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 721);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnViewCart);
            Controls.Add(btnAddToCart);
            Controls.Add(toolStrip1);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvProduct);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvProduct;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private ToolStrip toolStrip1;
        private ToolStripButton btnLogout;
        private Button btnAddToCart;
        private Button btnViewCart;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private Label label7;
        private TextBox txtID;
    }
}