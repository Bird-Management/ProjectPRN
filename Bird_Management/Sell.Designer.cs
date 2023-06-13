namespace Bird_Management
{
    partial class Sell
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            label1 = new Label();
            dgvListProduct = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            productBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btLogout = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(296, 51);
            label1.Name = "label1";
            label1.Size = new Size(527, 46);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO SELL PAGE";
            // 
            // dgvListProduct
            // 
            dgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.Location = new Point(196, 115);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowHeadersWidth = 62;
            dgvListProduct.RowTemplate.Height = 33;
            dgvListProduct.Size = new Size(771, 225);
            dgvListProduct.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(53, 111);
            button1.Name = "button1";
            button1.Size = new Size(111, 57);
            button1.TabIndex = 2;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(53, 175);
            button2.Name = "button2";
            button2.Size = new Size(111, 55);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(53, 236);
            button3.Name = "button3";
            button3.Size = new Size(111, 48);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(53, 291);
            button4.Name = "button4";
            button4.Size = new Size(111, 58);
            button4.TabIndex = 5;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Respository.Models.Product);
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
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvListProduct);
            Controls.Add(label1);
            Name = "Sell";
            Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvListProduct;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private BindingSource productBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton btLogout;
    }
}