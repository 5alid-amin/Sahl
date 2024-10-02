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
    public partial class SupplierOptionsFRM : Form
    {
        private Main main;

        public SupplierOptionsFRM(Main mainForm)
        {
            InitializeComponent();
            main = mainForm;
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            main.ShowSupplierCash();
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
            main.ShowSupplierProduct();
        }

    }
}
