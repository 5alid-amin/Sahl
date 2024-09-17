using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.PL
{
    public partial class DialogFRM : Form
    {
        public DialogFRM(string txt, Color seccolor)
        {
            InitializeComponent();
            this.txtdialog.Text = txt;
            this.khPanel1.GradientTopColor = seccolor;
            //this.khPanel1.GradientBottomColor = Color.FromArgb(83, 4, 128);
            Color move = Color.FromArgb(83, 4, 128);
            Color red = Color.FromArgb(64, 0, 0);

            //button_on_hover();
        }



        private void btnconferm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnconferm_MouseEnter(object sender, EventArgs e)
        {
            btnconferm.Image = Properties.Resources.confermd;
        }

        private void btnconferm_MouseLeave(object sender, EventArgs e)
        {
            btnconferm.Image = Properties.Resources.conferml;
        }

        private void btncancel_MouseEnter(object sender, EventArgs e)
        {
            btncancel.Image = Properties.Resources.canceld;
        }

        private void btncancel_MouseLeave(object sender, EventArgs e)
        {
            btncancel.Image = Properties.Resources.cancell1;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
