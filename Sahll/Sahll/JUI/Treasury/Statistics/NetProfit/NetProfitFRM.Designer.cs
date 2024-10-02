namespace Sahll.JUI.Selling
{
    partial class NetProfitFRM
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
            pnlstore = new Panel();
            btnreport = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            dgvNetProfit = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            purchasePrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            btnAddStore = new customs.KhControles.KhButton();
            DpToStore = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFromStore = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            pnlstore.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNetProfit).BeginInit();
            SuspendLayout();
            // 
            // pnlstore
            // 
            pnlstore.Controls.Add(btnreport);
            pnlstore.Controls.Add(khPanel1);
            pnlstore.Controls.Add(btnAddStore);
            pnlstore.Controls.Add(DpToStore);
            pnlstore.Controls.Add(label2);
            pnlstore.Controls.Add(khButton1);
            pnlstore.Controls.Add(DpFromStore);
            pnlstore.Controls.Add(label1);
            pnlstore.Controls.Add(khButton2);
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
            btnreport.Location = new Point(885, 666);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(51, 65);
            btnreport.TabIndex = 102;
            btnreport.TextColor = Color.Transparent;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvNetProfit);
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
            // dgvNetProfit
            // 
            dgvNetProfit.AllowUserToAddRows = false;
            dgvNetProfit.AllowUserToDeleteRows = false;
            dgvNetProfit.AllowUserToResizeColumns = false;
            dgvNetProfit.AllowUserToResizeRows = false;
            dgvNetProfit.BackgroundColor = Color.White;
            dgvNetProfit.BorderStyle = BorderStyle.None;
            dgvNetProfit.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvNetProfit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle4.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvNetProfit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvNetProfit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNetProfit.Columns.AddRange(new DataGridViewColumn[] { date, Column3, purchasePrice, SellingPrice, Column1, delete, info });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle6.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvNetProfit.DefaultCellStyle = dataGridViewCellStyle6;
            dgvNetProfit.Dock = DockStyle.Fill;
            dgvNetProfit.EnableHeadersVisualStyles = false;
            dgvNetProfit.GridColor = Color.White;
            dgvNetProfit.Location = new Point(5, 8);
            dgvNetProfit.Name = "dgvNetProfit";
            dgvNetProfit.ReadOnly = true;
            dgvNetProfit.RightToLeft = RightToLeft.Yes;
            dgvNetProfit.RowHeadersVisible = false;
            dgvNetProfit.RowHeadersWidth = 25;
            dgvNetProfit.RowTemplate.DividerHeight = 1;
            dgvNetProfit.RowTemplate.Height = 28;
            dgvNetProfit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNetProfit.Size = new Size(926, 564);
            dgvNetProfit.TabIndex = 1;
            dgvNetProfit.CellClick += dgvSelling_CellClick;
            dgvNetProfit.CellMouseEnter += dgvSelling_CellMouseEnter;
            dgvNetProfit.CellMouseLeave += dgvSelling_CellMouseLeave;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "التاريخ";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 42.3619156F;
            Column3.HeaderText = "المبيعات";
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
            dataGridViewCellStyle5.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellingPrice.DefaultCellStyle = dataGridViewCellStyle5;
            SellingPrice.FillWeight = 47.66477F;
            SellingPrice.HeaderText = "المصروفات";
            SellingPrice.Name = "SellingPrice";
            SellingPrice.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "إجمالي الربح";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            // NetProfitFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlstore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NetProfitFRM";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingFRM";
            pnlstore.ResumeLayout(false);
            pnlstore.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNetProfit).EndInit();
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
        private customs.KhPanel khPanel1;
        public Panel pnlstore;
        private DataGridView dgvNetProfit;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn purchasePrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn info;
        private customs.KhControles.KhButton btnreport;
    }
}