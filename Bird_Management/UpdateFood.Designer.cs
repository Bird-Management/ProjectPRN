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
            dgvDeleteFood = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            btnUpdate = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(352, 30);
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
            toolStrip1.Size = new Size(909, 41);
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
            dgvDeleteFood.Location = new Point(413, 98);
            dgvDeleteFood.Name = "dgvDeleteFood";
            dgvDeleteFood.RowHeadersWidth = 62;
            dgvDeleteFood.RowTemplate.Height = 33;
            dgvDeleteFood.Size = new Size(484, 354);
            dgvDeleteFood.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 101);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 3;
            label2.Text = "Food ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 146);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 4;
            label3.Text = "Food name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 191);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 5;
            label4.Text = "MFG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 236);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 6;
            label5.Text = "EXP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 281);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 7;
            label6.Text = "Producer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 326);
            label7.Name = "label7";
            label7.Size = new Size(65, 32);
            label7.TabIndex = 8;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(21, 371);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 9;
            label8.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(21, 416);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 10;
            label9.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(155, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 39);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(155, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 39);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(155, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 39);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(155, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(252, 39);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(155, 413);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(252, 39);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(155, 323);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(252, 39);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(155, 368);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(252, 39);
            textBox7.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 40);
            comboBox1.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(155, 473);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 40);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdateFood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 579);
            Controls.Add(btnUpdate);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDeleteFood);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Name = "UpdateFood";
            Text = "UpdateFood";
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Button btnUpdate;
    }
}