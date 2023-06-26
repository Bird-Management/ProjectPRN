namespace Bird_Management
{
    partial class UpdateFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFood));
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            dgvUpdateFood = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtFoodID = new TextBox();
            txtFoodName = new TextBox();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            txtPrice = new TextBox();
            txtAmount = new TextBox();
            cboProducer = new ComboBox();
            btnUpdate = new Button();
            chbOutOfStock = new CheckBox();
            chbStocking = new CheckBox();
            label10 = new Label();
            txtSearchFood = new TextBox();
            btnSearch = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(369, 30);
            label1.Name = "label1";
            label1.Size = new Size(262, 54);
            label1.TabIndex = 0;
            label1.Text = "Update Food";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1029, 41);
            toolStrip1.TabIndex = 1;
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
            // dgvUpdateFood
            // 
            dgvUpdateFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateFood.Location = new Point(485, 157);
            dgvUpdateFood.Name = "dgvUpdateFood";
            dgvUpdateFood.RowHeadersWidth = 62;
            dgvUpdateFood.RowTemplate.Height = 33;
            dgvUpdateFood.Size = new Size(532, 396);
            dgvUpdateFood.TabIndex = 2;
            dgvUpdateFood.CellDoubleClick += dgvUpdateFood_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 160);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 3;
            label2.Text = "Food ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 205);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 4;
            label3.Text = "Food name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 250);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 5;
            label4.Text = "MFG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 295);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 6;
            label5.Text = "EXP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 340);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 7;
            label6.Text = "Producer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 385);
            label7.Name = "label7";
            label7.Size = new Size(65, 32);
            label7.TabIndex = 8;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(21, 430);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 9;
            label8.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(21, 475);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 10;
            label9.Text = "Status";
            // 
            // txtFoodID
            // 
            txtFoodID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodID.Location = new Point(155, 157);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new Size(324, 39);
            txtFoodID.TabIndex = 11;
            // 
            // txtFoodName
            // 
            txtFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodName.Location = new Point(155, 202);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(324, 39);
            txtFoodName.TabIndex = 12;
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(155, 247);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(324, 39);
            txtStartDate.TabIndex = 13;
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(155, 292);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(324, 39);
            txtEndDate.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(155, 382);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(324, 39);
            txtPrice.TabIndex = 16;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(155, 427);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(324, 39);
            txtAmount.TabIndex = 17;
            // 
            // cboProducer
            // 
            cboProducer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboProducer.FormattingEnabled = true;
            cboProducer.Location = new Point(155, 336);
            cboProducer.Name = "cboProducer";
            cboProducer.Size = new Size(324, 40);
            cboProducer.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(155, 571);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 40);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // chbOutOfStock
            // 
            chbOutOfStock.AutoSize = true;
            chbOutOfStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbOutOfStock.Location = new Point(155, 475);
            chbOutOfStock.Name = "chbOutOfStock";
            chbOutOfStock.Size = new Size(171, 36);
            chbOutOfStock.TabIndex = 20;
            chbOutOfStock.Text = "Out of stock";
            chbOutOfStock.UseVisualStyleBackColor = true;
            // 
            // chbStocking
            // 
            chbStocking.AutoSize = true;
            chbStocking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbStocking.Location = new Point(155, 517);
            chbStocking.Name = "chbStocking";
            chbStocking.Size = new Size(131, 36);
            chbStocking.TabIndex = 21;
            chbStocking.Text = "Stocking";
            chbStocking.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(155, 102);
            label10.Name = "label10";
            label10.Size = new Size(85, 32);
            label10.TabIndex = 22;
            label10.Text = "Search";
            // 
            // txtSearchFood
            // 
            txtSearchFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchFood.Location = new Point(264, 97);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(462, 39);
            txtSearchFood.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(746, 97);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 39);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // UpdateFood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 620);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchFood);
            Controls.Add(label10);
            Controls.Add(chbStocking);
            Controls.Add(chbOutOfStock);
            Controls.Add(btnUpdate);
            Controls.Add(cboProducer);
            Controls.Add(txtAmount);
            Controls.Add(txtPrice);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvUpdateFood);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Name = "UpdateFood";
            Text = "UpdateFood";
            Load += UpdateFood_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private DataGridView dgvUpdateFood;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtFoodID;
        private TextBox txtFoodName;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private TextBox txtPrice;
        private TextBox txtAmount;
        private ComboBox cboProducer;
        private Button btnUpdate;
        private CheckBox chbOutOfStock;
        private CheckBox chbStocking;
        private Label label10;
        private TextBox txtSearchFood;
        private Button btnSearch;
    }
}