namespace Sahll.JUI.Car.InfoForms
{
    partial class AminHomeInfoFRM
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
            khPanel1 = new customs.KhPanel();
            label3 = new Label();
            txtprice = new Label();
            btnclose = new customs.KhControles.KhButton();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label1 = new Label();
            txtnote = new Label();
            khPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BackgroundImageLayout = ImageLayout.None;
            khPanel1.BorderRadius = 0;
            khPanel1.Controls.Add(label3);
            khPanel1.Controls.Add(txtprice);
            khPanel1.Controls.Add(btnclose);
            khPanel1.Controls.Add(label22);
            khPanel1.Controls.Add(label23);
            khPanel1.Controls.Add(label24);
            khPanel1.Controls.Add(label25);
            khPanel1.Controls.Add(label26);
            khPanel1.Controls.Add(label27);
            khPanel1.Controls.Add(label1);
            khPanel1.Controls.Add(txtnote);
            khPanel1.Dock = DockStyle.Fill;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 10F;
            khPanel1.GradientBottomColor = Color.Black;
            khPanel1.GradientTopColor = Color.FromArgb(83, 4, 128);
            khPanel1.Location = new Point(0, 0);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(1115, 790);
            khPanel1.TabIndex = 28;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("LBC", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(219, 181, 181);
            label3.Location = new Point(484, 330);
            label3.Name = "label3";
            label3.Size = new Size(140, 61);
            label3.TabIndex = 63;
            label3.Text = "المبلغ";
            // 
            // txtprice
            // 
            txtprice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtprice.BackColor = Color.Transparent;
            txtprice.Font = new Font("Hacen Egypt", 42F);
            txtprice.ForeColor = Color.White;
            txtprice.Location = new Point(12, 375);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(1091, 100);
            txtprice.TabIndex = 64;
            txtprice.Text = "215643";
            txtprice.TextAlign = ContentAlignment.MiddleCenter;
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
            btnclose.Location = new Point(0, 0);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 62;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Left;
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("LBC", 18F);
            label22.ForeColor = Color.FromArgb(219, 181, 181);
            label22.Location = new Point(108, 695);
            label22.Name = "label22";
            label22.Size = new Size(62, 31);
            label22.TabIndex = 38;
            label22.Text = "اليوم";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("LBC", 18F);
            label23.ForeColor = Color.FromArgb(219, 181, 181);
            label23.Location = new Point(518, 695);
            label23.Name = "label23";
            label23.Size = new Size(70, 31);
            label23.TabIndex = 39;
            label23.Text = "التاريخ";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Right;
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("LBC", 18F);
            label24.ForeColor = Color.FromArgb(219, 181, 181);
            label24.Location = new Point(920, 695);
            label24.Name = "label24";
            label24.Size = new Size(91, 31);
            label24.TabIndex = 40;
            label24.Text = "بواسطة";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Left;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Hacen Egypt", 21.75F);
            label25.ForeColor = Color.White;
            label25.Location = new Point(3, 726);
            label25.Name = "label25";
            label25.Size = new Size(283, 64);
            label25.TabIndex = 41;
            label25.Text = "الأربعاء";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Hacen Egypt", 21.75F);
            label26.ForeColor = Color.White;
            label26.Location = new Point(406, 726);
            label26.Name = "label26";
            label26.Size = new Size(303, 64);
            label26.TabIndex = 42;
            label26.Text = "28/12/2004";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Right;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Hacen Egypt", 21.75F);
            label27.ForeColor = Color.White;
            label27.Location = new Point(828, 726);
            label27.Name = "label27";
            label27.Size = new Size(287, 64);
            label27.TabIndex = 43;
            label27.Text = "محمد عبد الكريم ";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("LBC", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(219, 181, 181);
            label1.Location = new Point(459, 73);
            label1.Name = "label1";
            label1.Size = new Size(197, 61);
            label1.TabIndex = 28;
            label1.Text = "الملاحظه";
            label1.Click += label1_Click;
            // 
            // txtnote
            // 
            txtnote.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtnote.BackColor = Color.Transparent;
            txtnote.Font = new Font("Hacen Egypt", 42F);
            txtnote.ForeColor = Color.White;
            txtnote.Location = new Point(12, 111);
            txtnote.Name = "txtnote";
            txtnote.Size = new Size(1091, 100);
            txtnote.TabIndex = 29;
            txtnote.Text = "لتحويل النقود في البريد للاستاذ عادل صباحا";
            txtnote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AminHomeInfoFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 3, 81);
            ClientSize = new Size(1115, 790);
            Controls.Add(khPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AminHomeInfoFRM";
            Opacity = 0.95D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "product_infoFRM";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            khPanel1.ResumeLayout(false);
            khPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private customs.KhPanel khPanel1;
        private Label label1;
        private Label txtnote;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private customs.KhControles.KhButton btnclose;
        private Label label3;
        private Label txtprice;
    }
}