namespace Sahll.JUI.Selling
{
    partial class CustomerAddEditStaffFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnclose = new customs.KhControles.KhButton();
            btn_addcustomer = new customs.KhControles.KhButton();
            label2 = new Label();
            khPanel6 = new customs.KhPanel();
            khPanel4 = new customs.KhPanel();
            khPanel3 = new customs.KhPanel();
            khPanel2 = new customs.KhPanel();
            cmbcustomerstaffname = new ComboBox();
            khButton3 = new customs.KhControles.KhButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Transparent;
            btnclose.BackgroundColor = Color.Transparent;
            btnclose.BorderColor = Color.Crimson;
            btnclose.BorderRadius = 10;
            btnclose.BorderSize = 0;
            btnclose.Cursor = Cursors.Hand;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.ForeColor = Color.White;
            btnclose.Image = Properties.Resources.close;
            btnclose.Location = new Point(1, 1);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 77;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // btn_addcustomer
            // 
            btn_addcustomer.BackColor = Color.FromArgb(173, 109, 209);
            btn_addcustomer.BackgroundColor = Color.FromArgb(173, 109, 209);
            btn_addcustomer.BorderColor = Color.FromArgb(63, 36, 114);
            btn_addcustomer.BorderRadius = 40;
            btn_addcustomer.BorderSize = 0;
            btn_addcustomer.Cursor = Cursors.Hand;
            btn_addcustomer.FlatAppearance.BorderSize = 0;
            btn_addcustomer.FlatStyle = FlatStyle.Flat;
            btn_addcustomer.Font = new Font("Hacen Egypt", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addcustomer.ForeColor = Color.White;
            btn_addcustomer.Location = new Point(205, 196);
            btn_addcustomer.Name = "btn_addcustomer";
            btn_addcustomer.Size = new Size(182, 74);
            btn_addcustomer.TabIndex = 76;
            btn_addcustomer.Text = "إضافه";
            btn_addcustomer.TextColor = Color.White;
            btn_addcustomer.UseVisualStyleBackColor = false;
            btn_addcustomer.Click += btn_addcustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("LBC", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 36, 114);
            label2.Location = new Point(209, 9);
            label2.Name = "label2";
            label2.Size = new Size(175, 42);
            label2.TabIndex = 73;
            label2.Tag = "";
            label2.Text = "إضافة عميل";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // khPanel6
            // 
            khPanel6.BackColor = Color.White;
            khPanel6.BorderRadius = 0;
            khPanel6.Dock = DockStyle.Right;
            khPanel6.ForeColor = Color.Black;
            khPanel6.GradientAngle = 90F;
            khPanel6.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel6.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel6.Location = new Point(591, 0);
            khPanel6.Name = "khPanel6";
            khPanel6.Size = new Size(2, 276);
            khPanel6.TabIndex = 79;
            // 
            // khPanel4
            // 
            khPanel4.BackColor = Color.White;
            khPanel4.BorderRadius = 0;
            khPanel4.Dock = DockStyle.Bottom;
            khPanel4.ForeColor = Color.Black;
            khPanel4.GradientAngle = 90F;
            khPanel4.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel4.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel4.Location = new Point(2, 274);
            khPanel4.Name = "khPanel4";
            khPanel4.Size = new Size(589, 2);
            khPanel4.TabIndex = 82;
            // 
            // khPanel3
            // 
            khPanel3.BackColor = Color.White;
            khPanel3.BorderRadius = 0;
            khPanel3.Dock = DockStyle.Top;
            khPanel3.ForeColor = Color.Black;
            khPanel3.GradientAngle = 90F;
            khPanel3.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel3.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel3.Location = new Point(2, 0);
            khPanel3.Name = "khPanel3";
            khPanel3.Size = new Size(589, 2);
            khPanel3.TabIndex = 81;
            // 
            // khPanel2
            // 
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 0;
            khPanel2.Dock = DockStyle.Left;
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel2.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel2.Location = new Point(0, 0);
            khPanel2.Name = "khPanel2";
            khPanel2.Size = new Size(2, 276);
            khPanel2.TabIndex = 80;
            // 
            // cmbcustomerstaffname
            // 
            cmbcustomerstaffname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbcustomerstaffname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbcustomerstaffname.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbcustomerstaffname.BackColor = Color.White;
            cmbcustomerstaffname.DropDownHeight = 150;
            cmbcustomerstaffname.Font = new Font("Hacen Egypt", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbcustomerstaffname.ForeColor = Color.FromArgb(63, 36, 114);
            cmbcustomerstaffname.FormattingEnabled = true;
            cmbcustomerstaffname.IntegralHeight = false;
            cmbcustomerstaffname.Location = new Point(30, 76);
            cmbcustomerstaffname.Name = "cmbcustomerstaffname";
            cmbcustomerstaffname.Size = new Size(425, 101);
            cmbcustomerstaffname.TabIndex = 84;
            // 
            // khButton3
            // 
            khButton3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton3.BackColor = Color.FromArgb(203, 150, 233);
            khButton3.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton3.BorderColor = Color.FromArgb(203, 150, 233);
            khButton3.BorderRadius = 40;
            khButton3.BorderSize = 1;
            khButton3.Enabled = false;
            khButton3.FlatAppearance.BorderSize = 0;
            khButton3.FlatStyle = FlatStyle.Flat;
            khButton3.ForeColor = SystemColors.Window;
            khButton3.Location = new Point(13, 74);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(459, 104);
            khButton3.TabIndex = 83;
            khButton3.Text = "khButton1";
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hacen Egypt", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 36, 114);
            label1.Location = new Point(491, 89);
            label1.Name = "label1";
            label1.Size = new Size(105, 83);
            label1.TabIndex = 85;
            label1.Tag = "";
            label1.Text = "الإسم";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CustomerAddEditStaffFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(593, 276);
            Controls.Add(cmbcustomerstaffname);
            Controls.Add(khButton3);
            Controls.Add(khPanel4);
            Controls.Add(khPanel3);
            Controls.Add(khPanel2);
            Controls.Add(khPanel6);
            Controls.Add(btnclose);
            Controls.Add(btn_addcustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerAddEditStaffFRM";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingReturnedFRM";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private customs.KhControles.KhButton btnclose;
        private customs.KhControles.KhButton btn_addcustomer;
        private Label label2;
        private customs.KhPanel khPanel6;
        private customs.KhPanel khPanel4;
        private customs.KhPanel khPanel3;
        private customs.KhPanel khPanel2;
        private ComboBox cmbcustomerstaffname;
        private customs.KhControles.KhButton khButton3;
        private Label label1;
    }
}