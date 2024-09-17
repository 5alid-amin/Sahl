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
    public partial class CarsStaffFRM : Form
    {
        public CarsStaffFRM()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            string[] products = { "صابون سائل", "منظف زجاج", "مسحوق غسيل", "مبيض ملابس", "معقم أرضيات", "منظف أثاث", "مطهر متعدد الاستخدامات", "مزيل البقع", "منظف حمام", "منظف سجاد" };
            foreach (var x in products)
            {
                list.Add(x);
            }
            cmbdriver.DataSource = list;
            cmbdriver.SelectedIndex = -1;
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
        #endregion

        #region JUI
        private void pnlcar_staff_Resize(object sender, EventArgs e)
        {
            int buttonWidth = (pnlcar_staff.Size.Width) / 5;
            btncar5.Size = new Size(buttonWidth, 41);
            btncar4.Size = new Size(buttonWidth, 40); 
            btncar3.Size = new Size(buttonWidth, 40);
            btncar2.Size = new Size(buttonWidth, 40);
            btncar1.Size = new Size(buttonWidth, 41); 


            btncar5.Location = new Point(0, 17);
            btncar4.Location = new Point(btncar5.Width-8, 18);
            btncar3.Location = new Point(btncar5.Width * 2-9, 18);
            btncar2.Location = new Point(btncar5.Width * 3-10, 18);
            btncar1.Location = new Point(btncar5.Width * 4-18, 17);

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

    
    }

}
