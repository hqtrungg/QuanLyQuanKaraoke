namespace KaraManager
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Img1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegister = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoomRegister = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoomDetails = new DevExpress.XtraBars.BarButtonItem();
            this.btnPlace = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoomPrice = new DevExpress.XtraBars.BarButtonItem();
            this.btnWorker = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnDateReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonthReport = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPGSkin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPGRoomRegister = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPGRoom = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPGWorker = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPGCustomer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPGDate = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPGMonthReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnInformation = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbSStatus = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.Img1;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogin,
            this.btnRegister,
            this.btnLogOut,
            this.btnRoomRegister,
            this.btnRoomDetails,
            this.btnPlace,
            this.btnRoomPrice,
            this.btnWorker,
            this.btnCustomer,
            this.btnDateReport,
            this.barButtonItem1,
            this.btnMonthReport,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbPManager,
            this.rbPReport,
            this.btnInformation});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1059, 143);
            this.ribbonControl1.StatusBar = this.rbSStatus;
            // 
            // Img1
            // 
            this.Img1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("Img1.ImageStream")));
            this.Img1.Images.SetKeyName(0, "User.png");
            this.Img1.Images.SetKeyName(1, "Customer.png");
            this.Img1.Images.SetKeyName(2, "DateReport.png");
            this.Img1.Images.SetKeyName(3, "KaraokeManagerIcon.png");
            this.Img1.Images.SetKeyName(4, "Login.png");
            this.Img1.Images.SetKeyName(5, "Logout.png");
            this.Img1.Images.SetKeyName(6, "MonthReport.png");
            this.Img1.Images.SetKeyName(7, "Password.png");
            this.Img1.Images.SetKeyName(8, "Place.png");
            this.Img1.Images.SetKeyName(9, "Price.png");
            this.Img1.Images.SetKeyName(10, "Register.png");
            this.Img1.Images.SetKeyName(11, "RoomRegister.png");
            this.Img1.Images.SetKeyName(12, "SingingRoom.png");
            this.Img1.Images.SetKeyName(13, "User.png");
            this.Img1.Images.SetKeyName(14, "Worker.png");
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Glyph = global::KaraManager.Properties.Resources.User;
            this.btnLogin.Id = 1;
            this.btnLogin.ImageIndex = 0;
            this.btnLogin.LargeGlyph = global::KaraManager.Properties.Resources.User;
            this.btnLogin.LargeWidth = 80;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Caption = "Đăng Kí";
            this.btnRegister.Id = 2;
            this.btnRegister.ImageIndex = 10;
            this.btnRegister.LargeWidth = 80;
            this.btnRegister.Name = "btnRegister";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng Xuất";
            this.btnLogOut.Id = 3;
            this.btnLogOut.ImageIndex = 5;
            this.btnLogOut.LargeWidth = 80;
            this.btnLogOut.Name = "btnLogOut";
            // 
            // btnRoomRegister
            // 
            this.btnRoomRegister.Caption = "Đặt Phòng";
            this.btnRoomRegister.Glyph = global::KaraManager.Properties.Resources.User;
            this.btnRoomRegister.Id = 4;
            this.btnRoomRegister.ImageIndex = 11;
            this.btnRoomRegister.LargeGlyph = global::KaraManager.Properties.Resources.RoomRegister;
            this.btnRoomRegister.Name = "btnRoomRegister";
            this.btnRoomRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRoomRegister_ItemClick);
            // 
            // btnRoomDetails
            // 
            this.btnRoomDetails.Caption = "Phòng Hát";
            this.btnRoomDetails.Id = 5;
            this.btnRoomDetails.ImageIndex = 12;
            this.btnRoomDetails.LargeGlyph = global::KaraManager.Properties.Resources.SingingRoom;
            this.btnRoomDetails.LargeWidth = 70;
            this.btnRoomDetails.Name = "btnRoomDetails";
            this.btnRoomDetails.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRoomDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRoomDetails_ItemClick);
            // 
            // btnPlace
            // 
            this.btnPlace.Caption = "Khu Vực";
            this.btnPlace.Glyph = global::KaraManager.Properties.Resources.Place;
            this.btnPlace.Id = 6;
            this.btnPlace.ImageIndex = 8;
            this.btnPlace.Name = "btnPlace";
            // 
            // btnRoomPrice
            // 
            this.btnRoomPrice.Caption = "Đơn Giá Phòng";
            this.btnRoomPrice.Id = 7;
            this.btnRoomPrice.ImageIndex = 9;
            this.btnRoomPrice.Name = "btnRoomPrice";
            this.btnRoomPrice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRoomPrice_ItemClick);
            // 
            // btnWorker
            // 
            this.btnWorker.Caption = "Nhân Viên";
            this.btnWorker.Id = 8;
            this.btnWorker.ImageIndex = 14;
            this.btnWorker.LargeGlyph = global::KaraManager.Properties.Resources.Worker;
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWorker_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách Hàng";
            this.btnCustomer.Glyph = global::KaraManager.Properties.Resources.Customer;
            this.btnCustomer.Id = 9;
            this.btnCustomer.ImageIndex = 1;
            this.btnCustomer.LargeGlyph = global::KaraManager.Properties.Resources.Customer;
            this.btnCustomer.LargeWidth = 100;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnDateReport
            // 
            this.btnDateReport.Caption = "Theo Ngày";
            this.btnDateReport.Id = 10;
            this.btnDateReport.LargeGlyph = global::KaraManager.Properties.Resources.DateReport;
            this.btnDateReport.Name = "btnDateReport";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnMonthReport
            // 
            this.btnMonthReport.Caption = "Theo Tháng";
            this.btnMonthReport.Id = 12;
            this.btnMonthReport.LargeGlyph = global::KaraManager.Properties.Resources.MonthReport;
            this.btnMonthReport.Name = "btnMonthReport";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 13;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rbPGSkin});
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRegister);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // rbPGSkin
            // 
            this.rbPGSkin.AllowTextClipping = false;
            this.rbPGSkin.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rbPGSkin.Name = "rbPGSkin";
            this.rbPGSkin.Text = "Giao Diện";
            // 
            // rbPManager
            // 
            this.rbPManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPGRoomRegister,
            this.rbPGRoom,
            this.rbPGWorker,
            this.rbPGCustomer});
            this.rbPManager.Name = "rbPManager";
            this.rbPManager.Text = "Quản Lý";
            // 
            // rbPGRoomRegister
            // 
            this.rbPGRoomRegister.AllowTextClipping = false;
            this.rbPGRoomRegister.ItemLinks.Add(this.btnRoomRegister);
            this.rbPGRoomRegister.Name = "rbPGRoomRegister";
            this.rbPGRoomRegister.Text = "Đặt Phòng";
            // 
            // rbPGRoom
            // 
            this.rbPGRoom.AllowTextClipping = false;
            this.rbPGRoom.ItemLinks.Add(this.btnRoomDetails);
            this.rbPGRoom.ItemLinks.Add(this.btnPlace);
            this.rbPGRoom.ItemLinks.Add(this.btnRoomPrice);
            this.rbPGRoom.Name = "rbPGRoom";
            this.rbPGRoom.Text = "Phòng";
            // 
            // rbPGWorker
            // 
            this.rbPGWorker.AllowTextClipping = false;
            this.rbPGWorker.ItemLinks.Add(this.btnWorker);
            this.rbPGWorker.Name = "rbPGWorker";
            this.rbPGWorker.Text = "Nhân Viên";
            // 
            // rbPGCustomer
            // 
            this.rbPGCustomer.AllowTextClipping = false;
            this.rbPGCustomer.ItemLinks.Add(this.btnCustomer);
            this.rbPGCustomer.Name = "rbPGCustomer";
            this.rbPGCustomer.Text = "Khách Hàng";
            // 
            // rbPReport
            // 
            this.rbPReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPGDate,
            this.rbPGMonthReport});
            this.rbPReport.Name = "rbPReport";
            this.rbPReport.Text = "Báo Cáo";
            // 
            // rbPGDate
            // 
            this.rbPGDate.AllowTextClipping = false;
            this.rbPGDate.ItemLinks.Add(this.btnDateReport);
            this.rbPGDate.Name = "rbPGDate";
            this.rbPGDate.Text = "Theo Ngày";
            // 
            // rbPGMonthReport
            // 
            this.rbPGMonthReport.AllowTextClipping = false;
            this.rbPGMonthReport.ItemLinks.Add(this.btnMonthReport);
            this.rbPGMonthReport.Name = "rbPGMonthReport";
            this.rbPGMonthReport.Text = "Theo Tháng";
            // 
            // btnInformation
            // 
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Text = "Thông Tin";
            // 
            // rbSStatus
            // 
            this.rbSStatus.Location = new System.Drawing.Point(0, 668);
            this.rbSStatus.Name = "rbSStatus";
            this.rbSStatus.Ribbon = this.ribbonControl1;
            this.rbSStatus.Size = new System.Drawing.Size(1059, 31);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // fmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 699);
            this.Controls.Add(this.rbSStatus);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "fmMain";
            this.Ribbon = this.ribbonControl1;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StatusBar = this.rbSStatus;
            this.Text = "Quản Lý Quán Karaoke";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGSkin;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGRoomRegister;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGRoom;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGDate;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rbSStatus;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnRegister;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnRoomRegister;
        private DevExpress.XtraBars.BarButtonItem btnRoomDetails;
        private DevExpress.XtraBars.BarButtonItem btnPlace;
        private DevExpress.XtraBars.BarButtonItem btnRoomPrice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGWorker;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGCustomer;
        private DevExpress.XtraBars.BarButtonItem btnWorker;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnDateReport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnMonthReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGMonthReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage btnInformation;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.Utils.ImageCollection Img1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
    }
}

