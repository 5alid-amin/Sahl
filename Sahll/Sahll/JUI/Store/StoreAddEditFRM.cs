using Sahll.JUI.Product.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Store
{
    public partial class StoreAddEditFRM : Form
    {
        public StoreAddEditFRM()
        {
            InitializeComponent();
        }

        private void StoreAddEditFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            CategoryAddEditFRM FRM = new CategoryAddEditFRM();


            //JUI
            FRM.Show();
        }
    }
}
