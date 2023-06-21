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
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            btnUpdate = new Button();
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
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(314, 31);
            label1.Name = "label1";
            label1.Size = new Size(289, 54);
            label1.TabIndex = 0;
            label1.Text = "Add new Food";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 2;
            label3.Text = "Food Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(477, 103);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(174, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 39);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(596, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 39);
            textBox4.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(174, 371);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 51);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(477, 148);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 12;
            label6.Text = "Amount";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(596, 145);
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
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 1;
            label2.Text = "Food ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(174, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 39);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 206);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 19;
            label4.Text = "Start";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 253);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 20;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 299);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 21;
            label9.Text = "label9";
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 664);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(checkedListBox1);
            Controls.Add(toolStrip1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "ViewCart";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button btnUpdate;
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
        private Label label4;
        private Label label8;
        private Label label9;
    }
}