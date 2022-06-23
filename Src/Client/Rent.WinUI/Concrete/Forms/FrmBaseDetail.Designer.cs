namespace Rent.WinUI.Concrete.Forms
{
    partial class FrmBaseDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseDetail));
            this.RcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.RBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnSaveClose = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnPrintQuick = new DevExpress.XtraBars.BarButtonItem();
            this.RBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.rpMainMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgDataMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RpgPrintMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LcMain = new DevExpress.XtraLayout.LayoutControl();
            this.LcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RcMain
            // 
            this.RcMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RcMain.ExpandCollapseItem.Id = 0;
            this.RcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcMain.ExpandCollapseItem,
            this.RBtnSave,
            this.RBtnSaveClose,
            this.RBtnClose,
            this.RBtnPrintQuick,
            this.RBtnPrint});
            this.RcMain.Location = new System.Drawing.Point(0, 517);
            this.RcMain.MaxItemId = 6;
            this.RcMain.Name = "RcMain";
            this.RcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMainMenu});
            this.RcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.RcMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.RcMain.Size = new System.Drawing.Size(813, 31);
            // 
            // RBtnSave
            // 
            this.RBtnSave.Caption = "Kaydet";
            this.RBtnSave.Id = 1;
            this.RBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnSave.ImageOptions.Image")));
            this.RBtnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnSave.ImageOptions.LargeImage")));
            this.RBtnSave.Name = "RBtnSave";
            this.RBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnSave_ItemClick);
            // 
            // RBtnSaveClose
            // 
            this.RBtnSaveClose.Caption = "Kaydet ve Kapat";
            this.RBtnSaveClose.Id = 2;
            this.RBtnSaveClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnSaveClose.ImageOptions.Image")));
            this.RBtnSaveClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnSaveClose.ImageOptions.LargeImage")));
            this.RBtnSaveClose.Name = "RBtnSaveClose";
            this.RBtnSaveClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnSaveClose_ItemClick);
            // 
            // RBtnClose
            // 
            this.RBtnClose.Caption = "Kapat";
            this.RBtnClose.Id = 3;
            this.RBtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnClose.ImageOptions.Image")));
            this.RBtnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnClose.ImageOptions.LargeImage")));
            this.RBtnClose.Name = "RBtnClose";
            this.RBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnClose_ItemClick);
            // 
            // RBtnPrintQuick
            // 
            this.RBtnPrintQuick.Caption = "Hızlı Yazdır";
            this.RBtnPrintQuick.Id = 4;
            this.RBtnPrintQuick.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnPrintQuick.ImageOptions.Image")));
            this.RBtnPrintQuick.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnPrintQuick.ImageOptions.LargeImage")));
            this.RBtnPrintQuick.Name = "RBtnPrintQuick";
            this.RBtnPrintQuick.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnPrintQuick_ItemClick);
            // 
            // RBtnPrint
            // 
            this.RBtnPrint.Caption = "Yazdır";
            this.RBtnPrint.Id = 5;
            this.RBtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnPrint.ImageOptions.Image")));
            this.RBtnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnPrint.ImageOptions.LargeImage")));
            this.RBtnPrint.Name = "RBtnPrint";
            this.RBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RBtnPrint_ItemClick);
            // 
            // rpMainMenu
            // 
            this.rpMainMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgDataMenu,
            this.RpgPrintMenu});
            this.rpMainMenu.Name = "rpMainMenu";
            // 
            // RpgDataMenu
            // 
            this.RpgDataMenu.ItemLinks.Add(this.RBtnSave);
            this.RpgDataMenu.ItemLinks.Add(this.RBtnSaveClose, true);
            this.RpgDataMenu.ItemLinks.Add(this.RBtnClose, true);
            this.RpgDataMenu.Name = "RpgDataMenu";
            this.RpgDataMenu.Text = "Kayıt İşlemleri";
            // 
            // RpgPrintMenu
            // 
            this.RpgPrintMenu.ItemLinks.Add(this.RBtnPrintQuick);
            this.RpgPrintMenu.ItemLinks.Add(this.RBtnPrint, true);
            this.RpgPrintMenu.Name = "RpgPrintMenu";
            this.RpgPrintMenu.Text = "Yazıcı İşlemleri";
            // 
            // LcMain
            // 
            this.LcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LcMain.Location = new System.Drawing.Point(0, 0);
            this.LcMain.Name = "LcMain";
            this.LcMain.Root = this.LcgMain;
            this.LcMain.Size = new System.Drawing.Size(813, 517);
            this.LcMain.TabIndex = 1;
            this.LcMain.Text = "layoutControl1";
            // 
            // LcgMain
            // 
            this.LcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LcgMain.GroupBordersVisible = false;
            this.LcgMain.Name = "LcgMain";
            this.LcgMain.Size = new System.Drawing.Size(813, 517);
            this.LcgMain.TextVisible = false;
            // 
            // FrmBaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 548);
            this.Controls.Add(this.LcMain);
            this.Controls.Add(this.RcMain);
            this.Name = "FrmBaseDetail";
            this.Text = "Base Detay Formu";
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMainMenu;
        private DevExpress.XtraBars.BarButtonItem RBtnClose;
        private DevExpress.XtraBars.BarButtonItem RBtnPrintQuick;
        private DevExpress.XtraBars.BarButtonItem RBtnPrint;
        public DevExpress.XtraLayout.LayoutControlGroup LcgMain;
        public DevExpress.XtraLayout.LayoutControl LcMain;
        public DevExpress.XtraBars.Ribbon.RibbonControl RcMain;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgDataMenu;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgPrintMenu;
        public DevExpress.XtraBars.BarButtonItem RBtnSave;
        public DevExpress.XtraBars.BarButtonItem RBtnSaveClose;
    }
}