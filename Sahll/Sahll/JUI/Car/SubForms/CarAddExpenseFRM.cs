using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Car.SubForms
{
    public partial class CarAddExpenseFRM : Form
    {
        public CarAddExpenseFRM()
        {
            InitializeComponent();
            txtstatement.Focus();
        }

        private void CarAddExpenseFRM_Load(object sender, EventArgs e)
        {

        }

        private void khButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtprice.Focus();
            }
        }

        private void txtstatement_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
