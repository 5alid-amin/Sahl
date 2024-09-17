namespace Sahll.JUI.Car
{
    partial class CarsInventoryFRM
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
            pnlinventory = new Panel();
            DpToInventory = new customs.KhControles.KhDatePicker();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            DpFromInventory = new customs.KhControles.KhDatePicker();
            label1 = new Label();
            khButton2 = new customs.KhControles.KhButton();
            btnAddInventory = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            dgvinventory = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            returnd = new DataGridViewImageColumn();
            info = new DataGridViewImageColumn();
            btncar3 = new customs.KhControles.KhButton();
            btncar4 = new customs.KhControles.KhButton();
            btncar2 = new customs.KhControles.KhButton();
            btncar1 = new customs.KhControles.KhButton();
            btncar5 = new customs.KhControles.KhButton();
            txtsearch = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            pnlinventory.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvinventory).BeginInit();
            SuspendLayout();
            // 
            // pnlinventory
            // 
            pnlinventory.Controls.Add(DpToInventory);
            pnlinventory.Controls.Add(label2);
            pnlinventory.Controls.Add(khButton1);
            pnlinventory.Controls.Add(DpFromInventory);
            pnlinventory.Controls.Add(label1);
            pnlinventory.Controls.Add(khButton2);
            pnlinventory.Controls.Add(btnAddInventory);
            pnlinventory.Controls.Add(khPanel1);
            pnlinventory.Controls.Add(btncar3);
            pnlinventory.Controls.Add(btncar4);
            pnlinventory.Controls.Add(btncar2);
            pnlinventory.Controls.Add(btncar1);
            pnlinventory.Controls.Add(btncar5);
            pnlinventory.Controls.Add(txtsearch);
            pnlinventory.Controls.Add(khButton3);
            pnlinventory.Dock = DockStyle.Fill;
            pnlinventory.Location = new Point(20, 0);
            pnlinventory.Name = "pnlinventory";
            pnlinventory.Size = new Size(945, 750);
            pnlinventory.TabIndex = 0;
            pnlinventory.Resize += pnlinventory_Resize;
            // 
            // DpToInventory
            // 
            DpToInventory.Anchor = AnchorStyles.Right;
            DpToInventory.BorderColor = Color.White;
            DpToInventory.BorderSize = 0;
            DpToInventory.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpToInventory.Format = DateTimePickerFormat.Short;
            DpToInventory.Location = new Point(540, 18);
            DpToInventory.MinimumSize = new Size(0, 35);
            DpToInventory.Name = "DpToInventory";
            DpToInventory.Size = new Size(120, 46);
            DpToInventory.SkinColor = Color.Transparent;
            DpToInventory.TabIndex = 69;
            DpToInventory.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 109, 209);
            label2.Location = new Point(658, 18);
            label2.Name = "label2";
            label2.Size = new Size(39, 44);
            label2.TabIndex = 70;
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
            khButton1.Location = new Point(534, 14);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(167, 52);
            khButton1.TabIndex = 71;
            khButton1.TextColor = SystemColors.Window;
            khButton1.UseVisualStyleBackColor = false;
            // 
            // DpFromInventory
            // 
            DpFromInventory.Anchor = AnchorStyles.Right;
            DpFromInventory.BorderColor = Color.White;
            DpFromInventory.BorderSize = 0;
            DpFromInventory.Font = new Font("Hacen Egypt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DpFromInventory.Format = DateTimePickerFormat.Short;
            DpFromInventory.Location = new Point(782, 18);
            DpFromInventory.MinimumSize = new Size(0, 35);
            DpFromInventory.Name = "DpFromInventory";
            DpFromInventory.Size = new Size(120, 46);
            DpFromInventory.SkinColor = Color.Transparent;
            DpFromInventory.TabIndex = 38;
            DpFromInventory.TextColor = Color.FromArgb(63, 36, 114);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 109, 209);
            label1.Location = new Point(899, 16);
            label1.Name = "label1";
            label1.Size = new Size(37, 44);
            label1.TabIndex = 40;
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
            khButton2.Location = new Point(776, 14);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(167, 52);
            khButton2.TabIndex = 68;
            khButton2.TextColor = SystemColors.Window;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // btnAddInventory
            // 
            btnAddInventory.Anchor = AnchorStyles.None;
            btnAddInventory.BackColor = Color.FromArgb(173, 109, 209);
            btnAddInventory.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnAddInventory.BorderColor = Color.FromArgb(63, 36, 114);
            btnAddInventory.BorderRadius = 40;
            btnAddInventory.BorderSize = 0;
            btnAddInventory.Cursor = Cursors.Hand;
            btnAddInventory.FlatAppearance.BorderSize = 0;
            btnAddInventory.FlatStyle = FlatStyle.Flat;
            btnAddInventory.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddInventory.ForeColor = Color.White;
            btnAddInventory.Location = new Point(384, 667);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(177, 63);
            btnAddInventory.TabIndex = 67;
            btnAddInventory.Text = "إضافه";
            btnAddInventory.TextColor = Color.White;
            btnAddInventory.UseVisualStyleBackColor = false;
            btnAddInventory.Click += btnAddInventory_Click;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvinventory);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(2, 132);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(940, 532);
            khPanel1.TabIndex = 47;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(195, 172, 208);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvinventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvinventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventory.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, delete, edit, returnd, info });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvinventory.DefaultCellStyle = dataGridViewCellStyle3;
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
            dgvinventory.Size = new Size(930, 509);
            dgvinventory.TabIndex = 1;
            dgvinventory.CellClick += dgvinventory_CellClick;
            dgvinventory.CellMouseEnter += dgvinventory_CellMouseEnter;
            dgvinventory.CellMouseLeave += dgvinventory_CellMouseLeave;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 141.074585F;
            Column1.HeaderText = "الصنف";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Hacen Egypt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 65.834816F;
            Column2.HeaderText = "السعر";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 70.53729F;
            Column3.HeaderText = "الكميه";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.FillWeight = 13.825757F;
            delete.HeaderText = "";
            delete.Image = Properties.Resources.deletel1;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edit.FillWeight = 13.825757F;
            edit.HeaderText = "";
            edit.Image = Properties.Resources.editl;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.Name = "edit";
            edit.ReadOnly = true;
            // 
            // returnd
            // 
            returnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            returnd.FillWeight = 13.825757F;
            returnd.HeaderText = "";
            returnd.Image = Properties.Resources.returnedl;
            returnd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            returnd.Name = "returnd";
            returnd.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            info.FillWeight = 11.74983F;
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
            btncar3.Location = new Point(380, 77);
            btncar3.Margin = new Padding(0);
            btncar3.Name = "btncar3";
            btncar3.Size = new Size(190, 39);
            btncar3.TabIndex = 45;
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
            btncar4.Location = new Point(191, 77);
            btncar4.Margin = new Padding(0);
            btncar4.Name = "btncar4";
            btncar4.Size = new Size(190, 39);
            btncar4.TabIndex = 43;
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
            btncar2.Location = new Point(565, 77);
            btncar2.Margin = new Padding(0);
            btncar2.Name = "btncar2";
            btncar2.Size = new Size(190, 39);
            btncar2.TabIndex = 46;
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
            btncar1.TabIndex = 42;
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
            btncar5.TabIndex = 44;
            btncar5.Text = "سياره 5";
            btncar5.TextColor = Color.FromArgb(119, 67, 219);
            btncar5.UseVisualStyleBackColor = false;
            btncar5.Click += btncar5_Click;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.White;
            txtsearch.BorderStyle = BorderStyle.None;
            txtsearch.Font = new Font("Hacen Egypt", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = Color.FromArgb(63, 36, 114);
            txtsearch.Location = new Point(37, 12);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(274, 46);
            txtsearch.TabIndex = 37;
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
            khButton3.Location = new Point(6, 10);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(323, 52);
            khButton3.TabIndex = 36;
            khButton3.TextColor = SystemColors.Window;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // CarsInventoryFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlinventory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarsInventoryFRM";
            Padding = new Padding(20, 0, 20, 0);
            ShowInTaskbar = false;
            Text = "car_inventoryFRM";
            pnlinventory.ResumeLayout(false);
            pnlinventory.PerformLayout();
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvinventory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private customs.KhPanel khPanel1;
        private DataGridView dgvinventory;
        private customs.KhControles.KhButton btncar3;
        private customs.KhControles.KhButton btncar4;
        private customs.KhControles.KhButton btncar2;
        private customs.KhControles.KhButton btncar1;
        private customs.KhControles.KhButton btncar5;
        private TextBox txtsearch;
        private customs.KhControles.KhButton khButton3;
        private customs.KhControles.KhButton btnAddInventory;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn returnd;
        private DataGridViewImageColumn info;
        private customs.KhControles.KhDatePicker DpFromInventory;
        private Label label1;
        private customs.KhControles.KhButton khButton2;
        private customs.KhControles.KhDatePicker DpToInventory;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        public Panel pnlinventory;
    }
}