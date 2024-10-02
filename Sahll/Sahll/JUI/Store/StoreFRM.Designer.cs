namespace Sahll.JUI.Selling
{
    partial class StoreFRM
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
            btnreport = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            dgvStore = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            purchasePrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            profit = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            btnAddStore = new customs.KhControles.KhButton();
            lbltotal = new customs.KhControles.KhButton();
            DpToStore = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFromStore = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label3 = new Label();
            pnlstore.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStore).BeginInit();
            SuspendLayout();
            // 
            // pnlstore
            // 
            pnlstore.Controls.Add(btnreport);
            pnlstore.Controls.Add(khPanel1);
            pnlstore.Controls.Add(btnAddStore);
            pnlstore.Controls.Add(lbltotal);
            pnlstore.Controls.Add(DpToStore);
            pnlstore.Controls.Add(label2);
            pnlstore.Controls.Add(khButton1);
            pnlstore.Controls.Add(DpFromStore);
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
            btnreport.Location = new Point(885, 662);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(51, 65);
            btnreport.TabIndex = 104;
            btnreport.TextColor = Color.Transparent;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvStore);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(9, 73);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(936, 587);
            khPanel1.TabIndex = 99;
            // 
            // dgvStore
            // 
            dgvStore.AllowUserToAddRows = false;
            dgvStore.AllowUserToDeleteRows = false;
            dgvStore.AllowUserToResizeColumns = false;
            dgvStore.AllowUserToResizeRows = false;
            dgvStore.BackgroundColor = Color.White;
            dgvStore.BorderStyle = BorderStyle.None;
            dgvStore.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvStore.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, purchasePrice, SellingPrice, profit, supplier, edit, info });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvStore.DefaultCellStyle = dataGridViewCellStyle3;
            dgvStore.Dock = DockStyle.Fill;
            dgvStore.EnableHeadersVisualStyles = false;
            dgvStore.GridColor = Color.White;
            dgvStore.Location = new Point(5, 8);
            dgvStore.Name = "dgvStore";
            dgvStore.ReadOnly = true;
            dgvStore.RightToLeft = RightToLeft.Yes;
            dgvStore.RowHeadersVisible = false;
            dgvStore.RowHeadersWidth = 25;
            dgvStore.RowTemplate.DividerHeight = 1;
            dgvStore.RowTemplate.Height = 28;
            dgvStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStore.Size = new Size(926, 564);
            dgvStore.TabIndex = 1;
            dgvStore.CellClick += dgvSelling_CellClick;
            dgvStore.CellContentClick += dgvStore_CellContentClick;
            dgvStore.CellMouseEnter += dgvSelling_CellMouseEnter;
            dgvStore.CellMouseLeave += dgvSelling_CellMouseLeave;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 226.23378F;
            Column1.HeaderText = "الصنف";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 42.3619156F;
            Column3.HeaderText = "الكميه";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // purchasePrice
            // 
            purchasePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            purchasePrice.FillWeight = 44.861515F;
            purchasePrice.HeaderText = "س.الشراء";
            purchasePrice.Name = "purchasePrice";
            purchasePrice.ReadOnly = true;
            // 
            // SellingPrice
            // 
            SellingPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellingPrice.DefaultCellStyle = dataGridViewCellStyle2;
            SellingPrice.FillWeight = 47.66477F;
            SellingPrice.HeaderText = "س.البيع";
            SellingPrice.Name = "SellingPrice";
            SellingPrice.ReadOnly = true;
            // 
            // profit
            // 
            profit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            profit.FillWeight = 50.66704F;
            profit.HeaderText = "الربح";
            profit.Name = "profit";
            profit.ReadOnly = true;
            // 
            // supplier
            // 
            supplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supplier.FillWeight = 84.60645F;
            supplier.HeaderText = "المورد";
            supplier.Name = "supplier";
            supplier.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit.FillWeight = 18.794508F;
            edit.HeaderText = "";
            edit.Image = Properties.Resources.editl;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.Name = "edit";
            edit.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 21.5978737F;
            info.HeaderText = "";
            info.Image = Properties.Resources.infol;
            info.Name = "info";
            info.ReadOnly = true;
            // 
            // btnAddStore
            // 
            btnAddStore.Anchor = AnchorStyles.None;
            btnAddStore.BackColor = Color.FromArgb(173, 109, 209);
            btnAddStore.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnAddStore.BorderColor = Color.FromArgb(63, 36, 114);
            btnAddStore.BorderRadius = 40;
            btnAddStore.BorderSize = 0;
            btnAddStore.Cursor = Cursors.Hand;
            btnAddStore.FlatAppearance.BorderSize = 0;
            btnAddStore.FlatStyle = FlatStyle.Flat;
            btnAddStore.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStore.ForeColor = Color.White;
            btnAddStore.Location = new Point(380, 673);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(185, 63);
            btnAddStore.TabIndex = 98;
            btnAddStore.Text = "إضافه";
            btnAddStore.TextColor = Color.White;
            btnAddStore.UseVisualStyleBackColor = false;
            btnAddStore.Click += btnAddSelling_Click;
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
            // DpToStore
            // 
            DpToStore.Anchor = AnchorStyles.Right;
            DpToStore.BorderColor = Color.White;
            DpToStore.BorderSize = 0;
            DpToStore.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToStore.Format = DateTimePickerFormat.Short;
            DpToStore.Location = new Point(533, 16);
            DpToStore.MinimumSize = new Size(0, 35);
            DpToStore.Name = "DpToStore";
            DpToStore.Size = new Size(120, 46);
            DpToStore.SkinColor = Color.Transparent;
            DpToStore.TabIndex = 92;
            DpToStore.TextColor = Color.FromArgb(63, 36, 114);
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
            // DpFromStore
            // 
            DpFromStore.Anchor = AnchorStyles.Right;
            DpFromStore.BorderColor = Color.White;
            DpFromStore.BorderSize = 0;
            DpFromStore.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFromStore.Format = DateTimePickerFormat.Short;
            DpFromStore.Location = new Point(775, 16);
            DpFromStore.MinimumSize = new Size(0, 35);
            DpFromStore.Name = "DpFromStore";
            DpFromStore.Size = new Size(120, 46);
            DpFromStore.SkinColor = Color.Transparent;
            DpFromStore.TabIndex = 89;
            DpFromStore.TextColor = Color.FromArgb(63, 36, 114);
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
            // StoreFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlstore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreFRM";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingFRM";
            pnlstore.ResumeLayout(false);
            pnlstore.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStore).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhControles.KhDatePicker DpToStore;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFromStore;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton btnAddStore;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhPanel khPanel1;
        private DataGridView dgvStore;
        public Panel pnlstore;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn purchasePrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn profit;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn info;
        private customs.KhControles.KhButton btnreport;
    }
}