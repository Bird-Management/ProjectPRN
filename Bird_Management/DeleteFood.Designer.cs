namespace Bird_Management
{
    partial class DeleteFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFood));
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            dgvDeleteFood = new DataGridView();
            btnDeleteFood = new Button();
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
            txtProducer = new TextBox();
            txtAmount = new TextBox();
            txtPrice = new TextBox();
            txtStatus = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(475, 41);
            label1.Name = "label1";
            label1.Size = new Size(246, 54);
            label1.TabIndex = 0;
            label1.Text = "Delete Food";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1219, 41);
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
            // dgvDeleteFood
            // 
            dgvDeleteFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteFood.Location = new Point(492, 109);
            dgvDeleteFood.Name = "dgvDeleteFood";
            dgvDeleteFood.RowHeadersWidth = 62;
            dgvDeleteFood.RowTemplate.Height = 33;
            dgvDeleteFood.Size = new Size(715, 354);
            dgvDeleteFood.TabIndex = 2;
            dgvDeleteFood.CellDoubleClick += dgvDeleteFood_CellDoubleClick;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.Location = new Point(157, 469);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(191, 43);
            btnDeleteFood.TabIndex = 3;
            btnDeleteFood.Text = "Delete Food";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 4;
            label2.Text = "Food ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 5;
            label3.Text = "Food Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 202);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 6;
            label4.Text = "MFG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 247);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 7;
            label5.Text = "EXP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 292);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 8;
            label6.Text = "Producer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 337);
            label7.Name = "label7";
            label7.Size = new Size(100, 32);
            label7.TabIndex = 9;
            label7.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 382);
            label8.Name = "label8";
            label8.Size = new Size(65, 32);
            label8.TabIndex = 10;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 427);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 11;
            label9.Text = "Status";
            // 
            // txtFoodID
            // 
            txtFoodID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodID.Location = new Point(157, 109);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new Size(329, 39);
            txtFoodID.TabIndex = 12;
            // 
            // txtFoodName
            // 
            txtFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodName.Location = new Point(157, 154);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(329, 39);
            txtFoodName.TabIndex = 13;
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(157, 199);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(329, 39);
            txtStartDate.TabIndex = 14;
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(157, 244);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(329, 39);
            txtEndDate.TabIndex = 15;
            // 
            // txtProducer
            // 
            txtProducer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducer.Location = new Point(157, 289);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new Size(329, 39);
            txtProducer.TabIndex = 16;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(157, 334);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(329, 39);
            txtAmount.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(157, 379);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(329, 39);
            txtPrice.TabIndex = 18;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(157, 424);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(329, 39);
            txtStatus.TabIndex = 19;
            // 
            // DeleteFood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 590);
            Controls.Add(txtStatus);
            Controls.Add(txtPrice);
            Controls.Add(txtAmount);
            Controls.Add(txtProducer);
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
            Controls.Add(btnDeleteFood);
            Controls.Add(dgvDeleteFood);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Name = "DeleteFood";
            Text = "DeleteFood";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private DataGridView dgvDeleteFood;
        private Button btnDeleteFood;
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
        private TextBox txtProducer;
        private TextBox txtAmount;
        private TextBox txtPrice;
        private TextBox txtStatus;
    }
}