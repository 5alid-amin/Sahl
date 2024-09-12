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
    public partial class CarsRecordsFRM : Form
    {
        public CarsRecordsFRM()
        {
            InitializeComponent();
            dgvsoldproducts.Rows.Add(new object[] { "صابون سائل" });
            dgvinventory.Rows.Add(new object[] { "صابون سائل" });
            dgvcashtotal.Rows.Add(new object[] { "صابون سائل" });
            dgvDispatchedpro.Rows.Add(new object[] { "صابون سائل" });

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

        private void dgvsoldproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvsoldproducts.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvsoldproducts.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "info":
                        break;
                }
            }
        }
        private void dgvDispatchedpro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvDispatchedpro.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvDispatchedpro.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "info":
                        break;
                }
            }
        }
        private void dgvinventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvinventory.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvinventory.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "info":
                        break;
                }
            }
        }
        private void dgvcashtotal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcashtotal.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcashtotal.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "info":
                        break;
                }
            }
        }
        #endregion

        #region JUI
        private void dgvsoldproducts_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvsoldproducts.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvsoldproducts.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "info":
                        dgvsoldproducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }
        private void dgvsoldproducts_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvsoldproducts.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvsoldproducts.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "info":
                        dgvsoldproducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }

       

        private void dgvDispatchedpro_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvDispatchedpro.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvDispatchedpro.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "infor":
                        dgvDispatchedpro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }
        private void dgvDispatchedpro_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvDispatchedpro.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvDispatchedpro.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "infor":
                        dgvDispatchedpro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }



        private void dgvinventory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvinventory.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvinventory.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "inform":
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
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "inform":
                        dgvinventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }



        private void dgvcashtotal_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcashtotal.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcashtotal.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "information":
                        dgvcashtotal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }
        private void dgvcashtotal_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcashtotal.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcashtotal.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "information":
                        dgvcashtotal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
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
    }
}
