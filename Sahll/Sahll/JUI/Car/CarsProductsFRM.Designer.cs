namespace Sahll.JUI.Car
{
    partial class CarsProductsFRM
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
            pnlcarproduct = new Panel();
            txtsearch = new TextBox();
            khButton4 = new customs.KhControles.KhButton();
            btnreport = new customs.KhControles.KhButton();
            btnaddinventory = new customs.KhControles.KhButton();
            DpToProduct = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFromProduct = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            dgvcarproduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            returnd = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            btncar3 = new customs.KhControles.KhButton();
            btncar4 = new customs.KhControles.KhButton();
            btncar2 = new customs.KhControles.KhButton();
            btncar1 = new customs.KhControles.KhButton();
            btncar5 = new customs.KhControles.KhButton();
            pnlcarproduct.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcarproduct).BeginInit();
            SuspendLayout();
            // 
            // pnlcarproduct
            // 
            pnlcarproduct.Controls.Add(txtsearch);
            pnlcarproduct.Controls.Add(khButton4);
            pnlcarproduct.Controls.Add(btnreport);
            pnlcarproduct.Controls.Add(btnaddinventory);
            pnlcarproduct.Controls.Add(DpToProduct);
            pnlcarproduct.Controls.Add(label2);
            pnlcarproduct.Controls.Add(khButton1);
            pnlcarproduct.Controls.Add(DpFromProduct);
            pnlcarproduct.Controls.Add(label1);
            pnlcarproduct.Controls.Add(khButton2);
            pnlcarproduct.Controls.Add(khPanel1);
            pnlcarproduct.Controls.Add(btncar3);
            pnlcarproduct.Controls.Add(btncar4);
            pnlcarproduct.Controls.Add(btncar2);
            pnlcarproduct.Controls.Add(btncar1);
            pnlcarproduct.Controls.Add(btncar5);
            pnlcarproduct.Dock = DockStyle.Fill;
            pnlcarproduct.Location = new Point(20, 0);
            pnlcarproduct.Name = "pnlcarproduct";
            pnlcarproduct.Size = new Size(945, 750);
            pnlcarproduct.TabIndex = 0;
            pnlcarproduct.Resize += pnlcarproduct_Resize;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.BorderStyle = BorderStyle.None;
            txtsearch.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = Color.FromArgb(63, 36, 114);
            txtsearch.Location = new Point(41, 17);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(274, 45);
            txtsearch.TabIndex = 104;
            txtsearch.TextAlign = HorizontalAlignment.Center;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // khButton4
            // 
            khButton4.BackColor = Color.White;
            khButton4.BackgroundColor = Color.White;
            khButton4.BorderColor = Color.FromArgb(203, 150, 233);
            khButton4.BorderRadius = 40;
            khButton4.BorderSize = 1;
            khButton4.Enabled = false;
            khButton4.FlatAppearance.BorderSize = 0;
            khButton4.FlatStyle = FlatStyle.Flat;
            khButton4.ForeColor = SystemColors.Window;
            khButton4.Image = Properties.Resources.search;
            khButton4.ImageAlign = ContentAlignment.MiddleLeft;
            khButton4.Location = new Point(10, 13);
            khButton4.Name = "khButton4";
            khButton4.Size = new Size(323, 52);
            khButton4.TabIndex = 103;
            khButton4.TextColor = SystemColors.Window;
            khButton4.UseVisualStyleBackColor = false;
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
            btnreport.Location = new Point(891, 665);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(51, 65);
            btnreport.TabIndex = 99;
            btnreport.TextColor = Color.Transparent;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // btnaddinventory
            // 
            btnaddinventory.Anchor = AnchorStyles.None;
            btnaddinventory.BackColor = Color.FromArgb(173, 109, 209);
            btnaddinventory.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnaddinventory.BorderColor = Color.FromArgb(63, 36, 114);
            btnaddinventory.BorderRadius = 40;
            btnaddinventory.BorderSize = 0;
            btnaddinventory.Cursor = Cursors.Hand;
            btnaddinventory.FlatAppearance.BorderSize = 0;
            btnaddinventory.FlatStyle = FlatStyle.Flat;
            btnaddinventory.Font = new Font("Hacen Egypt", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnaddinventory.ForeColor = Color.White;
            btnaddinventory.Location = new Point(384, 668);
            btnaddinventory.Name = "btnaddinventory";
            btnaddinventory.Size = new Size(177, 60);
            btnaddinventory.TabIndex = 68;
            btnaddinventory.Text = "إضافه";
            btnaddinventory.TextColor = Color.White;
            btnaddinventory.UseVisualStyleBackColor = false;
            btnaddinventory.Click += btnaddinventory_Click;
            // 
            // DpToProduct
            // 
            DpToProduct.Anchor = AnchorStyles.Right;
            DpToProduct.BorderColor = Color.White;
            DpToProduct.BorderSize = 0;
            DpToProduct.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToProduct.Format = DateTimePickerFormat.Short;
            DpToProduct.Location = new Point(540, 15);
            DpToProduct.MinimumSize = new Size(0, 35);
            DpToProduct.Name = "DpToProduct";
            DpToProduct.Size = new Size(120, 46);
            DpToProduct.SkinColor = Color.Transparent;
            DpToProduct.TabIndex = 75;
            DpToProduct.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 109, 209);
            label2.Location = new Point(658, 15);
            label2.Name = "label2";
            label2.Size = new Size(39, 44);
            label2.TabIndex = 76;
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
            khButton1.Location = new Point(534, 11);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(167, 52);
            khButton1.TabIndex = 77;
            khButton1.TextColor = SystemColors.Window;
            khButton1.UseVisualStyleBackColor = false;
            // 
            // DpFromProduct
            // 
            DpFromProduct.Anchor = AnchorStyles.Right;
            DpFromProduct.BorderColor = Color.White;
            DpFromProduct.BorderSize = 0;
            DpFromProduct.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFromProduct.Format = DateTimePickerFormat.Short;
            DpFromProduct.Location = new Point(782, 15);
            DpFromProduct.MinimumSize = new Size(0, 35);
            DpFromProduct.Name = "DpFromProduct";
            DpFromProduct.Size = new Size(120, 46);
            DpFromProduct.SkinColor = Color.Transparent;
            DpFromProduct.TabIndex = 72;
            DpFromProduct.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.Location = new Point(899, 13);
            label1.Name = "label1";
            label1.Size = new Size(37, 44);
            label1.TabIndex = 73;
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
            khButton2.Location = new Point(776, 11);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(167, 52);
            khButton2.TabIndex = 74;
            khButton2.TextColor = SystemColors.Window;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvcarproduct);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(3, 133);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(940, 532);
            khPanel1.TabIndex = 33;
            // 
            // dgvcarproduct
            // 
            dgvcarproduct.AllowUserToAddRows = false;
            dgvcarproduct.AllowUserToDeleteRows = false;
            dgvcarproduct.AllowUserToResizeColumns = false;
            dgvcarproduct.AllowUserToResizeRows = false;
            dgvcarproduct.BackgroundColor = Color.White;
            dgvcarproduct.BorderStyle = BorderStyle.None;
            dgvcarproduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvcarproduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Shorooq_N1", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcarproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcarproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcarproduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, delete, edit, returnd, info });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Shorooq_N1", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvcarproduct.DefaultCellStyle = dataGridViewCellStyle3;
            dgvcarproduct.Dock = DockStyle.Fill;
            dgvcarproduct.EnableHeadersVisualStyles = false;
            dgvcarproduct.GridColor = Color.White;
            dgvcarproduct.Location = new Point(5, 8);
            dgvcarproduct.Name = "dgvcarproduct";
            dgvcarproduct.ReadOnly = true;
            dgvcarproduct.RightToLeft = RightToLeft.Yes;
            dgvcarproduct.RowHeadersVisible = false;
            dgvcarproduct.RowHeadersWidth = 25;
            dgvcarproduct.RowTemplate.DividerHeight = 1;
            dgvcarproduct.RowTemplate.Height = 28;
            dgvcarproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvcarproduct.Size = new Size(930, 509);
            dgvcarproduct.TabIndex = 1;
            dgvcarproduct.CellClick += dgvcarproduct_CellClick;
            dgvcarproduct.CellContentClick += dgvcarproduct_CellContentClick;
            dgvcarproduct.CellMouseEnter += dgvcarproduct_CellMouseEnter;
            dgvcarproduct.CellMouseLeave += dgvcarproduct_CellMouseLeave;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 133.952011F;
            Column1.HeaderText = "الصنف";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 62.51095F;
            Column2.HeaderText = "السعر";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 66.9760056F;
            Column3.HeaderText = "الكميه";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 53.5808144F;
            Column4.HeaderText = "اليوم";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 13.1277208F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit.FillWeight = 13.1277208F;
            edit.HeaderText = "";
            edit.Image = Properties.Resources.editl;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.Name = "edit";
            edit.ReadOnly = true;
            // 
            // returnd
            // 
            returnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            returnd.FillWeight = 13.1277208F;
            returnd.HeaderText = "";
            returnd.Image = Properties.Resources.returnedl;
            returnd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            returnd.Name = "returnd";
            returnd.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 15.0858421F;
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
            btncar3.Location = new Point(379, 74);
            btncar3.Margin = new Padding(0);
            btncar3.Name = "btncar3";
            btncar3.Size = new Size(190, 39);
            btncar3.TabIndex = 31;
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
            btncar4.Location = new Point(190, 74);
            btncar4.Margin = new Padding(0);
            btncar4.Name = "btncar4";
            btncar4.Size = new Size(190, 39);
            btncar4.TabIndex = 29;
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
            btncar2.Location = new Point(564, 74);
            btncar2.Margin = new Padding(0);
            btncar2.Name = "btncar2";
            btncar2.Size = new Size(190, 39);
            btncar2.TabIndex = 32;
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
            btncar1.Location = new Point(743, 73);
            btncar1.Margin = new Padding(0);
            btncar1.Name = "btncar1";
            btncar1.Size = new Size(201, 40);
            btncar1.TabIndex = 28;
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
            btncar5.Location = new Point(-1, 73);
            btncar5.Margin = new Padding(0);
            btncar5.Name = "btncar5";
            btncar5.Size = new Size(199, 40);
            btncar5.TabIndex = 30;
            btncar5.Text = "سياره 5";
            btncar5.TextColor = Color.FromArgb(119, 67, 219);
            btncar5.UseVisualStyleBackColor = false;
            btncar5.Click += btncar5_Click;
            // 
            // CarsProductsFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlcarproduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarsProductsFRM";
            Padding = new Padding(20, 0, 20, 0);
            ShowInTaskbar = false;
            Text = "CarProductFRM";
            pnlcarproduct.ResumeLayout(false);
            pnlcarproduct.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvcarproduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhControles.KhButton btncar3;
        private customs.KhControles.KhButton btncar4;
        private customs.KhControles.KhButton btncar2;
        private customs.KhControles.KhButton btncar1;
        private customs.KhControles.KhButton btncar5;
        public Panel pnlcarproduct;
        private customs.KhPanel khPanel1;
        private DataGridView dgvcarproduct;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn returnd;
        private DataGridViewImageColumn info;
        private customs.KhControles.KhDatePicker DpToProduct;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFromProduct;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private customs.KhControles.KhButton btnaddinventory;
        private customs.KhControles.KhButton btnreport;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton4;
    }
}