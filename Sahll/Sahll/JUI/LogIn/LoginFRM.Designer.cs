namespace Sahll.JUI.PL
{
    partial class LoginFRM
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
            pictureBox1 = new PictureBox();
            btnclose = new customs.KhControles.KhButton();
            khButton1 = new customs.KhControles.KhButton();
            khButton2 = new customs.KhControles.KhButton();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            khPanel3 = new customs.KhPanel();
            txtusername = new TextBox();
            khButton3 = new customs.KhControles.KhButton();
            label4 = new Label();
            label2 = new Label();
            khButton4 = new customs.KhControles.KhButton();
            txtpassword = new TextBox();
            khPanel1 = new customs.KhPanel();
            lblforgetingpassword = new Label();
            btnLogIn = new customs.KhControles.KhButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.sahl_logo_1;
            pictureBox1.Location = new Point(49, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            btnclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnclose.BackColor = Color.Transparent;
            btnclose.BackgroundColor = Color.Transparent;
            btnclose.BorderColor = Color.Crimson;
            btnclose.BorderRadius = 0;
            btnclose.BorderSize = 0;
            btnclose.Cursor = Cursors.Hand;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.ForeColor = Color.White;
            btnclose.Image = Properties.Resources.close;
            btnclose.ImageAlign = ContentAlignment.BottomLeft;
            btnclose.Location = new Point(1084, -11);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(41, 41);
            btnclose.TabIndex = 1;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // khButton1
            // 
            khButton1.Anchor = AnchorStyles.Right;
            khButton1.BackColor = Color.White;
            khButton1.BackgroundColor = Color.White;
            khButton1.BorderColor = Color.FromArgb(63, 36, 114);
            khButton1.BorderRadius = 40;
            khButton1.BorderSize = 1;
            khButton1.Enabled = false;
            khButton1.FlatAppearance.BorderSize = 0;
            khButton1.FlatStyle = FlatStyle.Flat;
            khButton1.ForeColor = Color.Transparent;
            khButton1.Location = new Point(516, 68);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(480, 630);
            khButton1.TabIndex = 2;
            khButton1.Text = "khButton1";
            khButton1.TextColor = Color.Transparent;
            khButton1.UseVisualStyleBackColor = false;
            // 
            // khButton2
            // 
            khButton2.Anchor = AnchorStyles.Right;
            khButton2.BackColor = Color.FromArgb(221, 180, 244);
            khButton2.BackgroundColor = Color.FromArgb(221, 180, 244);
            khButton2.BorderColor = Color.FromArgb(63, 36, 114);
            khButton2.BorderRadius = 40;
            khButton2.BorderSize = 0;
            khButton2.Enabled = false;
            khButton2.FlatAppearance.BorderSize = 0;
            khButton2.FlatStyle = FlatStyle.Flat;
            khButton2.ForeColor = Color.Transparent;
            khButton2.Location = new Point(532, 85);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(480, 630);
            khButton2.TabIndex = 3;
            khButton2.Text = "khButton2";
            khButton2.TextColor = Color.Transparent;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Hacen Egypt", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(85, 48, 175);
            label1.Location = new Point(615, 72);
            label1.Name = "label1";
            label1.Size = new Size(368, 89);
            label1.TabIndex = 0;
            label1.Text = "مرحباً وســــــهلاً";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.heart_1;
            pictureBox2.Location = new Point(543, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // khPanel3
            // 
            khPanel3.Anchor = AnchorStyles.Right;
            khPanel3.BackColor = Color.White;
            khPanel3.BorderRadius = 2;
            khPanel3.ForeColor = Color.Black;
            khPanel3.GradientAngle = 90F;
            khPanel3.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel3.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel3.Location = new Point(548, 385);
            khPanel3.Name = "khPanel3";
            khPanel3.Size = new Size(415, 3);
            khPanel3.TabIndex = 78;
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.Right;
            txtusername.BackColor = Color.FromArgb(255, 247, 244);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Hacen Egypt", 33.75F);
            txtusername.ForeColor = Color.FromArgb(63, 36, 114);
            txtusername.Location = new Point(550, 294);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(412, 94);
            txtusername.TabIndex = 77;
            txtusername.TextAlign = HorizontalAlignment.Center;
            // 
            // khButton3
            // 
            khButton3.Anchor = AnchorStyles.Right;
            khButton3.BackColor = Color.FromArgb(255, 247, 244);
            khButton3.BackgroundColor = Color.FromArgb(255, 247, 244);
            khButton3.BorderColor = Color.FromArgb(63, 36, 114);
            khButton3.BorderRadius = 40;
            khButton3.BorderSize = 0;
            khButton3.Enabled = false;
            khButton3.FlatAppearance.BorderSize = 0;
            khButton3.FlatStyle = FlatStyle.Flat;
            khButton3.ForeColor = Color.White;
            khButton3.Location = new Point(541, 288);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(430, 100);
            khButton3.TabIndex = 79;
            khButton3.Text = "khButton3";
            khButton3.TextColor = Color.White;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.BackColor = Color.White;
            label4.Font = new Font("Hacen Egypt", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(203, 150, 233);
            label4.Location = new Point(606, 192);
            label4.Name = "label4";
            label4.Size = new Size(301, 86);
            label4.TabIndex = 76;
            label4.Text = "إسم المستخدم";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.BackColor = Color.White;
            label2.Font = new Font("Hacen Egypt", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(203, 150, 233);
            label2.Location = new Point(606, 385);
            label2.Name = "label2";
            label2.Size = new Size(301, 86);
            label2.TabIndex = 76;
            label2.Text = "كلمـــة المرور";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // khButton4
            // 
            khButton4.Anchor = AnchorStyles.Right;
            khButton4.BackColor = Color.FromArgb(255, 247, 244);
            khButton4.BackgroundColor = Color.FromArgb(255, 247, 244);
            khButton4.BorderColor = Color.FromArgb(63, 36, 114);
            khButton4.BorderRadius = 40;
            khButton4.BorderSize = 0;
            khButton4.Enabled = false;
            khButton4.FlatAppearance.BorderSize = 0;
            khButton4.FlatStyle = FlatStyle.Flat;
            khButton4.ForeColor = Color.White;
            khButton4.Location = new Point(542, 476);
            khButton4.Name = "khButton4";
            khButton4.Size = new Size(430, 100);
            khButton4.TabIndex = 79;
            khButton4.Text = "khButton3";
            khButton4.TextColor = Color.White;
            khButton4.UseVisualStyleBackColor = false;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Right;
            txtpassword.BackColor = Color.FromArgb(255, 247, 244);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Hacen Egypt", 33.75F);
            txtpassword.ForeColor = Color.FromArgb(63, 36, 114);
            txtpassword.Location = new Point(551, 482);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(412, 94);
            txtpassword.TabIndex = 77;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // khPanel1
            // 
            khPanel1.Anchor = AnchorStyles.Right;
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 2;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel1.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel1.Location = new Point(549, 573);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(415, 3);
            khPanel1.TabIndex = 78;
            // 
            // lblforgetingpassword
            // 
            lblforgetingpassword.Anchor = AnchorStyles.Right;
            lblforgetingpassword.BackColor = Color.White;
            lblforgetingpassword.Cursor = Cursors.Hand;
            lblforgetingpassword.Font = new Font("Hacen Egypt", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblforgetingpassword.ForeColor = Color.FromArgb(203, 150, 233);
            lblforgetingpassword.Location = new Point(541, 567);
            lblforgetingpassword.Name = "lblforgetingpassword";
            lblforgetingpassword.Size = new Size(132, 31);
            lblforgetingpassword.TabIndex = 76;
            lblforgetingpassword.Text = "نسيت كلمة المرور";
            lblforgetingpassword.TextAlign = ContentAlignment.MiddleCenter;
            lblforgetingpassword.Click += label3_Click;
            lblforgetingpassword.MouseEnter += label3_MouseEnter;
            lblforgetingpassword.MouseLeave += label3_MouseLeave;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Right;
            btnLogIn.BackColor = Color.White;
            btnLogIn.BackgroundColor = Color.White;
            btnLogIn.BorderColor = Color.FromArgb(63, 36, 114);
            btnLogIn.BorderRadius = 40;
            btnLogIn.BorderSize = 1;
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Hacen Egypt", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.FromArgb(85, 48, 175);
            btnLogIn.Location = new Point(640, 620);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(232, 68);
            btnLogIn.TabIndex = 80;
            btnLogIn.Text = "تسجـــيل الدخــول";
            btnLogIn.TextColor = Color.FromArgb(85, 48, 175);
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.MouseEnter += khButton5_MouseEnter;
            btnLogIn.MouseLeave += khButton5_MouseLeave;
            // 
            // LoginFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1115, 790);
            Controls.Add(btnLogIn);
            Controls.Add(khPanel1);
            Controls.Add(khPanel3);
            Controls.Add(txtpassword);
            Controls.Add(khButton4);
            Controls.Add(txtusername);
            Controls.Add(lblforgetingpassword);
            Controls.Add(label2);
            Controls.Add(khButton3);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(khButton1);
            Controls.Add(khButton2);
            Controls.Add(btnclose);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFRM";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private customs.KhControles.KhButton btnclose;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhButton khButton2;
        private Label label1;
        private PictureBox pictureBox2;
        private customs.KhPanel khPanel3;
        private TextBox txtusername;
        private customs.KhControles.KhButton khButton3;
        private Label label4;
        private Label label2;
        private customs.KhControles.KhButton khButton4;
        private TextBox txtpassword;
        private customs.KhPanel khPanel1;
        private Label lblforgetingpassword;
        private customs.KhControles.KhButton btnLogIn;
    }
}