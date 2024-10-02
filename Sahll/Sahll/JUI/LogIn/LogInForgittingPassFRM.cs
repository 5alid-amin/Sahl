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

namespace Sahll.JUI.Selling
{
    public partial class LogInForgittingPassFRM : Form
    {
        public LogInForgittingPassFRM()
        {
            InitializeComponent();
            fillquestions();
        }

        #region ButtonsMethods
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void khButton1_Click_1(object sender, EventArgs e)
        {

            //JUI
            this.Close();
        }
        #endregion

        #region JUI
        void fillquestions()
        {
            cmbquestions.Items.Add("اسم أول مدرسة التحقت بها؟");
            cmbquestions.Items.Add("اسم حيوانك الأليف الأول؟");
            cmbquestions.Items.Add("اسم مدينتك المفضلة؟");
            cmbquestions.Items.Add("أفضل صديق لك في الطفولة؟");
            cmbquestions.Items.Add("ما هي مهنة والدتك؟");
            cmbquestions.Items.Add("اسم أول كتاب قرأته؟");
            cmbquestions.Items.Add("طعامك المفضل؟");
        }
        #endregion
    }
}
