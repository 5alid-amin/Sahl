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
    public partial class ExpensesFRM : Form
    {
        public ExpensesFRM()
        {
            InitializeComponent();
            dgvReceipts.Rows.Add(new object[] { "صابون سائل", 527, "خميس"," 28/12/2004"});
            dgvReceipts.Rows.Add(new object[] { " اريال", 524, "خميس", " 28/12/2004" });
            dgvReceipts.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 527, "خميس", " 28/12/2004" });
            dgvReceipts.Rows.Add(new object[] { " دابر املا 100 دهبي", 524, "خميس", " 28/12/2004" });
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            ExpensesAddEdit FRM = new ExpensesAddEdit();


            //JUI
            FRM.Show();
        }

        private void dgvSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvReceipts.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvReceipts.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":

                        DialogFRM fRM = new DialogFRM("سيتم حذق هذا المصروف ويتم ارجاع الاموال الي الخزينه؟", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit":

                        ExpensesAddEdit FRM = new ExpensesAddEdit();


                        //JUI
                        FRM.Show();
                        break;
                    case "info":

                       ExpensesInfo FRm = new ExpensesInfo();


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
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvReceipts.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvReceipts.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;
                    case "returnd":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedd;
                        break;

                    case "info":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvSelling_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvReceipts.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvReceipts.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;
                    case "returnd":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedl;
                        break;

                    case "info":
                        dgvReceipts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion
    }
}
