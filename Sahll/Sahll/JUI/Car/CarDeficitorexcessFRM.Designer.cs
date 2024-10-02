namespace Sahll.JUI.Car
{
    partial class CarDeficitorexcessFRM
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
            pnlCarDeficitorexcess = new Panel();
            label2 = new Label();
            lblDeficitorexcess = new customs.KhControles.KhButton();
            pnlCarDeficitorexcess.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCarDeficitorexcess
            // 
            pnlCarDeficitorexcess.Controls.Add(label2);
            pnlCarDeficitorexcess.Controls.Add(lblDeficitorexcess);
            pnlCarDeficitorexcess.Dock = DockStyle.Fill;
            pnlCarDeficitorexcess.Location = new Point(20, 0);
            pnlCarDeficitorexcess.Name = "pnlCarDeficitorexcess";
            pnlCarDeficitorexcess.Size = new Size(945, 750);
            pnlCarDeficitorexcess.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Hacen Egypt", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 109, 209);
            label2.Location = new Point(131, 100);
            label2.Name = "label2";
            label2.Size = new Size(683, 138);
            label2.TabIndex = 77;
            label2.Text = "العجز أو الزياده للاسبوع السابق";
            // 
            // lblDeficitorexcess
            // 
            lblDeficitorexcess.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDeficitorexcess.BackColor = Color.White;
            lblDeficitorexcess.BackgroundColor = Color.White;
            lblDeficitorexcess.BorderColor = Color.FromArgb(203, 150, 233);
            lblDeficitorexcess.BorderRadius = 30;
            lblDeficitorexcess.BorderSize = 1;
            lblDeficitorexcess.Cursor = Cursors.Hand;
            lblDeficitorexcess.Enabled = false;
            lblDeficitorexcess.FlatAppearance.BorderSize = 0;
            lblDeficitorexcess.FlatStyle = FlatStyle.Flat;
            lblDeficitorexcess.Font = new Font("Impact", 99.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeficitorexcess.ForeColor = Color.FromArgb(63, 36, 114);
            lblDeficitorexcess.Location = new Point(238, 241);
            lblDeficitorexcess.Name = "lblDeficitorexcess";
            lblDeficitorexcess.Size = new Size(453, 269);
            lblDeficitorexcess.TabIndex = 22;
            lblDeficitorexcess.Text = "52565";
            lblDeficitorexcess.TextColor = Color.FromArgb(63, 36, 114);
            lblDeficitorexcess.UseVisualStyleBackColor = false;
            // 
            // CarDeficitorexcessFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 245);
            ClientSize = new Size(985, 750);
            Controls.Add(pnlCarDeficitorexcess);
            ForeColor = Color.FromArgb(119, 67, 219);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarDeficitorexcessFRM";
            Padding = new Padding(20, 0, 20, 0);
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "x";
            pnlCarDeficitorexcess.ResumeLayout(false);
            pnlCarDeficitorexcess.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlCarDeficitorexcess;
        private customs.KhControles.KhButton lblDeficitorexcess;
        private Label label2;
    }
}