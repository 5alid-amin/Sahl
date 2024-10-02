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
    public partial class CustomersOptionsFRM : Form
    {
        private Main main;

        public CustomersOptionsFRM(Main mainForm)
        {
            InitializeComponent();
            main = mainForm;
        }

        #region ButtonsMethods
        private void btnproducts_Click(object sender, EventArgs e)
        {
            main.ShowCustomerCash();
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
            main.ShowCustomerProduct();
        }
        #endregion

    }
}
