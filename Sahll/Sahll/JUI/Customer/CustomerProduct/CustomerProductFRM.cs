using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.Customer.CustomerProduct;
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
    public partial class CustomerProductFRM : Form
    {
        public CustomerProductFRM()
        {
            InitializeComponent();
            dgvSelling.Rows.Add(new object[] { "صابون سائل", 527, 2156, 2156, "الخميس" });
            dgvSelling.Rows.Add(new object[] { " اريال", 524, 2156, 2156, "الخميس" });
            dgvSelling.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 524, 2156, 2156, "الخميس" });
            dgvSelling.Rows.Add(new object[] { " دابر املا 100 دهبي", 524, 2156, 2156, "الخميس" });
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            CustomerProductAddEditFRM FRM = new CustomerProductAddEditFRM();


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

                        DialogFRM fRM = new DialogFRM("سيتم ارجاع هذه الكميه من الصنف الي المخزن؟", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit":

                        CustomerProductAddEditFRM FRM = new CustomerProductAddEditFRM();


                        //JUI
                        FRM.Show();
                        break;
                    case "returnd":


                        SellingReturnFRM Frm = new SellingReturnFRM();


                        //JUI
                        Frm.Show();
                        break;
                    case "info":

                        CustomerProductInfoFRM FRm = new CustomerProductInfoFRM();


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
                    case "returnd":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedd;
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
                    case "delete":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;
                    case "returnd":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedl;
                        break;

                    case "info":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion

        private void dgvSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
