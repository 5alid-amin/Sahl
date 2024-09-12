namespace Sahll.JUI.Car.SubForms
{
    partial class CarsReturnProductsEnventoryFRM
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
            label2 = new Label();
            khPanel1 = new customs.KhPanel();
            txtquantity = new TextBox();
            btn_return = new customs.KhControles.KhButton();
            btnclose = new customs.KhControles.KhButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("LBC", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(63, 36, 114);
            label2.Location = new Point(85, 9);
            label2.Name = "label2";
            label2.Size = new Size(220, 42);
            label2.TabIndex = 2;
            label2.Tag = "";
            label2.Text = "الكميه المرتجعه";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 2;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 90F;
            khPanel1.GradientBottomColor = Color.FromArgb(195, 172, 208);
            khPanel1.GradientTopColor = Color.FromArgb(173, 109, 209);
            khPanel1.Location = new Point(21, 180);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(349, 3);
            khPanel1.TabIndex = 7;
            // 
            // txtquantity
            // 
            txtquantity.BorderStyle = BorderStyle.None;
            txtquantity.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtquantity.ForeColor = Color.FromArgb(63, 36, 114);
            txtquantity.Location = new Point(21, 84);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(349, 97);
            txtquantity.TabIndex = 6;
            txtquantity.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_return
            // 
            btn_return.BackColor = Color.FromArgb(173, 109, 209);
            btn_return.BackgroundColor = Color.FromArgb(173, 109, 209);
            btn_return.BorderColor = Color.FromArgb(63, 36, 114);
            btn_return.BorderRadius = 40;
            btn_return.BorderSize = 0;
            btn_return.FlatAppearance.BorderSize = 0;
            btn_return.FlatStyle = FlatStyle.Flat;
            btn_return.Font = new Font("Hacen Egypt", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_return.ForeColor = Color.White;
            btn_return.Location = new Point(104, 208);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(182, 74);
            btn_return.TabIndex = 8;
            btn_return.Text = "إسترجاع";
            btn_return.TextColor = Color.White;
            btn_return.UseVisualStyleBackColor = false;
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
            btnclose.Location = new Point(-1, -2);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(33, 33);
            btnclose.TabIndex = 9;
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            // 
            // ReturnFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(390, 294);
            Controls.Add(btnclose);
            Controls.Add(btn_return);
            Controls.Add(khPanel1);
            Controls.Add(txtquantity);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReturnFRM";
            ShowInTaskbar = false;
            Text = "ReturnFRM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private customs.KhPanel khPanel1;
        private TextBox txtquantity;
        private customs.KhControles.KhButton btn_return;
        private customs.KhControles.KhButton btnclose;
    }
}