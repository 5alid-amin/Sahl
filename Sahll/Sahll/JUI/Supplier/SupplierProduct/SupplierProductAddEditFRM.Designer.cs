namespace Sahll.JUI.Customer.CustomerProduct
{
    partial class SupplierProductAddEditFRM
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            khPanel1 = new customs.KhPanel();
            dgvAddSupplierProduct = new DataGridView();
            lbltotal = new Label();
            label1 = new Label();
            label7 = new Label();
            lblstorequantity = new Label();
            lblsellingprice = new Label();
            label6 = new Label();
            khButton5 = new customs.KhControles.KhButton();
            btn_add = new customs.KhControles.KhButton();
            khPanel2 = new customs.KhPanel();
            txtquantity = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label5 = new Label();
            cmbproduct = new ComboBox();
            khButton4 = new customs.KhControles.KhButton();
            khPanel3 = new customs.KhPanel();
            txtbarcode = new TextBox();
            khButton2 = new customs.KhControles.KhButton();
            label4 = new Label();
            label3 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            btnclose = new customs.KhControles.KhButton();
            btnminimize = new customs.KhControles.KhButton();
            product = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddSupplierProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(173, 109, 209);
            panel1.Location = new Point(81, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 2);
            panel1.TabIndex = 111;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvAddSupplierProduct);
            khPanel1.Controls.Add(lbltotal);
            khPanel1.Controls.Add(label1);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(203, 150, 233);
            khPanel1.GradientTopColor = Color.FromArgb(203, 150, 233);
            khPanel1.Location = new Point(338, 38);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(771, 738);
            khPanel1.TabIndex = 92;
            // 
            // dgvAddSupplierProduct
            // 
            dgvAddSupplierProduct.AllowUserToAddRows = false;
            dgvAddSupplierProduct.AllowUserToDeleteRows = false;
            dgvAddSupplierProduct.AllowUserToResizeColumns = false;
            dgvAddSupplierProduct.AllowUserToResizeRows = false;
            dgvAddSupplierProduct.BackgroundColor = Color.White;
            dgvAddSupplierProduct.BorderStyle = BorderStyle.None;
            dgvAddSupplierProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAddSupplierProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(203, 150, 233);
            dataGridViewCellStyle4.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAddSupplierProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAddSupplierProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddSupplierProduct.Columns.AddRange(new DataGridViewColumn[] { product, price, quantity, total, delete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle6.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAddSupplierProduct.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAddSupplierProduct.Dock = DockStyle.Top;
            dgvAddSupplierProduct.EnableHeadersVisualStyles = false;
            dgvAddSupplierProduct.GridColor = Color.White;
            dgvAddSupplierProduct.Location = new Point(5, 8);
            dgvAddSupplierProduct.Name = "dgvAddSupplierProduct";
            dgvAddSupplierProduct.ReadOnly = true;
            dgvAddSupplierProduct.RightToLeft = RightToLeft.Yes;
            dgvAddSupplierProduct.RowHeadersVisible = false;
            dgvAddSupplierProduct.RowHeadersWidth = 25;
            dgvAddSupplierProduct.RowTemplate.DividerHeight = 1;
            dgvAddSupplierProduct.RowTemplate.Height = 28;
            dgvAddSupplierProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddSupplierProduct.Size = new Size(761, 686);
            dgvAddSupplierProduct.TabIndex = 1;
            dgvAddSupplierProduct.CellClick += dgvAddCustomerProduct_CellClick;
            dgvAddSupplierProduct.CellMouseEnter += dgvAddCustomerProduct_CellMouseEnter;
            dgvAddSupplierProduct.CellMouseLeave += dgvAddCustomerProduct_CellMouseLeave;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = Color.Transparent;
            lbltotal.Font = new Font("Hacen Egypt", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotal.ForeColor = Color.FromArgb(63, 36, 114);
            lbltotal.Location = new Point(325, 679);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(116, 72);
            lbltotal.TabIndex = 2;
            lbltotal.Text = "52318";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Hacen Egypt", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(531, 678);
            label1.Name = "label1";
            label1.Size = new Size(125, 72);
            label1.TabIndex = 2;
            label1.Text = "الإجمالي";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.FromArgb(255, 247, 244);
            label7.Font = new Font("LBC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(203, 150, 233);
            label7.Location = new Point(57, 677);
            label7.Name = "label7";
            label7.Size = new Size(225, 45);
            label7.TabIndex = 108;
            label7.Text = "الكميه بالمخزن";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblstorequantity
            // 
            lblstorequantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblstorequantity.BackColor = Color.FromArgb(255, 247, 244);
            lblstorequantity.Font = new Font("Hacen Egypt", 27.75F);
            lblstorequantity.ForeColor = Color.FromArgb(138, 4, 214);
            lblstorequantity.Location = new Point(115, 720);
            lblstorequantity.Name = "lblstorequantity";
            lblstorequantity.Size = new Size(109, 55);
            lblstorequantity.TabIndex = 107;
            lblstorequantity.Text = "2153";
            lblstorequantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsellingprice
            // 
            lblsellingprice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblsellingprice.BackColor = Color.FromArgb(255, 247, 244);
            lblsellingprice.Font = new Font("Hacen Egypt", 27.75F);
            lblsellingprice.ForeColor = Color.FromArgb(138, 4, 214);
            lblsellingprice.Location = new Point(115, 612);
            lblsellingprice.Name = "lblsellingprice";
            lblsellingprice.Size = new Size(109, 57);
            lblsellingprice.TabIndex = 106;
            lblsellingprice.Text = "2153";
            lblsellingprice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.FromArgb(255, 247, 244);
            label6.Font = new Font("LBC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(203, 150, 233);
            label6.Location = new Point(81, 571);
            label6.Name = "label6";
            label6.Size = new Size(175, 45);
            label6.TabIndex = 105;
            label6.Text = "سعر الشراء";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // khButton5
            // 
            khButton5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton5.BackColor = Color.FromArgb(255, 247, 244);
            khButton5.BackgroundColor = Color.FromArgb(255, 247, 244);
            khButton5.BorderColor = Color.FromArgb(138, 4, 214);
            khButton5.BorderRadius = 40;
            khButton5.BorderSize = 1;
            khButton5.Enabled = false;
            khButton5.FlatAppearance.BorderSize = 0;
            khButton5.FlatStyle = FlatStyle.Flat;
            khButton5.ForeColor = SystemColors.Window;
            khButton5.Location = new Point(7, 566);
            khButton5.Margin = new Padding(3, 3, 2, 3);
            khButton5.Name = "khButton5";
            khButton5.Size = new Size(326, 210);
            khButton5.TabIndex = 104;
            khButton5.TextColor = SystemColors.Window;
            khButton5.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.None;
            btn_add.BackColor = Color.FromArgb(173, 109, 209);
            btn_add.BackgroundColor = Color.FromArgb(173, 109, 209);
            btn_add.BorderColor = Color.FromArgb(63, 36, 114);
            btn_add.BorderRadius = 40;
            btn_add.BorderSize = 0;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Hacen Egypt", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(93, 506);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(163, 56);
            btn_add.TabIndex = 103;
            btn_add.Text = "إضافه";
            btn_add.TextColor = Color.White;
            btn_add.UseVisualStyleBackColor = false;
            // 
            // khPanel2
            // 
            khPanel2.Anchor = AnchorStyles.None;
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 2;
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel2.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel2.Location = new Point(28, 489);
            khPanel2.Name = "khPanel2";
            khPanel2.Size = new Size(285, 3);
            khPanel2.TabIndex = 101;
            // 
            // txtquantity
            // 
            txtquantity.Anchor = AnchorStyles.None;
            txtquantity.BorderStyle = BorderStyle.None;
            txtquantity.Font = new Font("Hacen Egypt", 33.75F);
            txtquantity.ForeColor = Color.FromArgb(63, 36, 114);
            txtquantity.Location = new Point(30, 398);
            txtquantity.Multiline = true;
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(282, 94);
            txtquantity.TabIndex = 100;
            txtquantity.TextAlign = HorizontalAlignment.Center;
            // 
            // khButton3
            // 
            khButton3.Anchor = AnchorStyles.None;
            khButton3.BackColor = Color.White;
            khButton3.BackgroundColor = Color.White;
            khButton3.BorderColor = Color.FromArgb(63, 36, 114);
            khButton3.BorderRadius = 40;
            khButton3.BorderSize = 0;
            khButton3.FlatAppearance.BorderSize = 0;
            khButton3.FlatStyle = FlatStyle.Flat;
            khButton3.ForeColor = Color.White;
            khButton3.Location = new Point(21, 392);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(300, 100);
            khButton3.TabIndex = 102;
            khButton3.Text = "khButton3";
            khButton3.TextColor = Color.White;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.FromArgb(255, 247, 244);
            label5.Font = new Font("LBC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(203, 150, 233);
            label5.Location = new Point(119, 347);
            label5.Name = "label5";
            label5.Size = new Size(126, 45);
            label5.TabIndex = 99;
            label5.Text = "الكميه";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbproduct
            // 
            cmbproduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbproduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbproduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbproduct.BackColor = Color.White;
            cmbproduct.DropDownHeight = 150;
            cmbproduct.Font = new Font("Hacen Egypt", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbproduct.ForeColor = Color.FromArgb(63, 36, 114);
            cmbproduct.FormattingEnabled = true;
            cmbproduct.IntegralHeight = false;
            cmbproduct.Location = new Point(30, 86);
            cmbproduct.Name = "cmbproduct";
            cmbproduct.Size = new Size(282, 101);
            cmbproduct.TabIndex = 98;
            // 
            // khButton4
            // 
            khButton4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton4.BackColor = Color.FromArgb(203, 150, 233);
            khButton4.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton4.BorderColor = Color.FromArgb(203, 150, 233);
            khButton4.BorderRadius = 30;
            khButton4.BorderSize = 1;
            khButton4.Enabled = false;
            khButton4.FlatAppearance.BorderSize = 0;
            khButton4.FlatStyle = FlatStyle.Flat;
            khButton4.ForeColor = SystemColors.Window;
            khButton4.Location = new Point(15, 84);
            khButton4.Name = "khButton4";
            khButton4.Size = new Size(311, 104);
            khButton4.TabIndex = 97;
            khButton4.Text = "khButton1";
            khButton4.TextColor = SystemColors.Window;
            khButton4.UseVisualStyleBackColor = false;
            // 
            // khPanel3
            // 
            khPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel3.BackColor = Color.White;
            khPanel3.BorderRadius = 2;
            khPanel3.ForeColor = Color.Black;
            khPanel3.GradientAngle = 90F;
            khPanel3.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel3.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel3.Location = new Point(24, 334);
            khPanel3.Name = "khPanel3";
            khPanel3.Size = new Size(285, 3);
            khPanel3.TabIndex = 95;
            // 
            // txtbarcode
            // 
            txtbarcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbarcode.BorderStyle = BorderStyle.None;
            txtbarcode.Font = new Font("Hacen Egypt", 33.75F);
            txtbarcode.ForeColor = Color.FromArgb(63, 36, 114);
            txtbarcode.Location = new Point(26, 243);
            txtbarcode.Multiline = true;
            txtbarcode.Name = "txtbarcode";
            txtbarcode.Size = new Size(282, 94);
            txtbarcode.TabIndex = 94;
            txtbarcode.TextAlign = HorizontalAlignment.Center;
            // 
            // khButton2
            // 
            khButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton2.BackColor = Color.White;
            khButton2.BackgroundColor = Color.White;
            khButton2.BorderColor = Color.FromArgb(63, 36, 114);
            khButton2.BorderRadius = 40;
            khButton2.BorderSize = 0;
            khButton2.FlatAppearance.BorderSize = 0;
            khButton2.FlatStyle = FlatStyle.Flat;
            khButton2.ForeColor = Color.White;
            khButton2.Location = new Point(17, 237);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(300, 100);
            khButton2.TabIndex = 96;
            khButton2.Text = "khButton2";
            khButton2.TextColor = Color.White;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.FromArgb(255, 247, 244);
            label4.Font = new Font("LBC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(203, 150, 233);
            label4.Location = new Point(115, 191);
            label4.Name = "label4";
            label4.Size = new Size(126, 45);
            label4.TabIndex = 90;
            label4.Text = "الباركود";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.FromArgb(255, 247, 244);
            label3.Font = new Font("LBC", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(203, 150, 233);
            label3.Location = new Point(114, 43);
            label3.Name = "label3";
            label3.Size = new Size(113, 47);
            label3.TabIndex = 91;
            label3.Text = "الصنف";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // khButton1
            // 
            khButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton1.BackColor = Color.FromArgb(255, 247, 244);
            khButton1.BackgroundColor = Color.FromArgb(255, 247, 244);
            khButton1.BorderColor = Color.FromArgb(138, 4, 214);
            khButton1.BorderRadius = 40;
            khButton1.BorderSize = 1;
            khButton1.Enabled = false;
            khButton1.FlatAppearance.BorderSize = 0;
            khButton1.FlatStyle = FlatStyle.Flat;
            khButton1.ForeColor = SystemColors.Window;
            khButton1.Location = new Point(7, 38);
            khButton1.Margin = new Padding(3, 3, 2, 3);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(326, 526);
            khButton1.TabIndex = 93;
            khButton1.Text = "khButton1";
            khButton1.TextColor = SystemColors.Window;
            khButton1.UseVisualStyleBackColor = false;
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
            btnclose.Location = new Point(-2, -2);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 109;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // btnminimize
            // 
            btnminimize.BackColor = Color.Transparent;
            btnminimize.BackgroundColor = Color.Transparent;
            btnminimize.BorderColor = Color.Crimson;
            btnminimize.BorderRadius = 10;
            btnminimize.BorderSize = 0;
            btnminimize.Cursor = Cursors.Hand;
            btnminimize.FlatAppearance.BorderSize = 0;
            btnminimize.FlatStyle = FlatStyle.Flat;
            btnminimize.ForeColor = Color.White;
            btnminimize.Image = Properties.Resources.minimize;
            btnminimize.Location = new Point(30, -2);
            btnminimize.Name = "btnminimize";
            btnminimize.Size = new Size(33, 33);
            btnminimize.TabIndex = 110;
            btnminimize.TextColor = Color.White;
            btnminimize.UseVisualStyleBackColor = false;
            btnminimize.Click += btnminimize_Click;
            // 
            // product
            // 
            product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product.FillWeight = 144.4988F;
            product.HeaderText = "الصنف";
            product.Name = "product";
            product.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.DefaultCellStyle = dataGridViewCellStyle5;
            price.FillWeight = 51.1084938F;
            price.HeaderText = "سعر الشراء";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantity.FillWeight = 47.3107262F;
            quantity.HeaderText = "الكميه";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.FillWeight = 53.59442F;
            total.HeaderText = "الإجمالي";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 14.1613407F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // SupplierProductAddEditFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(1115, 790);
            Controls.Add(panel1);
            Controls.Add(khPanel1);
            Controls.Add(label7);
            Controls.Add(lblstorequantity);
            Controls.Add(lblsellingprice);
            Controls.Add(label6);
            Controls.Add(khButton5);
            Controls.Add(btn_add);
            Controls.Add(khPanel2);
            Controls.Add(txtquantity);
            Controls.Add(khButton3);
            Controls.Add(label5);
            Controls.Add(cmbproduct);
            Controls.Add(khButton4);
            Controls.Add(khPanel3);
            Controls.Add(txtbarcode);
            Controls.Add(khButton2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(khButton1);
            Controls.Add(btnclose);
            Controls.Add(btnminimize);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierProductAddEditFRM";
            Text = "CustomerProductAddEditFRM";
            WindowState = FormWindowState.Maximized;
            khPanel1.ResumeLayout(false);
            khPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddSupplierProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private customs.KhPanel khPanel1;
        private DataGridView dgvAddSupplierProduct;
        private Label lbltotal;
        private Label label1;
        private Label label7;
        private Label lblstorequantity;
        private Label lblsellingprice;
        private Label label6;
        private customs.KhControles.KhButton khButton5;
        private customs.KhControles.KhButton btn_add;
        private customs.KhPanel khPanel2;
        private TextBox txtquantity;
        private customs.KhControles.KhButton khButton3;
        private Label label5;
        private ComboBox cmbproduct;
        private customs.KhControles.KhButton khButton4;
        private customs.KhPanel khPanel3;
        private TextBox txtbarcode;
        private customs.KhControles.KhButton khButton2;
        private Label label4;
        private Label label3;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhButton btnclose;
        private customs.KhControles.KhButton btnminimize;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private DataGridViewImageColumn delete;
    }
}