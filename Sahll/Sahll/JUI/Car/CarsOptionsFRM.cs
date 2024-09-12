using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Car
{
    public partial class CarsOptionsFRM : Form
    {
        private Main main;

        public CarsOptionsFRM(Main mainForm)
        {
            InitializeComponent();
            main = mainForm;
        }

        #region ButtonsMethods
        private void btncar1_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar2_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar3_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar4_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar5_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }
        #endregion

        #region JUI
        private void SetButtonActive(System.Windows.Forms.Button clickedButton)
        {
            btncar1.BackColor = Color.Transparent;
            btncar2.BackColor = Color.Transparent;
            btncar3.BackColor = Color.Transparent;
            btncar4.BackColor = Color.Transparent;
            btncar5.BackColor = Color.Transparent;

            btncar1.ForeColor = Color.FromArgb(63, 36, 114);
            btncar2.ForeColor = Color.FromArgb(63, 36, 114);
            btncar3.ForeColor = Color.FromArgb(63, 36, 114);
            btncar4.ForeColor = Color.FromArgb(63, 36, 114);
            btncar5.ForeColor = Color.FromArgb(63, 36, 114);

            clickedButton.BackColor = Color.FromArgb(203, 150, 233);
            clickedButton.ForeColor = Color.White;

        }

        private void btnproducts_Click(object sender, EventArgs e)
        {

            main.ShowProducts();
        }

        private void btntresury_Click(object sender, EventArgs e)
        {
            main.ShowInventory();
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            main.ShowCash();
        }

        private void btns_Click(object sender, EventArgs e)
        {
            main.ShowSoldQuantity();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            main.ShowStaff();
        }

        private void btnrecords_Click(object sender, EventArgs e)
        {
            main.ShowCarsRecords();
        }
        #endregion

        private void pnlcarsoptions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
