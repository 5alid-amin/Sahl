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

namespace Sahll.JUI.Customer.CustomerProduct
{
    public partial class CustomerProductAddEditFRM : Form
    {
        public CustomerProductAddEditFRM()
        {
            InitializeComponent();
            dgvAddCustomerProduct.Rows.Add(new object[] { "صابون سائل", 527, 2156, 2156 });
            dgvAddCustomerProduct.Rows.Add(new object[] { "صابون سائل", 527, 2156, 2156 });
            dgvAddCustomerProduct.Rows.Add(new object[] { "صابون سائل", 527, 2156, 2156 });
        }

        #region ButtonsMethods

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvAddCustomerProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvAddCustomerProduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvAddCustomerProduct.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":

                        DialogFRM fRM = new DialogFRM("سيتم ارجاع هذه الكميه من الصنف الي المخزن؟", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region JUI
        private void dgvAddCustomerProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvAddCustomerProduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvAddCustomerProduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvAddCustomerProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;
                }
            }
        }

        private void dgvAddCustomerProduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvAddCustomerProduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvAddCustomerProduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvAddCustomerProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;
                }
            }
        }
        #endregion
    }
}
