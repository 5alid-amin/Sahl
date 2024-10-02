namespace Sahll.JUI.Car
{
    partial class CarsRecordsFRM
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlcarrecords = new Panel();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            DpToRecords = new customs.KhControles.KhDatePicker();
            lbltotal = new customs.KhControles.KhButton();
            label2 = new Label();
            khPanel4 = new customs.KhPanel();
            dgvcashtotal = new DataGridView();
            cash = new DataGridViewTextBoxColumn();
            information = new DataGridViewImageColumn();
            khButton1 = new customs.KhControles.KhButton();
            khPanel3 = new customs.KhPanel();
            dgvinventory = new DataGridView();
            inventory = new DataGridViewTextBoxColumn();
            inform = new DataGridViewImageColumn();
            DpFromRecords = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khPanel2 = new customs.KhPanel();
            dgvDispatchedpro = new DataGridView();
            Dispatchedproducts = new DataGridViewTextBoxColumn();
            infor = new DataGridViewImageColumn();
            khButton2 = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            dgvsoldproducts = new DataGridView();
            soldproducts = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            btncar3 = new customs.KhControles.KhButton();
            btncar4 = new customs.KhControles.KhButton();
            btncar2 = new customs.KhControles.KhButton();
            btncar1 = new customs.KhControles.KhButton();
            btncar5 = new customs.KhControles.KhButton();
            label3 = new Label();
            pnlcarrecords.SuspendLayout();
            khPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcashtotal).BeginInit();
            khPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvinventory).BeginInit();
            khPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDispatchedpro).BeginInit();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsoldproducts).BeginInit();
            SuspendLayout();
            // 
            // pnlcarrecords
            // 
            pnlcarrecords.Controls.Add(txtsearch);
            pnlcarrecords.Controls.Add(khButton3);
            pnlcarrecords.Controls.Add(DpToRecords);
            pnlcarrecords.Controls.Add(lbltotal);
            pnlcarrecords.Controls.Add(label2);
            pnlcarrecords.Controls.Add(khPanel4);
            pnlcarrecords.Controls.Add(khButton1);
            pnlcarrecords.Controls.Add(khPanel3);
            pnlcarrecords.Controls.Add(DpFromRecords);
            pnlcarrecords.Controls.Add(label1);
            pnlcarrecords.Controls.Add(khPanel2);
            pnlcarrecords.Controls.Add(khButton2);
            pnlcarrecords.Controls.Add(khPanel1);
            pnlcarrecords.Controls.Add(btncar3);
            pnlcarrecords.Controls.Add(btncar4);
            pnlcarrecords.Controls.Add(btncar2);
            pnlcarrecords.Controls.Add(btncar1);
            pnlcarrecords.Controls.Add(btncar5);
            pnlcarrecords.Controls.Add(label3);
            pnlcarrecords.Dock = DockStyle.Fill;
            pnlcarrecords.Location = new Point(20, 0);
            pnlcarrecords.Name = "pnlcarrecords";
            pnlcarrecords.Size = new Size(945, 750);
            pnlcarrecords.TabIndex = 0;
            pnlcarrecords.Resize += pnlcarrecords_Resize;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.BorderStyle = BorderStyle.None;
            txtsearch.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = Color.FromArgb(63, 36, 114);
            txtsearch.Location = new Point(51, 20);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(274, 45);
            txtsearch.TabIndex = 85;
            txtsearch.TextAlign = HorizontalAlignment.Center;
            txtsearch.TextChanged += txtsearch_TextChanged;
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
            khButton3.Location = new Point(20, 16);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(323, 52);
            khButton3.TabIndex = 84;
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // DpToRecords
            // 
            DpToRecords.Anchor = AnchorStyles.Right;
            DpToRecords.BorderColor = Color.White;
            DpToRecords.BorderSize = 0;
            DpToRecords.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToRecords.Format = DateTimePickerFormat.Short;
            DpToRecords.Location = new Point(539, 18);
            DpToRecords.MinimumSize = new Size(0, 35);
            DpToRecords.Name = "DpToRecords";
            DpToRecords.Size = new Size(120, 46);
            DpToRecords.SkinColor = Color.Transparent;
            DpToRecords.TabIndex = 81;
            DpToRecords.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // lbltotal
            // 
            lbltotal.Anchor = AnchorStyles.None;
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
            lbltotal.Location = new Point(277, 670);
            lbltotal.Margin = new Padding(0);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(220, 65);
            lbltotal.TabIndex = 67;
            lbltotal.Text = "25664";
            lbltotal.TextAlign = ContentAlignment.TopCenter;
            lbltotal.TextColor = Color.FromArgb(119, 67, 219);
            lbltotal.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 109, 209);
            label2.Location = new Point(657, 18);
            label2.Name = "label2";
            label2.Size = new Size(39, 44);
            label2.TabIndex = 82;
            label2.Text = "إلي";
            // 
            // khPanel4
            // 
            khPanel4.Anchor = AnchorStyles.Left;
            khPanel4.BackColor = Color.White;
            khPanel4.BorderRadius = 30;
            khPanel4.Controls.Add(dgvcashtotal);
            khPanel4.ForeColor = Color.Black;
            khPanel4.GradientAngle = 90F;
            khPanel4.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel4.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel4.Location = new Point(3, 129);
            khPanel4.Name = "khPanel4";
            khPanel4.Padding = new Padding(5, 8, 5, 15);
            khPanel4.Size = new Size(236, 535);
            khPanel4.TabIndex = 61;
            // 
            // dgvcashtotal
            // 
            dgvcashtotal.AllowUserToAddRows = false;
            dgvcashtotal.AllowUserToDeleteRows = false;
            dgvcashtotal.AllowUserToResizeColumns = false;
            dgvcashtotal.AllowUserToResizeRows = false;
            dgvcashtotal.BackgroundColor = Color.White;
            dgvcashtotal.BorderStyle = BorderStyle.None;
            dgvcashtotal.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvcashtotal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcashtotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcashtotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcashtotal.Columns.AddRange(new DataGridViewColumn[] { cash, information });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvcashtotal.DefaultCellStyle = dataGridViewCellStyle2;
            dgvcashtotal.Dock = DockStyle.Fill;
            dgvcashtotal.EnableHeadersVisualStyles = false;
            dgvcashtotal.GridColor = Color.White;
            dgvcashtotal.Location = new Point(5, 8);
            dgvcashtotal.Name = "dgvcashtotal";
            dgvcashtotal.ReadOnly = true;
            dgvcashtotal.RightToLeft = RightToLeft.Yes;
            dgvcashtotal.RowHeadersVisible = false;
            dgvcashtotal.RowHeadersWidth = 25;
            dgvcashtotal.RowTemplate.DividerHeight = 1;
            dgvcashtotal.RowTemplate.Height = 28;
            dgvcashtotal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvcashtotal.Size = new Size(226, 512);
            dgvcashtotal.TabIndex = 1;
            dgvcashtotal.CellClick += dgvcashtotal_CellClick;
            dgvcashtotal.CellMouseEnter += dgvcashtotal_CellMouseEnter;
            dgvcashtotal.CellMouseLeave += dgvcashtotal_CellMouseLeave;
            // 
            // cash
            // 
            cash.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cash.FillWeight = 96.17076F;
            cash.HeaderText = "النقديه(الصافي)";
            cash.Name = "cash";
            cash.ReadOnly = true;
            // 
            // information
            // 
            information.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            information.FillWeight = 10.8667526F;
            information.HeaderText = "";
            information.Image = Properties.Resources.infol;
            information.Name = "information";
            information.ReadOnly = true;
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
            khButton1.Location = new Point(533, 14);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(167, 52);
            khButton1.TabIndex = 83;
            khButton1.TextColor = SystemColors.Window;
            khButton1.UseVisualStyleBackColor = false;
            // 
            // khPanel3
            // 
            khPanel3.Anchor = AnchorStyles.Left;
            khPanel3.BackColor = Color.White;
            khPanel3.BorderRadius = 30;
            khPanel3.Controls.Add(dgvinventory);
            khPanel3.ForeColor = Color.Black;
            khPanel3.GradientAngle = 90F;
            khPanel3.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel3.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel3.Location = new Point(237, 129);
            khPanel3.Name = "khPanel3";
            khPanel3.Padding = new Padding(5, 8, 5, 15);
            khPanel3.Size = new Size(236, 535);
            khPanel3.TabIndex = 60;
            // 
            // dgvinventory
            // 
            dgvinventory.AllowUserToAddRows = false;
            dgvinventory.AllowUserToDeleteRows = false;
            dgvinventory.AllowUserToResizeColumns = false;
            dgvinventory.AllowUserToResizeRows = false;
            dgvinventory.BackgroundColor = Color.White;
            dgvinventory.BorderStyle = BorderStyle.None;
            dgvinventory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvinventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvinventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvinventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventory.Columns.AddRange(new DataGridViewColumn[] { inventory, inform });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvinventory.DefaultCellStyle = dataGridViewCellStyle4;
            dgvinventory.Dock = DockStyle.Fill;
            dgvinventory.EnableHeadersVisualStyles = false;
            dgvinventory.GridColor = Color.White;
            dgvinventory.Location = new Point(5, 8);
            dgvinventory.Name = "dgvinventory";
            dgvinventory.ReadOnly = true;
            dgvinventory.RightToLeft = RightToLeft.Yes;
            dgvinventory.RowHeadersVisible = false;
            dgvinventory.RowHeadersWidth = 25;
            dgvinventory.RowTemplate.DividerHeight = 1;
            dgvinventory.RowTemplate.Height = 28;
            dgvinventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvinventory.Size = new Size(226, 512);
            dgvinventory.TabIndex = 1;
            dgvinventory.CellClick += dgvinventory_CellClick;
            dgvinventory.CellMouseEnter += dgvinventory_CellMouseEnter;
            dgvinventory.CellMouseLeave += dgvinventory_CellMouseLeave;
            // 
            // inventory
            // 
            inventory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inventory.FillWeight = 96.17076F;
            inventory.HeaderText = "الجرد";
            inventory.Name = "inventory";
            inventory.ReadOnly = true;
            // 
            // inform
            // 
            inform.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inform.FillWeight = 10.8667526F;
            inform.HeaderText = "";
            inform.Image = Properties.Resources.infol;
            inform.Name = "inform";
            inform.ReadOnly = true;
            // 
            // DpFromRecords
            // 
            DpFromRecords.Anchor = AnchorStyles.Right;
            DpFromRecords.BorderColor = Color.White;
            DpFromRecords.BorderSize = 0;
            DpFromRecords.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFromRecords.Format = DateTimePickerFormat.Short;
            DpFromRecords.Location = new Point(781, 18);
            DpFromRecords.MinimumSize = new Size(0, 35);
            DpFromRecords.Name = "DpFromRecords";
            DpFromRecords.Size = new Size(120, 46);
            DpFromRecords.SkinColor = Color.Transparent;
            DpFromRecords.TabIndex = 78;
            DpFromRecords.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.Location = new Point(898, 16);
            label1.Name = "label1";
            label1.Size = new Size(37, 44);
            label1.TabIndex = 79;
            label1.Text = "من";
            // 
            // khPanel2
            // 
            khPanel2.Anchor = AnchorStyles.Left;
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 30;
            khPanel2.Controls.Add(dgvDispatchedpro);
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel2.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel2.Location = new Point(471, 129);
            khPanel2.Name = "khPanel2";
            khPanel2.Padding = new Padding(5, 8, 5, 15);
            khPanel2.Size = new Size(236, 535);
            khPanel2.TabIndex = 59;
            // 
            // dgvDispatchedpro
            // 
            dgvDispatchedpro.AllowUserToAddRows = false;
            dgvDispatchedpro.AllowUserToDeleteRows = false;
            dgvDispatchedpro.AllowUserToResizeColumns = false;
            dgvDispatchedpro.AllowUserToResizeRows = false;
            dgvDispatchedpro.BackgroundColor = Color.White;
            dgvDispatchedpro.BorderStyle = BorderStyle.None;
            dgvDispatchedpro.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDispatchedpro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle5.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDispatchedpro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDispatchedpro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDispatchedpro.Columns.AddRange(new DataGridViewColumn[] { Dispatchedproducts, infor });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle6.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDispatchedpro.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDispatchedpro.Dock = DockStyle.Fill;
            dgvDispatchedpro.EnableHeadersVisualStyles = false;
            dgvDispatchedpro.GridColor = Color.White;
            dgvDispatchedpro.Location = new Point(5, 8);
            dgvDispatchedpro.Name = "dgvDispatchedpro";
            dgvDispatchedpro.ReadOnly = true;
            dgvDispatchedpro.RightToLeft = RightToLeft.Yes;
            dgvDispatchedpro.RowHeadersVisible = false;
            dgvDispatchedpro.RowHeadersWidth = 25;
            dgvDispatchedpro.RowTemplate.DividerHeight = 1;
            dgvDispatchedpro.RowTemplate.Height = 28;
            dgvDispatchedpro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDispatchedpro.Size = new Size(226, 512);
            dgvDispatchedpro.TabIndex = 1;
            dgvDispatchedpro.CellClick += dgvDispatchedpro_CellClick;
            dgvDispatchedpro.CellMouseEnter += dgvDispatchedpro_CellMouseEnter;
            dgvDispatchedpro.CellMouseLeave += dgvDispatchedpro_CellMouseLeave;
            // 
            // Dispatchedproducts
            // 
            Dispatchedproducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dispatchedproducts.FillWeight = 96.17076F;
            Dispatchedproducts.HeaderText = "البضاعه المنصرفه";
            Dispatchedproducts.Name = "Dispatchedproducts";
            Dispatchedproducts.ReadOnly = true;
            // 
            // infor
            // 
            infor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            infor.FillWeight = 10.8667536F;
            infor.HeaderText = "";
            infor.Image = Properties.Resources.infol;
            infor.Name = "infor";
            infor.ReadOnly = true;
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
            khButton2.Location = new Point(775, 14);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(167, 52);
            khButton2.TabIndex = 80;
            khButton2.TextColor = SystemColors.Window;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvsoldproducts);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(705, 129);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(240, 535);
            khPanel1.TabIndex = 58;
            // 
            // dgvsoldproducts
            // 
            dgvsoldproducts.AllowUserToAddRows = false;
            dgvsoldproducts.AllowUserToDeleteRows = false;
            dgvsoldproducts.AllowUserToResizeColumns = false;
            dgvsoldproducts.AllowUserToResizeRows = false;
            dgvsoldproducts.BackgroundColor = Color.White;
            dgvsoldproducts.BorderStyle = BorderStyle.None;
            dgvsoldproducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvsoldproducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle7.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvsoldproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvsoldproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsoldproducts.Columns.AddRange(new DataGridViewColumn[] { soldproducts, info });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle8.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvsoldproducts.DefaultCellStyle = dataGridViewCellStyle8;
            dgvsoldproducts.Dock = DockStyle.Fill;
            dgvsoldproducts.EnableHeadersVisualStyles = false;
            dgvsoldproducts.GridColor = Color.White;
            dgvsoldproducts.Location = new Point(5, 8);
            dgvsoldproducts.Name = "dgvsoldproducts";
            dgvsoldproducts.ReadOnly = true;
            dgvsoldproducts.RightToLeft = RightToLeft.Yes;
            dgvsoldproducts.RowHeadersVisible = false;
            dgvsoldproducts.RowHeadersWidth = 25;
            dgvsoldproducts.RowTemplate.DividerHeight = 1;
            dgvsoldproducts.RowTemplate.Height = 28;
            dgvsoldproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsoldproducts.Size = new Size(230, 512);
            dgvsoldproducts.TabIndex = 1;
            dgvsoldproducts.CellClick += dgvsoldproducts_CellClick;
            dgvsoldproducts.CellMouseEnter += dgvsoldproducts_CellMouseEnter;
            dgvsoldproducts.CellMouseLeave += dgvsoldproducts_CellMouseLeave;
            // 
            // soldproducts
            // 
            soldproducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soldproducts.FillWeight = 96.17076F;
            soldproducts.HeaderText = "البضاعه المباعه";
            soldproducts.Name = "soldproducts";
            soldproducts.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 10.8667536F;
            info.HeaderText = "";
            info.Image = Properties.Resources.infol;
            info.Name = "info";
            info.ReadOnly = true;
            // 
            // btncar3
            // 
            btncar3.Anchor = AnchorStyles.None;
            btncar3.BackColor = Color.FromArgb(255, 251, 245);
            btncar3.BackgroundColor = Color.FromArgb(255, 251, 245);
            btncar3.BorderColor = Color.FromArgb(119, 67, 219);
            btncar3.BorderRadius = 0;
            btncar3.BorderSize = 1;
            btncar3.Cursor = Cursors.Hand;
            btncar3.FlatAppearance.BorderSize = 0;
            btncar3.FlatStyle = FlatStyle.Flat;
            btncar3.Font = new Font("Hacen Egypt", 12F);
            btncar3.ForeColor = Color.FromArgb(119, 67, 219);
            btncar3.ImageAlign = ContentAlignment.BottomRight;
            btncar3.Location = new Point(379, 80);
            btncar3.Margin = new Padding(0);
            btncar3.Name = "btncar3";
            btncar3.Size = new Size(190, 39);
            btncar3.TabIndex = 56;
            btncar3.Text = "سياره 3";
            btncar3.TextColor = Color.FromArgb(119, 67, 219);
            btncar3.UseVisualStyleBackColor = false;
            btncar3.Click += btncar3_Click;
            // 
            // btncar4
            // 
            btncar4.Anchor = AnchorStyles.None;
            btncar4.BackColor = Color.FromArgb(255, 251, 245);
            btncar4.BackgroundColor = Color.FromArgb(255, 251, 245);
            btncar4.BorderColor = Color.FromArgb(119, 67, 219);
            btncar4.BorderRadius = 0;
            btncar4.BorderSize = 1;
            btncar4.Cursor = Cursors.Hand;
            btncar4.FlatAppearance.BorderSize = 0;
            btncar4.FlatStyle = FlatStyle.Flat;
            btncar4.Font = new Font("Hacen Egypt", 12F);
            btncar4.ForeColor = Color.FromArgb(119, 67, 219);
            btncar4.ImageAlign = ContentAlignment.BottomRight;
            btncar4.Location = new Point(190, 80);
            btncar4.Margin = new Padding(0);
            btncar4.Name = "btncar4";
            btncar4.Size = new Size(190, 39);
            btncar4.TabIndex = 54;
            btncar4.Text = "سياره 4";
            btncar4.TextColor = Color.FromArgb(119, 67, 219);
            btncar4.UseVisualStyleBackColor = false;
            btncar4.Click += btncar4_Click;
            // 
            // btncar2
            // 
            btncar2.Anchor = AnchorStyles.None;
            btncar2.BackColor = Color.FromArgb(255, 251, 245);
            btncar2.BackgroundColor = Color.FromArgb(255, 251, 245);
            btncar2.BorderColor = Color.FromArgb(119, 67, 219);
            btncar2.BorderRadius = 0;
            btncar2.BorderSize = 1;
            btncar2.Cursor = Cursors.Hand;
            btncar2.FlatAppearance.BorderSize = 0;
            btncar2.FlatStyle = FlatStyle.Flat;
            btncar2.Font = new Font("Hacen Egypt", 12F);
            btncar2.ForeColor = Color.FromArgb(119, 67, 219);
            btncar2.ImageAlign = ContentAlignment.BottomRight;
            btncar2.Location = new Point(564, 80);
            btncar2.Margin = new Padding(0);
            btncar2.Name = "btncar2";
            btncar2.Size = new Size(190, 39);
            btncar2.TabIndex = 57;
            btncar2.Text = "سياره 2";
            btncar2.TextColor = Color.FromArgb(119, 67, 219);
            btncar2.UseVisualStyleBackColor = false;
            btncar2.Click += btncar2_Click;
            // 
            // btncar1
            // 
            btncar1.Anchor = AnchorStyles.None;
            btncar1.BackColor = Color.FromArgb(255, 251, 245);
            btncar1.BackgroundColor = Color.FromArgb(255, 251, 245);
            btncar1.BorderColor = Color.FromArgb(119, 67, 219);
            btncar1.BorderRadius = 15;
            btncar1.BorderSize = 1;
            btncar1.Cursor = Cursors.Hand;
            btncar1.FlatAppearance.BorderSize = 0;
            btncar1.FlatStyle = FlatStyle.Flat;
            btncar1.Font = new Font("Hacen Egypt", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncar1.ForeColor = Color.FromArgb(119, 67, 219);
            btncar1.ImageAlign = ContentAlignment.BottomRight;
            btncar1.Location = new Point(743, 79);
            btncar1.Margin = new Padding(0);
            btncar1.Name = "btncar1";
            btncar1.Size = new Size(201, 40);
            btncar1.TabIndex = 53;
            btncar1.Text = "سياره 1";
            btncar1.TextAlign = ContentAlignment.TopCenter;
            btncar1.TextColor = Color.FromArgb(119, 67, 219);
            btncar1.UseVisualStyleBackColor = false;
            btncar1.Click += btncar1_Click;
            // 
            // btncar5
            // 
            btncar5.Anchor = AnchorStyles.None;
            btncar5.BackColor = Color.FromArgb(255, 251, 245);
            btncar5.BackgroundColor = Color.FromArgb(255, 251, 245);
            btncar5.BorderColor = Color.FromArgb(119, 67, 219);
            btncar5.BorderRadius = 15;
            btncar5.BorderSize = 1;
            btncar5.Cursor = Cursors.Hand;
            btncar5.FlatAppearance.BorderSize = 0;
            btncar5.FlatStyle = FlatStyle.Flat;
            btncar5.Font = new Font("Hacen Egypt", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncar5.ForeColor = Color.FromArgb(119, 67, 219);
            btncar5.ImageAlign = ContentAlignment.BottomRight;
            btncar5.Location = new Point(-1, 79);
            btncar5.Margin = new Padding(0);
            btncar5.Name = "btncar5";
            btncar5.Size = new Size(199, 40);
            btncar5.TabIndex = 55;
            btncar5.Text = "سياره 5";
            btncar5.TextColor = Color.FromArgb(119, 67, 219);
            btncar5.UseVisualStyleBackColor = false;
            btncar5.Click += btncar5_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Hacen Egypt", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 36, 114);
            label3.Location = new Point(500, 653);
            label3.Name = "label3";
            label3.Size = new Size(172, 99);
            label3.TabIndex = 66;
            label3.Text = "الاجمالي";
            // 
            // CarsRecordsFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlcarrecords);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarsRecordsFRM";
            Padding = new Padding(20, 0, 20, 0);
            Text = "carsrecordsFRM";
            pnlcarrecords.ResumeLayout(false);
            pnlcarrecords.PerformLayout();
            khPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvcashtotal).EndInit();
            khPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvinventory).EndInit();
            khPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDispatchedpro).EndInit();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsoldproducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhControles.KhButton btncar3;
        private customs.KhControles.KhButton btncar4;
        private customs.KhControles.KhButton btncar2;
        private customs.KhControles.KhButton btncar1;
        private customs.KhControles.KhButton btncar5;
        private customs.KhPanel khPanel1;
        private DataGridView dgvsoldproducts;
        private customs.KhPanel khPanel2;
        private DataGridView dgvDispatchedpro;
        private customs.KhPanel khPanel4;
        private DataGridView dgvcashtotal;
        private customs.KhPanel khPanel3;
        private DataGridView dgvinventory;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhControles.KhDatePicker DpToRecords;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFromRecords;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private DataGridViewTextBoxColumn soldproducts;
        private DataGridViewImageColumn info;
        private DataGridViewTextBoxColumn cash;
        private DataGridViewImageColumn information;
        private DataGridViewTextBoxColumn inventory;
        private DataGridViewImageColumn inform;
        private DataGridViewTextBoxColumn Dispatchedproducts;
        private DataGridViewImageColumn infor;
        public Panel pnlcarrecords;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
    }
}