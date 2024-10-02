namespace Sahll.JUI.Selling
{
    partial class SupplierCashFRM
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlstore = new Panel();
            khPanel1 = new customs.KhPanel();
            dgvSupplierCash = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            purchasePrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            profit = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            btnAddSupplierCash = new customs.KhControles.KhButton();
            lbltotal = new customs.KhControles.KhButton();
            DpTo = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFrom = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label3 = new Label();
            btnreport = new customs.KhControles.KhButton();
            pnlstore.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierCash).BeginInit();
            SuspendLayout();
            // 
            // pnlstore
            // 
            pnlstore.Controls.Add(btnreport);
            pnlstore.Controls.Add(khPanel1);
            pnlstore.Controls.Add(btnAddSupplierCash);
            pnlstore.Controls.Add(lbltotal);
            pnlstore.Controls.Add(DpTo);
            pnlstore.Controls.Add(label2);
            pnlstore.Controls.Add(khButton1);
            pnlstore.Controls.Add(DpFrom);
            pnlstore.Controls.Add(label1);
            pnlstore.Controls.Add(khButton2);
            pnlstore.Controls.Add(txtsearch);
            pnlstore.Controls.Add(khButton3);
            pnlstore.Controls.Add(label3);
            pnlstore.Dock = DockStyle.Fill;
            pnlstore.Location = new Point(20, 0);
            pnlstore.Name = "pnlstore";
            pnlstore.Size = new Size(945, 750);
            pnlstore.TabIndex = 0;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvSupplierCash);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(6, 74);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(936, 587);
            khPanel1.TabIndex = 99;
            // 
            // dgvSupplierCash
            // 
            dgvSupplierCash.AllowUserToAddRows = false;
            dgvSupplierCash.AllowUserToDeleteRows = false;
            dgvSupplierCash.AllowUserToResizeColumns = false;
            dgvSupplierCash.AllowUserToResizeRows = false;
            dgvSupplierCash.BackgroundColor = Color.White;
            dgvSupplierCash.BorderStyle = BorderStyle.None;
            dgvSupplierCash.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSupplierCash.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSupplierCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSupplierCash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierCash.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, purchasePrice, SellingPrice, profit, delete, edit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSupplierCash.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSupplierCash.Dock = DockStyle.Fill;
            dgvSupplierCash.EnableHeadersVisualStyles = false;
            dgvSupplierCash.GridColor = Color.White;
            dgvSupplierCash.Location = new Point(5, 8);
            dgvSupplierCash.Name = "dgvSupplierCash";
            dgvSupplierCash.ReadOnly = true;
            dgvSupplierCash.RightToLeft = RightToLeft.Yes;
            dgvSupplierCash.RowHeadersVisible = false;
            dgvSupplierCash.RowHeadersWidth = 25;
            dgvSupplierCash.RowTemplate.DividerHeight = 1;
            dgvSupplierCash.RowTemplate.Height = 28;
            dgvSupplierCash.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplierCash.Size = new Size(926, 564);
            dgvSupplierCash.TabIndex = 1;
            dgvSupplierCash.CellClick += dgvSelling_CellClick;
            dgvSupplierCash.CellMouseEnter += dgvSelling_CellMouseEnter;
            dgvSupplierCash.CellMouseLeave += dgvSelling_CellMouseLeave;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 45.26249F;
            Column1.HeaderText = "المبلغ";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 174.746887F;
            Column3.HeaderText = "ملاحظه";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // purchasePrice
            // 
            purchasePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            purchasePrice.FillWeight = 46.0899277F;
            purchasePrice.HeaderText = "اليوم";
            purchasePrice.Name = "purchasePrice";
            purchasePrice.ReadOnly = true;
            // 
            // SellingPrice
            // 
            SellingPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellingPrice.DefaultCellStyle = dataGridViewCellStyle2;
            SellingPrice.FillWeight = 77.86169F;
            SellingPrice.HeaderText = "التاريخ";
            SellingPrice.Name = "SellingPrice";
            SellingPrice.ReadOnly = true;
            // 
            // profit
            // 
            profit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            profit.FillWeight = 45.5384445F;
            profit.HeaderText = "بواسطة";
            profit.Name = "profit";
            profit.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 20.5791283F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit.FillWeight = 20.2356358F;
            edit.HeaderText = "";
            edit.Image = Properties.Resources.editl;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.Name = "edit";
            edit.ReadOnly = true;
            // 
            // btnAddSupplierCash
            // 
            btnAddSupplierCash.Anchor = AnchorStyles.None;
            btnAddSupplierCash.BackColor = Color.FromArgb(173, 109, 209);
            btnAddSupplierCash.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnAddSupplierCash.BorderColor = Color.FromArgb(63, 36, 114);
            btnAddSupplierCash.BorderRadius = 40;
            btnAddSupplierCash.BorderSize = 0;
            btnAddSupplierCash.Cursor = Cursors.Hand;
            btnAddSupplierCash.FlatAppearance.BorderSize = 0;
            btnAddSupplierCash.FlatStyle = FlatStyle.Flat;
            btnAddSupplierCash.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSupplierCash.ForeColor = Color.White;
            btnAddSupplierCash.Location = new Point(380, 673);
            btnAddSupplierCash.Name = "btnAddSupplierCash";
            btnAddSupplierCash.Size = new Size(185, 63);
            btnAddSupplierCash.TabIndex = 98;
            btnAddSupplierCash.Text = "إضافه";
            btnAddSupplierCash.TextColor = Color.White;
            btnAddSupplierCash.UseVisualStyleBackColor = false;
            btnAddSupplierCash.Click += btnAddSelling_Click;
            // 
            // lbltotal
            // 
            lbltotal.Anchor = AnchorStyles.Left;
            lbltotal.BackColor = Color.White;
            lbltotal.BackgroundColor = Color.White;
            lbltotal.BorderColor = Color.FromArgb(119, 67, 219);
            lbltotal.BorderRadius = 40;
            lbltotal.BorderSize = 1;
            lbltotal.Cursor = Cursors.Hand;
            lbltotal.FlatAppearance.BorderSize = 0;
            lbltotal.FlatStyle = FlatStyle.Flat;
            lbltotal.Font = new Font("Hacen Egypt", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotal.ForeColor = Color.FromArgb(119, 67, 219);
            lbltotal.ImageAlign = ContentAlignment.BottomRight;
            lbltotal.Location = new Point(5, 670);
            lbltotal.Margin = new Padding(0);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(204, 63);
            lbltotal.TabIndex = 97;
            lbltotal.TextAlign = ContentAlignment.TopCenter;
            lbltotal.TextColor = Color.FromArgb(119, 67, 219);
            lbltotal.UseVisualStyleBackColor = false;
            // 
            // DpTo
            // 
            DpTo.Anchor = AnchorStyles.Right;
            DpTo.BorderColor = Color.White;
            DpTo.BorderSize = 0;
            DpTo.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpTo.Format = DateTimePickerFormat.Short;
            DpTo.Location = new Point(533, 16);
            DpTo.MinimumSize = new Size(0, 35);
            DpTo.Name = "DpTo";
            DpTo.Size = new Size(120, 46);
            DpTo.SkinColor = Color.Transparent;
            DpTo.TabIndex = 92;
            DpTo.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 109, 209);
            label2.Location = new Point(651, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 44);
            label2.TabIndex = 93;
            label2.Text = "إلي";
            // 
            // khButton1
            // 
            khButton1.Anchor = AnchorStyles.Right;
            khButton1.BackColor = Color.White;
            khButton1.BackgroundColor = Color.White;
            khButton1.BorderColor = Color.FromArgb(203, 150, 233);
            khButton1.BorderRadius = 20;
            khButton1.BorderSize = 1;
            khButton1.Enabled = false;
            khButton1.FlatAppearance.BorderSize = 0;
            khButton1.FlatStyle = FlatStyle.Flat;
            khButton1.ForeColor = SystemColors.Window;
            khButton1.ImageAlign = ContentAlignment.MiddleLeft;
            khButton1.Location = new Point(527, 12);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(167, 52);
            khButton1.TabIndex = 94;
            khButton1.TextColor = SystemColors.Window;
            khButton1.UseVisualStyleBackColor = false;
            // 
            // DpFrom
            // 
            DpFrom.Anchor = AnchorStyles.Right;
            DpFrom.BorderColor = Color.White;
            DpFrom.BorderSize = 0;
            DpFrom.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFrom.Format = DateTimePickerFormat.Short;
            DpFrom.Location = new Point(775, 16);
            DpFrom.MinimumSize = new Size(0, 35);
            DpFrom.Name = "DpFrom";
            DpFrom.Size = new Size(120, 46);
            DpFrom.SkinColor = Color.Transparent;
            DpFrom.TabIndex = 89;
            DpFrom.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.Location = new Point(892, 14);
            label1.Name = "label1";
            label1.Size = new Size(37, 44);
            label1.TabIndex = 90;
            label1.Text = "من";
            // 
            // khButton2
            // 
            khButton2.Anchor = AnchorStyles.Right;
            khButton2.BackColor = Color.White;
            khButton2.BackgroundColor = Color.White;
            khButton2.BorderColor = Color.FromArgb(203, 150, 233);
            khButton2.BorderRadius = 20;
            khButton2.BorderSize = 1;
            khButton2.Enabled = false;
            khButton2.FlatAppearance.BorderSize = 0;
            khButton2.FlatStyle = FlatStyle.Flat;
            khButton2.ForeColor = SystemColors.Window;
            khButton2.ImageAlign = ContentAlignment.MiddleLeft;
            khButton2.Location = new Point(769, 12);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(167, 52);
            khButton2.TabIndex = 91;
            khButton2.TextColor = SystemColors.Window;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.BorderStyle = BorderStyle.None;
            txtsearch.Font = new Font("Hacen Egypt", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = Color.FromArgb(63, 36, 114);
            txtsearch.Location = new Point(34, 12);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(274, 46);
            txtsearch.TabIndex = 88;
            // 
            // khButton3
            // 
            khButton3.BackColor = Color.White;
            khButton3.BackgroundColor = Color.White;
            khButton3.BorderColor = Color.FromArgb(203, 150, 233);
            khButton3.BorderRadius = 40;
            khButton3.BorderSize = 1;
            khButton3.Enabled = false;
            khButton3.FlatAppearance.BorderSize = 0;
            khButton3.FlatStyle = FlatStyle.Flat;
            khButton3.ForeColor = SystemColors.Window;
            khButton3.Image = Properties.Resources.search;
            khButton3.ImageAlign = ContentAlignment.MiddleLeft;
            khButton3.Location = new Point(3, 10);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(323, 52);
            khButton3.TabIndex = 87;
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Hacen Egypt", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 36, 114);
            label3.Location = new Point(204, 653);
            label3.Name = "label3";
            label3.Size = new Size(172, 99);
            label3.TabIndex = 96;
            label3.Text = "الاجمالي";
            // 
            // btnreport
            // 
            btnreport.Anchor = AnchorStyles.Right;
            btnreport.BackColor = Color.Transparent;
            btnreport.BackgroundColor = Color.Transparent;
            btnreport.BorderColor = Color.FromArgb(63, 36, 114);
            btnreport.BorderRadius = 10;
            btnreport.BorderSize = 0;
            btnreport.Cursor = Cursors.Hand;
            btnreport.FlatAppearance.BorderSize = 0;
            btnreport.FlatStyle = FlatStyle.Flat;
            btnreport.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreport.ForeColor = Color.Transparent;
            btnreport.Image = Properties.Resources.reportl1;
            btnreport.Location = new Point(874, 663);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(51, 65);
            btnreport.TabIndex = 100;
            btnreport.TextColor = Color.Transparent;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // SupplierCashFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlstore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierCashFRM";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingFRM";
            pnlstore.ResumeLayout(false);
            pnlstore.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSupplierCash).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhControles.KhDatePicker DpTo;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFrom;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton btnAddSupplierCash;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhPanel khPanel1;
        private DataGridView dgvSupplierCash;
        public Panel pnlstore;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn purchasePrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn profit;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn edit;
        private customs.KhControles.KhButton btnreport;
    }
}