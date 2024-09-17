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
    public partial class ManufacturingFRM : Form
    {
        public ManufacturingFRM()
        {
            InitializeComponent();
            dgvStore.Rows.Add(new object[] { "صابون سائل", 527, 2156, 2156, 2156 });
            dgvStore.Rows.Add(new object[] { " اريال", 524, 2156, 2156, 2156});
            dgvStore.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 524, 2156, 2156, 2156});
            dgvStore.Rows.Add(new object[] { " دابر املا 100 دهبي", 524, 2156, 2156, 2156 });
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            ManufacturingAddEditFRM FRM = new ManufacturingAddEditFRM();


            //JUI
            FRM.Show();
        }

        private void dgvSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvStore.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvStore.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "edit":
                        ManufacturingAddEditFRM FRM = new ManufacturingAddEditFRM();


                        //JUI
                        FRM.Show();
                        break;
                    case "info":
                        ManufacturingInfoFRM FRm = new ManufacturingInfoFRM();


                        //JUI
                        FRm.Show();
                        break;
                }
            }
        }

        #endregion

        #region JUI
        private void dgvSelling_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvStore.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvStore.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;

                    case "info":
                        dgvStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvSelling_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvStore.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvStore.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete":
                        dgvStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;

                    case "info":
                        dgvStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion
    }
}
