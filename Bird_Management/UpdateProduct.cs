using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Management
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Sell Page?", "BirdShop",
               MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
<<<<<<< HEAD
                Form form = new Sell();
=======
                Form form = new Seller();
>>>>>>> 1062abc77efa1e2dd0233f09b1315691e0f0ae58
                form.Show();
            }
        }
    }
}
