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
    public partial class AminHomeAddEditOptionsFRM : Form
    {
        public AminHomeAddEditOptionsFRM()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            AminHAddEditWithdrawFRM frm = new AminHAddEditWithdrawFRM();
            frm.Show();
            this.Close();
        }

        private void khButton1_Click(object sender, EventArgs e)
        {
            AminHAddEditDespositFRM frm = new AminHAddEditDespositFRM();
            frm.Show();
            this.Close();
        }

        private void AminHomeAddEditOptionsFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
