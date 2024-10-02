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
    public partial class CarsOptionsFRM : Form
    {
        private Main main;

        public CarsOptionsFRM(Main mainForm)
        {
            InitializeComponent();
            CarsButtonsSynchronization();
            main = mainForm;


        }
       

        #region ButtonsMethods
        public void btncar1_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 1;
        }

        private void btncar2_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 2;
        }

        private void btncar3_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 3;
        }

        private void btncar4_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 4;
        }

        private void btncar5_Click_1(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 5;
        }

        private void btnnewweek_Click(object sender, EventArgs e)
        {
            DialogFRM fRM = new DialogFRM("سوف تبدأ اسبوعا جديدا وسيتم نقل البيانات للسجلات لتصبح غير قابله للتعديل؟", Color.FromArgb(64, 0, 0));
            var result = fRM.ShowDialog();

            if (result == DialogResult.Yes)
            {
                //Functions

                //JUI
                DialogFRM frm = new DialogFRM("تمت بداية يوم اسبوع جديد وانتقلت المعلومات للسجل😊", Color.FromArgb(83, 4, 128));
                frm.btncancel.Visible = false;
                frm.btnconferm.Visible = false;
                frm.timer1.Enabled = true;
                frm.ShowDialog();
            }
        }

        private void btndeficitorexcess_Click(object sender, EventArgs e)
        {
            main.ShowDeficitorexcess();
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

        public void CarsButtonsSynchronization()
        {
            var num = CarsButtonsTransitions.SelectedCar;

            // تحقق من السيارة المختارة واستدعاء دالة الزر المناسب
            switch (num)
            {
                case 1:
                    btncar1_Click_1(btncar1, EventArgs.Empty);
                    break;
                case 2:
                    btncar2_Click_1(btncar2, EventArgs.Empty);
                    break;
                case 3:
                    btncar3_Click_1(btncar3, EventArgs.Empty);
                    break;
                case 4:
                    btncar4_Click_1(btncar4, EventArgs.Empty);
                    break;
                case 5:
                    btncar5_Click_1(btncar5, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {

            main.ShowProducts();
        }

        private void btntresury_Click(object sender, EventArgs e)
        {
            main.ShowInventory();
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            main.ShowCash();
        }

        private void btns_Click(object sender, EventArgs e)
        {
            main.ShowSoldQuantity();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            main.ShowStaff();
        }

        private void btnrecords_Click(object sender, EventArgs e)
        {
            main.ShowCarsRecords();
        }

        private void pnlcarsoptions_Resize(object sender, EventArgs e)
        {
            int buttonWidth = (pnlcarsoptions.Size.Width) / 5;
            btncar5.Size = new Size(buttonWidth, 41);
            btncar4.Size = new Size(buttonWidth, 40);
            btncar3.Size = new Size(buttonWidth, 40);
            btncar2.Size = new Size(buttonWidth, 40);
            btncar1.Size = new Size(buttonWidth, 41);


            btncar5.Location = new Point(0, 17);
            btncar4.Location = new Point(btncar5.Width - 8, 18);
            btncar3.Location = new Point(btncar5.Width * 2 - 9, 18);
            btncar2.Location = new Point(btncar5.Width * 3 - 10, 18);
            btncar1.Location = new Point(btncar5.Width * 4 - 18, 17);
        }
        #endregion




    }
}
