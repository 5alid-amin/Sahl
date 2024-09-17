namespace Sahll.JUI.Selling
{
    partial class SellingFRM
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
            dgvSelling = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            day = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            returnd = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            btnAddSelling = new customs.KhControles.KhButton();
            lbltotal = new customs.KhControles.KhButton();
            DpToSelling = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFromSelling = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label3 = new Label();
            pnlselling.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelling).BeginInit();
            SuspendLayout();
            // 
            // pnlselling
            // 
            pnlselling.Controls.Add(khPanel1);
            pnlselling.Controls.Add(btnAddSelling);
            pnlselling.Controls.Add(lbltotal);
            pnlselling.Controls.Add(DpToSelling);
            pnlselling.Controls.Add(label2);
            pnlselling.Controls.Add(khButton1);
            pnlselling.Controls.Add(DpFromSelling);
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
            khPanel1.Controls.Add(dgvSelling);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(5, 74);
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
            dgvSelling.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, day, Column4, delete, edit, returnd, info });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSelling.DefaultCellStyle = dataGridViewCellStyle3;
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
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 191.4675F;
            Column1.HeaderText = "الصنف";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 37.2203445F;
            Column2.HeaderText = "السعر";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 61.0211F;
            Column3.HeaderText = "الكميه";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // day
            // 
            day.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            day.FillWeight = 50.8606262F;
            day.HeaderText = "الإجمالي";
            day.Name = "day";
            day.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 64.92151F;
            Column4.HeaderText = "اليوم";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 15.9062777F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit.FillWeight = 15.9062777F;
            edit.HeaderText = "";
            edit.Image = Properties.Resources.editl;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.Name = "edit";
            edit.ReadOnly = true;
            // 
            // returnd
            // 
            returnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            returnd.FillWeight = 15.9062777F;
            returnd.HeaderText = "";
            returnd.Image = Properties.Resources.returnedl;
            returnd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            returnd.Name = "returnd";
            returnd.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 18.27884F;
            info.HeaderText = "";
            info.Image = Properties.Resources.infol;
            info.Name = "info";
            info.ReadOnly = true;
            // 
            // btnAddSelling
            // 
            btnAddSelling.Anchor = AnchorStyles.None;
            btnAddSelling.BackColor = Color.FromArgb(173, 109, 209);
            btnAddSelling.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnAddSelling.BorderColor = Color.FromArgb(63, 36, 114);
            btnAddSelling.BorderRadius = 40;
            btnAddSelling.BorderSize = 0;
            btnAddSelling.Cursor = Cursors.Hand;
            btnAddSelling.FlatAppearance.BorderSize = 0;
            btnAddSelling.FlatStyle = FlatStyle.Flat;
            btnAddSelling.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSelling.ForeColor = Color.White;
            btnAddSelling.Location = new Point(380, 673);
            btnAddSelling.Name = "btnAddSelling";
            btnAddSelling.Size = new Size(185, 63);
            btnAddSelling.TabIndex = 98;
            btnAddSelling.Text = "عملية بيع";
            btnAddSelling.TextColor = Color.White;
            btnAddSelling.UseVisualStyleBackColor = false;
            btnAddSelling.Click += btnAddSelling_Click;
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
            // DpToSelling
            // 
            DpToSelling.Anchor = AnchorStyles.Right;
            DpToSelling.BorderColor = Color.White;
            DpToSelling.BorderSize = 0;
            DpToSelling.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToSelling.Format = DateTimePickerFormat.Short;
            DpToSelling.Location = new Point(533, 16);
            DpToSelling.MinimumSize = new Size(0, 35);
            DpToSelling.Name = "DpToSelling";
            DpToSelling.Size = new Size(120, 46);
            DpToSelling.SkinColor = Color.Transparent;
            DpToSelling.TabIndex = 92;
            DpToSelling.TextColor = Color.FromArgb(63, 36, 114);
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
            // DpFromSelling
            // 
            DpFromSelling.Anchor = AnchorStyles.Right;
            DpFromSelling.BorderColor = Color.White;
            DpFromSelling.BorderSize = 0;
            DpFromSelling.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFromSelling.Format = DateTimePickerFormat.Short;
            DpFromSelling.Location = new Point(775, 16);
            DpFromSelling.MinimumSize = new Size(0, 35);
            DpFromSelling.Name = "DpFromSelling";
            DpFromSelling.Size = new Size(120, 46);
            DpFromSelling.SkinColor = Color.Transparent;
            DpFromSelling.TabIndex = 89;
            DpFromSelling.TextColor = Color.FromArgb(63, 36, 114);
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
            // SellingFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlselling);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellingFRM";
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
        private customs.KhControles.KhDatePicker DpToSelling;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFromSelling;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton btnAddSelling;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhPanel khPanel1;
        private DataGridView dgvSelling;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn returnd;
        private DataGridViewImageColumn info;
        public Panel pnlselling;
    }
}