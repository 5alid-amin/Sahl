using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.PL;
using Sahll.JUI.Store;
using Sahll.JUI.User;
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
    public partial class UserFRM : Form
    {
        public UserFRM()
        {
            InitializeComponent();
            dgvUser.Rows.Add(new object[] { "امين محمود سنوسي حسونه", "مدير"});
            dgvUser.Rows.Add(new object[] { "امين محمود سنوسي حسونه", "مستخدم"});
            }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            UserAddEditFRM FRM = new UserAddEditFRM();


            //JUI
            FRM.Show();
        }

        private void dgvSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvUser.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":

                        DialogFRM fRM = new DialogFRM("سيتم حذف حساب هذا المستخدم بحيث لا يكون قادرا علي التعامل مع البرنامج بأسمه مجددا", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit":
                        UserConfermationFRM FRM = new UserConfermationFRM();


                        //JUI
                        FRM.Show();
                        break;
                    case "info":
                        UserConfermationFRM FRm = new UserConfermationFRM();


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
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvUser.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;

                    case "info":
                        dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvSelling_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvUser.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete":
                        dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;

                    case "info":
                        dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion

        private void dgvStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
