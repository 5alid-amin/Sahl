using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Product.Category
{
    public partial class CategoryAddEditFRM : Form
    {
        public CategoryAddEditFRM()
        {
            InitializeComponent();
        }


        #region ButtonsMethods
        private void btn_add_edit_Click(object sender, EventArgs e)
        {

            //JUI
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
