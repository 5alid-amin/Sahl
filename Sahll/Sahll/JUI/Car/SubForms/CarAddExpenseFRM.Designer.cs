namespace Sahll.JUI.Car.SubForms
{
    partial class CarAddExpenseFRM
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
            txtstatement = new TextBox();
            label2 = new Label();
            khButton1 = new customs.KhControles.KhButton();
            khButton2 = new customs.KhControles.KhButton();
            label1 = new Label();
            txtprice = new TextBox();
            btnclose = new customs.KhControles.KhButton();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtstatement
            // 
            txtstatement.BackColor = Color.FromArgb(255, 251, 245);
            txtstatement.BorderStyle = BorderStyle.None;
            txtstatement.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstatement.ForeColor = Color.FromArgb(63, 36, 114);
            txtstatement.Location = new Point(25, 73);
            txtstatement.Name = "txtstatement";
            txtstatement.Size = new Size(699, 97);
            txtstatement.TabIndex = 10;
            txtstatement.TextAlign = HorizontalAlignment.Center;
            txtstatement.TextChanged += txtstatement_TextChanged;
            txtstatement.KeyDown += txtquantity_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Hacen Egypt", 39.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(734, 66);
            label2.Name = "label2";
            label2.Size = new Size(135, 110);
            label2.TabIndex = 9;
            label2.Tag = "";
            label2.Text = "البيان";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // khButton1
            // 
            khButton1.BackColor = Color.FromArgb(255, 251, 245);
            khButton1.BackgroundColor = Color.FromArgb(255, 251, 245);
            khButton1.BorderColor = Color.FromArgb(63, 36, 114);
            khButton1.BorderRadius = 40;
            khButton1.BorderSize = 0;
            khButton1.FlatAppearance.BorderSize = 0;
            khButton1.FlatStyle = FlatStyle.Flat;
            khButton1.ForeColor = Color.White;
            khButton1.Location = new Point(12, 66);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(726, 112);
            khButton1.TabIndex = 13;
            khButton1.Text = "khButton1";
            khButton1.TextColor = Color.White;
            khButton1.UseVisualStyleBackColor = false;
            khButton1.Click += khButton1_Click;
            // 
            // khButton2
            // 
            khButton2.BackColor = Color.FromArgb(255, 251, 245);
            khButton2.BackgroundColor = Color.FromArgb(255, 251, 245);
            khButton2.BorderColor = Color.FromArgb(63, 36, 114);
            khButton2.BorderRadius = 40;
            khButton2.BorderSize = 0;
            khButton2.FlatAppearance.BorderSize = 0;
            khButton2.FlatStyle = FlatStyle.Flat;
            khButton2.ForeColor = Color.White;
            khButton2.Location = new Point(183, 207);
            khButton2.Name = "khButton2";
            khButton2.Size = new Size(398, 112);
            khButton2.TabIndex = 13;
            khButton2.Text = "khButton1";
            khButton2.TextColor = Color.White;
            khButton2.UseVisualStyleBackColor = false;
            khButton2.Click += khButton1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Hacen Egypt", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(587, 218);
            label1.Name = "label1";
            label1.Size = new Size(154, 86);
            label1.TabIndex = 9;
            label1.Tag = "";
            label1.Text = "المبلغ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtprice
            // 
            txtprice.BackColor = Color.FromArgb(255, 251, 245);
            txtprice.BorderStyle = BorderStyle.None;
            txtprice.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.ForeColor = Color.FromArgb(63, 36, 114);
            txtprice.Location = new Point(196, 214);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(371, 97);
            txtprice.TabIndex = 10;
            txtprice.TextAlign = HorizontalAlignment.Center;
            txtprice.KeyDown += txtprice_KeyDown;
            txtprice.KeyPress += txtprice_KeyPress;
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
            btnclose.Location = new Point(-1, -1);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 14;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("LBC", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(274, 0);
            label3.Name = "label3";
            label3.Size = new Size(310, 42);
            label3.TabIndex = 9;
            label3.Tag = "";
            label3.Text = "إضافة مصروف للسياره";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CarAddExpenseFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 109, 209);
            ClientSize = new Size(859, 347);
            Controls.Add(txtstatement);
            Controls.Add(btnclose);
            Controls.Add(txtprice);
            Controls.Add(label1);
            Controls.Add(khButton2);
            Controls.Add(label3);
            Controls.Add(khButton1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarAddExpenseFRM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarAddExpenseFRM";
            Load += CarAddExpenseFRM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtstatement;
        private Label label2;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhButton khButton2;
        private Label label1;
        private TextBox txtprice;
        private customs.KhControles.KhButton btnclose;
        private Label label3;
    }
}