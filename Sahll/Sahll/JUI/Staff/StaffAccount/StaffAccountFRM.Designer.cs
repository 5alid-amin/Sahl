namespace Sahll.JUI.Selling
{
    partial class StaffAccountFRM
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlselling = new Panel();
            btnreport = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            dgvSelling = new DataGridView();
            lbltotal = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            sell = new DataGridViewTextBoxColumn();
            net = new DataGridViewTextBoxColumn();
            PresonalID = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            bouns = new DataGridViewImageColumn();
            rival = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            pnlselling.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelling).BeginInit();
            SuspendLayout();
            // 
            // pnlselling
            // 
            pnlselling.Controls.Add(btnreport);
            pnlselling.Controls.Add(khPanel1);
            pnlselling.Controls.Add(lbltotal);
            pnlselling.Controls.Add(txtsearch);
            pnlselling.Controls.Add(khButton3);
            pnlselling.Controls.Add(label3);
            pnlselling.Dock = DockStyle.Fill;
            pnlselling.Location = new Point(20, 0);
            pnlselling.Name = "pnlselling";
            pnlselling.Size = new Size(945, 750);
            pnlselling.TabIndex = 0;
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
            btnreport.Location = new Point(882, 663);
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
            khPanel1.Controls.Add(dgvSelling);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(5, 75);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(936, 587);
            khPanel1.TabIndex = 99;
            // 
            // dgvSelling
            // 
            dgvSelling.AllowUserToAddRows = false;
            dgvSelling.AllowUserToDeleteRows = false;
            dgvSelling.AllowUserToResizeColumns = false;
            dgvSelling.AllowUserToResizeRows = false;
            dgvSelling.BackgroundColor = Color.White;
            dgvSelling.BorderStyle = BorderStyle.None;
            dgvSelling.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSelling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSelling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelling.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, sell, net, PresonalID, product, Column2, Column3, total, bouns, rival, info });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSelling.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSelling.Dock = DockStyle.Fill;
            dgvSelling.EnableHeadersVisualStyles = false;
            dgvSelling.GridColor = Color.White;
            dgvSelling.Location = new Point(5, 8);
            dgvSelling.Name = "dgvSelling";
            dgvSelling.ReadOnly = true;
            dgvSelling.RightToLeft = RightToLeft.Yes;
            dgvSelling.RowHeadersVisible = false;
            dgvSelling.RowHeadersWidth = 25;
            dgvSelling.RowTemplate.DividerHeight = 1;
            dgvSelling.RowTemplate.Height = 28;
            dgvSelling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelling.Size = new Size(926, 564);
            dgvSelling.TabIndex = 1;
            dgvSelling.CellClick += dgvSelling_CellClick;
            dgvSelling.CellMouseEnter += dgvSelling_CellMouseEnter;
            dgvSelling.CellMouseLeave += dgvSelling_CellMouseLeave;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 155.848816F;
            Column1.HeaderText = "التاريخ";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 78.88697F;
            Column4.HeaderText = "اليوم";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // sell
            // 
            sell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sell.FillWeight = 99.48627F;
            sell.HeaderText = "مبيعات";
            sell.Name = "sell";
            sell.ReadOnly = true;
            // 
            // net
            // 
            net.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            net.FillWeight = 99.48627F;
            net.HeaderText = "النسبه";
            net.Name = "net";
            net.ReadOnly = true;
            // 
            // PresonalID
            // 
            PresonalID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PresonalID.FillWeight = 97.3030243F;
            PresonalID.HeaderText = "السلف";
            PresonalID.Name = "PresonalID";
            PresonalID.ReadOnly = true;
            // 
            // product
            // 
            product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product.FillWeight = 71.52654F;
            product.HeaderText = "آجل";
            product.Name = "product";
            product.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 99.48627F;
            Column2.HeaderText = "مكافأه";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 99.48627F;
            Column3.HeaderText = "خصم";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.FillWeight = 95.7205F;
            total.HeaderText = "الصافي";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // bouns
            // 
            bouns.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bouns.FillWeight = 39.68303F;
            bouns.HeaderText = "";
            bouns.Image = Properties.Resources.bonus;
            bouns.ImageLayout = DataGridViewImageCellLayout.Zoom;
            bouns.Name = "bouns";
            bouns.ReadOnly = true;
            // 
            // rival
            // 
            rival.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rival.FillWeight = 40.14202F;
            rival.HeaderText = "";
            rival.Image = Properties.Resources.rival1;
            rival.ImageLayout = DataGridViewImageCellLayout.Zoom;
            rival.Name = "rival";
            rival.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 29.4247284F;
            info.HeaderText = "";
            info.Image = Properties.Resources.infol;
            info.Name = "info";
            info.ReadOnly = true;
            // 
            // StaffAccountFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlselling);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffAccountFRM";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingFRM";
            pnlselling.ResumeLayout(false);
            pnlselling.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSelling).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhPanel khPanel1;
        private DataGridView dgvSelling;
        public Panel pnlselling;
        private ContextMenuStrip contextMenuStrip1;
        private customs.KhControles.KhButton btnreport;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn sell;
        private DataGridViewTextBoxColumn net;
        private DataGridViewTextBoxColumn PresonalID;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn total;
        private DataGridViewImageColumn bouns;
        private DataGridViewImageColumn rival;
        private DataGridViewImageColumn info;
    }
}