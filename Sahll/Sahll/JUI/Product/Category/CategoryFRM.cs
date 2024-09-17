using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.PL;
using Sahll.JUI.Product.Category;
using Sahll.JUI.Store;
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
    public partial class CategoryFRM : Form
    {
        public CategoryFRM()
        {
            InitializeComponent();
            dgvJustProduct.Rows.Add(new object[] { "سوائل"});
            dgvJustProduct.Rows.Add(new object[] { "مساحيق"});
            dgvJustProduct.Rows.Add(new object[] { "ورقيات" });
            dgvJustProduct.Rows.Add(new object[] { "تصنيع" });
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            CategoryAddEditFRM FRM = new CategoryAddEditFRM();


            //JUI
            FRM.Show();
        }

        #endregion
    }
}
