namespace Sahll.JUI.Car.InfoForms
{
    partial class ManufacturingInfoFRM
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
            khPanel1 = new customs.KhPanel();
            btnclose = new customs.KhControles.KhButton();
            khPanel2 = new customs.KhPanel();
            dgvrowmaterial = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txtpruchaseprice = new Label();
            label8 = new Label();
            label6 = new Label();
            txtsellingprice = new Label();
            txtquantity = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            txtday = new Label();
            txtdate = new Label();
            txtby = new Label();
            label1 = new Label();
            txtproduct = new Label();
            khPanel1.SuspendLayout();
            khPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvrowmaterial).BeginInit();
            SuspendLayout();
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 0;
            khPanel1.Controls.Add(btnclose);
            khPanel1.Controls.Add(khPanel2);
            khPanel1.Controls.Add(label9);
            khPanel1.Controls.Add(txtpruchaseprice);
            khPanel1.Controls.Add(label8);
            khPanel1.Controls.Add(label6);
            khPanel1.Controls.Add(txtsellingprice);
            khPanel1.Controls.Add(txtquantity);
            khPanel1.Controls.Add(label22);
            khPanel1.Controls.Add(label23);
            khPanel1.Controls.Add(label24);
            khPanel1.Controls.Add(txtday);
            khPanel1.Controls.Add(txtdate);
            khPanel1.Controls.Add(txtby);
            khPanel1.Controls.Add(label1);
            khPanel1.Controls.Add(txtproduct);
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
            btnclose.Location = new Point(0, 1);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 109;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click_2;
            // 
            // khPanel2
            // 
            khPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 30;
            khPanel2.Controls.Add(dgvrowmaterial);
            khPanel2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(247, 239, 229);
            khPanel2.GradientTopColor = Color.FromArgb(219, 181, 181);
            khPanel2.Location = new Point(114, 322);
            khPanel2.Name = "khPanel2";
            khPanel2.Padding = new Padding(5, 8, 5, 15);
            khPanel2.Size = new Size(824, 296);
            khPanel2.TabIndex = 108;
            // 
            // dgvrowmaterial
            // 
            dgvrowmaterial.AllowUserToAddRows = false;
            dgvrowmaterial.AllowUserToDeleteRows = false;
            dgvrowmaterial.AllowUserToResizeColumns = false;
            dgvrowmaterial.AllowUserToResizeRows = false;
            dgvrowmaterial.BackgroundColor = Color.FromArgb(247, 239, 229);
            dgvrowmaterial.BorderStyle = BorderStyle.None;
            dgvrowmaterial.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvrowmaterial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(219, 181, 181);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvrowmaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvrowmaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvrowmaterial.Columns.AddRange(new DataGridViewColumn[] { Column1, amount, quantity, total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvrowmaterial.DefaultCellStyle = dataGridViewCellStyle2;
            dgvrowmaterial.Dock = DockStyle.Fill;
            dgvrowmaterial.EnableHeadersVisualStyles = false;
            dgvrowmaterial.GridColor = Color.White;
            dgvrowmaterial.Location = new Point(5, 8);
            dgvrowmaterial.Name = "dgvrowmaterial";
            dgvrowmaterial.ReadOnly = true;
            dgvrowmaterial.RightToLeft = RightToLeft.Yes;
            dgvrowmaterial.RowHeadersVisible = false;
            dgvrowmaterial.RowHeadersWidth = 25;
            dgvrowmaterial.RowTemplate.DividerHeight = 1;
            dgvrowmaterial.RowTemplate.Height = 28;
            dgvrowmaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvrowmaterial.Size = new Size(814, 273);
            dgvrowmaterial.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 102.037514F;
            Column1.HeaderText = "الخام";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // amount
            // 
            amount.HeaderText = "السعر";
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "الكميه";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // total
            // 
            total.HeaderText = "الاجمالي";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("LBC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(219, 181, 181);
            label9.Location = new Point(484, 167);
            label9.Name = "label9";
            label9.Size = new Size(138, 37);
            label9.TabIndex = 106;
            label9.Text = "سعر الشراء";
            // 
            // txtpruchaseprice
            // 
            txtpruchaseprice.Anchor = AnchorStyles.None;
            txtpruchaseprice.BackColor = Color.Transparent;
            txtpruchaseprice.Font = new Font("Hacen Egypt", 42F);
            txtpruchaseprice.ForeColor = Color.White;
            txtpruchaseprice.Location = new Point(461, 183);
            txtpruchaseprice.Name = "txtpruchaseprice";
            txtpruchaseprice.Size = new Size(191, 100);
            txtpruchaseprice.TabIndex = 107;
            txtpruchaseprice.Text = "51315";
            txtpruchaseprice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("LBC", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(219, 181, 181);
            label8.Location = new Point(943, 167);
            label8.Name = "label8";
            label8.Size = new Size(117, 35);
            label8.TabIndex = 102;
            label8.Text = "سعر البيع";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("LBC", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(219, 181, 181);
            label6.Location = new Point(55, 167);
            label6.Name = "label6";
            label6.Size = new Size(85, 35);
            label6.TabIndex = 103;
            label6.Text = "الكميه";
            // 
            // txtsellingprice
            // 
            txtsellingprice.Anchor = AnchorStyles.Right;
            txtsellingprice.BackColor = Color.Transparent;
            txtsellingprice.Font = new Font("Hacen Egypt", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsellingprice.ForeColor = Color.White;
            txtsellingprice.Location = new Point(923, 183);
            txtsellingprice.Name = "txtsellingprice";
            txtsellingprice.Size = new Size(191, 100);
            txtsellingprice.TabIndex = 104;
            txtsellingprice.Text = "51315";
            txtsellingprice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtquantity
            // 
            txtquantity.Anchor = AnchorStyles.Left;
            txtquantity.BackColor = Color.Transparent;
            txtquantity.Font = new Font("Hacen Egypt", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtquantity.ForeColor = Color.White;
            txtquantity.Location = new Point(8, 183);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(191, 100);
            txtquantity.TabIndex = 105;
            txtquantity.Text = "51315";
            txtquantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Left;
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("LBC", 18F);
            label22.ForeColor = Color.FromArgb(219, 181, 181);
            label22.Location = new Point(105, 691);
            label22.Name = "label22";
            label22.Size = new Size(62, 31);
            label22.TabIndex = 96;
            label22.Text = "اليوم";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("LBC", 18F);
            label23.ForeColor = Color.FromArgb(219, 181, 181);
            label23.Location = new Point(515, 691);
            label23.Name = "label23";
            label23.Size = new Size(70, 31);
            label23.TabIndex = 97;
            label23.Text = "التاريخ";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Right;
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("LBC", 18F);
            label24.ForeColor = Color.FromArgb(219, 181, 181);
            label24.Location = new Point(917, 691);
            label24.Name = "label24";
            label24.Size = new Size(91, 31);
            label24.TabIndex = 98;
            label24.Text = "بواسطة";
            // 
            // txtday
            // 
            txtday.Anchor = AnchorStyles.Left;
            txtday.BackColor = Color.Transparent;
            txtday.Font = new Font("Hacen Egypt", 21.75F);
            txtday.ForeColor = Color.White;
            txtday.Location = new Point(0, 722);
            txtday.Name = "txtday";
            txtday.Size = new Size(283, 64);
            txtday.TabIndex = 99;
            txtday.Text = "الأربعاء";
            txtday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtdate
            // 
            txtdate.Anchor = AnchorStyles.None;
            txtdate.BackColor = Color.Transparent;
            txtdate.Font = new Font("Hacen Egypt", 21.75F);
            txtdate.ForeColor = Color.White;
            txtdate.Location = new Point(403, 722);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(303, 64);
            txtdate.TabIndex = 100;
            txtdate.Text = "28/12/2004";
            txtdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtby
            // 
            txtby.Anchor = AnchorStyles.Right;
            txtby.BackColor = Color.Transparent;
            txtby.Font = new Font("Hacen Egypt", 21.75F);
            txtby.ForeColor = Color.White;
            txtby.Location = new Point(825, 722);
            txtby.Name = "txtby";
            txtby.Size = new Size(287, 64);
            txtby.TabIndex = 101;
            txtby.Text = "محمد عبد الكريم ";
            txtby.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("LBC", 35.25F);
            label1.ForeColor = Color.FromArgb(219, 181, 181);
            label1.Location = new Point(483, -9);
            label1.Name = "label1";
            label1.Size = new Size(146, 61);
            label1.TabIndex = 94;
            label1.Text = "الصنف";
            // 
            // txtproduct
            // 
            txtproduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtproduct.BackColor = Color.Transparent;
            txtproduct.Font = new Font("Hacen Egypt", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtproduct.ForeColor = Color.White;
            txtproduct.Location = new Point(149, 13);
            txtproduct.Name = "txtproduct";
            txtproduct.Size = new Size(814, 100);
            txtproduct.TabIndex = 95;
            txtproduct.Text = "صابون سايل عالي الجوده";
            txtproduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManufacturingInfoFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 790);
            Controls.Add(khPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManufacturingInfoFRM";
            Opacity = 0.95D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cash_infoFRM";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            khPanel1.ResumeLayout(false);
            khPanel1.PerformLayout();
            khPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvrowmaterial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private customs.KhPanel khPanel1;
        private customs.KhControles.KhButton btnclose;
        private customs.KhPanel khPanel2;
        private DataGridView dgvrowmaterial;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private Label label9;
        private Label txtpruchaseprice;
        private Label label8;
        private Label label6;
        private Label txtsellingprice;
        private Label txtquantity;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label txtday;
        private Label txtdate;
        private Label txtby;
        private Label label1;
        private Label txtproduct;
    }
}