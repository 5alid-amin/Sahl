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
    public partial class CustomerAdditionOptionsFRM : Form
    {
        bool isEditing = false;
        public CustomerAdditionOptionsFRM(bool isEditing)
        {
            InitializeComponent();
            this.isEditing = isEditing;
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            CustomerAddEditStaffFRM frm = new CustomerAddEditStaffFRM();
            if (isEditing) frm.lblCustomerAddEditStaffFRM.Text = "تعديل عميل";
            frm.Show();
            this.Close();
        }

        private void khButton1_Click(object sender, EventArgs e)
        {
            CustomerAddEditNotStaffFRM frm = new CustomerAddEditNotStaffFRM();
            if (isEditing) frm.lblCustomerAddEditNotStaffFRM.Text = "تعديل عميل";
                frm.Show();
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
