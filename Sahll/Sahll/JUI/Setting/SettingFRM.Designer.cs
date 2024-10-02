namespace Sahll.JUI.Car
{
    partial class SettingFRM
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
            pnlcarsoptions = new Panel();
            btndeficitorexcess = new customs.KhControles.KhButton();
            btns = new customs.KhControles.KhButton();
            khButton7 = new customs.KhControles.KhButton();
            btncash = new customs.KhControles.KhButton();
            btntresury = new customs.KhControles.KhButton();
            khButton4 = new customs.KhControles.KhButton();
            khButton5 = new customs.KhControles.KhButton();
            btnproducts = new customs.KhControles.KhButton();
            khButton2 = new customs.KhControles.KhButton();
            picsahlwhenmax = new PictureBox();
            pnlcarsoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picsahlwhenmax).BeginInit();
            SuspendLayout();
            // 
            // pnlcarsoptions
            // 
            pnlcarsoptions.Controls.Add(btndeficitorexcess);
            pnlcarsoptions.Controls.Add(btns);
            pnlcarsoptions.Controls.Add(khButton7);
            pnlcarsoptions.Controls.Add(btncash);
            pnlcarsoptions.Controls.Add(btntresury);
            pnlcarsoptions.Controls.Add(khButton4);
            pnlcarsoptions.Controls.Add(khButton5);
            pnlcarsoptions.Controls.Add(btnproducts);
            pnlcarsoptions.Controls.Add(khButton2);
            pnlcarsoptions.Controls.Add(picsahlwhenmax);
            pnlcarsoptions.Dock = DockStyle.Fill;
            pnlcarsoptions.Location = new Point(20, 0);
            pnlcarsoptions.Name = "pnlcarsoptions";
            pnlcarsoptions.Size = new Size(945, 750);
            pnlcarsoptions.TabIndex = 0;
            pnlcarsoptions.Paint += pnlcarsoptions_Paint;
            // 
            // btndeficitorexcess
            // 
            btndeficitorexcess.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btndeficitorexcess.BackColor = Color.FromArgb(173, 109, 209);
            btndeficitorexcess.BackgroundColor = Color.FromArgb(173, 109, 209);
            btndeficitorexcess.BorderColor = Color.FromArgb(63, 36, 114);
            btndeficitorexcess.BorderRadius = 40;
            btndeficitorexcess.BorderSize = 0;
            btndeficitorexcess.Cursor = Cursors.Hand;
            btndeficitorexcess.FlatAppearance.BorderSize = 0;
            btndeficitorexcess.FlatStyle = FlatStyle.Flat;
            btndeficitorexcess.Font = new Font("Hacen Egypt", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndeficitorexcess.ForeColor = Color.White;
            btndeficitorexcess.Location = new Point(383, 647);
            btndeficitorexcess.Name = "btndeficitorexcess";
            btndeficitorexcess.Size = new Size(178, 74);
            btndeficitorexcess.TabIndex = 68;
            btndeficitorexcess.Text = "حذف البيانات";
            btndeficitorexcess.TextColor = Color.White;
            btndeficitorexcess.UseVisualStyleBackColor = false;
            btndeficitorexcess.Click += btndeficitorexcess_Click;
            // 
            // btns
            // 
            btns.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btns.BackColor = Color.White;
            btns.BackgroundColor = Color.White;
            btns.BorderColor = Color.FromArgb(203, 150, 233);
            btns.BorderRadius = 30;
            btns.BorderSize = 1;
            btns.Cursor = Cursors.Hand;
            btns.FlatAppearance.BorderSize = 0;
            btns.FlatStyle = FlatStyle.Flat;
            btns.Font = new Font("Hacen Egypt", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btns.ForeColor = Color.FromArgb(63, 36, 114);
            btns.Location = new Point(43, 386);
            btns.Name = "btns";
            btns.Size = new Size(400, 220);
            btns.TabIndex = 21;
            btns.Text = "من إكسيـــل";
            btns.TextColor = Color.FromArgb(63, 36, 114);
            btns.UseVisualStyleBackColor = false;
            btns.Click += btns_Click;
            // 
            // khButton7
            // 
            khButton7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            khButton7.BackColor = Color.FromArgb(203, 150, 233);
            khButton7.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton7.BorderColor = Color.FromArgb(203, 150, 233);
            khButton7.BorderRadius = 30;
            khButton7.BorderSize = 2;
            khButton7.Enabled = false;
            khButton7.FlatAppearance.BorderSize = 0;
            khButton7.FlatStyle = FlatStyle.Flat;
            khButton7.ForeColor = Color.White;
            khButton7.Location = new Point(52, 401);
            khButton7.Name = "khButton7";
            khButton7.Size = new Size(400, 220);
            khButton7.TabIndex = 23;
            khButton7.Text = "khButton4";
            khButton7.TextColor = Color.White;
            khButton7.UseVisualStyleBackColor = false;
            // 
            // btncash
            // 
            btncash.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btncash.BackColor = Color.White;
            btncash.BackgroundColor = Color.White;
            btncash.BorderColor = Color.FromArgb(203, 150, 233);
            btncash.BorderRadius = 30;
            btncash.BorderSize = 1;
            btncash.Cursor = Cursors.Hand;
            btncash.FlatAppearance.BorderSize = 0;
            btncash.FlatStyle = FlatStyle.Flat;
            btncash.Font = new Font("Hacen Egypt", 60F);
            btncash.ForeColor = Color.FromArgb(63, 36, 114);
            btncash.Location = new Point(497, 386);
            btncash.Name = "btncash";
            btncash.Size = new Size(400, 220);
            btncash.TabIndex = 22;
            btncash.Text = "إلي إكسيـــل";
            btncash.TextColor = Color.FromArgb(63, 36, 114);
            btncash.UseVisualStyleBackColor = false;
            btncash.Click += btncash_Click;
            // 
            // btntresury
            // 
            btntresury.BackColor = Color.White;
            btntresury.BackgroundColor = Color.White;
            btntresury.BorderColor = Color.FromArgb(203, 150, 233);
            btntresury.BorderRadius = 30;
            btntresury.BorderSize = 1;
            btntresury.Cursor = Cursors.Hand;
            btntresury.FlatAppearance.BorderSize = 0;
            btntresury.FlatStyle = FlatStyle.Flat;
            btntresury.Font = new Font("Hacen Egypt", 54.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntresury.ForeColor = Color.FromArgb(63, 36, 114);
            btntresury.Location = new Point(43, 77);
            btntresury.Name = "btntresury";
            btntresury.Size = new Size(400, 220);
            btntresury.TabIndex = 18;
            btntresury.Text = "إستعادة نسخه";
            btntresury.TextColor = Color.FromArgb(63, 36, 114);
            btntresury.UseVisualStyleBackColor = false;
            btntresury.Click += btntresury_Click;
            // 
            // khButton4
            // 
            khButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            khButton4.BackColor = Color.FromArgb(203, 150, 233);
            khButton4.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton4.BorderColor = Color.FromArgb(203, 150, 233);
            khButton4.BorderRadius = 30;
            khButton4.BorderSize = 2;
            khButton4.Enabled = false;
            khButton4.FlatAppearance.BorderSize = 0;
            khButton4.FlatStyle = FlatStyle.Flat;
            khButton4.ForeColor = Color.White;
            khButton4.Location = new Point(506, 401);
            khButton4.Name = "khButton4";
            khButton4.Size = new Size(400, 220);
            khButton4.TabIndex = 24;
            khButton4.Text = "khButton4";
            khButton4.TextColor = Color.White;
            khButton4.UseVisualStyleBackColor = false;
            // 
            // khButton5
            // 
            khButton5.BackColor = Color.FromArgb(203, 150, 233);
            khButton5.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton5.BorderColor = Color.FromArgb(203, 150, 233);
            khButton5.BorderRadius = 30;
            khButton5.BorderSize = 2;
            khButton5.Enabled = false;
            khButton5.FlatAppearance.BorderSize = 0;
            khButton5.FlatStyle = FlatStyle.Flat;
            khButton5.ForeColor = Color.White;
            khButton5.Location = new Point(52, 92);
            khButton5.Name = "khButton5";
            khButton5.Size = new Size(400, 220);
            khButton5.TabIndex = 19;
            khButton5.Text = "khButton2";
            khButton5.TextColor = Color.White;
            khButton5.UseVisualStyleBackColor = false;
            // 
            // btnproducts
            // 
            btnproducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnproducts.BackColor = Color.White;
            btnproducts.BackgroundColor = Color.White;
            btnproducts.BorderColor = Color.FromArgb(203, 150, 233);
            btnproducts.BorderRadius = 30;
            btnproducts.BorderSize = 1;
            btnproducts.Cursor = Cursors.Hand;
            btnproducts.FlatAppearance.BorderSize = 0;
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Font = new Font("Hacen Egypt", 57F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproducts.ForeColor = Color.FromArgb(63, 36, 114);
            btnproducts.Location = new Point(497, 77);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(400, 220);
            btnproducts.TabIndex = 17;
            btnproducts.Text = "نسخ إحتياطي";
            btnproducts.TextColor = Color.FromArgb(63, 36, 114);
            btnproducts.UseVisualStyleBackColor = false;
            btnproducts.Click += btnproducts_Click;
            // 
            // khButton2
            // 
            khButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            khButton2.BackColor = Color.FromArgb(203, 150, 233);
            khButton2.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton2.BorderColor = Color.FromArgb(203, 150, 233);
            khButton2.BorderRadius = 30;
            khButton2.BorderSize = 2;
            khButton2.Enabled = false;
            khButton2.FlatAppearance.BorderSize = 0;
            khButton2.FlatStyle = FlatStyle.Flat;
            khButton2.ForeColor = Color.White;
            khButton2.Location = new Point(506, 92);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(400, 220);
            khButton2.TabIndex = 20;
            khButton2.Text = "khButton2";
            khButton2.TextColor = Color.White;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // picsahlwhenmax
            // 
            picsahlwhenmax.Anchor = AnchorStyles.None;
            picsahlwhenmax.BackColor = Color.Transparent;
            picsahlwhenmax.Image = Properties.Resources.sahlwhenmax;
            picsahlwhenmax.Location = new Point(339, 244);
            picsahlwhenmax.Name = "picsahlwhenmax";
            picsahlwhenmax.Size = new Size(304, 243);
            picsahlwhenmax.SizeMode = PictureBoxSizeMode.CenterImage;
            picsahlwhenmax.TabIndex = 33;
            picsahlwhenmax.TabStop = false;
            picsahlwhenmax.Visible = false;
            // 
            // SettingFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlcarsoptions);
            ForeColor = Color.FromArgb(119, 67, 219);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingFRM";
            Padding = new Padding(20, 0, 20, 0);
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "x";
            pnlcarsoptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picsahlwhenmax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlcarsoptions;
        private customs.KhControles.KhButton khButton7;
        private customs.KhControles.KhButton btncash;
        private customs.KhControles.KhButton btntresury;
        private customs.KhControles.KhButton khButton4;
        private customs.KhControles.KhButton khButton5;
        private customs.KhControles.KhButton btnproducts;
        private customs.KhControles.KhButton khButton2;
        public PictureBox picsahlwhenmax;
        private customs.KhControles.KhButton btndeficitorexcess;
        private customs.KhControles.KhButton btns;
    }
}