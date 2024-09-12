namespace Sahll.JUI.PL
{
    partial class DialogFRM
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
            btnconferm = new PictureBox();
            btncancel = new PictureBox();
            txtdialog = new Label();
            khPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnconferm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncancel).BeginInit();
            SuspendLayout();
            // 
            // khPanel1
            // 
            khPanel1.BackColor = Color.White;
            khPanel1.BorderRadius = 0;
            khPanel1.Controls.Add(btnconferm);
            khPanel1.Controls.Add(btncancel);
            khPanel1.Controls.Add(txtdialog);
            khPanel1.Dock = DockStyle.Fill;
            khPanel1.ForeColor = Color.Black;
            khPanel1.GradientAngle = 20F;
            khPanel1.GradientBottomColor = Color.FromArgb(0, 0, 5);
            khPanel1.GradientTopColor = Color.FromArgb(64, 0, 0);
            khPanel1.Location = new Point(0, 0);
            khPanel1.Name = "khPanel1";
            khPanel1.Size = new Size(1115, 790);
            khPanel1.TabIndex = 0;
            // 
            // btnconferm
            // 
            btnconferm.Anchor = AnchorStyles.None;
            btnconferm.BackColor = Color.Transparent;
            btnconferm.Cursor = Cursors.Hand;
            btnconferm.Image = Properties.Resources.conferml;
            btnconferm.Location = new Point(620, 586);
            btnconferm.Name = "btnconferm";
            btnconferm.Size = new Size(180, 100);
            btnconferm.SizeMode = PictureBoxSizeMode.Zoom;
            btnconferm.TabIndex = 61;
            btnconferm.TabStop = false;
            btnconferm.Click += btnconferm_Click;
            btnconferm.MouseEnter += btnconferm_MouseEnter;
            btnconferm.MouseLeave += btnconferm_MouseLeave;
            // 
            // btncancel
            // 
            btncancel.Anchor = AnchorStyles.None;
            btncancel.BackColor = Color.Transparent;
            btncancel.Cursor = Cursors.Hand;
            btncancel.Image = Properties.Resources.cancell1;
            btncancel.Location = new Point(322, 586);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(180, 100);
            btncancel.SizeMode = PictureBoxSizeMode.Zoom;
            btncancel.TabIndex = 61;
            btncancel.TabStop = false;
            btncancel.Click += btncancel_Click;
            btncancel.MouseEnter += btncancel_MouseEnter;
            btncancel.MouseLeave += btncancel_MouseLeave;
            // 
            // txtdialog
            // 
            txtdialog.Anchor = AnchorStyles.None;
            txtdialog.BackColor = Color.Transparent;
            txtdialog.Font = new Font("LBC", 41.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdialog.ForeColor = Color.White;
            txtdialog.Location = new Point(0, 208);
            txtdialog.Name = "txtdialog";
            txtdialog.Size = new Size(1115, 375);
            txtdialog.TabIndex = 60;
            txtdialog.Text = "انا اسمي عمي احماد";
            txtdialog.TextAlign = ContentAlignment.TopCenter;
            // 
            // DialogFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 790);
            Controls.Add(khPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DialogFRM";
            Opacity = 0.9D;
            ShowInTaskbar = false;
            Text = "DialogFRM";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            khPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnconferm).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private customs.KhPanel khPanel1;
        private Label txtdialog;
        private PictureBox btncancel;
        private PictureBox btnconferm;
    }
}