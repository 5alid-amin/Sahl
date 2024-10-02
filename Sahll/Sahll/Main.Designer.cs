namespace Sahll
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnlTop = new Panel();
            btngoback = new customs.KhControles.KhButton();
            lbltoptitle = new Label();
            btncollapes = new customs.KhControles.KhButton();
            btnminimize = new customs.KhControles.KhButton();
            btnmax = new customs.KhControles.KhButton();
            btnclose = new customs.KhControles.KhButton();
            picnavbig = new PictureBox();
            picnavsmall = new PictureBox();
            pnlContainer = new Panel();
            picpointer = new customs.KhControles.KhButton();
            pnlnavbar = new Panel();
            khPanel1 = new customs.KhPanel();
            btnsettings = new Button();
            btnsell = new Button();
            btnusers = new Button();
            btncar = new Button();
            btncustomers = new Button();
            btnstore = new Button();
            btnsuppliers = new Button();
            btnproducts = new Button();
            btnstaff = new Button();
            btntreasury = new Button();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picnavbig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picnavsmall).BeginInit();
            pnlnavbar.SuspendLayout();
            khPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 251, 245);
            pnlTop.Controls.Add(btngoback);
            pnlTop.Controls.Add(lbltoptitle);
            pnlTop.Controls.Add(btncollapes);
            pnlTop.Controls.Add(btnminimize);
            pnlTop.Controls.Add(btnmax);
            pnlTop.Controls.Add(btnclose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1115, 40);
            pnlTop.TabIndex = 0;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            pnlTop.MouseUp += pnlTop_MouseUp;
            // 
            // btngoback
            // 
            btngoback.Anchor = AnchorStyles.Right;
            btngoback.BackColor = Color.Transparent;
            btngoback.BackgroundColor = Color.Transparent;
            btngoback.BorderColor = Color.PaleVioletRed;
            btngoback.BorderRadius = 10;
            btngoback.BorderSize = 0;
            btngoback.Cursor = Cursors.Hand;
            btngoback.FlatAppearance.BorderSize = 0;
            btngoback.FlatStyle = FlatStyle.Flat;
            btngoback.ForeColor = Color.White;
            btngoback.Image = Properties.Resources.go_backl;
            btngoback.Location = new Point(948, -2);
            btngoback.Name = "btngoback";
            btngoback.Size = new Size(37, 36);
            btngoback.TabIndex = 6;
            btngoback.TextColor = Color.White;
            btngoback.UseVisualStyleBackColor = false;
            btngoback.Visible = false;
            btngoback.Click += btngoback_Click;
            btngoback.MouseEnter += btngoback_MouseEnter;
            btngoback.MouseLeave += btngoback_MouseLeave;
            // 
            // lbltoptitle
            // 
            lbltoptitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbltoptitle.AutoSize = true;
            lbltoptitle.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltoptitle.ForeColor = Color.FromArgb(63, 36, 114);
            lbltoptitle.Location = new Point(557, -5);
            lbltoptitle.Name = "lbltoptitle";
            lbltoptitle.Size = new Size(0, 50);
            lbltoptitle.TabIndex = 8;
            lbltoptitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btncollapes
            // 
            btncollapes.Anchor = AnchorStyles.Right;
            btncollapes.BackColor = Color.Transparent;
            btncollapes.BackgroundColor = Color.Transparent;
            btncollapes.BorderColor = Color.PaleVioletRed;
            btncollapes.BorderRadius = 10;
            btncollapes.BorderSize = 0;
            btncollapes.Cursor = Cursors.Hand;
            btncollapes.FlatAppearance.BorderSize = 0;
            btncollapes.FlatStyle = FlatStyle.Flat;
            btncollapes.ForeColor = Color.White;
            btncollapes.Image = Properties.Resources.menu;
            btncollapes.Location = new Point(1077, 4);
            btncollapes.Name = "btncollapes";
            btncollapes.Size = new Size(35, 35);
            btncollapes.TabIndex = 5;
            btncollapes.TextColor = Color.White;
            btncollapes.UseVisualStyleBackColor = false;
            btncollapes.Click += btncollapes_Click;
            // 
            // btnminimize
            // 
            btnminimize.BackColor = Color.Transparent;
            btnminimize.BackgroundColor = Color.Transparent;
            btnminimize.BorderColor = Color.Crimson;
            btnminimize.BorderRadius = 10;
            btnminimize.BorderSize = 0;
            btnminimize.Cursor = Cursors.Hand;
            btnminimize.FlatAppearance.BorderSize = 0;
            btnminimize.FlatStyle = FlatStyle.Flat;
            btnminimize.ForeColor = Color.White;
            btnminimize.Image = Properties.Resources.minimize;
            btnminimize.Location = new Point(64, -2);
            btnminimize.Name = "btnminimize";
            btnminimize.Size = new Size(33, 33);
            btnminimize.TabIndex = 7;
            btnminimize.TextColor = Color.White;
            btnminimize.UseVisualStyleBackColor = false;
            btnminimize.Click += btnminimize_Click;
            // 
            // btnmax
            // 
            btnmax.BackColor = Color.Transparent;
            btnmax.BackgroundColor = Color.Transparent;
            btnmax.BorderColor = Color.Crimson;
            btnmax.BorderRadius = 10;
            btnmax.BorderSize = 0;
            btnmax.Cursor = Cursors.Hand;
            btnmax.FlatAppearance.BorderSize = 0;
            btnmax.FlatStyle = FlatStyle.Flat;
            btnmax.ForeColor = Color.White;
            btnmax.Image = Properties.Resources.maximize;
            btnmax.Location = new Point(31, -2);
            btnmax.Name = "btnmax";
            btnmax.Size = new Size(33, 33);
            btnmax.TabIndex = 6;
            btnmax.TextColor = Color.White;
            btnmax.UseVisualStyleBackColor = false;
            btnmax.Click += btnmax_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Transparent;
            btnclose.BackgroundColor = Color.Transparent;
            btnclose.BorderColor = Color.Crimson;
            btnclose.BorderRadius = 10;
            btnclose.BorderSize = 0;
            btnclose.Cursor = Cursors.Hand;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.ForeColor = Color.White;
            btnclose.Image = Properties.Resources.close;
            btnclose.Location = new Point(-2, -2);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 0;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // picnavbig
            // 
            picnavbig.Anchor = AnchorStyles.Right;
            picnavbig.BackColor = Color.FromArgb(255, 251, 245);
            picnavbig.Image = Properties.Resources.navbig;
            picnavbig.Location = new Point(0, 9);
            picnavbig.Name = "picnavbig";
            picnavbig.Size = new Size(130, 60);
            picnavbig.SizeMode = PictureBoxSizeMode.Zoom;
            picnavbig.TabIndex = 0;
            picnavbig.TabStop = false;
            // 
            // picnavsmall
            // 
            picnavsmall.Anchor = AnchorStyles.Right;
            picnavsmall.BackColor = Color.FromArgb(255, 251, 245);
            picnavsmall.Image = Properties.Resources.navsmall;
            picnavsmall.Location = new Point(70, 11);
            picnavsmall.Name = "picnavsmall";
            picnavsmall.Size = new Size(60, 53);
            picnavsmall.SizeMode = PictureBoxSizeMode.Zoom;
            picnavsmall.TabIndex = 1;
            picnavsmall.TabStop = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(255, 251, 245);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 40);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(15, 0, 15, 0);
            pnlContainer.Size = new Size(985, 750);
            pnlContainer.TabIndex = 2;
            // 
            // picpointer
            // 
            picpointer.BackColor = Color.Transparent;
            picpointer.BackgroundColor = Color.Transparent;
            picpointer.BorderColor = Color.PaleVioletRed;
            picpointer.BorderRadius = 0;
            picpointer.BorderSize = 0;
            picpointer.FlatAppearance.BorderSize = 0;
            picpointer.FlatStyle = FlatStyle.Flat;
            picpointer.ForeColor = Color.White;
            picpointer.Image = Properties.Resources._d;
            picpointer.Location = new Point(-1, 41);
            picpointer.Name = "picpointer";
            picpointer.Size = new Size(18, 54);
            picpointer.TabIndex = 1;
            picpointer.TextColor = Color.White;
            picpointer.UseVisualStyleBackColor = false;
            // 
            // pnlnavbar
            // 
            pnlnavbar.BackColor = Color.FromArgb(255, 251, 245);
            pnlnavbar.Controls.Add(khPanel1);
            pnlnavbar.Controls.Add(picnavbig);
            pnlnavbar.Controls.Add(picnavsmall);
            pnlnavbar.Dock = DockStyle.Right;
            pnlnavbar.Location = new Point(985, 40);
            pnlnavbar.Name = "pnlnavbar";
            pnlnavbar.Size = new Size(130, 750);
            pnlnavbar.TabIndex = 3;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 0;
            khPanel1.Controls.Add(btnsettings);
            khPanel1.Controls.Add(btnsell);
            khPanel1.Controls.Add(btnusers);
            khPanel1.Controls.Add(btncar);
            khPanel1.Controls.Add(btncustomers);
            khPanel1.Controls.Add(btnstore);
            khPanel1.Controls.Add(btnsuppliers);
            khPanel1.Controls.Add(btnproducts);
            khPanel1.Controls.Add(btnstaff);
            khPanel1.Controls.Add(btntreasury);
            khPanel1.Controls.Add(picpointer);
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(82, 46, 150);
            khPanel1.GradientTopColor = Color.FromArgb(107, 60, 200);
            khPanel1.Location = new Point(0, 60);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(130, 688);
            khPanel1.TabIndex = 2;
            // 
            // btnsettings
            // 
            btnsettings.BackColor = Color.Transparent;
            btnsettings.Cursor = Cursors.Hand;
            btnsettings.FlatAppearance.BorderSize = 0;
            btnsettings.FlatStyle = FlatStyle.Flat;
            btnsettings.Font = new Font("Hacen Egypt", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsettings.ForeColor = Color.FromArgb(255, 251, 245);
            btnsettings.Image = Properties.Resources.settingl;
            btnsettings.ImageAlign = ContentAlignment.MiddleRight;
            btnsettings.Location = new Point(0, 526);
            btnsettings.Margin = new Padding(0);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(130, 54);
            btnsettings.TabIndex = 54;
            btnsettings.Text = "الإعدادات";
            btnsettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnsettings.UseVisualStyleBackColor = false;
            btnsettings.Click += btnsettings_Click_1;
            btnsettings.MouseEnter += btnsettings_MouseEnter;
            btnsettings.MouseLeave += btnsettings_MouseLeave;
            // 
            // btnsell
            // 
            btnsell.BackColor = Color.Transparent;
            btnsell.Cursor = Cursors.Hand;
            btnsell.FlatAppearance.BorderSize = 0;
            btnsell.FlatStyle = FlatStyle.Flat;
            btnsell.Font = new Font("Hacen Egypt", 14.25F);
            btnsell.ForeColor = Color.FromArgb(255, 251, 245);
            btnsell.Image = Properties.Resources.selll;
            btnsell.ImageAlign = ContentAlignment.MiddleRight;
            btnsell.Location = new Point(0, 94);
            btnsell.Margin = new Padding(0);
            btnsell.Name = "btnsell";
            btnsell.Size = new Size(130, 54);
            btnsell.TabIndex = 45;
            btnsell.Text = "المبيعات";
            btnsell.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnsell.UseVisualStyleBackColor = false;
            btnsell.Click += btnsell_Click_1;
            btnsell.MouseEnter += btnsell_MouseEnter;
            btnsell.MouseLeave += btnsell_MouseLeave;
            // 
            // btnusers
            // 
            btnusers.BackColor = Color.Transparent;
            btnusers.Cursor = Cursors.Hand;
            btnusers.FlatAppearance.BorderSize = 0;
            btnusers.FlatStyle = FlatStyle.Flat;
            btnusers.Font = new Font("Hacen Egypt", 14.25F);
            btnusers.ForeColor = Color.FromArgb(255, 251, 245);
            btnusers.Image = Properties.Resources.userl;
            btnusers.ImageAlign = ContentAlignment.MiddleRight;
            btnusers.Location = new Point(0, 472);
            btnusers.Margin = new Padding(0);
            btnusers.Name = "btnusers";
            btnusers.Size = new Size(130, 54);
            btnusers.TabIndex = 53;
            btnusers.Text = "المستخدم";
            btnusers.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnusers.UseVisualStyleBackColor = false;
            btnusers.Click += btnusers_Click_1;
            btnusers.MouseEnter += btnusers_MouseEnter;
            btnusers.MouseLeave += btnusers_MouseLeave;
            // 
            // btncar
            // 
            btncar.BackColor = Color.Transparent;
            btncar.Cursor = Cursors.Hand;
            btncar.FlatAppearance.BorderSize = 0;
            btncar.FlatStyle = FlatStyle.Flat;
            btncar.Font = new Font("Hacen Egypt", 14.25F);
            btncar.ForeColor = Color.FromArgb(255, 251, 245);
            btncar.Image = (Image)resources.GetObject("btncar.Image");
            btncar.ImageAlign = ContentAlignment.MiddleRight;
            btncar.Location = new Point(0, 40);
            btncar.Margin = new Padding(0);
            btncar.Name = "btncar";
            btncar.Size = new Size(130, 54);
            btncar.TabIndex = 47;
            btncar.Text = "السيارات";
            btncar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btncar.UseVisualStyleBackColor = false;
            btncar.Click += btncar_Click_1;
            btncar.MouseEnter += btncar_MouseEnter;
            btncar.MouseLeave += btncar_MouseLeave;
            // 
            // btncustomers
            // 
            btncustomers.BackColor = Color.Transparent;
            btncustomers.Cursor = Cursors.Hand;
            btncustomers.FlatAppearance.BorderSize = 0;
            btncustomers.FlatStyle = FlatStyle.Flat;
            btncustomers.Font = new Font("Hacen Egypt", 14.25F);
            btncustomers.ForeColor = Color.FromArgb(255, 251, 245);
            btncustomers.Image = Properties.Resources.customerl;
            btncustomers.ImageAlign = ContentAlignment.MiddleRight;
            btncustomers.Location = new Point(0, 418);
            btncustomers.Margin = new Padding(0);
            btncustomers.Name = "btncustomers";
            btncustomers.Size = new Size(130, 54);
            btncustomers.TabIndex = 52;
            btncustomers.Text = "العملاء";
            btncustomers.TextImageRelation = TextImageRelation.TextBeforeImage;
            btncustomers.UseVisualStyleBackColor = false;
            btncustomers.Click += btncustomers_Click_1;
            btncustomers.MouseEnter += btncustomers_MouseEnter;
            btncustomers.MouseLeave += btncustomers_MouseLeave;
            // 
            // btnstore
            // 
            btnstore.BackColor = Color.Transparent;
            btnstore.Cursor = Cursors.Hand;
            btnstore.FlatAppearance.BorderSize = 0;
            btnstore.FlatStyle = FlatStyle.Flat;
            btnstore.Font = new Font("Hacen Egypt", 14.25F);
            btnstore.ForeColor = Color.FromArgb(255, 251, 245);
            btnstore.Image = Properties.Resources.storel;
            btnstore.ImageAlign = ContentAlignment.MiddleRight;
            btnstore.Location = new Point(0, 148);
            btnstore.Margin = new Padding(0);
            btnstore.Name = "btnstore";
            btnstore.Size = new Size(130, 54);
            btnstore.TabIndex = 46;
            btnstore.Text = "المخزن";
            btnstore.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnstore.UseVisualStyleBackColor = false;
            btnstore.Click += btnstore_Click_1;
            btnstore.MouseEnter += btnstore_MouseEnter;
            btnstore.MouseLeave += btnstore_MouseLeave;
            // 
            // btnsuppliers
            // 
            btnsuppliers.BackColor = Color.Transparent;
            btnsuppliers.Cursor = Cursors.Hand;
            btnsuppliers.FlatAppearance.BorderSize = 0;
            btnsuppliers.FlatStyle = FlatStyle.Flat;
            btnsuppliers.Font = new Font("Hacen Egypt", 14.25F);
            btnsuppliers.ForeColor = Color.FromArgb(255, 251, 245);
            btnsuppliers.Image = Properties.Resources.supplierl;
            btnsuppliers.ImageAlign = ContentAlignment.MiddleRight;
            btnsuppliers.Location = new Point(0, 364);
            btnsuppliers.Margin = new Padding(0);
            btnsuppliers.Name = "btnsuppliers";
            btnsuppliers.Size = new Size(130, 54);
            btnsuppliers.TabIndex = 51;
            btnsuppliers.Text = "الموردين";
            btnsuppliers.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnsuppliers.UseVisualStyleBackColor = false;
            btnsuppliers.Click += btnsuppliers_Click_1;
            btnsuppliers.MouseEnter += btnsuppliers_MouseEnter;
            btnsuppliers.MouseLeave += btnsuppliers_MouseLeave;
            // 
            // btnproducts
            // 
            btnproducts.BackColor = Color.Transparent;
            btnproducts.Cursor = Cursors.Hand;
            btnproducts.FlatAppearance.BorderSize = 0;
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Font = new Font("Hacen Egypt", 14.25F);
            btnproducts.ForeColor = Color.FromArgb(255, 251, 245);
            btnproducts.Image = Properties.Resources.productl;
            btnproducts.ImageAlign = ContentAlignment.MiddleRight;
            btnproducts.Location = new Point(0, 202);
            btnproducts.Margin = new Padding(0);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(130, 54);
            btnproducts.TabIndex = 48;
            btnproducts.Text = "المنتجات";
            btnproducts.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnproducts.UseVisualStyleBackColor = false;
            btnproducts.Click += btnproducts_Click_1;
            btnproducts.MouseEnter += btnproducts_MouseEnter;
            btnproducts.MouseLeave += btnproducts_MouseLeave;
            // 
            // btnstaff
            // 
            btnstaff.BackColor = Color.Transparent;
            btnstaff.Cursor = Cursors.Hand;
            btnstaff.FlatAppearance.BorderSize = 0;
            btnstaff.FlatStyle = FlatStyle.Flat;
            btnstaff.Font = new Font("Hacen Egypt", 14.25F);
            btnstaff.ForeColor = Color.FromArgb(255, 251, 245);
            btnstaff.Image = Properties.Resources.staffl;
            btnstaff.ImageAlign = ContentAlignment.MiddleRight;
            btnstaff.Location = new Point(0, 310);
            btnstaff.Margin = new Padding(0);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(130, 54);
            btnstaff.TabIndex = 50;
            btnstaff.Text = "العاملين";
            btnstaff.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnstaff.UseVisualStyleBackColor = false;
            btnstaff.Click += btnstaff_Click_1;
            btnstaff.MouseEnter += btnstaff_MouseEnter;
            btnstaff.MouseLeave += btnstaff_MouseLeave;
            // 
            // btntreasury
            // 
            btntreasury.BackColor = Color.Transparent;
            btntreasury.Cursor = Cursors.Hand;
            btntreasury.FlatAppearance.BorderSize = 0;
            btntreasury.FlatStyle = FlatStyle.Flat;
            btntreasury.Font = new Font("Hacen Egypt", 14.25F);
            btntreasury.ForeColor = Color.FromArgb(255, 251, 245);
            btntreasury.Image = Properties.Resources.treasuryL;
            btntreasury.ImageAlign = ContentAlignment.MiddleRight;
            btntreasury.Location = new Point(0, 256);
            btntreasury.Margin = new Padding(0);
            btntreasury.Name = "btntreasury";
            btntreasury.Size = new Size(130, 54);
            btntreasury.TabIndex = 49;
            btntreasury.Text = "الخزينه";
            btntreasury.TextImageRelation = TextImageRelation.TextBeforeImage;
            btntreasury.UseVisualStyleBackColor = false;
            btntreasury.Click += btntreasury_Click_1;
            btntreasury.MouseEnter += btntreasury_MouseEnter;
            btntreasury.MouseLeave += btntreasury_MouseLeave;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 790);
            Controls.Add(pnlContainer);
            Controls.Add(pnlnavbar);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picnavbig).EndInit();
            ((System.ComponentModel.ISupportInitialize)picnavsmall).EndInit();
            pnlnavbar.ResumeLayout(false);
            khPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private PictureBox picnavbig;
        private PictureBox picnavsmall;
        private Panel pnlnavbar;
        private customs.KhPanel khPanel1;
        private customs.KhControles.KhButton btnclose;
        private customs.KhControles.KhButton btncollapes;
        private customs.KhControles.KhButton btnmax;
        private customs.KhControles.KhButton btnminimize;
        private customs.KhControles.KhButton picpointer;
        private Button btnsettings;
        private Button btnsell;
        private Button btnusers;
        private Button btncar;
        private Button btncustomers;
        private Button btnstore;
        private Button btnsuppliers;
        private Button btnproducts;
        private Button btnstaff;
        private Button btntreasury;
        private customs.KhControles.KhButton btngoback;
        public Panel pnlContainer;
        public Label lbltoptitle;
    }
}
