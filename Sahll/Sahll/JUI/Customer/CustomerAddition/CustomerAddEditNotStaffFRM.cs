﻿using System;
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
    public partial class CustomerAddEditNotStaffFRM : Form
    {
        public CustomerAddEditNotStaffFRM()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {


            //JUI
            this.Close();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
