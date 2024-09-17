namespace Sahll.JUI.Selling
{
    partial class CustomerFrm
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
            khPanel1 = new customs.KhPanel();
            dgvSelling = new DataGridView();
            btnAddSelling = new customs.KhControles.KhButton();
            lbltotal = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            account = new DataGridViewImageColumn();
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
            dgvSelling.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, delete, edit, account });
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
            btnAddSelling.Text = "إضافه";
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
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 191.4675F;
            Column1.HeaderText = "الإسم";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 64.92151F;
            Column4.HeaderText = "الهاتف";
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
            // account
            // 
            account.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            account.FillWeight = 18.27884F;
            account.HeaderText = "";
            account.Image = Properties.Resources.accountl;
            account.Name = "account";
            account.ReadOnly = true;
            // 
            // CustomerFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlselling);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerFrm";
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
        private customs.KhControles.KhButton btnAddSelling;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhPanel khPanel1;
        private DataGridView dgvSelling;
        public Panel pnlselling;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn account;
    }
}