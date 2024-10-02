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
            pnlselling.SuspendLayout();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelling).BeginInit();
            SuspendLayout();
            // 
            // pnlselling
            // 
            pnlselling.Controls.Add(khPanel1);
            pnlselling.Dock = DockStyle.Fill;
            pnlselling.Location = new Point(20, 0);
            pnlselling.Name = "pnlselling";
            pnlselling.Size = new Size(945, 750);
            pnlselling.TabIndex = 0;
            pnlselling.Paint += pnlselling_Paint;
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 30;
            khPanel1.Controls.Add(dgvSelling);
            khPanel1.Dock = DockStyle.Fill;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(173, 109, 209);
            khPanel1.GradientTopColor = Color.FromArgb(195, 172, 208);
            khPanel1.Location = new Point(0, 0);
            khPanel1.Name = "khPanel1";
            khPanel1.Padding = new Padding(5, 8, 5, 15);
            khPanel1.Size = new Size(945, 750);
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
            dgvSelling.Size = new Size(935, 727);
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
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSelling).EndInit();
            ResumeLayout(false);
        }

        #endregion
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