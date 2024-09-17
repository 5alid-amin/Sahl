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

namespace Sahll.JUI.Car
{
    public partial class CarsProductsFRM : Form
    {
        public CarsProductsFRM()
        {
            InitializeComponent();
            dgvcarproduct.Rows.Add(new object[] { "صابون سائل", 527, 2156, "الخميس" });
            dgvcarproduct.Rows.Add(new object[] { " اريال", 524, 2156, "الخميس" });
            dgvcarproduct.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 524, 2156, "الخميس" });
            dgvcarproduct.Rows.Add(new object[] { " دابر املا 100 دهبي", 524, 2156, "الخميس" });
        }

        #region ButtonsMethods
        private void btncar1_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar3_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
        }

        private void dgvcarproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarproduct.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":

                        DialogFRM fRM = new DialogFRM("هل انت متأكد من حذف هذا الصنف المورد؟", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit":


                        //JUI
                        CarsAddEditProductsEnventoryFRM frm = new CarsAddEditProductsEnventoryFRM();
                        frm.Show();
                        break;
                    case "returnd":


                        //JUI
                        CarReturnedProduct rFRM = new CarReturnedProduct();
                        rFRM.Show();
                        break;
                    case "info":

                        //JUI
                        InfoForms.CarInfoProduct IFRM = new InfoForms.CarInfoProduct();
                        IFRM.Show();
                        break;
                }
            }
        }

        #endregion

        #region JUI
        private void SetButtonActive(System.Windows.Forms.Button clickedButton)
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

        private void dgvcarproduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarproduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;
                    case "returnd":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedd;
                        break;

                    case "info":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvcarproduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarproduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;
                    case "returnd":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedl;
                        break;

                    case "info":
                        dgvcarproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion


        private void btnaddinventory_Click(object sender, EventArgs e)
        {


            //JUI
            CarsAddEditProductsEnventoryFRM FRM = new CarsAddEditProductsEnventoryFRM();
            FRM.Show();
        }

        private void pnlcarproduct_Resize(object sender, EventArgs e)
        {
            int buttonWidth = (pnlcarproduct.Size.Width) / 5;
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
