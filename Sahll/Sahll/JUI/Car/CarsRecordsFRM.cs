using Sahll.JUI.Car.InfoForms;
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




                        //JUI
                        InfoForms.CarInfoProduct IFRM = new InfoForms.CarInfoProduct();
                        IFRM.Show();
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
                    case "infor":
                        //JUI
                        InfoForms.CarInfoProduct IFRM = new InfoForms.CarInfoProduct();
                        IFRM.Show();
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
                    case "inform":



                        //JUI
                        InfoForms.CarInfoProduct IFRM = new InfoForms.CarInfoProduct();
                        IFRM.Show();
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
                    case "information":


                        //JUI
                        CarsInfoCashFRM IFRM = new CarsInfoCashFRM();
                        IFRM.Show();
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

        private void pnlcarrecords_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void pnlcarrecords_Resize(object sender, EventArgs e)
        {
            int buttonWidth = (pnlcarrecords.Size.Width) / 5;
            btncar5.Size = new Size(buttonWidth, 41);
            btncar4.Size = new Size(buttonWidth, 40);
            btncar3.Size = new Size(buttonWidth, 40);
            btncar2.Size = new Size(buttonWidth, 40);
            btncar1.Size = new Size(buttonWidth, 41);


            btncar5.Location = new Point(15, 73);
            btncar4.Location = new Point(btncar5.Width - 8, 74);
            btncar3.Location = new Point(btncar5.Width * 2 - 9, 74);
            btncar2.Location = new Point(btncar5.Width * 3 - 10, 74);
            btncar1.Location = new Point(btncar5.Width * 4 - 18, 73);
        }
    }
}
