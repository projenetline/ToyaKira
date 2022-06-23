namespace Rent.WinUI.Concrete.Forms
{
    partial class FrmBaseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseList));
            this.RcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.RbtnAddNewRecord = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnEditRecord = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnExamineRecord = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnShowAll = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnExportXlsx = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnExportXls = new DevExpress.XtraBars.BarButtonItem();
            this.RpMainMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgMainMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RpgPrint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LcMain = new DevExpress.XtraLayout.LayoutControl();
            this.LcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // RcMain
            // 
            this.RcMain.AllowMinimizeRibbon = false;
            this.RcMain.AllowTrimPageText = false;
            this.RcMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RcMain.ExpandCollapseItem.Id = 0;
            this.RcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcMain.ExpandCollapseItem,
            this.RbtnAddNewRecord,
            this.RBtnEditRecord,
            this.RBtnExamineRecord,
            this.RBtnCopy,
            this.RBtnDelete,
            this.RBtnRefresh,
            this.RBtnClose,
            this.RBtnShowAll,
            this.RBtnExportPdf,
            this.RBtnExportXlsx,
            this.RBtnExportXls});
            this.RcMain.Location = new System.Drawing.Point(0, 699);
            this.RcMain.MaxItemId = 12;
            this.RcMain.Name = "RcMain";
            this.RcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpMainMenu});
            this.RcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.RcMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.RcMain.ShowToolbarCustomizeItem = false;
            this.RcMain.Size = new System.Drawing.Size(1350, 31);
            this.RcMain.Toolbar.ShowCustomizeItem = false;
            this.RcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // RbtnAddNewRecord
            // 
            this.RbtnAddNewRecord.Caption = "Yeni Kayıt";
            this.RbtnAddNewRecord.Id = 1;
            this.RbtnAddNewRecord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RbtnAddNewRecord.ImageOptions.Image")));
            this.RbtnAddNewRecord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RbtnAddNewRecord.ImageOptions.LargeImage")));
            this.RbtnAddNewRecord.Name = "RbtnAddNewRecord";
            this.RbtnAddNewRecord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RbtnAddNewRecord_ItemClick);
            // 
            // RBtnEditRecord
            // 
            this.RBtnEditRecord.Caption = "Düzenle";
            this.RBtnEditRecord.Id = 2;
            this.RBtnEditRecord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnEditRecord.ImageOptions.Image")));
            this.RBtnEditRecord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnEditRecord.ImageOptions.LargeImage")));
            this.RBtnEditRecord.Name = "RBtnEditRecord";
            this.RBtnEditRecord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnEditRecord_ItemClick);
            // 
            // RBtnExamineRecord
            // 
            this.RBtnExamineRecord.Caption = "İncele";
            this.RBtnExamineRecord.Id = 3;
            this.RBtnExamineRecord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnExamineRecord.ImageOptions.Image")));
            this.RBtnExamineRecord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnExamineRecord.ImageOptions.LargeImage")));
            this.RBtnExamineRecord.Name = "RBtnExamineRecord";
            this.RBtnExamineRecord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnExamineRecord_ItemClick);
            // 
            // RBtnCopy
            // 
            this.RBtnCopy.Caption = "Kopyala";
            this.RBtnCopy.Id = 4;
            this.RBtnCopy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnCopy.ImageOptions.Image")));
            this.RBtnCopy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnCopy.ImageOptions.LargeImage")));
            this.RBtnCopy.Name = "RBtnCopy";
            this.RBtnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnCopy_ItemClick);
            // 
            // RBtnDelete
            // 
            this.RBtnDelete.Caption = "Sil";
            this.RBtnDelete.Id = 5;
            this.RBtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnDelete.ImageOptions.Image")));
            this.RBtnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnDelete.ImageOptions.LargeImage")));
            this.RBtnDelete.Name = "RBtnDelete";
            this.RBtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnDelete_ItemClick);
            // 
            // RBtnRefresh
            // 
            this.RBtnRefresh.Caption = "Yenile";
            this.RBtnRefresh.Id = 6;
            this.RBtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnRefresh.ImageOptions.Image")));
            this.RBtnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnRefresh.ImageOptions.LargeImage")));
            this.RBtnRefresh.Name = "RBtnRefresh";
            this.RBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnRefresh_ItemClick);
            // 
            // RBtnClose
            // 
            this.RBtnClose.Caption = "Kapat";
            this.RBtnClose.Id = 7;
            this.RBtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnClose.ImageOptions.Image")));
            this.RBtnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnClose.ImageOptions.LargeImage")));
            this.RBtnClose.Name = "RBtnClose";
            this.RBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnClose_ItemClick);
            // 
            // RBtnShowAll
            // 
            this.RBtnShowAll.Caption = "Tüm Kayıtlar";
            this.RBtnShowAll.Id = 8;
            this.RBtnShowAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnShowAll.ImageOptions.Image")));
            this.RBtnShowAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnShowAll.ImageOptions.LargeImage")));
            this.RBtnShowAll.Name = "RBtnShowAll";
            this.RBtnShowAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnShowAll_ItemClick);
            // 
            // RBtnExportPdf
            // 
            this.RBtnExportPdf.Caption = "Aktar (Pdf)";
            this.RBtnExportPdf.Id = 9;
            this.RBtnExportPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnExportPdf.ImageOptions.Image")));
            this.RBtnExportPdf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnExportPdf.ImageOptions.LargeImage")));
            this.RBtnExportPdf.Name = "RBtnExportPdf";
            this.RBtnExportPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnExportPdf_ItemClick);
            // 
            // RBtnExportXlsx
            // 
            this.RBtnExportXlsx.Caption = "Aktar (Excel Xlsx)";
            this.RBtnExportXlsx.Id = 10;
            this.RBtnExportXlsx.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnExportXlsx.ImageOptions.Image")));
            this.RBtnExportXlsx.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnExportXlsx.ImageOptions.LargeImage")));
            this.RBtnExportXlsx.Name = "RBtnExportXlsx";
            this.RBtnExportXlsx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnExportXlsx_ItemClick);
            // 
            // RBtnExportXls
            // 
            this.RBtnExportXls.Caption = "Aktar (Excel Xls)";
            this.RBtnExportXls.Id = 11;
            this.RBtnExportXls.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnExportXls.ImageOptions.Image")));
            this.RBtnExportXls.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnExportXls.ImageOptions.LargeImage")));
            this.RBtnExportXls.Name = "RBtnExportXls";
            this.RBtnExportXls.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnExportXls_ItemClick);
            // 
            // RpMainMenu
            // 
            this.RpMainMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgMainMenu,
            this.RpgPrint});
            this.RpMainMenu.Name = "RpMainMenu";
            // 
            // RpgMainMenu
            // 
            this.RpgMainMenu.ItemLinks.Add(this.RbtnAddNewRecord);
            this.RpgMainMenu.ItemLinks.Add(this.RBtnEditRecord, true);
            this.RpgMainMenu.ItemLinks.Add(this.RBtnExamineRecord, true);
            this.RpgMainMenu.ItemLinks.Add(this.RBtnCopy, true);
            this.RpgMainMenu.ItemLinks.Add(this.RBtnDelete, true);
            this.RpgMainMenu.ItemLinks.Add(this.RBtnRefresh, true);
            this.RpgMainMenu.ItemLinks.Add(this.RBtnClose, true);
            this.RpgMainMenu.ItemLinks.Add(this.RBtnShowAll, true);
            this.RpgMainMenu.Name = "RpgMainMenu";
            this.RpgMainMenu.Text = "ribbonPageGroup1";
            // 
            // RpgPrint
            // 
            this.RpgPrint.ItemLinks.Add(this.RBtnExportPdf);
            this.RpgPrint.ItemLinks.Add(this.RBtnExportXlsx, true);
            this.RpgPrint.ItemLinks.Add(this.RBtnExportXls, true);
            this.RpgPrint.Name = "RpgPrint";
            this.RpgPrint.Text = "ribbonPageGroup2";
            // 
            // LcMain
            // 
            this.LcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LcMain.Location = new System.Drawing.Point(0, 0);
            this.LcMain.Name = "LcMain";
            this.LcMain.Root = this.LcgMain;
            this.LcMain.Size = new System.Drawing.Size(1350, 699);
            this.LcMain.TabIndex = 1;
            this.LcMain.Text = "Main Layout";
            // 
            // LcgMain
            // 
            this.LcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LcgMain.GroupBordersVisible = false;
            this.LcgMain.Name = "LcgMain";
            this.LcgMain.Size = new System.Drawing.Size(1350, 699);
            this.LcgMain.TextVisible = false;
            // 
            // FrmBaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.LcMain);
            this.Controls.Add(this.RcMain);
            this.Name = "FrmBaseList";
            this.Text = "Base List";
            this.Activated += new System.EventHandler(this.FrmBaseList_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaseList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraLayout.LayoutControl LcMain;
        public DevExpress.XtraLayout.LayoutControlGroup LcgMain;
        private DevExpress.XtraBars.BarButtonItem RBtnExportPdf;
        public DevExpress.XtraBars.Ribbon.RibbonControl RcMain;
        public DevExpress.XtraBars.BarButtonItem RbtnAddNewRecord;
        public DevExpress.XtraBars.BarButtonItem RBtnEditRecord;
        public DevExpress.XtraBars.BarButtonItem RBtnExamineRecord;
        public DevExpress.XtraBars.BarButtonItem RBtnCopy;
        public DevExpress.XtraBars.BarButtonItem RBtnDelete;
        public DevExpress.XtraBars.BarButtonItem RBtnRefresh;
        public DevExpress.XtraBars.BarButtonItem RBtnClose;
        public DevExpress.XtraBars.BarButtonItem RBtnShowAll;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgMainMenu;
        public DevExpress.XtraBars.Ribbon.RibbonPage RpMainMenu;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgPrint;
        public DevExpress.XtraBars.BarButtonItem RBtnExportXlsx;
        public DevExpress.XtraBars.BarButtonItem RBtnExportXls;
    }
}