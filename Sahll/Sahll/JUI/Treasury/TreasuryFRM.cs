using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Treasury
{
    public partial class TreasuryFRM : Form
    {
        private Main main;
        bool IsToday = false;

        public TreasuryFRM(Main main)
        {
            InitializeComponent();
            this.main = main;
        }



        #region ButtonsMethods
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IsToday = !IsToday;

            //JUI
            pictureBox1.Image = IsToday ? Properties.Resources.todayd : Properties.Resources.todayl;
        }
        private void btnReceipts_Click(object sender, EventArgs e)
        {
            main.ShowReceipts();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            main.ShowExpenses();
        }

        #endregion

        #region JUI
        private void pnltreasury_Resize(object sender, EventArgs e)
        {
            var containerWidth = pnltreasury.Width;
            khPanel1.Size = new Size(containerWidth / 2, 534);
            khPanel2.Size = new Size(containerWidth / 2, 534);
            khPanel1.Location = new Point(0, 72);
            khPanel2.Location = new Point(khPanel1.Width, 72);

            btnaminhome.Size = btnExpenses.Size = btnReceipts.Size = new Size(
               (containerWidth - (containerWidth / 2) + 6) / 3, 88);
            btnaminhome.Location = new Point(0, btnaminhome.Location.Y);
            btnExpenses.Location = new Point(btnaminhome.Width + 1, btnExpenses.Location.Y);
            btnReceipts.Location = new Point(btnaminhome.Width*2 + 2, btnReceipts.Location.Y);
        }
        #endregion

        private void pnltreasury_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaminhome_Clic(object sender, EventArgs e)
        {
            main.ShowAminHome();
        }
    }
}
