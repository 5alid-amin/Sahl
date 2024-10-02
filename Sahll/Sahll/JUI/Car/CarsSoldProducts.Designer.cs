namespace Sahll.JUI.Car
{
    partial class CarsSoldProducts
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
            pnlcarsoldproduct = new Panel();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            btnreport = new customs.KhControles.KhButton();
            DpToSoldProduct = new customs.KhControles.KhDatePicker();
            lbltotal = new customs.KhControles.KhButton();
            label2 = new Label();
            khPanel1 = new customs.KhPanel();
            dgvcarsoldproduct = new DataGridView();
            khButton1 = new customs.KhControles.KhButton();
            btncar3 = new customs.KhControles.KhButton();
            DpFromSoldProduct = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            btncar4 = new customs.KhControles.KhButton();
            khButton2 = new customs.KhControles.KhButton();
            btncar2 = new customs.KhControles.KhButton();
            btncar1 = new customs.KhControles.KhButton();
            btncar5 = new customs.KhControles.KhButton();
            label3 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            pnlcarsoldproduct.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcarsoldproduct).BeginInit();
            SuspendLayout();
            // 
            // pnlcarsoldproduct
            // 
            pnlcarsoldproduct.Controls.Add(txtsearch);
            pnlcarsoldproduct.Controls.Add(khButton3);
            pnlcarsoldproduct.Controls.Add(btnreport);
            pnlcarsoldproduct.Controls.Add(DpToSoldProduct);
            pnlcarsoldproduct.Controls.Add(lbltotal);
            pnlcarsoldproduct.Controls.Add(label2);
            pnlcarsoldproduct.Controls.Add(khPanel1);
            pnlcarsoldproduct.Controls.Add(khButton1);
            pnlcarsoldproduct.Controls.Add(btncar3);
            pnlcarsoldproduct.Controls.Add(DpFromSoldProduct);
            pnlcarsoldproduct.Controls.Add(label1);
            pnlcarsoldproduct.Controls.Add(btncar4);
            pnlcarsoldproduct.Controls.Add(khButton2);
            pnlcarsoldproduct.Controls.Add(btncar2);
            pnlcarsoldproduct.Controls.Add(btncar1);
            pnlcarsoldproduct.Controls.Add(btncar5);
            pnlcarsoldproduct.Controls.Add(label3);
            pnlcarsoldproduct.Dock = DockStyle.Fill;
            pnlcarsoldproduct.Location = new Point(20, 0);
            pnlcarsoldproduct.Name = "pnlcarsoldproduct";
            pnlcarsoldproduct.Size = new Size(945, 750);
            pnlcarsoldproduct.TabIndex = 0;
            pnlcarsoldproduct.Resize += pnlcarsoldproduct_Resize;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.BorderStyle = BorderStyle.None;
            txtsearch.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = Color.FromArgb(63, 36, 114);
            txtsearch.Location = new Point(51, 15);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(274, 45);
            txtsearch.TabIndex = 103;
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
            khButton3.Location = new Point(20, 11);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(323, 52);
            khButton3.TabIndex = 102;
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
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
            btnreport.Location = new Point(876, 653);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(51, 65);
            btnreport.TabIndex = 101;
            btnreport.TextColor = Color.Transparent;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // DpToSoldProduct
            // 
            DpToSoldProduct.Anchor = AnchorStyles.Right;
            DpToSoldProduct.BorderColor = Color.White;
            DpToSoldProduct.BorderSize = 0;
            DpToSoldProduct.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToSoldProduct.Format = DateTimePickerFormat.Short;
            DpToSoldProduct.Location = new Point(539, 16);
            DpToSoldProduct.MinimumSize = new Size(0, 35);
            DpToSoldProduct.Name = "DpToSoldProduct";
            DpToSoldProduct.Size = new Size(120, 46);
            DpToSoldProduct.SkinColor = Color.Transparent;
            DpToSoldProduct.TabIndex = 87;
            DpToSoldProduct.TextColor = Color.FromArgb(63, 36, 114);
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
            lbltotal.Location = new Point(320, 668);
            lbltotal.Margin = new Padding(0);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(220, 65);
            lbltotal.TabIndex = 63;
            lbltotal.Text = "25664";
            lbltotal.TextAlign = ContentAlignment.TopCenter;
            lbltotal.TextColor = Color.FromArgb(119, 67, 219);
            lbltotal.UseVisualStyleBackColor = false;
            lbltotal.Click += lbltotal_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 109, 209);
            label2.Location = new Point(657, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 44);
            label2.TabIndex = 88;
            label2.Text = "إلي";
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvcarsoldproduct);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(7, 135);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(930, 509);
            khPanel1.TabIndex = 61;
            // 
            // dgvcarsoldproduct
            // 
            dgvcarsoldproduct.AllowUserToAddRows = false;
            dgvcarsoldproduct.AllowUserToDeleteRows = false;
            dgvcarsoldproduct.AllowUserToResizeColumns = false;
            dgvcarsoldproduct.AllowUserToResizeRows = false;
            dgvcarsoldproduct.BackgroundColor = Color.White;
            dgvcarsoldproduct.BorderStyle = BorderStyle.None;
            dgvcarsoldproduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvcarsoldproduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcarsoldproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcarsoldproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcarsoldproduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, info });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvcarsoldproduct.DefaultCellStyle = dataGridViewCellStyle3;
            dgvcarsoldproduct.Dock = DockStyle.Fill;
            dgvcarsoldproduct.EnableHeadersVisualStyles = false;
            dgvcarsoldproduct.GridColor = Color.White;
            dgvcarsoldproduct.Location = new Point(5, 8);
            dgvcarsoldproduct.Name = "dgvcarsoldproduct";
            dgvcarsoldproduct.ReadOnly = true;
            dgvcarsoldproduct.RightToLeft = RightToLeft.Yes;
            dgvcarsoldproduct.RowHeadersVisible = false;
            dgvcarsoldproduct.RowHeadersWidth = 25;
            dgvcarsoldproduct.RowTemplate.DividerHeight = 1;
            dgvcarsoldproduct.RowTemplate.Height = 28;
            dgvcarsoldproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvcarsoldproduct.Size = new Size(920, 486);
            dgvcarsoldproduct.TabIndex = 1;
            dgvcarsoldproduct.CellClick += dgvcarsoldproduct_CellClick;
            dgvcarsoldproduct.CellMouseEnter += dgvcarsoldproduct_CellMouseEnter;
            dgvcarsoldproduct.CellMouseLeave += dgvcarsoldproduct_CellMouseLeave;
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
            khButton1.Location = new Point(533, 12);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(167, 52);
            khButton1.TabIndex = 89;
            khButton1.TextColor = SystemColors.Window;
            khButton1.UseVisualStyleBackColor = false;
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
            btncar3.Location = new Point(380, 77);
            btncar3.Margin = new Padding(0);
            btncar3.Name = "btncar3";
            btncar3.Size = new Size(190, 39);
            btncar3.TabIndex = 59;
            btncar3.Text = "سياره 3";
            btncar3.TextColor = Color.FromArgb(119, 67, 219);
            btncar3.UseVisualStyleBackColor = false;
            btncar3.Click += btncar3_Click;
            // 
            // DpFromSoldProduct
            // 
            DpFromSoldProduct.Anchor = AnchorStyles.Right;
            DpFromSoldProduct.BorderColor = Color.White;
            DpFromSoldProduct.BorderSize = 0;
            DpFromSoldProduct.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFromSoldProduct.Format = DateTimePickerFormat.Short;
            DpFromSoldProduct.Location = new Point(781, 16);
            DpFromSoldProduct.MinimumSize = new Size(0, 35);
            DpFromSoldProduct.Name = "DpFromSoldProduct";
            DpFromSoldProduct.Size = new Size(120, 46);
            DpFromSoldProduct.SkinColor = Color.Transparent;
            DpFromSoldProduct.TabIndex = 84;
            DpFromSoldProduct.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.Location = new Point(898, 14);
            label1.Name = "label1";
            label1.Size = new Size(37, 44);
            label1.TabIndex = 85;
            label1.Text = "من";
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
            btncar4.Location = new Point(191, 77);
            btncar4.Margin = new Padding(0);
            btncar4.Name = "btncar4";
            btncar4.Size = new Size(190, 39);
            btncar4.TabIndex = 57;
            btncar4.Text = "سياره 4";
            btncar4.TextColor = Color.FromArgb(119, 67, 219);
            btncar4.UseVisualStyleBackColor = false;
            btncar4.Click += btncar4_Click;
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
            khButton2.Location = new Point(775, 12);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(167, 52);
            khButton2.TabIndex = 86;
            khButton2.TextColor = SystemColors.Window;
            khButton2.UseVisualStyleBackColor = false;
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
            btncar2.Location = new Point(565, 77);
            btncar2.Margin = new Padding(0);
            btncar2.Name = "btncar2";
            btncar2.Size = new Size(190, 39);
            btncar2.TabIndex = 60;
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
            btncar1.Location = new Point(744, 76);
            btncar1.Margin = new Padding(0);
            btncar1.Name = "btncar1";
            btncar1.Size = new Size(201, 40);
            btncar1.TabIndex = 56;
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
            btncar5.Location = new Point(0, 76);
            btncar5.Margin = new Padding(0);
            btncar5.Name = "btncar5";
            btncar5.Size = new Size(199, 40);
            btncar5.TabIndex = 58;
            btncar5.Text = "سياره 5";
            btncar5.TextColor = Color.FromArgb(119, 67, 219);
            btncar5.UseVisualStyleBackColor = false;
            btncar5.Click += btncar5_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Hacen Egypt", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 36, 114);
            label3.Location = new Point(543, 651);
            label3.Name = "label3";
            label3.Size = new Size(172, 99);
            label3.TabIndex = 62;
            label3.Text = "الاجمالي";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 145.1243F;
            Column1.HeaderText = "الصنف";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 67.7246857F;
            Column2.HeaderText = "السعر";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 72.56215F;
            Column3.HeaderText = "الكميه";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "القيمه";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 15.2626286F;
            info.HeaderText = "";
            info.Image = Properties.Resources.infol;
            info.Name = "info";
            info.ReadOnly = true;
            // 
            // CarsSoldProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlcarsoldproduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarsSoldProducts";
            Padding = new Padding(20, 0, 20, 0);
            Text = "carssoldproductsFRM";
            pnlcarsoldproduct.ResumeLayout(false);
            pnlcarsoldproduct.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvcarsoldproduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhPanel khPanel1;
        private DataGridView dgvcarsoldproduct;
        private customs.KhControles.KhButton btncar3;
        private customs.KhControles.KhButton btncar4;
        private customs.KhControles.KhButton btncar2;
        private customs.KhControles.KhButton btncar1;
        private customs.KhControles.KhButton btncar5;
        private customs.KhControles.KhButton lbltotal;
        private Label label3;
        private customs.KhControles.KhDatePicker DpToSoldProduct;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhDatePicker DpFromSoldProduct;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        public Panel pnlcarsoldproduct;
        private customs.KhControles.KhButton btnreport;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn info;
    }
}