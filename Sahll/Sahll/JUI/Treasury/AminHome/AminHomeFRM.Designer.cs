namespace Sahll.JUI.Treasury
{
    partial class AminHomeFRM
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
            pnlaminhome = new Panel();
            khPanel2 = new customs.KhPanel();
            dgvdeposit = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            delete2 = new DataGridViewImageColumn();
            edit2 = new DataGridViewImageColumn();
            info2 = new DataGridViewImageColumn();
            pictureBox1 = new PictureBox();
            khPanel1 = new customs.KhPanel();
            dgvwithdraw = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            DpToStore = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFromStore = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label3 = new Label();
            label4 = new Label();
            btnadd = new customs.KhControles.KhButton();
            khDeposittotal = new customs.KhControles.KhButton();
            lbltotalwithdraw = new customs.KhControles.KhButton();
            label6 = new Label();
            label5 = new Label();
            pnlaminhome.SuspendLayout();
            khPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdeposit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvwithdraw).BeginInit();
            SuspendLayout();
            // 
            // pnlaminhome
            // 
            pnlaminhome.Controls.Add(khPanel2);
            pnlaminhome.Controls.Add(pictureBox1);
            pnlaminhome.Controls.Add(khPanel1);
            pnlaminhome.Controls.Add(DpToStore);
            pnlaminhome.Controls.Add(label2);
            pnlaminhome.Controls.Add(khButton1);
            pnlaminhome.Controls.Add(DpFromStore);
            pnlaminhome.Controls.Add(label1);
            pnlaminhome.Controls.Add(khButton2);
            pnlaminhome.Controls.Add(txtsearch);
            pnlaminhome.Controls.Add(khButton3);
            pnlaminhome.Controls.Add(label3);
            pnlaminhome.Controls.Add(label4);
            pnlaminhome.Controls.Add(btnadd);
            pnlaminhome.Controls.Add(khDeposittotal);
            pnlaminhome.Controls.Add(lbltotalwithdraw);
            pnlaminhome.Controls.Add(label6);
            pnlaminhome.Controls.Add(label5);
            pnlaminhome.Dock = DockStyle.Fill;
            pnlaminhome.Location = new Point(20, 0);
            pnlaminhome.Name = "pnlaminhome";
            pnlaminhome.Size = new Size(945, 750);
            pnlaminhome.TabIndex = 0;
            pnlaminhome.Paint += pnlaminhome_Paint;
            pnlaminhome.Resize += pnltreasury_Resize;
            // 
            // khPanel2
            // 
            khPanel2.Anchor = AnchorStyles.Left;
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 30;
            khPanel2.Controls.Add(dgvdeposit);
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel2.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel2.Location = new Point(0, 102);
            khPanel2.Margin = new Padding(0);
            khPanel2.Name = "khPanel2";
            khPanel2.Padding = new Padding(5, 8, 5, 15);
            khPanel2.Size = new Size(471, 591);
            khPanel2.TabIndex = 116;
            // 
            // dgvdeposit
            // 
            dgvdeposit.AllowUserToAddRows = false;
            dgvdeposit.AllowUserToDeleteRows = false;
            dgvdeposit.AllowUserToResizeColumns = false;
            dgvdeposit.AllowUserToResizeRows = false;
            dgvdeposit.BackgroundColor = Color.White;
            dgvdeposit.BorderStyle = BorderStyle.None;
            dgvdeposit.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvdeposit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdeposit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdeposit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdeposit.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, delete2, edit2, info2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvdeposit.DefaultCellStyle = dataGridViewCellStyle2;
            dgvdeposit.Dock = DockStyle.Fill;
            dgvdeposit.EnableHeadersVisualStyles = false;
            dgvdeposit.GridColor = Color.White;
            dgvdeposit.Location = new Point(5, 8);
            dgvdeposit.Name = "dgvdeposit";
            dgvdeposit.ReadOnly = true;
            dgvdeposit.RightToLeft = RightToLeft.Yes;
            dgvdeposit.RowHeadersVisible = false;
            dgvdeposit.RowHeadersWidth = 25;
            dgvdeposit.RowTemplate.DividerHeight = 1;
            dgvdeposit.RowTemplate.Height = 28;
            dgvdeposit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdeposit.Size = new Size(461, 568);
            dgvdeposit.TabIndex = 2;
            dgvdeposit.CellClick += dgvdeposit_CellClick;
            dgvdeposit.CellContentClick += dgvdeposit_CellContentClick;
            dgvdeposit.CellMouseEnter += dgvdeposit_CellMouseEnter;
            dgvdeposit.CellMouseLeave += dgvdeposit_CellMouseLeave;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 243.292572F;
            dataGridViewTextBoxColumn1.HeaderText = "اليوم";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 199.250214F;
            dataGridViewTextBoxColumn2.HeaderText = "المبلغ";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // delete2
            // 
            delete2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete2.FillWeight = 43.2940979F;
            delete2.HeaderText = "";
            delete2.Image = Properties.Resources.deletel1;
            delete2.Name = "delete2";
            delete2.ReadOnly = true;
            // 
            // edit2
            // 
            edit2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit2.FillWeight = 42.0049171F;
            edit2.HeaderText = "";
            edit2.Image = Properties.Resources.editl;
            edit2.Name = "edit2";
            edit2.ReadOnly = true;
            // 
            // info2
            // 
            info2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info2.FillWeight = 40.7541F;
            info2.HeaderText = "";
            info2.Image = Properties.Resources.infol;
            info2.Name = "info2";
            info2.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.todayl;
            pictureBox1.Location = new Point(703, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 115;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvwithdraw);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(472, 102);
            khPanel1.Margin = new Padding(0);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(471, 591);
            khPanel1.TabIndex = 111;
            // 
            // dgvwithdraw
            // 
            dgvwithdraw.AllowUserToAddRows = false;
            dgvwithdraw.AllowUserToDeleteRows = false;
            dgvwithdraw.AllowUserToResizeColumns = false;
            dgvwithdraw.AllowUserToResizeRows = false;
            dgvwithdraw.BackgroundColor = Color.White;
            dgvwithdraw.BorderStyle = BorderStyle.None;
            dgvwithdraw.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvwithdraw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvwithdraw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvwithdraw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvwithdraw.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, delete, edit, info });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvwithdraw.DefaultCellStyle = dataGridViewCellStyle4;
            dgvwithdraw.Dock = DockStyle.Fill;
            dgvwithdraw.EnableHeadersVisualStyles = false;
            dgvwithdraw.GridColor = Color.White;
            dgvwithdraw.Location = new Point(5, 8);
            dgvwithdraw.Name = "dgvwithdraw";
            dgvwithdraw.ReadOnly = true;
            dgvwithdraw.RightToLeft = RightToLeft.Yes;
            dgvwithdraw.RowHeadersVisible = false;
            dgvwithdraw.RowHeadersWidth = 25;
            dgvwithdraw.RowTemplate.DividerHeight = 1;
            dgvwithdraw.RowTemplate.Height = 28;
            dgvwithdraw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvwithdraw.Size = new Size(461, 568);
            dgvwithdraw.TabIndex = 1;
            dgvwithdraw.CellClick += dgvwithdraw_CellClick;
            dgvwithdraw.CellMouseEnter += dgvwithdraw_CellMouseEnter;
            dgvwithdraw.CellMouseLeave += dgvwithdraw_CellMouseLeave;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 243.292572F;
            Column1.HeaderText = "اليوم";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 199.250214F;
            Column3.HeaderText = "المبلغ";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 43.2940979F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit.FillWeight = 42.0049171F;
            edit.HeaderText = "";
            edit.Image = Properties.Resources.editl;
            edit.Name = "edit";
            edit.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 40.7541F;
            info.HeaderText = "";
            info.Image = Properties.Resources.infol;
            info.Name = "info";
            info.ReadOnly = true;
            // 
            // DpToStore
            // 
            DpToStore.Anchor = AnchorStyles.Right;
            DpToStore.BorderColor = Color.White;
            DpToStore.BorderSize = 0;
            DpToStore.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToStore.Format = DateTimePickerFormat.Short;
            DpToStore.Location = new Point(531, 14);
            DpToStore.MinimumSize = new Size(0, 35);
            DpToStore.Name = "DpToStore";
            DpToStore.Size = new Size(120, 46);
            DpToStore.SkinColor = Color.Transparent;
            DpToStore.TabIndex = 105;
            DpToStore.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 109, 209);
            label2.Location = new Point(649, 14);
            label2.Name = "label2";
            label2.Size = new Size(39, 44);
            label2.TabIndex = 106;
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
            khButton1.Location = new Point(525, 10);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(167, 52);
            khButton1.TabIndex = 107;
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
            DpFromStore.Location = new Point(773, 14);
            DpFromStore.MinimumSize = new Size(0, 35);
            DpFromStore.Name = "DpFromStore";
            DpFromStore.Size = new Size(120, 46);
            DpFromStore.SkinColor = Color.Transparent;
            DpFromStore.TabIndex = 102;
            DpFromStore.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.Location = new Point(890, 12);
            label1.Name = "label1";
            label1.Size = new Size(37, 44);
            label1.TabIndex = 103;
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
            khButton2.Location = new Point(767, 10);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(167, 52);
            khButton2.TabIndex = 104;
            khButton2.TextColor = SystemColors.Window;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.BorderStyle = BorderStyle.None;
            txtsearch.Font = new Font("Hacen Egypt", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = Color.FromArgb(63, 36, 114);
            txtsearch.Location = new Point(32, 8);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(274, 46);
            txtsearch.TabIndex = 101;
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
            khButton3.Location = new Point(1, 6);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(323, 52);
            khButton3.TabIndex = 100;
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(173, 109, 209);
            label3.Location = new Point(432, 61);
            label3.Name = "label3";
            label3.Size = new Size(513, 60);
            label3.TabIndex = 103;
            label3.Text = "السحــــــــــــب";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(173, 109, 209);
            label4.Location = new Point(0, 61);
            label4.Name = "label4";
            label4.Size = new Size(504, 60);
            label4.TabIndex = 103;
            label4.Text = "الإيــــــــــــداع";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.Right;
            btnadd.BackColor = Color.FromArgb(173, 109, 209);
            btnadd.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnadd.BorderColor = Color.FromArgb(63, 36, 114);
            btnadd.BorderRadius = 40;
            btnadd.BorderSize = 0;
            btnadd.Cursor = Cursors.Hand;
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Hacen Egypt", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(384, 668);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(177, 70);
            btnadd.TabIndex = 117;
            btnadd.Text = "إضافه";
            btnadd.TextColor = Color.White;
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnstaff_Click;
            // 
            // khDeposittotal
            // 
            khDeposittotal.Anchor = AnchorStyles.Left;
            khDeposittotal.BackColor = Color.White;
            khDeposittotal.BackgroundColor = Color.White;
            khDeposittotal.BorderColor = Color.FromArgb(119, 67, 219);
            khDeposittotal.BorderRadius = 40;
            khDeposittotal.BorderSize = 1;
            khDeposittotal.Cursor = Cursors.Hand;
            khDeposittotal.FlatAppearance.BorderSize = 0;
            khDeposittotal.FlatStyle = FlatStyle.Flat;
            khDeposittotal.Font = new Font("Hacen Egypt", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khDeposittotal.ForeColor = Color.FromArgb(119, 67, 219);
            khDeposittotal.ImageAlign = ContentAlignment.BottomRight;
            khDeposittotal.Location = new Point(5, 668);
            khDeposittotal.Margin = new Padding(0);
            khDeposittotal.Name = "khDeposittotal";
            khDeposittotal.Size = new Size(220, 65);
            khDeposittotal.TabIndex = 65;
            khDeposittotal.Text = "25664";
            khDeposittotal.TextAlign = ContentAlignment.TopCenter;
            khDeposittotal.TextColor = Color.FromArgb(119, 67, 219);
            khDeposittotal.UseVisualStyleBackColor = false;
            // 
            // lbltotalwithdraw
            // 
            lbltotalwithdraw.Anchor = AnchorStyles.Right;
            lbltotalwithdraw.BackColor = Color.White;
            lbltotalwithdraw.BackgroundColor = Color.White;
            lbltotalwithdraw.BorderColor = Color.FromArgb(119, 67, 219);
            lbltotalwithdraw.BorderRadius = 40;
            lbltotalwithdraw.BorderSize = 1;
            lbltotalwithdraw.Cursor = Cursors.Hand;
            lbltotalwithdraw.FlatAppearance.BorderSize = 0;
            lbltotalwithdraw.FlatStyle = FlatStyle.Flat;
            lbltotalwithdraw.Font = new Font("Hacen Egypt", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalwithdraw.ForeColor = Color.FromArgb(119, 67, 219);
            lbltotalwithdraw.ImageAlign = ContentAlignment.BottomRight;
            lbltotalwithdraw.Location = new Point(602, 668);
            lbltotalwithdraw.Margin = new Padding(0);
            lbltotalwithdraw.Name = "lbltotalwithdraw";
            lbltotalwithdraw.Size = new Size(220, 65);
            lbltotalwithdraw.TabIndex = 65;
            lbltotalwithdraw.Text = "25664";
            lbltotalwithdraw.TextAlign = ContentAlignment.TopCenter;
            lbltotalwithdraw.TextColor = Color.FromArgb(119, 67, 219);
            lbltotalwithdraw.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Hacen Egypt", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(63, 36, 114);
            label6.Location = new Point(228, 664);
            label6.Name = "label6";
            label6.Size = new Size(120, 69);
            label6.TabIndex = 64;
            label6.Text = "الاجمالي";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Hacen Egypt", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(63, 36, 114);
            label5.Location = new Point(825, 664);
            label5.Name = "label5";
            label5.Size = new Size(120, 69);
            label5.TabIndex = 64;
            label5.Text = "الاجمالي";
            // 
            // AminHomeFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlaminhome);
            ForeColor = Color.DarkGoldenrod;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AminHomeFRM";
            Padding = new Padding(20, 0, 20, 0);
            ShowInTaskbar = false;
            Text = "TreasuryFRM";
            pnlaminhome.ResumeLayout(false);
            pnlaminhome.PerformLayout();
            khPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdeposit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvwithdraw).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhPanel khPanel1;
        private DataGridView dgvwithdraw;
        private customs.KhControles.KhDatePicker DpToStore;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFromStore;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        public Panel pnlaminhome;
        private PictureBox pictureBox1;
        private customs.KhPanel khPanel2;
        private Label label3;
        private Label label4;
        private customs.KhControles.KhButton lbltotalwithdraw;
        private Label label5;
        private customs.KhControles.KhButton khDeposittotal;
        private Label label6;
        private customs.KhControles.KhButton btnadd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn info;
        private DataGridView dgvdeposit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn delete2;
        private DataGridViewImageColumn edit2;
        private DataGridViewImageColumn info2;
    }
}