namespace Sahll.JUI.User
{
    partial class UserAddEditFRM
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
            btnclose = new customs.KhControles.KhButton();
            label2 = new Label();
            khPanel4 = new customs.KhPanel();
            khPanel3 = new customs.KhPanel();
            khPanel2 = new customs.KhPanel();
            khPanel6 = new customs.KhPanel();
            label4 = new Label();
            khButton3 = new customs.KhControles.KhButton();
            txtusername = new TextBox();
            khPanel7 = new customs.KhPanel();
            label1 = new Label();
            cmbrole = new ComboBox();
            khButton2 = new customs.KhControles.KhButton();
            label3 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            khPanel1 = new customs.KhPanel();
            label5 = new Label();
            khButton4 = new customs.KhControles.KhButton();
            khPanel5 = new customs.KhPanel();
            label6 = new Label();
            label7 = new Label();
            khButton6 = new customs.KhControles.KhButton();
            khPanel9 = new customs.KhPanel();
            khButton7 = new customs.KhControles.KhButton();
            cmbquestions = new ComboBox();
            label8 = new Label();
            picuserimage = new PictureBox();
            txtanswer = new TextBox();
            txtconfermpassword = new TextBox();
            txtpassword = new TextBox();
            btnsave = new customs.KhControles.KhButton();
            ((System.ComponentModel.ISupportInitialize)picuserimage).BeginInit();
            SuspendLayout();
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
            btnclose.Location = new Point(0, 0);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 84;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("LBC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 36, 114);
            label2.Location = new Point(403, -1);
            label2.Name = "label2";
            label2.Size = new Size(194, 37);
            label2.TabIndex = 83;
            label2.Tag = "";
            label2.Text = "إضافه مستخدم";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // khPanel4
            // 
            khPanel4.BackColor = Color.White;
            khPanel4.BorderRadius = 0;
            khPanel4.Dock = DockStyle.Bottom;
            khPanel4.ForeColor = Color.Black;
            khPanel4.GradientAngle = 90F;
            khPanel4.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel4.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel4.Location = new Point(2, 698);
            khPanel4.Name = "khPanel4";
            khPanel4.Size = new Size(996, 2);
            khPanel4.TabIndex = 88;
            // 
            // khPanel3
            // 
            khPanel3.BackColor = Color.White;
            khPanel3.BorderRadius = 0;
            khPanel3.Dock = DockStyle.Top;
            khPanel3.ForeColor = Color.Black;
            khPanel3.GradientAngle = 90F;
            khPanel3.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel3.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel3.Location = new Point(2, 0);
            khPanel3.Name = "khPanel3";
            khPanel3.Size = new Size(996, 2);
            khPanel3.TabIndex = 87;
            // 
            // khPanel2
            // 
            khPanel2.BackColor = Color.White;
            khPanel2.BorderRadius = 0;
            khPanel2.Dock = DockStyle.Left;
            khPanel2.ForeColor = Color.Black;
            khPanel2.GradientAngle = 90F;
            khPanel2.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel2.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel2.Location = new Point(0, 0);
            khPanel2.Name = "khPanel2";
            khPanel2.Size = new Size(2, 700);
            khPanel2.TabIndex = 86;
            // 
            // khPanel6
            // 
            khPanel6.BackColor = Color.White;
            khPanel6.BorderRadius = 0;
            khPanel6.Dock = DockStyle.Right;
            khPanel6.ForeColor = Color.Black;
            khPanel6.GradientAngle = 90F;
            khPanel6.GradientBottomColor = Color.FromArgb(83, 4, 128);
            khPanel6.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel6.Location = new Point(998, 0);
            khPanel6.Name = "khPanel6";
            khPanel6.Size = new Size(2, 700);
            khPanel6.TabIndex = 85;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Hacen Egypt", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(63, 36, 114);
            label4.Location = new Point(826, 75);
            label4.Name = "label4";
            label4.Size = new Size(181, 75);
            label4.TabIndex = 79;
            label4.Tag = "";
            label4.Text = "إسم المستخدم";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // khButton3
            // 
            khButton3.BackColor = Color.White;
            khButton3.BackgroundColor = Color.White;
            khButton3.BorderColor = Color.FromArgb(63, 36, 114);
            khButton3.BorderRadius = 40;
            khButton3.BorderSize = 0;
            khButton3.Enabled = false;
            khButton3.FlatAppearance.BorderSize = 0;
            khButton3.FlatStyle = FlatStyle.Flat;
            khButton3.ForeColor = Color.White;
            khButton3.Location = new Point(432, 54);
            khButton3.Name = "khButton3";
            khButton3.Size = new Size(398, 99);
            khButton3.TabIndex = 82;
            khButton3.Text = "khButton1";
            khButton3.TextColor = Color.White;
            khButton3.UseVisualStyleBackColor = false;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Hacen Egypt", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.FromArgb(63, 36, 114);
            txtusername.Location = new Point(441, 60);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(381, 89);
            txtusername.TabIndex = 80;
            txtusername.TextAlign = HorizontalAlignment.Center;
            // 
            // khPanel7
            // 
            khPanel7.BackColor = Color.White;
            khPanel7.BorderRadius = 2;
            khPanel7.ForeColor = Color.Black;
            khPanel7.GradientAngle = 90F;
            khPanel7.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel7.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel7.Location = new Point(442, 150);
            khPanel7.Name = "khPanel7";
            khPanel7.Size = new Size(381, 3);
            khPanel7.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hacen Egypt", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 36, 114);
            label1.Location = new Point(326, 78);
            label1.Name = "label1";
            label1.Size = new Size(94, 75);
            label1.TabIndex = 79;
            label1.Tag = "";
            label1.Text = "الرتبه";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbrole
            // 
            cmbrole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbrole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbrole.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbrole.BackColor = Color.White;
            cmbrole.DropDownHeight = 150;
            cmbrole.Font = new Font("Hacen Egypt", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbrole.ForeColor = Color.FromArgb(63, 36, 114);
            cmbrole.FormattingEnabled = true;
            cmbrole.IntegralHeight = false;
            cmbrole.Location = new Point(43, 62);
            cmbrole.Name = "cmbrole";
            cmbrole.Size = new Size(277, 91);
            cmbrole.TabIndex = 90;
            // 
            // khButton2
            // 
            khButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton2.BackColor = Color.FromArgb(203, 150, 233);
            khButton2.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton2.BorderColor = Color.FromArgb(203, 150, 233);
            khButton2.BorderRadius = 40;
            khButton2.BorderSize = 1;
            khButton2.Enabled = false;
            khButton2.FlatAppearance.BorderSize = 0;
            khButton2.FlatStyle = FlatStyle.Flat;
            khButton2.ForeColor = SystemColors.Window;
            khButton2.Location = new Point(30, 60);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(302, 94);
            khButton2.TabIndex = 89;
            khButton2.Text = "khButton1";
            khButton2.TextColor = SystemColors.Window;
            khButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Hacen Egypt", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 36, 114);
            label3.Location = new Point(847, 189);
            label3.Name = "label3";
            label3.Size = new Size(160, 75);
            label3.TabIndex = 79;
            label3.Tag = "";
            label3.Text = "الرقم السري";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label4_Click;
            // 
            // khButton1
            // 
            khButton1.BackColor = Color.White;
            khButton1.BackgroundColor = Color.White;
            khButton1.BorderColor = Color.FromArgb(63, 36, 114);
            khButton1.BorderRadius = 40;
            khButton1.BorderSize = 0;
            khButton1.Enabled = false;
            khButton1.FlatAppearance.BorderSize = 0;
            khButton1.FlatStyle = FlatStyle.Flat;
            khButton1.ForeColor = Color.White;
            khButton1.Location = new Point(432, 168);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(398, 99);
            khButton1.TabIndex = 82;
            khButton1.Text = "khButton1";
            khButton1.TextColor = Color.White;
            khButton1.UseVisualStyleBackColor = false;
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 2;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel1.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel1.Location = new Point(442, 264);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(381, 3);
            khPanel1.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Hacen Egypt", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(63, 36, 114);
            label5.Location = new Point(847, 303);
            label5.Name = "label5";
            label5.Size = new Size(160, 75);
            label5.TabIndex = 79;
            label5.Tag = "";
            label5.Text = "الرقم السري";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Click += label4_Click;
            // 
            // khButton4
            // 
            khButton4.BackColor = Color.White;
            khButton4.BackgroundColor = Color.White;
            khButton4.BorderColor = Color.FromArgb(63, 36, 114);
            khButton4.BorderRadius = 40;
            khButton4.BorderSize = 0;
            khButton4.Enabled = false;
            khButton4.FlatAppearance.BorderSize = 0;
            khButton4.FlatStyle = FlatStyle.Flat;
            khButton4.ForeColor = Color.White;
            khButton4.Location = new Point(432, 279);
            khButton4.Name = "khButton4";
            khButton4.Size = new Size(398, 99);
            khButton4.TabIndex = 82;
            khButton4.Text = "khButton1";
            khButton4.TextColor = Color.White;
            khButton4.UseVisualStyleBackColor = false;
            // 
            // khPanel5
            // 
            khPanel5.BackColor = Color.White;
            khPanel5.BorderRadius = 2;
            khPanel5.ForeColor = Color.Black;
            khPanel5.GradientAngle = 90F;
            khPanel5.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel5.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel5.Location = new Point(442, 378);
            khPanel5.Name = "khPanel5";
            khPanel5.Size = new Size(381, 3);
            khPanel5.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Hacen Egypt", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(63, 36, 114);
            label6.Location = new Point(864, 414);
            label6.Name = "label6";
            label6.Size = new Size(143, 75);
            label6.TabIndex = 79;
            label6.Tag = "";
            label6.Text = "اختر سؤالا";
            label6.TextAlign = ContentAlignment.MiddleRight;
            label6.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Hacen Egypt", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(63, 36, 114);
            label7.Location = new Point(838, 533);
            label7.Name = "label7";
            label7.Size = new Size(170, 75);
            label7.TabIndex = 79;
            label7.Tag = "";
            label7.Text = "أُكتب الإجابه";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.Click += label4_Click;
            // 
            // khButton6
            // 
            khButton6.BackColor = Color.White;
            khButton6.BackgroundColor = Color.White;
            khButton6.BorderColor = Color.FromArgb(63, 36, 114);
            khButton6.BorderRadius = 40;
            khButton6.BorderSize = 0;
            khButton6.Enabled = false;
            khButton6.FlatAppearance.BorderSize = 0;
            khButton6.FlatStyle = FlatStyle.Flat;
            khButton6.ForeColor = Color.White;
            khButton6.Location = new Point(432, 512);
            khButton6.Name = "khButton6";
            khButton6.Size = new Size(398, 99);
            khButton6.TabIndex = 82;
            khButton6.Text = "khButton1";
            khButton6.TextColor = Color.White;
            khButton6.UseVisualStyleBackColor = false;
            // 
            // khPanel9
            // 
            khPanel9.BackColor = Color.White;
            khPanel9.BorderRadius = 2;
            khPanel9.ForeColor = Color.Black;
            khPanel9.GradientAngle = 90F;
            khPanel9.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel9.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel9.Location = new Point(442, 608);
            khPanel9.Name = "khPanel9";
            khPanel9.Size = new Size(381, 3);
            khPanel9.TabIndex = 81;
            // 
            // khButton7
            // 
            khButton7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            khButton7.BackColor = Color.FromArgb(203, 150, 233);
            khButton7.BackgroundColor = Color.FromArgb(203, 150, 233);
            khButton7.BorderColor = Color.FromArgb(203, 150, 233);
            khButton7.BorderRadius = 40;
            khButton7.BorderSize = 1;
            khButton7.Enabled = false;
            khButton7.FlatAppearance.BorderSize = 0;
            khButton7.FlatStyle = FlatStyle.Flat;
            khButton7.ForeColor = SystemColors.Window;
            khButton7.Location = new Point(428, 404);
            khButton7.Name = "khButton7";
            khButton7.Size = new Size(408, 88);
            khButton7.TabIndex = 89;
            khButton7.Text = "khButton1";
            khButton7.TextColor = SystemColors.Window;
            khButton7.UseVisualStyleBackColor = false;
            // 
            // cmbquestions
            // 
            cmbquestions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbquestions.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbquestions.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbquestions.BackColor = Color.White;
            cmbquestions.DropDownHeight = 150;
            cmbquestions.Font = new Font("Hacen Egypt", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbquestions.ForeColor = Color.FromArgb(63, 36, 114);
            cmbquestions.FormattingEnabled = true;
            cmbquestions.IntegralHeight = false;
            cmbquestions.Location = new Point(442, 406);
            cmbquestions.Name = "cmbquestions";
            cmbquestions.Size = new Size(380, 85);
            cmbquestions.TabIndex = 90;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Hacen Egypt", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(63, 36, 114);
            label8.Location = new Point(151, 173);
            label8.Name = "label8";
            label8.Size = new Size(107, 75);
            label8.TabIndex = 79;
            label8.Tag = "";
            label8.Text = "الصوره";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picuserimage
            // 
            picuserimage.BorderStyle = BorderStyle.FixedSingle;
            picuserimage.Cursor = Cursors.Hand;
            picuserimage.Image = Properties.Resources.User_07b;
            picuserimage.Location = new Point(24, 264);
            picuserimage.Name = "picuserimage";
            picuserimage.Size = new Size(370, 347);
            picuserimage.SizeMode = PictureBoxSizeMode.Zoom;
            picuserimage.TabIndex = 91;
            picuserimage.TabStop = false;
            picuserimage.Click += picuserimage_Click;
            // 
            // txtanswer
            // 
            txtanswer.BorderStyle = BorderStyle.None;
            txtanswer.Font = new Font("Hacen Egypt", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtanswer.ForeColor = Color.FromArgb(63, 36, 114);
            txtanswer.Location = new Point(445, 519);
            txtanswer.Name = "txtanswer";
            txtanswer.Size = new Size(381, 89);
            txtanswer.TabIndex = 80;
            txtanswer.TextAlign = HorizontalAlignment.Center;
            // 
            // txtconfermpassword
            // 
            txtconfermpassword.BorderStyle = BorderStyle.None;
            txtconfermpassword.Font = new Font("Hacen Egypt", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfermpassword.ForeColor = Color.FromArgb(63, 36, 114);
            txtconfermpassword.Location = new Point(441, 289);
            txtconfermpassword.Name = "txtconfermpassword";
            txtconfermpassword.Size = new Size(381, 89);
            txtconfermpassword.TabIndex = 80;
            txtconfermpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Hacen Egypt", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(63, 36, 114);
            txtpassword.Location = new Point(441, 173);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(381, 89);
            txtpassword.TabIndex = 80;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            txtpassword.TextChanged += textBox4_TextChanged;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.Bottom;
            btnsave.BackColor = Color.FromArgb(173, 109, 209);
            btnsave.BackgroundColor = Color.FromArgb(173, 109, 209);
            btnsave.BorderColor = Color.FromArgb(63, 36, 114);
            btnsave.BorderRadius = 40;
            btnsave.BorderSize = 0;
            btnsave.Cursor = Cursors.Hand;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Hacen Egypt", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(406, 624);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(188, 70);
            btnsave.TabIndex = 92;
            btnsave.Text = "حفظ";
            btnsave.TextColor = Color.White;
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // UserAddEditFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(1000, 700);
            Controls.Add(btnsave);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Controls.Add(txtconfermpassword);
            Controls.Add(txtanswer);
            Controls.Add(cmbquestions);
            Controls.Add(picuserimage);
            Controls.Add(khButton7);
            Controls.Add(cmbrole);
            Controls.Add(khButton2);
            Controls.Add(khPanel4);
            Controls.Add(khPanel3);
            Controls.Add(khPanel2);
            Controls.Add(khPanel6);
            Controls.Add(btnclose);
            Controls.Add(label2);
            Controls.Add(khPanel9);
            Controls.Add(khPanel5);
            Controls.Add(khPanel1);
            Controls.Add(khPanel7);
            Controls.Add(khButton6);
            Controls.Add(khButton4);
            Controls.Add(label7);
            Controls.Add(khButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(khButton3);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAddEditFRM";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAddEditFRM";
            ((System.ComponentModel.ISupportInitialize)picuserimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private customs.KhControles.KhButton btnclose;
        private Label label2;
        private customs.KhPanel khPanel4;
        private customs.KhPanel khPanel3;
        private customs.KhPanel khPanel2;
        private customs.KhPanel khPanel6;
        private Label label4;
        private customs.KhControles.KhButton khButton3;
        private TextBox txtusername;
        private customs.KhPanel khPanel7;
        private Label label1;
        private ComboBox cmbrole;
        private customs.KhControles.KhButton khButton2;
        private Label label3;
        private customs.KhControles.KhButton khButton1;
        private customs.KhPanel khPanel1;
        private Label label5;
        private customs.KhControles.KhButton khButton4;
        private customs.KhPanel khPanel5;
        private Label label6;
        private Label label7;
        private customs.KhControles.KhButton khButton6;
        private customs.KhPanel khPanel9;
        private customs.KhControles.KhButton khButton7;
        private ComboBox cmbquestions;
        private Label label8;
        private PictureBox picuserimage;
        private TextBox txtanswer;
        private TextBox txtconfermpassword;
        private TextBox txtpassword;
        private customs.KhControles.KhButton btnsave;
    }
}