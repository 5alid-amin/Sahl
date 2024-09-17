namespace Sahll.JUI.Selling
{
    partial class ReceiptsFRM
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
            pnlselling = new Panel();
            khPanel1 = new customs.KhPanel();
            dgvReceipts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            day = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            btnAddReceipts = new customs.KhControles.KhButton();
            lbltotal = new customs.KhControles.KhButton();
            DpToReceipts = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFromReceipts = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label3 = new Label();
            pnlselling.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).BeginInit();
            SuspendLayout();
            // 
            // pnlselling
            // 
            pnlselling.Controls.Add(khPanel1);
            pnlselling.Controls.Add(btnAddReceipts);
            pnlselling.Controls.Add(lbltotal);
            pnlselling.Controls.Add(DpToReceipts);
            pnlselling.Controls.Add(label2);
            pnlselling.Controls.Add(khButton1);
            pnlselling.Controls.Add(DpFromReceipts);
            pnlselling.Controls.Add(label1);
            pnlselling.Controls.Add(khButton2);
            pnlselling.Controls.Add(txtsearch);
            pnlselling.Controls.Add(khButton3);
            pnlselling.Controls.Add(label3);
            pnlselling.Dock = DockStyle.Fill;
            pnlselling.Location = new Point(20, 0);
            pnlselling.Name = "pnlselling";
            pnlselling.Size = new Size(945, 750);
            pnlselling.TabIndex = 0;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvReceipts);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(2, 77);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(940, 587);
            khPanel1.TabIndex = 99;
            // 
            // dgvReceipts
            // 
            dgvReceipts.AllowUserToAddRows = false;
            dgvReceipts.AllowUserToDeleteRows = false;
            dgvReceipts.AllowUserToResizeColumns = false;
            dgvReceipts.AllowUserToResizeRows = false;
            dgvReceipts.BackgroundColor = Color.White;
            dgvReceipts.BorderStyle = BorderStyle.None;
            dgvReceipts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvReceipts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceipts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, day, delete, edit, info });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReceipts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReceipts.Dock = DockStyle.Fill;
            dgvReceipts.EnableHeadersVisualStyles = false;
            dgvReceipts.GridColor = Color.White;
            dgvReceipts.Location = new Point(5, 8);
            dgvReceipts.Name = "dgvReceipts";
            dgvReceipts.ReadOnly = true;
            dgvReceipts.RightToLeft = RightToLeft.Yes;
            dgvReceipts.RowHeadersVisible = false;
            dgvReceipts.RowHeadersWidth = 25;
            dgvReceipts.RowTemplate.DividerHeight = 1;
            dgvReceipts.RowTemplate.Height = 28;
            dgvReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceipts.Size = new Size(930, 564);
            dgvReceipts.TabIndex = 1;
            dgvReceipts.CellClick += dgvSelling_CellClick;
            dgvReceipts.CellMouseEnter += dgvSelling_CellMouseEnter;
            dgvReceipts.CellMouseLeave += dgvSelling_CellMouseLeave;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 227.15538F;
            Column1.HeaderText = "البيان";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 44.1578979F;
            Column2.HeaderText = "المبلغ";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 42.9802F;
            Column3.HeaderText = "اليوم";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // day
            // 
            day.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            day.FillWeight = 92.15459F;
            day.HeaderText = "التاريخ";
            day.Name = "day";
            day.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 24.7848625F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit.FillWeight = 18.8710728F;
            edit.HeaderText = "";
            edit.Image = Properties.Resources.editl;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.Name = "edit";
            edit.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 21.68586F;
            info.HeaderText = "";
            info.Image = Properties.Resources.infol;
            info.Name = "info";
            info.ReadOnly = true;
            // 
            // btnAddReceipts
            // 
            btnAddReceipts.Anchor = AnchorStyles.None;
            btnAddReceipts.BackColor = Color.FromArgb(173, 109, 209);
            btnAddReceipts.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnAddReceipts.BorderColor = Color.FromArgb(63, 36, 114);
            btnAddReceipts.BorderRadius = 40;
            btnAddReceipts.BorderSize = 0;
            btnAddReceipts.Cursor = Cursors.Hand;
            btnAddReceipts.FlatAppearance.BorderSize = 0;
            btnAddReceipts.FlatStyle = FlatStyle.Flat;
            btnAddReceipts.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddReceipts.ForeColor = Color.White;
            btnAddReceipts.Location = new Point(380, 673);
            btnAddReceipts.Name = "btnAddReceipts";
            btnAddReceipts.Size = new Size(185, 63);
            btnAddReceipts.TabIndex = 98;
            btnAddReceipts.Text = "إضافه";
            btnAddReceipts.TextColor = Color.White;
            btnAddReceipts.UseVisualStyleBackColor = false;
            btnAddReceipts.Click += btnAddSelling_Click;
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
            // DpToReceipts
            // 
            DpToReceipts.Anchor = AnchorStyles.Right;
            DpToReceipts.BorderColor = Color.White;
            DpToReceipts.BorderSize = 0;
            DpToReceipts.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToReceipts.Format = DateTimePickerFormat.Short;
            DpToReceipts.Location = new Point(533, 16);
            DpToReceipts.MinimumSize = new Size(0, 35);
            DpToReceipts.Name = "DpToReceipts";
            DpToReceipts.Size = new Size(120, 46);
            DpToReceipts.SkinColor = Color.Transparent;
            DpToReceipts.TabIndex = 92;
            DpToReceipts.TextColor = Color.FromArgb(63, 36, 114);
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
            // DpFromReceipts
            // 
            DpFromReceipts.Anchor = AnchorStyles.Right;
            DpFromReceipts.BorderColor = Color.White;
            DpFromReceipts.BorderSize = 0;
            DpFromReceipts.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFromReceipts.Format = DateTimePickerFormat.Short;
            DpFromReceipts.Location = new Point(775, 16);
            DpFromReceipts.MinimumSize = new Size(0, 35);
            DpFromReceipts.Name = "DpFromReceipts";
            DpFromReceipts.Size = new Size(120, 46);
            DpFromReceipts.SkinColor = Color.Transparent;
            DpFromReceipts.TabIndex = 89;
            DpFromReceipts.TextColor = Color.FromArgb(63, 36, 114);
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
            // ReceiptsFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlselling);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceiptsFRM";
            Padding = new Padding(20, 0, 20, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingFRM";
            pnlselling.ResumeLayout(false);
            pnlselling.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhControles.KhDatePicker DpToReceipts;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFromReceipts;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton btnAddReceipts;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhPanel khPanel1;
        private DataGridView dgvReceipts;
        public Panel pnlselling;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn day;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn info;
    }
}