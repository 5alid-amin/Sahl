using Sahll.JUI.PL;

namespace Sahll.JUI.Selling
{
    public partial class SellingAddEditFRM : Form
    {
        public SellingAddEditFRM()
        {
            InitializeComponent();
        }


        #region ButtonsMethods
        private void dgvcarcash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvAddSellingProces.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvAddSellingProces.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":
                        //JUI
                        DialogFRM fRM = new DialogFRM("هل انت متأكد من حذف هذا المنتج ", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;
                }
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region JUI
        private void dgvcarcash_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvAddSellingProces.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvAddSellingProces.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvAddSellingProces.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;
                }
            }
        }

        private void dgvcarcash_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvAddSellingProces.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvAddSellingProces.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvAddSellingProces.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;
                }
            }
        }
        #endregion



    }
}
