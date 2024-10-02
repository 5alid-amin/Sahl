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
    public partial class SettingFRM : Form
    {
        private Main main;

        public SettingFRM()
        {
            InitializeComponent();
        }

        #region ButtonsMethods
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
        #endregion

        #region JUI
       

        private void btnproducts_Click(object sender, EventArgs e)
        {



            //JUI
            DialogFRM fRM = new DialogFRM("تم أخذ لقطة كامله من قاعدة البيانات للجاهز🩷", Color.FromArgb(83, 4, 128));
            fRM.btncancel.Visible = false;
            fRM.btnconferm.Visible = false;
            fRM.timer1.Enabled = false;
            fRM.Show();
        }

        private void btntresury_Click(object sender, EventArgs e)
        {


            //JUI
            DialogFRM fRM = new DialogFRM("تم استرجاع النسخة الاحتياطيه🩷", Color.FromArgb(83, 4, 128));
            fRM.btncancel.Visible = false;
            fRM.btnconferm.Visible = false;
            fRM.timer1.Enabled = false;
            fRM.Show();
        }

        private void btncash_Click(object sender, EventArgs e)
        {


            //JUI
            DialogFRM fRM = new DialogFRM("تم اخذ لقطة إحتياطيه كامله من قاعدة البيانات بصيغة اكسيل", Color.FromArgb(83, 4, 128));
            fRM.btncancel.Visible = false;
            fRM.btnconferm.Visible = false;
            fRM.timer1.Enabled = false;
            fRM.Show();
        }

        private void btns_Click(object sender, EventArgs e)
        {


            //JUI
            DialogFRM fRM = new DialogFRM("تم استرجاع نسخة إحتياطيه  من صيغة اكسيل", Color.FromArgb(83, 4, 128));
            fRM.btncancel.Visible = false;
            fRM.btnconferm.Visible = false;
            fRM.timer1.Enabled = false;
            fRM.Show();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            main.ShowStaff();
        }

        private void btnrecords_Click(object sender, EventArgs e)
        {
            main.ShowCarsRecords();
        }
     
        #endregion



        private void btndeficitorexcess_Click(object sender, EventArgs e)
        {
            DialogFRM fRM = new DialogFRM("سوف يتم حذف جمبيع البيانات بالبرنامج بحيث لا تستطيع الوصول اليها الا اذا اخذت مسبقا نسخة احتياطيه", Color.FromArgb(64, 0, 0));
            fRM.Show();
        }

        private void pnlcarsoptions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
