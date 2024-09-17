using Sahll.JUI.Car.InfoForms;
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
    public partial class CarsSoldProducts : Form
    {
        public CarsSoldProducts()
        {
            InitializeComponent();
            dgvcarsoldproduct.Rows.Add(new object[] { "صابون سائل", 26345, 23156 });
            dgvcarsoldproduct.Rows.Add(new object[] { " اريال", 26345, 2156 });
            dgvcarsoldproduct.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 26345, 2156 });
            dgvcarsoldproduct.Rows.Add(new object[] { " دابر املا 100 دهبي", 26345, 2156 });
        }


        #region ButtonsMethods
        private void btncar1_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as Button);
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as Button);
        }

        private void btncar3_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as Button);
        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as Button);
        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as Button);
        }

        private void dgvcarsoldproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarsoldproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarsoldproduct.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "info":
                        //JUI
                        InfoForms.CarInfoProduct IFRM = new InfoForms.CarInfoProduct();
                        IFRM.Show();
                        break;
                }
            }
        }
        #endregion

        #region JUI
        private void dgvcarsoldproduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarsoldproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarsoldproduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "info":
                        dgvcarsoldproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvcarsoldproduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarsoldproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarsoldproduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "info":
                        dgvcarsoldproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }

        private void SetButtonActive(Button clickedButton)
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
        #endregion

        private void pnlcarsoldproduct_Resize(object sender, EventArgs e)
        {
            int buttonWidth = (pnlcarsoldproduct.Size.Width) / 5;
            btncar5.Size = new Size(buttonWidth, 41);
            btncar4.Size = new Size(buttonWidth, 40);
            btncar3.Size = new Size(buttonWidth, 40);
            btncar2.Size = new Size(buttonWidth, 40);
            btncar1.Size = new Size(buttonWidth, 41);


            btncar5.Location = new Point(15, 73);
            btncar4.Location = new Point(btncar5.Width - 8, 74);
            btncar3.Location = new Point(btncar5.Width * 2 - 9, 74);
            btncar2.Location = new Point(btncar5.Width * 3 - 10, 74);
            btncar1.Location = new Point(btncar5.Width * 4 - 18, 73);
        }
    }
}
