namespace Sahll.JUI.Car.InfoForms
{
    partial class CarsInfoCashFRM
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            khPanel1 = new customs.KhPanel();
            btnclose = new customs.KhControles.KhButton();
            khPanel2 = new customs.KhPanel();
            dgvexpencesinfo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txtdelegator = new Label();
            label8 = new Label();
            label6 = new Label();
            txtdriver = new Label();
            txtreserve = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            txtday = new Label();
            txtdate = new Label();
            txtby = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtreservename = new Label();
            txtdelegatorname = new Label();
            txtdrivername = new Label();
            label3 = new Label();
            txttotal = new Label();
            label1 = new Label();
            txtcash = new Label();
            khPanel1.SuspendLayout();
            khPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvexpencesinfo).BeginInit();
            SuspendLayout();
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 0;
            khPanel1.Controls.Add(btnclose);
            khPanel1.Controls.Add(khPanel2);
            khPanel1.Controls.Add(label9);
            khPanel1.Controls.Add(txtdelegator);
            khPanel1.Controls.Add(label8);
            khPanel1.Controls.Add(label6);
            khPanel1.Controls.Add(txtdriver);
            khPanel1.Controls.Add(txtreserve);
            khPanel1.Controls.Add(label22);
            khPanel1.Controls.Add(label23);
            khPanel1.Controls.Add(label24);
            khPanel1.Controls.Add(txtday);
            khPanel1.Controls.Add(txtdate);
            khPanel1.Controls.Add(txtby);
            khPanel1.Controls.Add(label15);
            khPanel1.Controls.Add(label16);
            khPanel1.Controls.Add(label17);
            khPanel1.Controls.Add(txtreservename);
            khPanel1.Controls.Add(txtdelegatorname);
            khPanel1.Controls.Add(txtdrivername);
            khPanel1.Controls.Add(label3);
            khPanel1.Controls.Add(txttotal);
            khPanel1.Controls.Add(label1);
            khPanel1.Controls.Add(txtcash);
            khPanel1.Dock = DockStyle.Fill;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 20F;
            khPanel1.GradientBottomColor = Color.FromArgb(0, 0, 5);
            khPanel1.GradientTopColor = Color.FromArgb(83, 4, 128);
            khPanel1.Location = new Point(0, 0);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(1115, 790);
            khPanel1.TabIndex = 0;
            khPanel1.Paint += khPanel1_Paint;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Transparent;
            btnclose.BackgroundColor = Color.Transparent;
            btnclose.BorderColor = Color.Crimson;
            btnclose.BorderRadius = 0;
            btnclose.BorderSize = 0;
            btnclose.Cursor = Cursors.Hand;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.ForeColor = Color.White;
            btnclose.Image = Properties.Resources.closed;
            btnclose.Location = new Point(0, 6);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 85;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            // 
            // khPanel2
            // 
            khPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 30;
            khPanel2.Controls.Add(dgvexpencesinfo);
            khPanel2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(247, 239, 229);
            khPanel2.GradientTopColor = Color.FromArgb(219, 181, 181);
            khPanel2.Location = new Point(127, 252);
            khPanel2.Name = "khPanel2";
            khPanel2.Padding = new Padding(5, 8, 5, 15);
            khPanel2.Size = new Size(824, 296);
            khPanel2.TabIndex = 84;
            // 
            // dgvexpencesinfo
            // 
            dgvexpencesinfo.AllowUserToAddRows = false;
            dgvexpencesinfo.AllowUserToDeleteRows = false;
            dgvexpencesinfo.AllowUserToResizeColumns = false;
            dgvexpencesinfo.AllowUserToResizeRows = false;
            dgvexpencesinfo.BackgroundColor = Color.FromArgb(247, 239, 229);
            dgvexpencesinfo.BorderStyle = BorderStyle.None;
            dgvexpencesinfo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvexpencesinfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 181, 181);
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvexpencesinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvexpencesinfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvexpencesinfo.Columns.AddRange(new DataGridViewColumn[] { Column1, amount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvexpencesinfo.DefaultCellStyle = dataGridViewCellStyle4;
            dgvexpencesinfo.Dock = DockStyle.Fill;
            dgvexpencesinfo.EnableHeadersVisualStyles = false;
            dgvexpencesinfo.GridColor = Color.White;
            dgvexpencesinfo.Location = new Point(5, 8);
            dgvexpencesinfo.Name = "dgvexpencesinfo";
            dgvexpencesinfo.ReadOnly = true;
            dgvexpencesinfo.RightToLeft = RightToLeft.Yes;
            dgvexpencesinfo.RowHeadersVisible = false;
            dgvexpencesinfo.RowHeadersWidth = 25;
            dgvexpencesinfo.RowTemplate.DividerHeight = 1;
            dgvexpencesinfo.RowTemplate.Height = 28;
            dgvexpencesinfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvexpencesinfo.Size = new Size(814, 273);
            dgvexpencesinfo.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 102.037514F;
            Column1.HeaderText = "البيان";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // amount
            // 
            amount.HeaderText = "المبلغ";
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("LBC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(219, 181, 181);
            label9.Location = new Point(466, 143);
            label9.Name = "label9";
            label9.Size = new Size(172, 37);
            label9.TabIndex = 82;
            label9.Text = "سلفة مندوب";
            // 
            // txtdelegator
            // 
            txtdelegator.Anchor = AnchorStyles.None;
            txtdelegator.BackColor = Color.Transparent;
            txtdelegator.Font = new Font("Hacen Egypt", 42F);
            txtdelegator.ForeColor = Color.White;
            txtdelegator.Location = new Point(461, 159);
            txtdelegator.Name = "txtdelegator";
            txtdelegator.Size = new Size(191, 100);
            txtdelegator.TabIndex = 83;
            txtdelegator.Text = "51315";
            txtdelegator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("LBC", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(219, 181, 181);
            label8.Location = new Point(943, 143);
            label8.Name = "label8";
            label8.Size = new Size(143, 35);
            label8.TabIndex = 79;
            label8.Text = "سلفة سواق";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("LBC", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(219, 181, 181);
            label6.Location = new Point(11, 143);
            label6.Name = "label6";
            label6.Size = new Size(174, 35);
            label6.TabIndex = 78;
            label6.Text = "سلفة احتياطي";
            // 
            // txtdriver
            // 
            txtdriver.Anchor = AnchorStyles.Right;
            txtdriver.BackColor = Color.Transparent;
            txtdriver.Font = new Font("Hacen Egypt", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdriver.ForeColor = Color.White;
            txtdriver.Location = new Point(923, 159);
            txtdriver.Name = "txtdriver";
            txtdriver.Size = new Size(191, 100);
            txtdriver.TabIndex = 81;
            txtdriver.Text = "51315";
            txtdriver.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtreserve
            // 
            txtreserve.Anchor = AnchorStyles.Left;
            txtreserve.BackColor = Color.Transparent;
            txtreserve.Font = new Font("Hacen Egypt", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtreserve.ForeColor = Color.White;
            txtreserve.Location = new Point(8, 159);
            txtreserve.Name = "txtreserve";
            txtreserve.Size = new Size(191, 100);
            txtreserve.TabIndex = 80;
            txtreserve.Text = "51315";
            txtreserve.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Left;
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("LBC", 18F);
            label22.ForeColor = Color.FromArgb(219, 181, 181);
            label22.Location = new Point(105, 700);
            label22.Name = "label22";
            label22.Size = new Size(62, 31);
            label22.TabIndex = 72;
            label22.Text = "اليوم";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("LBC", 18F);
            label23.ForeColor = Color.FromArgb(219, 181, 181);
            label23.Location = new Point(515, 700);
            label23.Name = "label23";
            label23.Size = new Size(70, 31);
            label23.TabIndex = 73;
            label23.Text = "التاريخ";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Right;
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("LBC", 18F);
            label24.ForeColor = Color.FromArgb(219, 181, 181);
            label24.Location = new Point(917, 700);
            label24.Name = "label24";
            label24.Size = new Size(91, 31);
            label24.TabIndex = 74;
            label24.Text = "بواسطة";
            // 
            // txtday
            // 
            txtday.Anchor = AnchorStyles.Left;
            txtday.BackColor = Color.Transparent;
            txtday.Font = new Font("Hacen Egypt", 21.75F);
            txtday.ForeColor = Color.White;
            txtday.Location = new Point(0, 731);
            txtday.Name = "txtday";
            txtday.Size = new Size(283, 64);
            txtday.TabIndex = 75;
            txtday.Text = "الأربعاء";
            txtday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtdate
            // 
            txtdate.Anchor = AnchorStyles.None;
            txtdate.BackColor = Color.Transparent;
            txtdate.Font = new Font("Hacen Egypt", 21.75F);
            txtdate.ForeColor = Color.White;
            txtdate.Location = new Point(403, 731);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(303, 64);
            txtdate.TabIndex = 76;
            txtdate.Text = "28/12/2004";
            txtdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtby
            // 
            txtby.Anchor = AnchorStyles.Right;
            txtby.BackColor = Color.Transparent;
            txtby.Font = new Font("Hacen Egypt", 21.75F);
            txtby.ForeColor = Color.White;
            txtby.Location = new Point(825, 731);
            txtby.Name = "txtby";
            txtby.Size = new Size(287, 64);
            txtby.TabIndex = 77;
            txtby.Text = "محمد عبد الكريم ";
            txtby.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("LBC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(219, 181, 181);
            label15.Location = new Point(68, 573);
            label15.Name = "label15";
            label15.Size = new Size(131, 37);
            label15.TabIndex = 66;
            label15.Text = "الإحتياطي";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("LBC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(219, 181, 181);
            label16.Location = new Point(494, 573);
            label16.Name = "label16";
            label16.Size = new Size(114, 37);
            label16.TabIndex = 67;
            label16.Text = "المندوب";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Right;
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("LBC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(219, 181, 181);
            label17.Location = new Point(916, 573);
            label17.Name = "label17";
            label17.Size = new Size(92, 37);
            label17.TabIndex = 68;
            label17.Text = "السائق";
            // 
            // txtreservename
            // 
            txtreservename.Anchor = AnchorStyles.Left;
            txtreservename.BackColor = Color.Transparent;
            txtreservename.Font = new Font("Hacen Egypt", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtreservename.ForeColor = Color.White;
            txtreservename.Location = new Point(0, 610);
            txtreservename.Name = "txtreservename";
            txtreservename.Size = new Size(283, 64);
            txtreservename.TabIndex = 69;
            txtreservename.Text = "محمد عبد الكريم ";
            txtreservename.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtdelegatorname
            // 
            txtdelegatorname.Anchor = AnchorStyles.None;
            txtdelegatorname.BackColor = Color.Transparent;
            txtdelegatorname.Font = new Font("Hacen Egypt", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdelegatorname.ForeColor = Color.White;
            txtdelegatorname.Location = new Point(413, 610);
            txtdelegatorname.Name = "txtdelegatorname";
            txtdelegatorname.Size = new Size(303, 64);
            txtdelegatorname.TabIndex = 70;
            txtdelegatorname.Text = "محمد عبد الكريم ";
            txtdelegatorname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtdrivername
            // 
            txtdrivername.Anchor = AnchorStyles.Right;
            txtdrivername.BackColor = Color.Transparent;
            txtdrivername.Font = new Font("Hacen Egypt", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdrivername.ForeColor = Color.White;
            txtdrivername.Location = new Point(809, 610);
            txtdrivername.Name = "txtdrivername";
            txtdrivername.Size = new Size(303, 64);
            txtdrivername.TabIndex = 71;
            txtdrivername.Text = "محمد عبد الكريم ";
            txtdrivername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("LBC", 35.25F);
            label3.ForeColor = Color.FromArgb(219, 181, 181);
            label3.Location = new Point(127, -4);
            label3.Name = "label3";
            label3.Size = new Size(168, 61);
            label3.TabIndex = 64;
            label3.Text = "الصافي";
            // 
            // txttotal
            // 
            txttotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txttotal.BackColor = Color.Transparent;
            txttotal.Font = new Font("Hacen Egypt", 48F);
            txttotal.ForeColor = Color.White;
            txttotal.Location = new Point(92, 32);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(244, 100);
            txttotal.TabIndex = 65;
            txttotal.Text = "532145";
            txttotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("LBC", 35.25F);
            label1.ForeColor = Color.FromArgb(219, 181, 181);
            label1.Location = new Point(815, -4);
            label1.Name = "label1";
            label1.Size = new Size(136, 61);
            label1.TabIndex = 62;
            label1.Text = "الكاش";
            // 
            // txtcash
            // 
            txtcash.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtcash.BackColor = Color.Transparent;
            txtcash.Font = new Font("Hacen Egypt", 48F);
            txtcash.ForeColor = Color.White;
            txtcash.Location = new Point(759, 32);
            txtcash.Name = "txtcash";
            txtcash.Size = new Size(244, 100);
            txtcash.TabIndex = 63;
            txtcash.Text = "532145";
            txtcash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CarsInfoCashFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 790);
            Controls.Add(khPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarsInfoCashFRM";
            Opacity = 0.95D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cash_infoFRM";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            khPanel1.ResumeLayout(false);
            khPanel1.PerformLayout();
            khPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvexpencesinfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private customs.KhPanel khPanel1;
        private customs.KhControles.KhButton btnclose;
        private customs.KhPanel khPanel2;
        private DataGridView dgvexpencesinfo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn amount;
        private Label label9;
        private Label txtdelegator;
        private Label label8;
        private Label label6;
        private Label txtdriver;
        private Label txtreserve;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label txtday;
        private Label txtdate;
        private Label txtby;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label txtreservename;
        private Label txtdelegatorname;
        private Label txtdrivername;
        private Label label3;
        private Label txttotal;
        private Label label1;
        private Label txtcash;
    }
}