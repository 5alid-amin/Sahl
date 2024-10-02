namespace Sahll.JUI.Car.SubForms
{
    partial class CarsAddEditProductsEnventoryFRM
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
            khPanel6 = new customs.KhPanel();
            khPanel4 = new customs.KhPanel();
            khPanel3 = new customs.KhPanel();
            khPanel5 = new customs.KhPanel();
            cmbproduct = new ComboBox();
            khButton4 = new customs.KhControles.KhButton();
            btnclose = new customs.KhControles.KhButton();
            btn_add_edit = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            khPanel2 = new customs.KhPanel();
            txtquantity = new TextBox();
            txtbarcode = new TextBox();
            label4 = new Label();
            label1 = new Label();
            lblCarsAddEditProductsEnventoryFRM = new Label();
            khButton2 = new customs.KhControles.KhButton();
            label3 = new Label();
            khButton3 = new customs.KhControles.KhButton();
            SuspendLayout();
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
            khPanel6.Location = new Point(640, 0);
            khPanel6.Name = "khPanel6";
            khPanel6.Size = new Size(2, 750);
            khPanel6.TabIndex = 70;
            // 
            // khPanel4
            // 
            khPanel4.BackColor = Color.White;
            khPanel4.BorderRadius = 0;
            khPanel4.Dock = DockStyle.Left;
            khPanel4.ForeColor = Color.Black;
            khPanel4.GradientAngle = 90F;
            khPanel4.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel4.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel4.Location = new Point(0, 0);
            khPanel4.Name = "khPanel4";
            khPanel4.Size = new Size(2, 750);
            khPanel4.TabIndex = 71;
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
            khPanel3.Size = new Size(638, 2);
            khPanel3.TabIndex = 107;
            // 
            // khPanel5
            // 
            khPanel5.BackColor = Color.White;
            khPanel5.BorderRadius = 0;
            khPanel5.Dock = DockStyle.Bottom;
            khPanel5.ForeColor = Color.Black;
            khPanel5.GradientAngle = 90F;
            khPanel5.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel5.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel5.Location = new Point(2, 748);
            khPanel5.Name = "khPanel5";
            khPanel5.Size = new Size(638, 2);
            khPanel5.TabIndex = 108;
            // 
            // cmbproduct
            // 
            cmbproduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbproduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbproduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbproduct.BackColor = Color.White;
            cmbproduct.DropDownHeight = 150;
            cmbproduct.Font = new Font("Hacen Egypt", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbproduct.ForeColor = Color.FromArgb(63, 36, 114);
            cmbproduct.FormattingEnabled = true;
            cmbproduct.IntegralHeight = false;
            cmbproduct.Location = new Point(24, 111);
            cmbproduct.Name = "cmbproduct";
            cmbproduct.Size = new Size(462, 113);
            cmbproduct.TabIndex = 136;
            // 
            // khButton4
            // 
            khButton4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton4.BackColor = Color.FromArgb(203, 150, 233);
            khButton4.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton4.BorderColor = Color.FromArgb(203, 150, 233);
            khButton4.BorderRadius = 40;
            khButton4.BorderSize = 1;
            khButton4.Enabled = false;
            khButton4.FlatAppearance.BorderSize = 0;
            khButton4.FlatStyle = FlatStyle.Flat;
            khButton4.ForeColor = SystemColors.Window;
            khButton4.Location = new Point(6, 109);
            khButton4.Name = "khButton4";
            khButton4.Size = new Size(499, 116);
            khButton4.TabIndex = 135;
            khButton4.Text = "khButton1";
            khButton4.TextColor = SystemColors.Window;
            khButton4.UseVisualStyleBackColor = false;
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
            btnclose.TabIndex = 132;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click_1;
            // 
            // btn_add_edit
            // 
            btn_add_edit.BackColor = Color.FromArgb(173, 109, 209);
            btn_add_edit.BackgroundColor = Color.FromArgb(173, 109, 209);
            btn_add_edit.BorderColor = Color.FromArgb(63, 36, 114);
            btn_add_edit.BorderRadius = 40;
            btn_add_edit.BorderSize = 0;
            btn_add_edit.Cursor = Cursors.Hand;
            btn_add_edit.FlatAppearance.BorderSize = 0;
            btn_add_edit.FlatStyle = FlatStyle.Flat;
            btn_add_edit.Font = new Font("Hacen Egypt", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add_edit.ForeColor = Color.White;
            btn_add_edit.Location = new Point(227, 639);
            btn_add_edit.Name = "btn_add_edit";
            btn_add_edit.Size = new Size(182, 74);
            btn_add_edit.TabIndex = 131;
            btn_add_edit.Text = "إضافه";
            btn_add_edit.TextColor = Color.White;
            btn_add_edit.UseVisualStyleBackColor = false;
            btn_add_edit.Click += btn_add_edit_Click_1;
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 2;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel1.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel1.Location = new Point(24, 595);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(466, 3);
            khPanel1.TabIndex = 129;
            // 
            // khPanel2
            // 
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 2;
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel2.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel2.Location = new Point(16, 410);
            khPanel2.Name = "khPanel2";
            khPanel2.Size = new Size(477, 3);
            khPanel2.TabIndex = 130;
            // 
            // txtquantity
            // 
            txtquantity.BorderStyle = BorderStyle.None;
            txtquantity.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtquantity.ForeColor = Color.FromArgb(63, 36, 114);
            txtquantity.Location = new Point(24, 491);
            txtquantity.Multiline = true;
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(477, 107);
            txtquantity.TabIndex = 127;
            txtquantity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbarcode
            // 
            txtbarcode.BorderStyle = BorderStyle.None;
            txtbarcode.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbarcode.ForeColor = Color.FromArgb(63, 36, 114);
            txtbarcode.Location = new Point(16, 310);
            txtbarcode.Multiline = true;
            txtbarcode.Name = "txtbarcode";
            txtbarcode.Size = new Size(477, 100);
            txtbarcode.TabIndex = 128;
            txtbarcode.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Hacen Egypt", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(173, 109, 209);
            label4.Location = new Point(498, 485);
            label4.Name = "label4";
            label4.Size = new Size(164, 116);
            label4.TabIndex = 123;
            label4.Tag = "";
            label4.Text = "الكميه";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hacen Egypt", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.Location = new Point(504, 111);
            label1.Name = "label1";
            label1.Size = new Size(162, 116);
            label1.TabIndex = 124;
            label1.Tag = "";
            label1.Text = "الصنف";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCarsAddEditProductsEnventoryFRM
            // 
            lblCarsAddEditProductsEnventoryFRM.AutoSize = true;
            lblCarsAddEditProductsEnventoryFRM.Font = new Font("LBC", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarsAddEditProductsEnventoryFRM.ForeColor = Color.FromArgb(63, 36, 114);
            lblCarsAddEditProductsEnventoryFRM.Location = new Point(184, 3);
            lblCarsAddEditProductsEnventoryFRM.Name = "lblCarsAddEditProductsEnventoryFRM";
            lblCarsAddEditProductsEnventoryFRM.Size = new Size(274, 42);
            lblCarsAddEditProductsEnventoryFRM.TabIndex = 125;
            lblCarsAddEditProductsEnventoryFRM.Tag = "";
            lblCarsAddEditProductsEnventoryFRM.Text = "إضافة صنف للسياره";
            lblCarsAddEditProductsEnventoryFRM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // khButton2
            // 
            khButton2.BackColor = Color.White;
            khButton2.BackgroundColor = Color.White;
            khButton2.BorderColor = Color.FromArgb(63, 36, 114);
            khButton2.BorderRadius = 40;
            khButton2.BorderSize = 0;
            khButton2.FlatAppearance.BorderSize = 0;
            khButton2.FlatStyle = FlatStyle.Flat;
            khButton2.ForeColor = Color.White;
            khButton2.Location = new Point(7, 301);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(494, 112);
            khButton2.TabIndex = 133;
            khButton2.Text = "khButton2";
            khButton2.TextColor = Color.White;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Hacen Egypt", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(173, 109, 209);
            label3.Location = new Point(485, 298);
            label3.Name = "label3";
            label3.Size = new Size(179, 116);
            label3.TabIndex = 126;
            label3.Tag = "";
            label3.Text = "الباركود";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // khButton3
            // 
            khButton3.BackColor = Color.White;
            khButton3.BackgroundColor = Color.White;
            khButton3.BorderColor = Color.FromArgb(63, 36, 114);
            khButton3.BorderRadius = 40;
            khButton3.BorderSize = 0;
            khButton3.FlatAppearance.BorderSize = 0;
            khButton3.FlatStyle = FlatStyle.Flat;
            khButton3.ForeColor = Color.White;
            khButton3.Location = new Point(15, 484);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(494, 114);
            khButton3.TabIndex = 134;
            khButton3.Text = "khButton3";
            khButton3.TextColor = Color.White;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // CarsAddEditProductsEnventoryFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(642, 750);
            Controls.Add(cmbproduct);
            Controls.Add(khButton4);
            Controls.Add(btn_add_edit);
            Controls.Add(khPanel1);
            Controls.Add(khPanel2);
            Controls.Add(txtquantity);
            Controls.Add(txtbarcode);
            Controls.Add(lblCarsAddEditProductsEnventoryFRM);
            Controls.Add(khButton2);
            Controls.Add(khButton3);
            Controls.Add(khPanel5);
            Controls.Add(khPanel3);
            Controls.Add(khPanel4);
            Controls.Add(khPanel6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnclose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarsAddEditProductsEnventoryFRM";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_edit_products_inventoryFRM";
            TopMost = true;
            Load += CarsAddEditProductsEnventoryFRM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private customs.KhPanel khPanel6;
        private customs.KhPanel khPanel4;
        private customs.KhPanel khPanel3;
        private customs.KhPanel khPanel5;
        private ComboBox cmbproduct;
        private customs.KhControles.KhButton khButton4;
        private customs.KhControles.KhButton btnclose;
        private customs.KhControles.KhButton btn_add_edit;
        private customs.KhPanel khPanel1;
        private customs.KhPanel khPanel2;
        private TextBox txtquantity;
        private TextBox txtbarcode;
        private Label label4;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private Label label3;
        private customs.KhControles.KhButton khButton3;
        public Label lblCarsAddEditProductsEnventoryFRM;
    }
}