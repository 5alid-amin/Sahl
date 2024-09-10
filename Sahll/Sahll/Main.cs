namespace Sahll
{
    public partial class Main : Form
    {
        //feild
        bool IsCollapsed = false;
        bool IsMaxmized = false;
        Button PreviousButton;

        public Main()
        {
            InitializeComponent();
            navbar_transparent_button_on_hover();
            navbar_transparent_button_on_click();

        }


        #region ButtonsMethods

        private void btnstore_Click_1(object sender, EventArgs e)
        {
            pointer(btnstore);
            toptitle(btnstore);
        }

        private void btncar_Click_1(object sender, EventArgs e)
        {
            pointer(btncar);
            toptitle(btncar);
        }

        private void btnsell_Click_1(object sender, EventArgs e)
        {
            pointer(btnsell);
            toptitle(btnsell);
        }

        private void btnproducts_Click_1(object sender, EventArgs e)
        {
            pointer(btnproducts);
            toptitle(btnproducts);
        }

        private void btntreasury_Click_1(object sender, EventArgs e)
        {
            pointer(btntreasury);
            toptitle(btntreasury);
        }

        private void btnstaff_Click_1(object sender, EventArgs e)
        {
            pointer(btnstaff);
            toptitle(btnstaff);
        }

        private void btnsuppliers_Click_1(object sender, EventArgs e)
        {
            pointer(btnsuppliers);
            toptitle(btnsuppliers);
        }

        private void btncustomers_Click_1(object sender, EventArgs e)
        {
            pointer(btncustomers);
            toptitle(btncustomers);
        }

        private void btnusers_Click_1(object sender, EventArgs e)
        {
            pointer(btnusers);
            toptitle(btnusers);
        }

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            pointer(btnsettings);
            toptitle(btnsettings);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btncollapes_Click(object sender, EventArgs e)
        {
            if (IsCollapsed) IsCollapsed = false;
            else IsCollapsed = true;
            collapsing();
        }
        private void btnmax_Click(object sender, EventArgs e)
        {
            if (IsMaxmized)
            {
                btnmax.Image = Properties.Resources.maximize;
                this.WindowState = FormWindowState.Normal;
                IsMaxmized = false;
            }
            else
            {
                btnmax.Image = Properties.Resources.normal;
                this.WindowState = FormWindowState.Maximized;
                IsMaxmized = true;
            }
        }
        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region JUI_Methods
        private void toptitle( Button button)
        {
            lbltoptitle.Text = button.Text;
        }
        private void collapsing()
        {
            if (PreviousButton == null) PreviousButton = btncar;
            if (IsCollapsed)
            {
                collapsed();
            }
            else
            {
                notcollapsed();
            }
            pointer(PreviousButton);
        }
        private void collapsed()
        {
            picnavbig.SendToBack();
            pnlnavbar.Width = 60;

            btncar.TextImageRelation = btnsell.TextImageRelation =
            btnstore.TextImageRelation = btnproducts.TextImageRelation =
            btntreasury.TextImageRelation = btnstaff.TextImageRelation =
            btnsuppliers.TextImageRelation = btncustomers.TextImageRelation =
            btnusers.TextImageRelation = btnsettings.TextImageRelation =
            TextImageRelation.ImageBeforeText;

            btncar.ImageAlign = btnsell.ImageAlign =
            btnstore.ImageAlign = btnproducts.ImageAlign =
            btntreasury.ImageAlign = btnstaff.ImageAlign =
            btnsuppliers.ImageAlign = btncustomers.ImageAlign =
            btnusers.ImageAlign = btnsettings.ImageAlign =
            ContentAlignment.MiddleLeft;

            int offset = 70;
            btncar.Left += offset;
            btnsell.Left += offset;
            btnstore.Left += offset;
            btnproducts.Left += offset;
            btntreasury.Left += offset;
            btnstaff.Left += offset;
            btnsuppliers.Left += offset;
            btncustomers.Left += offset;
            btnusers.Left += offset;
            btnsettings.Left += offset;
        }
        private void notcollapsed()
        {
            picnavsmall.SendToBack();
            pnlnavbar.Width = 130;

            // تعيين TextImageRelation
            btncar.TextImageRelation = btnsell.TextImageRelation =
            btnstore.TextImageRelation = btnproducts.TextImageRelation =
            btntreasury.TextImageRelation = btnstaff.TextImageRelation =
            btnsuppliers.TextImageRelation = btncustomers.TextImageRelation =
            btnusers.TextImageRelation = btnsettings.TextImageRelation =
            TextImageRelation.TextBeforeImage;

            // تعيين ImageAlign
            btncar.ImageAlign = btnsell.ImageAlign =
            btnstore.ImageAlign = btnproducts.ImageAlign =
            btntreasury.ImageAlign = btnstaff.ImageAlign =
            btnsuppliers.ImageAlign = btncustomers.ImageAlign =
            btnusers.ImageAlign = btnsettings.ImageAlign =
            ContentAlignment.MiddleRight;

            // إرجاع الأزرار إلى مكانها الأصلي
            int offset = 70;
            btncar.Left -= offset;
            btnsell.Left -= offset;
            btnstore.Left -= offset;
            btnproducts.Left -= offset;
            btntreasury.Left -= offset;
            btnstaff.Left -= offset;
            btnsuppliers.Left -= offset;
            btncustomers.Left -= offset;
            btnusers.Left -= offset;
            btnsettings.Left -= offset;
        }
        private void pointer(Button button)
        {
            picpointer.BringToFront();
            picpointer.BringToFront();

            if (PreviousButton == null)
            {
                picpointer.Location = button.Location;
                button.Left += 10;
            }
            if (PreviousButton != null && PreviousButton != button)
            {
                picpointer.Location = button.Location;
                PreviousButton.Left -= 10;
                button.Left += 10;
            }
            if (PreviousButton == button)
            {
                if (button.Location.X == 70 || button.Location.X == 0)
                {
                    picpointer.Location = button.Location;
                    button.Left += 10;
                }
            }

            PreviousButton = button;
        }
        private void navbar_transparent_button_on_click()
        {
            btncar.FlatAppearance.MouseDownBackColor = btnsell.FlatAppearance.MouseDownBackColor =
            btnstore.FlatAppearance.MouseDownBackColor = btnproducts.FlatAppearance.MouseDownBackColor =
            btntreasury.FlatAppearance.MouseDownBackColor = btnstaff.FlatAppearance.MouseDownBackColor =
            btnsuppliers.FlatAppearance.MouseDownBackColor = btncustomers.FlatAppearance.MouseDownBackColor =
            btnusers.FlatAppearance.MouseDownBackColor = btnsettings.FlatAppearance.MouseDownBackColor =
            picpointer.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        private void navbar_transparent_button_on_hover()
        {
            btnclose.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnmax.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 150, 233);
            btnminimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 150, 233);

            btncar.FlatAppearance.MouseOverBackColor = btnsell.FlatAppearance.MouseOverBackColor =
            btnstore.FlatAppearance.MouseOverBackColor = btnproducts.FlatAppearance.MouseOverBackColor =
            btntreasury.FlatAppearance.MouseOverBackColor = btnstaff.FlatAppearance.MouseOverBackColor =
            btnsuppliers.FlatAppearance.MouseOverBackColor = btncustomers.FlatAppearance.MouseOverBackColor =
            btnusers.FlatAppearance.MouseOverBackColor = btnsettings.FlatAppearance.MouseOverBackColor =
            picpointer.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        #endregion

        #region navBar_Darck_image_on_hoverd
        private void btncar_MouseEnter(object sender, EventArgs e)
        {
            btncar.Image = Properties.Resources.card;
        }

        private void btncar_MouseLeave(object sender, EventArgs e)
        {
            btncar.Image = Properties.Resources.carl;
        }

        private void btnsell_MouseEnter(object sender, EventArgs e)
        {
            btnsell.Image = Properties.Resources.selld;
        }

        private void btnsell_MouseLeave(object sender, EventArgs e)
        {
            btnsell.Image = Properties.Resources.selll;
        }

        private void btnstore_MouseEnter(object sender, EventArgs e)
        {
            btnstore.Image = Properties.Resources.stored;
        }

        private void btnstore_MouseLeave(object sender, EventArgs e)
        {
            btnstore.Image = Properties.Resources.storel;
        }

        private void btnproducts_MouseEnter(object sender, EventArgs e)
        {
            btnproducts.Image = Properties.Resources.productd;
        }

        private void btnproducts_MouseLeave(object sender, EventArgs e)
        {
            btnproducts.Image = Properties.Resources.productl;
        }

        private void btntreasury_MouseEnter(object sender, EventArgs e)
        {
            btntreasury.Image = Properties.Resources.treasuryd_;
        }

        private void btntreasury_MouseLeave(object sender, EventArgs e)
        {
            btntreasury.Image = Properties.Resources.treasuryL;
        }

        private void btnstaff_MouseEnter(object sender, EventArgs e)
        {
            btnstaff.Image = Properties.Resources.staffd;
        }

        private void btnstaff_MouseLeave(object sender, EventArgs e)
        {
            btnstaff.Image = Properties.Resources.staffl;
        }

        private void btnsuppliers_MouseEnter(object sender, EventArgs e)
        {
            btnsuppliers.Image = Properties.Resources.supplierd;
        }

        private void btnsuppliers_MouseLeave(object sender, EventArgs e)
        {
            btnsuppliers.Image = Properties.Resources.supplierl;
        }

        private void btncustomers_MouseEnter(object sender, EventArgs e)
        {
            btncustomers.Image = Properties.Resources.customerd;
        }

        private void btncustomers_MouseLeave(object sender, EventArgs e)
        {
            btncustomers.Image = Properties.Resources.customerl;
        }

        private void btnusers_MouseEnter(object sender, EventArgs e)
        {
            btnusers.Image = Properties.Resources.userd;
        }

        private void btnusers_MouseLeave(object sender, EventArgs e)
        {
            btnusers.Image = Properties.Resources.userl;
        }

        private void btnsettings_MouseEnter(object sender, EventArgs e)
        {
            btnsettings.Image = Properties.Resources.setting;
        }

        private void btnsettings_MouseLeave(object sender, EventArgs e)
        {
            btnsettings.Image = Properties.Resources.settingl;
        }



        #endregion

    }
}
