using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Car.SubForms
{
    public partial class ExpensesAddEdit : Form
    {
        public ExpensesAddEdit()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {



            //JUI
            this.Close();
        }

        private void ExpensesAddEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Receipt_Click(object sender, EventArgs e)
        {
            //JUI
            this.Close();
        }
    }
}
