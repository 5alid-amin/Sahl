using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.PL;
using Sahll.JUI.Selling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Treasury
{
    public partial class AminHomeFRM : Form
    {
        private Main main;
        bool IsToday = false;

        public AminHomeFRM()
        {
            InitializeComponent();
            dgvwithdraw.Rows.Add(new object[] { "الخميس", 26345 });
            dgvwithdraw.Rows.Add(new object[] { "الخميس", 26345 });
            dgvwithdraw.Rows.Add(new object[] { "الخميس", 26345 });
            dgvwithdraw.Rows.Add(new object[] { "الخميس", 26345 });
            dgvdeposit.Rows.Add(new object[] { "الخميس", 26345 });
            dgvdeposit.Rows.Add(new object[] { "الخميس", 26345 });
            dgvdeposit.Rows.Add(new object[] { "الخميس", 26345 });
            dgvdeposit.Rows.Add(new object[] { "الخميس", 26345 });
        }



        #region ButtonsMethods
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IsToday = !IsToday;

            //JUI
            pictureBox1.Image = IsToday ? Properties.Resources.todayd : Properties.Resources.todayl;
        }
        private void btnReceipts_Click(object sender, EventArgs e)
        {
            main.ShowReceipts();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            main.ShowExpenses();
        }

        #endregion

        #region JUI
        private void pnltreasury_Resize(object sender, EventArgs e)
        {
            var containerWidth = pnlaminhome.Width;
            khPanel1.Size = new Size(containerWidth / 2, 534);
            khPanel2.Size = new Size(containerWidth / 2, 534);
            khPanel2.Location = new Point(0, 108);
            khPanel1.Location = new Point(khPanel1.Width, 108);

            btnadd.Location = new Point((pnlaminhome.Width / 2) - (btnadd.Width / 2),653); 
            
        }
        #endregion



        private void dgvwithdraw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvwithdraw.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvwithdraw.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":

                        DialogFRM fRM = new DialogFRM("سوف يتم حذف هذا السحب وترجع هذه النقديه الي الخزينه؟", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit":


                        //JUI
                        AminHAddEditWithdrawFRM frm = new AminHAddEditWithdrawFRM();
                        frm.Show();
                        break;
                    case "info":

                        //JUI
                        AminHomeInfoFRM IFRM = new AminHomeInfoFRM();
                        IFRM.Show();
                        break;
                }
            }
        }
        private void dgvdeposit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvdeposit.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvdeposit.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete2":

                        DialogFRM fRM = new DialogFRM("سوف يتم حذف هذا الإيداع وتسلب هذه النقديه من الخزينه", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit2":

                        //JUI
                        AminHAddEditDespositFRM frm = new AminHAddEditDespositFRM();
                        frm.Show();
                        break;
                    case "info2":

                        //JUI
                        AminHomeInfoFRM IFRM = new AminHomeInfoFRM();
                        IFRM.Show();
                        break;
                }
            }
        }
        private void dgvwithdraw_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvwithdraw.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvwithdraw.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;
                    case "returnd":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedd;
                        break;

                    case "info":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvwithdraw_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvwithdraw.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvwithdraw.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;
                    case "returnd":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedl;
                        break;

                    case "info":
                        dgvwithdraw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }



        private void dgvdeposit_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvdeposit.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvdeposit.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete2":
                        dgvdeposit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit2":
                        dgvdeposit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;

                    case "info2":
                        dgvdeposit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvdeposit_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvdeposit.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvdeposit.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete2":
                        dgvdeposit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit2":
                        dgvdeposit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;

                    case "info2":
                        dgvdeposit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            AminHomeAddEditOptionsFRM frm = new AminHomeAddEditOptionsFRM();
            frm.Show();
        }

        private void dgvdeposit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlaminhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
