namespace Sahll.JUI.Store
{
    partial class StoreAddEditFRM
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
            btnaddcategory = new customs.KhControles.KhButton();
            khPanel5 = new customs.KhPanel();
            khPanel3 = new customs.KhPanel();
            khPanel1 = new customs.KhPanel();
            txtquantity = new TextBox();
            khButton1 = new customs.KhControles.KhButton();
            cmbproduct = new ComboBox();
            khButton4 = new customs.KhControles.KhButton();
            cmbcategory = new ComboBox();
            khButton5 = new customs.KhControles.KhButton();
            cmbsupplier = new ComboBox();
            khButton3 = new customs.KhControles.KhButton();
            khPanel2 = new customs.KhPanel();
            txtbarcode = new TextBox();
            label2 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            khPanel4 = new customs.KhPanel();
            khPanel6 = new customs.KhPanel();
            btnclose = new customs.KhControles.KhButton();
            btn_add_edit = new customs.KhControles.KhButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnaddsupplier = new customs.KhControles.KhButton();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnaddcategory
            // 
            btnaddcategory.BackColor = Color.FromArgb(255, 251, 245);
            btnaddcategory.BackgroundColor = Color.FromArgb(255, 251, 245);
            btnaddcategory.BorderColor = Color.FromArgb(63, 36, 114);
            btnaddcategory.BorderRadius = 38;
            btnaddcategory.BorderSize = 0;
            btnaddcategory.Cursor = Cursors.Hand;
            btnaddcategory.FlatAppearance.BorderSize = 0;
            btnaddcategory.FlatStyle = FlatStyle.Flat;
            btnaddcategory.ForeColor = Color.White;
            btnaddcategory.Image = Properties.Resources.plus;
            btnaddcategory.Location = new Point(7, 604);
            btnaddcategory.Name = "btnaddcategory";
            btnaddcategory.Size = new Size(42, 47);
            btnaddcategory.TabIndex = 136;
            btnaddcategory.TextColor = Color.White;
            btnaddcategory.UseVisualStyleBackColor = false;
            btnaddcategory.Click += btnaddcategory_Click;
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
            khPanel5.Size = new Size(590, 2);
            khPanel5.TabIndex = 134;
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
            khPanel3.Size = new Size(590, 2);
            khPanel3.TabIndex = 133;
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 2;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel1.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel1.Location = new Point(15, 409);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(427, 3);
            khPanel1.TabIndex = 131;
            // 
            // txtquantity
            // 
            txtquantity.BorderStyle = BorderStyle.None;
            txtquantity.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtquantity.ForeColor = Color.FromArgb(63, 36, 114);
            txtquantity.Location = new Point(16, 319);
            txtquantity.Multiline = true;
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(427, 92);
            txtquantity.TabIndex = 130;
            txtquantity.TextAlign = HorizontalAlignment.Center;
            // 
            // khButton1
            // 
            khButton1.BackColor = Color.White;
            khButton1.BackgroundColor = Color.White;
            khButton1.BorderColor = Color.FromArgb(63, 36, 114);
            khButton1.BorderRadius = 40;
            khButton1.BorderSize = 0;
            khButton1.FlatAppearance.BorderSize = 0;
            khButton1.FlatStyle = FlatStyle.Flat;
            khButton1.ForeColor = Color.White;
            khButton1.Location = new Point(7, 312);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(444, 100);
            khButton1.TabIndex = 132;
            khButton1.Text = "khButton1";
            khButton1.TextColor = Color.White;
            khButton1.UseVisualStyleBackColor = false;
            // 
            // cmbproduct
            // 
            cmbproduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbproduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbproduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbproduct.BackColor = Color.White;
            cmbproduct.DropDownHeight = 150;
            cmbproduct.Font = new Font("Hacen Egypt", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbproduct.ForeColor = Color.FromArgb(63, 36, 114);
            cmbproduct.FormattingEnabled = true;
            cmbproduct.IntegralHeight = false;
            cmbproduct.Location = new Point(19, 59);
            cmbproduct.Name = "cmbproduct";
            cmbproduct.Size = new Size(424, 91);
            cmbproduct.TabIndex = 129;
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
            khButton4.Location = new Point(6, 57);
            khButton4.Name = "khButton4";
            khButton4.Size = new Size(450, 94);
            khButton4.TabIndex = 128;
            khButton4.Text = "khButton1";
            khButton4.TextColor = SystemColors.Window;
            khButton4.UseVisualStyleBackColor = false;
            // 
            // cmbcategory
            // 
            cmbcategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbcategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbcategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbcategory.BackColor = Color.White;
            cmbcategory.DropDownHeight = 150;
            cmbcategory.Font = new Font("Hacen Egypt", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbcategory.ForeColor = Color.FromArgb(63, 36, 114);
            cmbcategory.FormattingEnabled = true;
            cmbcategory.IntegralHeight = false;
            cmbcategory.Location = new Point(67, 582);
            cmbcategory.Name = "cmbcategory";
            cmbcategory.Size = new Size(376, 91);
            cmbcategory.TabIndex = 125;
            // 
            // khButton5
            // 
            khButton5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton5.BackColor = Color.FromArgb(203, 150, 233);
            khButton5.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton5.BorderColor = Color.FromArgb(203, 150, 233);
            khButton5.BorderRadius = 40;
            khButton5.BorderSize = 1;
            khButton5.Enabled = false;
            khButton5.FlatAppearance.BorderSize = 0;
            khButton5.FlatStyle = FlatStyle.Flat;
            khButton5.ForeColor = SystemColors.Window;
            khButton5.Location = new Point(53, 580);
            khButton5.Name = "khButton5";
            khButton5.Size = new Size(403, 94);
            khButton5.TabIndex = 123;
            khButton5.Text = "khButton1";
            khButton5.TextColor = SystemColors.Window;
            khButton5.UseVisualStyleBackColor = false;
            // 
            // cmbsupplier
            // 
            cmbsupplier.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbsupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbsupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbsupplier.BackColor = Color.White;
            cmbsupplier.DropDownHeight = 150;
            cmbsupplier.Font = new Font("Hacen Egypt", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbsupplier.ForeColor = Color.FromArgb(63, 36, 114);
            cmbsupplier.FormattingEnabled = true;
            cmbsupplier.IntegralHeight = false;
            cmbsupplier.Location = new Point(67, 459);
            cmbsupplier.Name = "cmbsupplier";
            cmbsupplier.Size = new Size(376, 91);
            cmbsupplier.TabIndex = 126;
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
            khButton3.Location = new Point(53, 457);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(403, 94);
            khButton3.TabIndex = 124;
            khButton3.Text = "khButton1";
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // khPanel2
            // 
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 2;
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel2.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel2.Location = new Point(16, 280);
            khPanel2.Name = "khPanel2";
            khPanel2.Size = new Size(427, 3);
            khPanel2.TabIndex = 119;
            // 
            // txtbarcode
            // 
            txtbarcode.BorderStyle = BorderStyle.None;
            txtbarcode.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbarcode.ForeColor = Color.FromArgb(63, 36, 114);
            txtbarcode.Location = new Point(16, 187);
            txtbarcode.Multiline = true;
            txtbarcode.Name = "txtbarcode";
            txtbarcode.Size = new Size(427, 92);
            txtbarcode.TabIndex = 118;
            txtbarcode.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("LBC", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 36, 114);
            label2.Location = new Point(159, 4);
            label2.Name = "label2";
            label2.Size = new Size(268, 42);
            label2.TabIndex = 117;
            label2.Tag = "";
            label2.Text = "إضافة صنف للمخزن";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            khButton2.Location = new Point(7, 180);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(444, 100);
            khButton2.TabIndex = 120;
            khButton2.Text = "khButton2";
            khButton2.TextColor = Color.White;
            khButton2.UseVisualStyleBackColor = false;
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
            khPanel4.TabIndex = 114;
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
            khPanel6.Location = new Point(592, 0);
            khPanel6.Name = "khPanel6";
            khPanel6.Size = new Size(2, 750);
            khPanel6.TabIndex = 113;
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
            btnclose.Location = new Point(2, 2);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(30, 33);
            btnclose.TabIndex = 112;
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
            btn_add_edit.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add_edit.ForeColor = Color.White;
            btn_add_edit.Location = new Point(194, 680);
            btn_add_edit.Name = "btn_add_edit";
            btn_add_edit.Size = new Size(199, 65);
            btn_add_edit.TabIndex = 111;
            btn_add_edit.Text = "إضافه";
            btn_add_edit.TextColor = Color.White;
            btn_add_edit.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Hacen Egypt", 32.25F);
            label5.ForeColor = Color.FromArgb(173, 109, 209);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(498, 457);
            label5.Name = "label5";
            label5.Size = new Size(103, 89);
            label5.TabIndex = 122;
            label5.Tag = "";
            label5.Text = "المورد";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Hacen Egypt", 32.25F);
            label4.ForeColor = Color.FromArgb(173, 109, 209);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(476, 323);
            label4.Name = "label4";
            label4.Size = new Size(125, 89);
            label4.TabIndex = 116;
            label4.Tag = "";
            label4.Text = "الكميه";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Hacen Egypt", 32.25F);
            label3.ForeColor = Color.FromArgb(173, 109, 209);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(465, 191);
            label3.Name = "label3";
            label3.Size = new Size(136, 89);
            label3.TabIndex = 115;
            label3.Tag = "";
            label3.Text = "الباركود";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hacen Egypt", 32.25F);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(476, 59);
            label1.Name = "label1";
            label1.Size = new Size(125, 89);
            label1.TabIndex = 127;
            label1.Tag = "";
            label1.Text = "الصنف";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnaddsupplier
            // 
            btnaddsupplier.BackColor = Color.FromArgb(255, 251, 245);
            btnaddsupplier.BackgroundColor = Color.FromArgb(255, 251, 245);
            btnaddsupplier.BorderColor = Color.FromArgb(63, 36, 114);
            btnaddsupplier.BorderRadius = 38;
            btnaddsupplier.BorderSize = 0;
            btnaddsupplier.Cursor = Cursors.Hand;
            btnaddsupplier.FlatAppearance.BorderSize = 0;
            btnaddsupplier.FlatStyle = FlatStyle.Flat;
            btnaddsupplier.ForeColor = Color.White;
            btnaddsupplier.Image = Properties.Resources.plus;
            btnaddsupplier.Location = new Point(7, 481);
            btnaddsupplier.Name = "btnaddsupplier";
            btnaddsupplier.Size = new Size(42, 47);
            btnaddsupplier.TabIndex = 135;
            btnaddsupplier.TextColor = Color.White;
            btnaddsupplier.UseVisualStyleBackColor = false;
            btnaddsupplier.Click += btnaddsupplier_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Hacen Egypt", 32.25F);
            label6.ForeColor = Color.FromArgb(173, 109, 209);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(449, 585);
            label6.Name = "label6";
            label6.Size = new Size(152, 89);
            label6.TabIndex = 121;
            label6.Tag = "";
            label6.Text = "التصنيف";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StoreAddEditFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(594, 750);
            Controls.Add(btnaddcategory);
            Controls.Add(khPanel5);
            Controls.Add(khPanel3);
            Controls.Add(khPanel1);
            Controls.Add(txtquantity);
            Controls.Add(khButton1);
            Controls.Add(cmbproduct);
            Controls.Add(khButton4);
            Controls.Add(cmbcategory);
            Controls.Add(khButton5);
            Controls.Add(cmbsupplier);
            Controls.Add(khButton3);
            Controls.Add(khPanel2);
            Controls.Add(txtbarcode);
            Controls.Add(label2);
            Controls.Add(khButton2);
            Controls.Add(khPanel4);
            Controls.Add(khPanel6);
            Controls.Add(btnclose);
            Controls.Add(btn_add_edit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnaddsupplier);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreAddEditFRM";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoreAddEditFRM";
            TopMost = true;
            Load += StoreAddEditFRM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private customs.KhControles.KhButton btnaddcategory;
        private customs.KhPanel khPanel5;
        private customs.KhPanel khPanel3;
        private customs.KhPanel khPanel1;
        private TextBox txtquantity;
        private customs.KhControles.KhButton khButton1;
        private ComboBox cmbproduct;
        private customs.KhControles.KhButton khButton4;
        private ComboBox cmbcategory;
        private customs.KhControles.KhButton khButton5;
        private ComboBox cmbsupplier;
        private customs.KhControles.KhButton khButton3;
        private customs.KhPanel khPanel2;
        private TextBox txtbarcode;
        private Label label2;
        private customs.KhControles.KhButton khButton2;
        private customs.KhPanel khPanel4;
        private customs.KhPanel khPanel6;
        private customs.KhControles.KhButton btnclose;
        private customs.KhControles.KhButton btn_add_edit;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private customs.KhControles.KhButton btnaddsupplier;
        private Label label6;
    }
}