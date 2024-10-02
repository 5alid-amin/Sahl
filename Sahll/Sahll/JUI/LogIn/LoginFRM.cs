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

namespace Sahll.JUI.PL
{
    public partial class LoginFRM : Form
    {
        public LoginFRM()
        {
            InitializeComponent();
        }

        #region ButtonsMethods
            private void btnclose_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            private void label3_Click(object sender, EventArgs e)
            {




                //JIU
                LogInForgittingPassFRM frm = new LogInForgittingPassFRM();
                frm.Show();
            }
        #endregion

        #region JUI
        private void khButton5_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.FromArgb(63, 36, 114);
            btnLogIn.ForeColor = Color.White;
        }

        private void khButton5_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.White;
            btnLogIn.ForeColor = Color.FromArgb(63, 36, 114);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            lblforgetingpassword.ForeColor = Color.FromArgb(85, 48, 175);

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            lblforgetingpassword.ForeColor = Color.FromArgb(203, 150, 233);
        }
        #endregion
    }
}
