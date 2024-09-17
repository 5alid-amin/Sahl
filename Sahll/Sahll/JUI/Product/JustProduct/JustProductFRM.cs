using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.PL;
using Sahll.JUI.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Selling
{
    public partial class JustProductFRM : Form
    {
        public JustProductFRM()
        {
            InitializeComponent();
            dgvJustProduct.Rows.Add(new object[] { "صابون سائل", 527, 2156, 2156});
            dgvJustProduct.Rows.Add(new object[] { " اريال", 524, 2156, 215 });
            dgvJustProduct.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 524, 2156, 2156 });
            dgvJustProduct.Rows.Add(new object[] { " دابر املا 100 دهبي", 524, 2156, 2156 });
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            JustProductAddEditFRM FRM = new JustProductAddEditFRM();

            //JUI
            FRM.Show();
        }

        private void dgvSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvJustProduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvJustProduct.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "edit":
                         StoreAddEditFRM FRM = new StoreAddEditFRM();


                        //JUI
                        FRM.Show();
                        break;
                }
            }
        }

        #endregion

        #region JUI
        private void dgvSelling_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvJustProduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvJustProduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "edit":
                        dgvJustProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;
                }
            }
        }

        private void dgvSelling_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvJustProduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvJustProduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "edit":
                        dgvJustProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;
                }
            }
        }
        #endregion
    }
}
