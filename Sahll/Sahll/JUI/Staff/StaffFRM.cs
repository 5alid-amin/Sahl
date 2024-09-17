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
    public partial class StaffFRM : Form
    {
        private Main main;
        public StaffFRM(Main main)
        {
            InitializeComponent();
            dgvSelling.Rows.Add(new object[] { "محمود محمد خيري", 01271948553, 30412283200133 });
            dgvSelling.Rows.Add(new object[] { "صالح طالح سامح", 01271948553, 30412283200133 });
            dgvSelling.Rows.Add(new object[] { "علي محمد علي محمد", 01271948553, 30412283200133 });
            dgvSelling.Rows.Add(new object[] { "اخر واحد خلاص الحمدلله", 01271948553, 30412283200133 });
            this.main = main;
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            StaffAddEditFRM FRM = new StaffAddEditFRM();


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
                    case "delete":

                        DialogFRM fRM = new DialogFRM("سيتم حذف هذا العامل من النظام وتصفية حسابه من الخزينه؟", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit":

                        StaffAddEditFRM FRM = new StaffAddEditFRM();


                        //JUI
                        FRM.Show();
                        break;
                    case "account":

                        main.ShowStaffAccounts();
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
                    case "delete":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;
                    case "account":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.accountd;
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
                    case "delete":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;
                    case "account":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.accountl;
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

        private void dgvSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
