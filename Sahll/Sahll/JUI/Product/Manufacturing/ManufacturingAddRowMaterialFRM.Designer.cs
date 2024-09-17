namespace Sahll.JUI.Car.SubForms
{
    partial class ManufacturingAddRowMaterialFRM
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
            khButton2 = new customs.KhControles.KhButton();
            label1 = new Label();
            //this.txtquantity = new TextBox();
            btnclose = new customs.KhControles.KhButton();
            label3 = new Label();
            cmbproduct = new ComboBox();
            khButton1 = new customs.KhControles.KhButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Hacen Egypt", 39.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(564, 66);
            label2.Name = "label2";
            label2.Size = new Size(129, 110);
            label2.TabIndex = 9;
            label2.Tag = "";
            label2.Text = "الخام";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            khButton2.Size = new Size(221, 112);
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
            label1.Location = new Point(400, 215);
            label1.Name = "label1";
            label1.Size = new Size(154, 86);
            label1.TabIndex = 9;
            label1.Tag = "";
            label1.Text = "الكميه";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtquantity
            // 
            //this.txtquantity.BackColor = Color.FromArgb(255, 251, 245);
            //this.txtquantity.BorderStyle = BorderStyle.None;
            //this.txtquantity.Font = new Font("Hacen Egypt", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            //this.txtquantity.ForeColor = Color.FromArgb(63, 36, 114);
            //this.txtquantity.Location = new Point(196, 214);
            //this.txtquantity.Name = "txtquantity";
            //this.txtquantity.Size = new Size(194, 97);
            //this.txtquantity.TabIndex = 10;
            //this.txtquantity.TextAlign = HorizontalAlignment.Center;
            //this.txtquantity.KeyDown += this.txtprice_KeyDown;
            //this.txtquantity.KeyPress += this.txtprice_KeyPress;
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
            label3.Location = new Point(270, 2);
            label3.Name = "label3";
            label3.Size = new Size(152, 42);
            label3.TabIndex = 9;
            label3.Tag = "";
            label3.Text = "إضافة خام";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbproduct
            // 
            cmbproduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbproduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbproduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbproduct.BackColor = Color.White;
            cmbproduct.DropDownHeight = 150;
            cmbproduct.Font = new Font("Hacen Egypt", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbproduct.ForeColor = Color.FromArgb(63, 36, 114);
            cmbproduct.FormattingEnabled = true;
            cmbproduct.IntegralHeight = false;
            cmbproduct.Location = new Point(21, 74);
            cmbproduct.Name = "cmbproduct";
            cmbproduct.Size = new Size(532, 97);
            cmbproduct.TabIndex = 40;
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
            khButton1.Location = new Point(6, 72);
            khButton1.Name = "khButton1";
            khButton1.Size = new Size(563, 100);
            khButton1.TabIndex = 13;
            khButton1.Text = "khButton1";
            khButton1.TextColor = Color.White;
            khButton1.UseVisualStyleBackColor = false;
            khButton1.Click += khButton1_Click;
            // 
            // ManufacturingAddRowMaterialFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 109, 209);
            ClientSize = new Size(693, 347);
            Controls.Add(cmbproduct);
            Controls.Add(btnclose);
            //Controls.Add(this.txtquantity);
            Controls.Add(khButton2);
            Controls.Add(label3);
            Controls.Add(khButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManufacturingAddRowMaterialFRM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarAddExpenseFRM";
            Load += CarAddExpenseFRM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtstatement;
        private Label label2;
        private customs.KhControles.KhButton khButton2;
        private Label label1;
        private TextBox txtprice;
        private customs.KhControles.KhButton btnclose;
        private Label label3;
        private ComboBox cmbproduct;
        private customs.KhControles.KhButton khButton1;
        private customs.KhControles.KhButton khButton3;
    }
}