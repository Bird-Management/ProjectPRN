﻿namespace Bird_Management
{
    partial class ViewCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCart));
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            dgvListCart = new DataGridView();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            checkedListBox1 = new CheckedListBox();
            label7 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            btnNewOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListCart).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(349, 31);
            label1.Name = "label1";
            label1.Size = new Size(201, 54);
            label1.TabIndex = 0;
            label1.Text = "Your Cart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 392);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 440);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // dgvListCart
            // 
            dgvListCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListCart.Location = new Point(42, 88);
            dgvListCart.Name = "dgvListCart";
            dgvListCart.RowHeadersWidth = 62;
            dgvListCart.RowTemplate.Height = 33;
            dgvListCart.Size = new Size(837, 253);
            dgvListCart.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(192, 392);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 39);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(192, 440);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 39);
            textBox4.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(193, 550);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 51);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(314, 550);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 51);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 491);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 12;
            label6.Text = "Amount";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(192, 491);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 39);
            textBox5.TabIndex = 13;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(903, 41);
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
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(577, 347);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(302, 88);
            checkedListBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(577, 449);
            label7.Name = "label7";
            label7.Size = new Size(70, 32);
            label7.TabIndex = 16;
            label7.Text = "Total";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(653, 446);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 39);
            textBox6.TabIndex = 17;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(653, 491);
            button1.Name = "button1";
            button1.Size = new Size(125, 45);
            button1.TabIndex = 18;
            button1.Text = "Payment";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 347);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 1;
            label2.Text = "ProductID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(193, 347);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 39);
            textBox1.TabIndex = 6;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewOrder.Location = new Point(193, 607);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(231, 44);
            btnNewOrder.TabIndex = 19;
            btnNewOrder.Text = "New Order";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // ViewCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 664);
            Controls.Add(btnNewOrder);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(checkedListBox1);
            Controls.Add(toolStrip1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dgvListCart);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewCart";
            Text = "ViewCart";
            ((System.ComponentModel.ISupportInitialize)dgvListCart).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private DataGridView dgvListCart;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label6;
        private TextBox textBox5;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private CheckedListBox checkedListBox1;
        private Label label7;
        private TextBox textBox6;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Button btnNewOrder;
    }
}