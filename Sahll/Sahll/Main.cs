using Sahll.JUI.Car;
using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Selling;
using Sahll.JUI.Treasury;
using System.Windows.Forms;
namespace Sahll
{
    public partial class Main : Form
    {
        //feilds

        bool IsCollapsed = false;
        bool IsMaxmized = false;

        //For Draging The Form
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        //For Transitions
        bool GoToCars = false;
        bool GoToProduct = false;
        bool GoToTreasury = false;
        bool GoToCustomer = false;
        bool GoToCusOptions = false;
        bool GoToStaff = false;
        bool GoToSupplier = false;
        bool GoToSupOptions = false;

        Button PreviousButton;

        CarsOptionsFRM carsOptionsFRM;
        ProudctsOptionsFRM proudctsOptionsFRM;
        TreasuryFRM TreasuryFRM;
        CustomerFrm customerFrm;
        StaffFRM staffFRM;
        SupplierFRM supplierFRM;
        StatisticsOptionsFRM statisticsOptionsFRM;

        public Main()
        {
            InitializeComponent();
            navbar_transparent_button_on_hover();
            navbar_transparent_button_on_click();
            btncar_Click_1(null, EventArgs.Empty);
            btncollapes_Click(null, EventArgs.Empty);


            carsOptionsFRM = new CarsOptionsFRM(this);
            proudctsOptionsFRM = new ProudctsOptionsFRM(this);
            TreasuryFRM = new TreasuryFRM(this);
            customerFrm = new CustomerFrm(this);
            staffFRM = new StaffFRM(this);
            supplierFRM = new SupplierFRM(this);
            statisticsOptionsFRM = new StatisticsOptionsFRM(this);
        }

        #region ButtonsMethods
        private void btncar_Click_1(object sender, EventArgs e)
        {
            //Functions


            //JUI
            pointer(btncar);
            toptitle(btncar);
            pnlContainer.Controls.Clear();
            carsOptionsFRM = new CarsOptionsFRM(this);
            carsOptionsFRM.btncar1_Click_1(carsOptionsFRM.btncar1, EventArgs.Empty);
            pnlContainer.Controls.Add(carsOptionsFRM.pnlcarsoptions);
            btngoback.Visible = false;
        }

        private void btnstore_Click_1(object sender, EventArgs e)
        {
            StoreFRM frm = new StoreFRM();
            //Functions

            //JUI
            pointer(btnstore);
            toptitle(btnstore);
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlstore);
            btngoback.Visible = false;
        }


        private void btnsell_Click_1(object sender, EventArgs e)
        {
            SellingFRM frm = new SellingFRM();
            //Functions

            //JUI
            pointer(btnsell);
            toptitle(btnsell);
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlselling);
            btngoback.Visible = false;
        }

        private void btnproducts_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnproducts);
            toptitle(btnproducts);

            //Functions
            pnlContainer.Controls.Clear();
            proudctsOptionsFRM = new ProudctsOptionsFRM(this);
            pnlContainer.Controls.Add(proudctsOptionsFRM.pnlcarsoptions);
            lbltoptitle.Text = "المنتجات";
            btngoback.Visible = false;
        }

        private void btntreasury_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btntreasury);
            toptitle(btntreasury);

            //Functions
            pnlContainer.Controls.Clear();
            TreasuryFRM = new TreasuryFRM(this);
            pnlContainer.Controls.Add(TreasuryFRM.pnltreasury);
            lbltoptitle.Text = "الخزينه";
            btngoback.Visible = false;
        }

        private void btnstaff_Click_1(object sender, EventArgs e)
        {
            //Functions

            //JUI
            pointer(btnstaff);
            toptitle(btnstaff);
            pnlContainer.Controls.Clear();
            staffFRM = new StaffFRM(this);
            pnlContainer.Controls.Add(staffFRM.pnlselling);
            btngoback.Visible = false;
            lbltoptitle.Text = "العمال";
        }

        private void btnsuppliers_Click_1(object sender, EventArgs e)
        {
            //Functions


            //JUI
            pointer(btnsuppliers);
            toptitle(btnsuppliers);

            pnlContainer.Controls.Clear();
            supplierFRM = new SupplierFRM(this);
            pnlContainer.Controls.Add(supplierFRM.pnlselling);
            btngoback.Visible = false;
            GoToSupplier = false;
            lbltoptitle.Text = "الموردين";
        }

        private void btncustomers_Click_1(object sender, EventArgs e)
        {
            //Functions

            //JUI
            pointer(btncustomers);
            toptitle(btncustomers);
            pnlContainer.Controls.Clear();
            customerFrm = new CustomerFrm(this);
            pnlContainer.Controls.Add(customerFrm.pnlselling);
            lbltoptitle.Text = "العملاء";
            btngoback.Visible = false;
        }

        private void btnusers_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnusers);
            toptitle(btnusers);
            pnlContainer.Controls.Clear();
            UserFRM frm = new UserFRM();
            pnlContainer.Controls.Add(frm.pnlstore);
            lbltoptitle.Text = "المستخدمين";
            btngoback.Visible = false;

            //Functions
        }

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            //JUI
            pointer(btnsettings);
            toptitle(btnsettings);
            pnlContainer.Controls.Clear();
            SettingFRM frm = new SettingFRM();
            pnlContainer.Controls.Add(frm.pnlcarsoptions);
            lbltoptitle.Text = "الإعدادات";
            btngoback.Visible = false;

            //Functions
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            if (GoToCars)
            {
                pnlContainer.Controls.Clear();
                carsOptionsFRM = new CarsOptionsFRM(this);
                pnlContainer.Controls.Add(carsOptionsFRM.pnlcarsoptions);

                btngoback.Visible = false;
                GoToCars = false;
                lbltoptitle.Text = "السيارات";
            }
            else if (GoToProduct)
            {
                pnlContainer.Controls.Clear();
                proudctsOptionsFRM = new ProudctsOptionsFRM(this);
                pnlContainer.Controls.Add(proudctsOptionsFRM.pnlcarsoptions);

                btngoback.Visible = false;
                GoToProduct = false;
                lbltoptitle.Text = "المنتجات";
            }
            else if (GoToTreasury)
            {
                pnlContainer.Controls.Clear();
                TreasuryFRM = new TreasuryFRM(this);
                pnlContainer.Controls.Add(TreasuryFRM.pnltreasury);

                btngoback.Visible = false;
                GoToTreasury = false;
                lbltoptitle.Text = "الخزينه";
            }
            else if (GoToCustomer)
            {
                pnlContainer.Controls.Clear();
                customerFrm = new CustomerFrm(this);
                pnlContainer.Controls.Add(customerFrm.pnlselling);

                btngoback.Visible = false;
                GoToCustomer = false;
                lbltoptitle.Text = "العملاء";
            }
            else if (GoToCusOptions)
            {
                SHowCustomerOptions();

                GoToCustomer = true;
                GoToCusOptions = false;
                lbltoptitle.Text = "صافي حساب العميل";
            }
            else if (GoToStaff)
            {
                pnlContainer.Controls.Clear();
                staffFRM = new StaffFRM(this);
                pnlContainer.Controls.Add(staffFRM.pnlselling);

                btngoback.Visible = false;
                GoToStaff = false;
                lbltoptitle.Text = "العمال";
            }
            else if (GoToSupplier)
            {
                pnlContainer.Controls.Clear();
                supplierFRM = new SupplierFRM(this);
                pnlContainer.Controls.Add(supplierFRM.pnlselling);

                btngoback.Visible = false;
                GoToSupplier = false;
                lbltoptitle.Text = "الموردين";
            }
            else if (GoToSupOptions)
            {
                ShowSupplierOptions();
                GoToSupplier = true;
                GoToSupOptions = false;
                lbltoptitle.Text = "صافي حساب المورد";
            }

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

        //Transitions

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
        public void ShowDeficitorexcess()
        {
            pnlContainer.Controls.Clear();
            CarDeficitorexcessFRM FRM = new CarDeficitorexcessFRM();
            pnlContainer.Controls.Add(FRM.pnlCarDeficitorexcess);

            //GoBackButton
            btngoback.Visible = true;
            GoToCars = true;

            //title
            lbltoptitle.Text = "العجز أو الزياده للسياره";
        }
        #endregion

        #region ProductsTransactions
        public void ShowJustProduct()
        {
            JustProductFRM frm = new JustProductFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlstore);

            //GoBackButton
            btngoback.Visible = true;
            GoToProduct = true;

            //tit
            lbltoptitle.Text = "الأصناف";
        }
        public void ShowCategoreis()
        {
            CategoryFRM frm = new CategoryFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlstore);

            //GoBackButton
            btngoback.Visible = true;
            GoToProduct = true;

            //tit
            lbltoptitle.Text = "التصنيفات";
        }
        public void ShowManufacturing()
        {
            ManufacturingFRM manufacturingFRM = new ManufacturingFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(manufacturingFRM.pnlstore);

            //GoBackButton
            btngoback.Visible = true;
            GoToProduct = true;

            //tit
            lbltoptitle.Text = "التصنيع";
        }
        #endregion

        #region TresuryTransactions
        public void ShowReceipts()
        {
            ReceiptsFRM frm = new ReceiptsFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlselling);

            //GoBackButton
            btngoback.Visible = true;
            GoToTreasury = true;

            //tit
            lbltoptitle.Text = "المقبوضات";
        }
        public void ShowExpenses()
        {
            ExpensesFRM frm = new ExpensesFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlselling);

            //GoBackButton
            btngoback.Visible = true;
            GoToTreasury = true;

            //tit
            lbltoptitle.Text = "المصروفات";
        }
        public void ShowAminHome()
        {
            AminHomeFRM frm = new AminHomeFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlaminhome);

            //GoBackButton
            btngoback.Visible = true;
            GoToTreasury = true;

            //tit
            lbltoptitle.Text = "أمين منزل";
        }
        public void ShowNetProfit()
        {
            NetProfitFRM frm = new NetProfitFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlstore);

            //GoBackButton
            btngoback.Visible = true;
            GoToTreasury = true;

            //tit
            lbltoptitle.Text = "صافي الربح";
        }
        public void ShowNetCapital()
        {
            NetCpitalFRM frm = new NetCpitalFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlstore);

            //GoBackButton
            btngoback.Visible = true;
            GoToTreasury = true;

            //tit
            lbltoptitle.Text = "صافي رأس المال";
        }
        public void showstatisticsoptions()
        {
            statisticsOptionsFRM = new StatisticsOptionsFRM(this);
            statisticsOptionsFRM.Show();
        }
        #endregion

        #region CustomerTransformation
        public void SHowCustomerOptions()
        {
            CustomersOptionsFRM frm = new CustomersOptionsFRM(this);
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlcarsoptions);

            //GoBackButton
            btngoback.Visible = true;
            GoToCustomer = true;

            //tit
            lbltoptitle.Text = "صافي حساب العميل";
        }
        public void ShowCustomerProduct()
        {
            CustomerProductFRM frm = new CustomerProductFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlselling);

            //GoBackButton
            GoToCustomer = false;
            btngoback.Visible = true;
            GoToCusOptions = true;

            //tit
            lbltoptitle.Text = "الاصناف المورده للعميل";
        }
        public void ShowCustomerCash()
        {
            CustomerCashFRM frm = new CustomerCashFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlstore);

            //GoBackButton
            GoToCustomer = false;
            btngoback.Visible = true;
            GoToCusOptions = true;

            //tit
            lbltoptitle.Text = "النقديه المحصله من العميل";
        }
        #endregion

        #region StaffTransitions

        public void ShowStaffAccounts()
        {
            StaffAccountFRM frm = new StaffAccountFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlselling);

            //GoBackButton
            btngoback.Visible = true;
            GoToStaff = true;

            //tit
            lbltoptitle.Text = "حسابات العمال";
        }
        #endregion

        #region SupplierTransformation

        public void ShowSupplierOptions()
        {
            SupplierOptionsFRM frm = new SupplierOptionsFRM(this);
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlcarsoptions);

            //GoBackButton
            btngoback.Visible = true;
            GoToSupplier = true;

            //tit
            lbltoptitle.Text = "صافي حساب المورد";
        }
        public void ShowSupplierCash()
        {
            SupplierCashFRM frm = new SupplierCashFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlstore);

            //GoBackButton
            GoToSupplier = false;
            btngoback.Visible = true;
            GoToSupOptions = true;

            //tit
            lbltoptitle.Text = "النقدية المنصرفه للمورد";
        }
        public void ShowSupplierProduct()
        {
            SupplierProductFRM frm = new SupplierProductFRM();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm.pnlselling);

            //GoBackButton
            GoToSupplier = false;
            btngoback.Visible = true;
            GoToSupOptions = true;

            //tit
            lbltoptitle.Text = "الأصناف المستورده";
        }

        #endregion

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
