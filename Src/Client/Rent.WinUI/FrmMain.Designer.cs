namespace Rent.WinUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.RcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.BtnThemeGallary = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.BtnExpenseTypes = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTenants = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRealities = new DevExpress.XtraBars.BarButtonItem();
            this.BtnContracts = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMailSettings = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMailList = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPolicies = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // RcMain
            // 
            this.RcMain.AllowMdiChildButtons = false;
            this.RcMain.AllowMinimizeRibbon = false;
            this.RcMain.ExpandCollapseItem.Id = 0;
            this.RcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcMain.ExpandCollapseItem,
            this.BtnUsers,
            this.BtnThemeGallary,
            this.BtnExpenseTypes,
            this.BtnTenants,
            this.BtnRealities,
            this.BtnContracts,
            this.BtnMailSettings,
            this.BtnMailList,
            this.BtnPolicies});
            this.RcMain.Location = new System.Drawing.Point(0, 0);
            this.RcMain.MaxItemId = 10;
            this.RcMain.Name = "RcMain";
            this.RcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.RcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.RcMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowCategoryInCaption = false;
            this.RcMain.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.RcMain.ShowQatLocationSelector = false;
            this.RcMain.ShowToolbarCustomizeItem = false;
            this.RcMain.Size = new System.Drawing.Size(1356, 58);
            this.RcMain.StatusBar = this.ribbonStatusBar;
            this.RcMain.Toolbar.ShowCustomizeItem = false;
            // 
            // BtnUsers
            // 
            this.BtnUsers.Caption = "Kullanıcılar";
            this.BtnUsers.Id = 1;
            this.BtnUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUsers.ImageOptions.SvgImage")));
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUsers_ItemClick);
            // 
            // BtnThemeGallary
            // 
            this.BtnThemeGallary.Caption = "Temalar";
            this.BtnThemeGallary.Id = 2;
            this.BtnThemeGallary.Name = "BtnThemeGallary";
            this.BtnThemeGallary.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.BtnThemeGallary_GalleryItemClick);
            // 
            // BtnExpenseTypes
            // 
            this.BtnExpenseTypes.Caption = "Gider Tanımları";
            this.BtnExpenseTypes.Id = 3;
            this.BtnExpenseTypes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExpenseTypes.ImageOptions.SvgImage")));
            this.BtnExpenseTypes.Name = "BtnExpenseTypes";
            this.BtnExpenseTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExpenseTypes_ItemClick);
            // 
            // BtnTenants
            // 
            this.BtnTenants.Caption = "Kiracılar";
            this.BtnTenants.Id = 4;
            this.BtnTenants.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnTenants.ImageOptions.SvgImage")));
            this.BtnTenants.Name = "BtnTenants";
            this.BtnTenants.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTenants_ItemClick);
            // 
            // BtnRealities
            // 
            this.BtnRealities.Caption = "Taşınmazlar";
            this.BtnRealities.Id = 5;
            this.BtnRealities.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRealities.ImageOptions.SvgImage")));
            this.BtnRealities.Name = "BtnRealities";
            this.BtnRealities.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRealities_ItemClick);
            // 
            // BtnContracts
            // 
            this.BtnContracts.Caption = "Sözleşmeler";
            this.BtnContracts.Id = 6;
            this.BtnContracts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnContracts.ImageOptions.SvgImage")));
            this.BtnContracts.Name = "BtnContracts";
            this.BtnContracts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnContracts_ItemClick);
            // 
            // BtnMailSettings
            // 
            this.BtnMailSettings.Caption = "Mail Ayarları";
            this.BtnMailSettings.Id = 7;
            this.BtnMailSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnMailSettings.ImageOptions.SvgImage")));
            this.BtnMailSettings.Name = "BtnMailSettings";
            this.BtnMailSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMailSettings_ItemClick);
            // 
            // BtnMailList
            // 
            this.BtnMailList.Caption = "Mail Listesi";
            this.BtnMailList.Id = 8;
            this.BtnMailList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnMailList.ImageOptions.SvgImage")));
            this.BtnMailList.Name = "BtnMailList";
            this.BtnMailList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMailList_ItemClick);
            // 
            // BtnPolicies
            // 
            this.BtnPolicies.Caption = "Sigorta Poliçeleri";
            this.BtnPolicies.Id = 9;
            this.BtnPolicies.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPolicies.ImageOptions.SvgImage")));
            this.BtnPolicies.Name = "BtnPolicies";
            this.BtnPolicies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPolicies_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnThemeGallary);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUsers, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnExpenseTypes);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnRealities, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnTenants, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnContracts);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnMailSettings);
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnMailList, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnPolicies);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RcMain;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1356, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 767);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.RcMain);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.RcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Netline Kira Takip Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnUsers;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem BtnThemeGallary;
        private DevExpress.XtraBars.BarButtonItem BtnExpenseTypes;
        private DevExpress.XtraBars.BarButtonItem BtnTenants;
        private DevExpress.XtraBars.BarButtonItem BtnRealities;
        private DevExpress.XtraBars.BarButtonItem BtnContracts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnMailSettings;
        private DevExpress.XtraBars.BarButtonItem BtnMailList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BtnPolicies;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}