﻿namespace Bird_Management
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            dgvListAccount = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            toolStrip1 = new ToolStrip();
            btLogout = new ToolStripButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListAccount
            // 
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgvListAccount.Location = new Point(109, 145);
=======
            dgvListAccount.Location = new Point(87, 152);
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
            dgvListAccount.Margin = new Padding(2);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.RowHeadersWidth = 62;
            dgvListAccount.RowTemplate.Height = 33;
            dgvListAccount.Size = new Size(634, 206);
            dgvListAccount.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btnCreate.Location = new Point(107, 429);
=======
            btnCreate.Location = new Point(110, 372);
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(159, 50);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btnUpdate.Location = new Point(318, 429);
=======
            btnUpdate.Location = new Point(322, 372);
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 50);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            btnDelete.Location = new Point(530, 431);
=======
            btnDelete.Location = new Point(530, 372);
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btLogout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(780, 35);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // btLogout
            // 
            btLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btLogout.Image = (Image)resources.GetObject("btLogout.Image");
            btLogout.ImageTransparentColor = Color.Magenta;
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(106, 32);
            btLogout.Text = "Logout";
            btLogout.Click += btLogout_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(214, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(541, 54);
=======
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(463, 46);
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
            label1.TabIndex = 19;
            label1.Text = "WELCOME TO ADMIN PAGE";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 468);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvListAccount);
            Margin = new Padding(2);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListAccount;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private ToolStrip toolStrip1;
        private ToolStripButton btLogout;
        private Label label1;
    }
}