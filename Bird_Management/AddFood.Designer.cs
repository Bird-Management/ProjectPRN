namespace Bird_Management
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtFoodName = new TextBox();
            txtPrice = new TextBox();
            btnAddFood = new Button();
            label6 = new Label();
            txtAmount = new TextBox();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            label2 = new Label();
            txtFoodID = new TextBox();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            cboProducer = new ComboBox();
            label7 = new Label();
            chbOutOfStock = new CheckBox();
            chbStoking = new CheckBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(280, 32);
            label1.Name = "label1";
            label1.Size = new Size(289, 54);
            label1.TabIndex = 0;
            label1.Text = "Add new Food";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(137, 153);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 2;
            label3.Text = "Food Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(137, 333);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // txtFoodName
            // 
            txtFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFoodName.Location = new Point(280, 150);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(435, 39);
            txtFoodName.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(280, 330);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(435, 39);
            txtPrice.TabIndex = 9;
            // 
            // btnAddFood
            // 
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(280, 521);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(179, 51);
            btnAddFood.TabIndex = 10;
            btnAddFood.Text = "Add food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(137, 378);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 12;
            label6.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmount.Location = new Point(280, 375);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(435, 39);
            txtAmount.TabIndex = 13;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(806, 41);
            toolStrip1.TabIndex = 14;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(137, 108);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 1;
            label2.Text = "Food ID";
            // 
            // txtFoodID
            // 
            txtFoodID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFoodID.Location = new Point(280, 105);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new Size(435, 39);
            txtFoodID.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 198);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 19;
            label4.Text = "MFG";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(135, 243);
            label8.Name = "label8";
            label8.Size = new Size(53, 32);
            label8.TabIndex = 20;
            label8.Text = "EXP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(137, 285);
            label9.Name = "label9";
            label9.Size = new Size(109, 32);
            label9.TabIndex = 21;
            label9.Text = "Producer";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(280, 195);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(435, 39);
            txtStartDate.TabIndex = 22;
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(280, 240);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(435, 39);
            txtEndDate.TabIndex = 23;
            // 
            // cboProducer
            // 
            cboProducer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboProducer.FormattingEnabled = true;
            cboProducer.Location = new Point(280, 285);
            cboProducer.Name = "cboProducer";
            cboProducer.Size = new Size(435, 40);
            cboProducer.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(137, 424);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 25;
            label7.Text = "Status";
            // 
            // chbOutOfStock
            // 
            chbOutOfStock.AutoSize = true;
            chbOutOfStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbOutOfStock.Location = new Point(280, 424);
            chbOutOfStock.Name = "chbOutOfStock";
            chbOutOfStock.Size = new Size(171, 36);
            chbOutOfStock.TabIndex = 26;
            chbOutOfStock.Text = "Out of stock";
            chbOutOfStock.UseVisualStyleBackColor = true;
            // 
            // chbStoking
            // 
            chbStoking.AutoSize = true;
            chbStoking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbStoking.Location = new Point(280, 466);
            chbStoking.Name = "chbStoking";
            chbStoking.Size = new Size(131, 36);
            chbStoking.TabIndex = 27;
            chbStoking.Text = "Stocking";
            chbStoking.UseVisualStyleBackColor = true;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 584);
            Controls.Add(chbStoking);
            Controls.Add(chbOutOfStock);
            Controls.Add(label7);
            Controls.Add(cboProducer);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(toolStrip1);
            Controls.Add(txtAmount);
            Controls.Add(label6);
            Controls.Add(btnAddFood);
            Controls.Add(txtPrice);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodID);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "ViewCart";
            Load += AddFood_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox txtFoodName;
        private TextBox txtPrice;
        private Button btnAddFood;
        private Label label6;
        private TextBox txtAmount;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private Label label2;
        private TextBox txtFoodID;
        private Label label4;
        private Label label8;
        private Label label9;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private ComboBox cboProducer;
        private Label label7;
        private CheckBox chbOutOfStock;
        private CheckBox chbStoking;
    }
}