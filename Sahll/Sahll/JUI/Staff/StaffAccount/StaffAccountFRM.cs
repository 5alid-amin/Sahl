using Sahll.JUI.Car;
using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.PL;
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
    public partial class StaffAccountFRM : Form
    {
        private Main main;
        public StaffAccountFRM()
        {
            InitializeComponent();
            dgvSelling.Rows.Add(new object[] { "28/12/2004", "الثلاثاء", 15325, 15325, 15325, 15325, 15325, 15325, 15325 });
            dgvSelling.Rows.Add(new object[] { "28/12/2004", "الثلاثاء", 15325, 15325, 15325, 15325, 15325, 15325, 15325 });
            dgvSelling.Rows.Add(new object[] { "28/12/2004", "الثلاثاء", 15325, 15325, 15325, 15325, 15325, 15325, 15325 });
            dgvSelling.Rows.Add(new object[] { "28/12/2004", "الثلاثاء", 15325, 15325, 15325, 15325, 15325, 15325, 15325 });
            dgvSelling.Rows.Add(new object[] { "28/12/2004", "الثلاثاء", 15325, 15325, 15325, 15325, 15325, 15325, 15325 });


            this.main = main;
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            CustomerAdditionOptionsFRM FRM = new CustomerAdditionOptionsFRM();


            //JUI
            FRM.Show();
        }

        private void dgvSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSelling.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvSelling.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "bouns":

                       StaffAddEditBounsFRM frm = new StaffAddEditBounsFRM();
                        frm.Show();
                        break;

                    case "rival":

                        StaffAddEditRivalFRM FRM = new StaffAddEditRivalFRM();


                        //JUI
                        FRM.Show();
                        break;
                    case "info":

                       StaffAccountInfoFRM fRm = new StaffAccountInfoFRM();
                        fRm.Show();
                        break;
                }
            }
        }

        #endregion

        #region JUI
        private void dgvSelling_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSelling.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvSelling.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "bouns":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.bonusd;
                        break;

                    case "rival":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.rivald;
                        break;
                    case "info":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvSelling_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSelling.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvSelling.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "bouns":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.bonus;
                        break;

                    case "rival":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.rival;
                        break;
                    case "info":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pnlselling_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
