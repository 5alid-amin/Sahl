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
    public partial class ManufacturingAddEditFRM : Form
    {
        public ManufacturingAddEditFRM()
        {
            InitializeComponent();
        }

        private void btnadddriver_Click(object sender, EventArgs e)
        {
            ManufacturingAddRowMaterialFRM frm = new();
            frm.Show();
        }

        private void add_edit__cash_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_cash_Click(object sender, EventArgs e)
        {

        }
    }
}
