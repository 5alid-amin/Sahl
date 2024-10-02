namespace Sahll.JUI.Selling
{
    partial class JustProductFRM
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
            dgvJustProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            purchasePrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            profit = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            btnAddJustProduct = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            pnlstore.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJustProduct).BeginInit();
            SuspendLayout();
            // 
            // pnlstore
            // 
            pnlstore.Controls.Add(btnreport);
            pnlstore.Controls.Add(khPanel1);
            pnlstore.Controls.Add(btnAddJustProduct);
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
            btnreport.Location = new Point(887, 671);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(51, 65);
            btnreport.TabIndex = 105;
            btnreport.TextColor = Color.Transparent;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvJustProduct);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(7, 74);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(936, 587);
            khPanel1.TabIndex = 99;
            // 
            // dgvJustProduct
            // 
            dgvJustProduct.AllowUserToAddRows = false;
            dgvJustProduct.AllowUserToDeleteRows = false;
            dgvJustProduct.AllowUserToResizeColumns = false;
            dgvJustProduct.AllowUserToResizeRows = false;
            dgvJustProduct.BackgroundColor = Color.White;
            dgvJustProduct.BorderStyle = BorderStyle.None;
            dgvJustProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvJustProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJustProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJustProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJustProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, purchasePrice, SellingPrice, profit, edit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvJustProduct.DefaultCellStyle = dataGridViewCellStyle3;
            dgvJustProduct.Dock = DockStyle.Fill;
            dgvJustProduct.EnableHeadersVisualStyles = false;
            dgvJustProduct.GridColor = Color.White;
            dgvJustProduct.Location = new Point(5, 8);
            dgvJustProduct.Name = "dgvJustProduct";
            dgvJustProduct.ReadOnly = true;
            dgvJustProduct.RightToLeft = RightToLeft.Yes;
            dgvJustProduct.RowHeadersVisible = false;
            dgvJustProduct.RowHeadersWidth = 25;
            dgvJustProduct.RowTemplate.DividerHeight = 1;
            dgvJustProduct.RowTemplate.Height = 28;
            dgvJustProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJustProduct.Size = new Size(926, 564);
            dgvJustProduct.TabIndex = 1;
            dgvJustProduct.CellClick += dgvSelling_CellClick;
            dgvJustProduct.CellMouseEnter += dgvSelling_CellMouseEnter;
            dgvJustProduct.CellMouseLeave += dgvSelling_CellMouseLeave;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 226.23378F;
            Column1.HeaderText = "الصنف";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            // btnAddJustProduct
            // 
            btnAddJustProduct.Anchor = AnchorStyles.None;
            btnAddJustProduct.BackColor = Color.FromArgb(173, 109, 209);
            btnAddJustProduct.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnAddJustProduct.BorderColor = Color.FromArgb(63, 36, 114);
            btnAddJustProduct.BorderRadius = 40;
            btnAddJustProduct.BorderSize = 0;
            btnAddJustProduct.Cursor = Cursors.Hand;
            btnAddJustProduct.FlatAppearance.BorderSize = 0;
            btnAddJustProduct.FlatStyle = FlatStyle.Flat;
            btnAddJustProduct.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddJustProduct.ForeColor = Color.White;
            btnAddJustProduct.Location = new Point(380, 673);
            btnAddJustProduct.Name = "btnAddJustProduct";
            btnAddJustProduct.Size = new Size(185, 63);
            btnAddJustProduct.TabIndex = 98;
            btnAddJustProduct.Text = "إضافه";
            btnAddJustProduct.TextColor = Color.White;
            btnAddJustProduct.UseVisualStyleBackColor = false;
            btnAddJustProduct.Click += btnAddSelling_Click;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.BorderStyle = BorderStyle.None;
            txtsearch.Font = new Font("Hacen Egypt", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = Color.FromArgb(63, 36, 114);
            txtsearch.Location = new Point(34, 10);
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
            khButton3.Location = new Point(3, 8);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(323, 52);
            khButton3.TabIndex = 87;
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // JustProductFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlstore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "JustProductFRM";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingFRM";
            pnlstore.ResumeLayout(false);
            pnlstore.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJustProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton btnAddJustProduct;
        private customs.KhPanel khPanel1;
        private DataGridView dgvJustProduct;
        public Panel pnlstore;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn purchasePrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn profit;
        private DataGridViewImageColumn edit;
        private customs.KhControles.KhButton btnreport;
    }
}