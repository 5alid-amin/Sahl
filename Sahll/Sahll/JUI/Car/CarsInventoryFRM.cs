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
    public partial class CarsInventoryFRM : Form
    {
        public CarsInventoryFRM()
        {
            InitializeComponent();
            dgvinventory.Rows.Add(new object[] { "صابون سائل", 527, 2156 });
            dgvinventory.Rows.Add(new object[] { " اريال", 524, 2156 });
            dgvinventory.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 524, 2156 });
            dgvinventory.Rows.Add(new object[] { " دابر املا 100 دهبي", 524, 2156 });
        }

        #region ButtonsMethods
        private void btncar1_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar3_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void dgvinventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvinventory.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvinventory.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":

                        break;

                    case "edit":

                        break;

                    case "returnd":

                        break;

                    case "info":

                        break;
                }
            }
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

        private void dgvinventory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvinventory.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                Cursor = Cursors.Hand;
                string columnName = dgvinventory.Columns[e.ColumnIndex].Name;
                switch (columnName)
                {
                    case "delete":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;

                    case "returnd":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedd;
                        break;

                    case "info":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvinventory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvinventory.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvinventory.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;

                    case "returnd":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedl;
                        break;

                    case "info":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion

    }
}
