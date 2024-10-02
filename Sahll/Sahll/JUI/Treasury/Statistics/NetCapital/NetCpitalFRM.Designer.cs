namespace Sahll.JUI.Selling
{
    partial class NetCpitalFRM
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
            dgvNetCapital = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            purchasePrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            btnAddStore = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            pnlstore.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNetCapital).BeginInit();
            SuspendLayout();
            // 
            // pnlstore
            // 
            pnlstore.Controls.Add(btnreport);
            pnlstore.Controls.Add(khPanel1);
            pnlstore.Controls.Add(btnAddStore);
            pnlstore.Controls.Add(txtsearch);
            pnlstore.Controls.Add(khButton3);
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
            btnreport.Location = new Point(885, 671);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(51, 65);
            btnreport.TabIndex = 103;
            btnreport.TextColor = Color.Transparent;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvNetCapital);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(5, 79);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(936, 587);
            khPanel1.TabIndex = 99;
            // 
            // dgvNetCapital
            // 
            dgvNetCapital.AllowUserToAddRows = false;
            dgvNetCapital.AllowUserToDeleteRows = false;
            dgvNetCapital.AllowUserToResizeColumns = false;
            dgvNetCapital.AllowUserToResizeRows = false;
            dgvNetCapital.BackgroundColor = Color.White;
            dgvNetCapital.BorderStyle = BorderStyle.None;
            dgvNetCapital.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvNetCapital.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNetCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNetCapital.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNetCapital.Columns.AddRange(new DataGridViewColumn[] { date, Column3, purchasePrice, SellingPrice, Column1, Column2, Column4, Column5, delete, info });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNetCapital.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNetCapital.Dock = DockStyle.Fill;
            dgvNetCapital.EnableHeadersVisualStyles = false;
            dgvNetCapital.GridColor = Color.White;
            dgvNetCapital.Location = new Point(5, 8);
            dgvNetCapital.Name = "dgvNetCapital";
            dgvNetCapital.ReadOnly = true;
            dgvNetCapital.RightToLeft = RightToLeft.Yes;
            dgvNetCapital.RowHeadersVisible = false;
            dgvNetCapital.RowHeadersWidth = 25;
            dgvNetCapital.RowTemplate.DividerHeight = 1;
            dgvNetCapital.RowTemplate.Height = 28;
            dgvNetCapital.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNetCapital.Size = new Size(926, 564);
            dgvNetCapital.TabIndex = 1;
            dgvNetCapital.CellClick += dgvSelling_CellClick;
            dgvNetCapital.CellMouseEnter += dgvSelling_CellMouseEnter;
            dgvNetCapital.CellMouseLeave += dgvSelling_CellMouseLeave;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "التاريخ";
            date.MinimumWidth = 2;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 42.3619156F;
            Column3.HeaderText = "المخزن";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // purchasePrice
            // 
            purchasePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            purchasePrice.FillWeight = 44.861515F;
            purchasePrice.HeaderText = "السيارات";
            purchasePrice.Name = "purchasePrice";
            purchasePrice.ReadOnly = true;
            // 
            // SellingPrice
            // 
            SellingPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellingPrice.DefaultCellStyle = dataGridViewCellStyle2;
            SellingPrice.FillWeight = 47.66477F;
            SellingPrice.HeaderText = "الخزينه";
            SellingPrice.Name = "SellingPrice";
            SellingPrice.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "أمين";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "العملاء";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "الموردين";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "الاجمالي";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 18.794508F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.Name = "delete";
            delete.ReadOnly = true;
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
            btnAddStore.Text = "لقطـــــــه";
            btnAddStore.TextColor = Color.White;
            btnAddStore.UseVisualStyleBackColor = false;
            btnAddStore.Click += btnAddSelling_Click;
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
            // NetCpitalFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlstore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NetCpitalFRM";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingFRM";
            pnlstore.ResumeLayout(false);
            pnlstore.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNetCapital).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton btnAddStore;
        private customs.KhPanel khPanel1;
        private DataGridView dgvNetCapital;
        public Panel pnlstore;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn purchasePrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn info;
        private customs.KhControles.KhButton btnreport;
    }
}