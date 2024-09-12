using Sahll.JUI.Car;
namespace Sahll
{
    public partial class Main : Form
    {
        //feild
        bool IsCollapsed = false;
        bool IsMaxmized = false;
        bool GoToCars = false;
        Button PreviousButton;
        CarsOptionsFRM FRM;


        public Main()
        {
            InitializeComponent();
            navbar_transparent_button_on_hover();
            navbar_transparent_button_on_click();
            btncar_Click_1(null, EventArgs.Empty);
            FRM = new CarsOptionsFRM(this);
        }

        #region ButtonsMethods

        private void btnstore_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnstore);
            toptitle(btnstore);

            //Functions
        }


        private void btncar_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btncar);
            toptitle(btncar);

            //Functions
            pnlContainer.Controls.Clear();
            FRM = new CarsOptionsFRM(this);
            pnlContainer.Controls.Add(FRM.pnlcarsoptions);
        }

        private void btnsell_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnsell);
            toptitle(btnsell);

            //Functions
        }

        private void btnproducts_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnproducts);
            toptitle(btnproducts);

            //Functions
        }

        private void btntreasury_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btntreasury);
            toptitle(btntreasury);

            //Functions
        }

        private void btnstaff_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnstaff);
            toptitle(btnstaff);

            //Functions
        }

        private void btnsuppliers_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnsuppliers);
            toptitle(btnsuppliers);

            //Functions
        }

        private void btncustomers_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btncustomers);
            toptitle(btncustomers);

            //Functions
        }

        private void btnusers_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnusers);
            toptitle(btnusers);

            //Functions
        }

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnsettings);
            toptitle(btnsettings);

            //Functions
        }



        //controle buttons
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void btncollapes_Click(object sender, EventArgs e)
        {
            if (IsCollapsed) IsCollapsed = false;
            else IsCollapsed = true;
            collapsing();
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

        private void btngoback_MouseEnter(object sender, EventArgs e)
        {
            btngoback.Image = Properties.Resources.go_backd;
        }
        private void btngoback_MouseLeave(object sender, EventArgs e)
        {
            btngoback.Image = Properties.Resources.go_backl;

        }

        #endregion

        #region JUI_Methods
        private void toptitle(Button button)
        {
            lbltoptitle.Text = button.Text;
        }
        private void collapsing()
        {
            if (PreviousButton == null) PreviousButton = btncar;
            if (PreviousButton != null)
                PreviousButton.Left -= 10;

            if (IsCollapsed) collapsed();
            else notcollapsed();

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
                if (button.Location.X != 10 && button.Location.X != 80)
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
            btncollapes.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 150, 233);

            btncar.FlatAppearance.MouseOverBackColor = btnsell.FlatAppearance.MouseOverBackColor =
            btnstore.FlatAppearance.MouseOverBackColor = btnproducts.FlatAppearance.MouseOverBackColor =
            btntreasury.FlatAppearance.MouseOverBackColor = btnstaff.FlatAppearance.MouseOverBackColor =
            btnsuppliers.FlatAppearance.MouseOverBackColor = btncustomers.FlatAppearance.MouseOverBackColor =
            btnusers.FlatAppearance.MouseOverBackColor = btnsettings.FlatAppearance.MouseOverBackColor =
            picpointer.FlatAppearance.MouseOverBackColor = btngoback.FlatAppearance.MouseOverBackColor =
            Color.Transparent;
        }
        #endregion


        #region CarTransitions
        public void ShowProducts()
        {
            pnlContainer.Controls.Clear();
            CarsProductsFRM FRM = new CarsProductsFRM();
            pnlContainer.Controls.Add(FRM.pnlcarproduct);

            //GoBackButton
            btngoback.Visible = true;
            GoToCars = true;

            //title
            lbltoptitle.Text = "توريد بضاعه للسيارات";
        }
        public void ShowInventory()
        {
            pnlContainer.Controls.Clear();
            CarsInventoryFRM FRM = new CarsInventoryFRM();
            pnlContainer.Controls.Add(FRM.pnlinventory);

            //GoBackButton
            btngoback.Visible = true;
            GoToCars = true;

            //title
            lbltoptitle.Text = "جرد السيارات";
        }
        public void ShowCash()
        {
            pnlContainer.Controls.Clear();
            CarsCashFRM FRM = new CarsCashFRM();
            pnlContainer.Controls.Add(FRM.pnlcarcash);

            //GoBackButton
            btngoback.Visible = true;
            GoToCars = true;

            //title
            lbltoptitle.Text = "تحصيل نقدية السيارات";
        }
        public void ShowSoldQuantity()
        {
            pnlContainer.Controls.Clear();
            CarsSoldProducts FRM = new CarsSoldProducts();
            pnlContainer.Controls.Add(FRM.pnlcarsoldproduct);

            //GoBackButton
            btngoback.Visible = true;
            GoToCars = true;

            //title
            lbltoptitle.Text = "الكميه المباعه (السيارات)";
        }
        public void ShowStaff()
        {
            pnlContainer.Controls.Clear();
            CarsStaffFRM FRM = new CarsStaffFRM();
            pnlContainer.Controls.Add(FRM.pnlcar_staff);

            //GoBackButton
            btngoback.Visible = true;
            GoToCars = true;

            //title
            lbltoptitle.Text = "عمال السيارات";
        }
        public void ShowCarsRecords()
        {
            pnlContainer.Controls.Clear();
            CarsRecordsFRM FRM = new CarsRecordsFRM();
            pnlContainer.Controls.Add(FRM.pnlcarrecords);

            //GoBackButton
            btngoback.Visible = true;
            GoToCars = true;

            //title
            lbltoptitle.Text = "سجلات السيارات";
        }
        #endregion

        private void btngoback_Click(object sender, EventArgs e)
        {
            if (GoToCars) 
            {
                pnlContainer.Controls.Clear();
                FRM = new CarsOptionsFRM(this);
                pnlContainer.Controls.Add(FRM.pnlcarsoptions);

                btngoback.Visible = false;
                lbltoptitle.Text = "السيارات";
            }
        }
    }
}
