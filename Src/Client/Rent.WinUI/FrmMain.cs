using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using Rent.Business.Abstract;
using Rent.Core.Concrete.Helpers;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Rent.WinUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        WinFormProperty _winFormProperty;
        private readonly IWinFormPropertyService _winFormPropertyService;
        private readonly IWinFormLayoutService _winFormLayoutService;
        public FrmMain(IWinFormPropertyService winFormPropertyService, IWinFormLayoutService winFormLayoutService)
        {
            _winFormPropertyService = winFormPropertyService;
            _winFormLayoutService = winFormLayoutService;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            if (WinFormProperty != null)
                if (WinFormProperty.DefaultSkinName == null)
                    return;
                else
                    UserLookAndFeel.Default.SkinName = WinFormProperty.DefaultSkinName;
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
            BtnThemeGallary.GalleryItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(GalleryItemCheckedChanged);
            InitSkinGalery();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            SaveWinFormProperty();
            base.OnClosing(e);
        }
        private void GalleryItemCheckedChanged(object sender, GalleryItemEventArgs e)
        {
            if (WinFormProperty != null)
                WinFormProperty.DefaultSkinName = e.Item.Caption; ;
        }

        #region PROPERTIES
        bool ActiveChildFormControl(string cFormName)
        {
            bool result = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == cFormName)
                {
                    frm.BringToFront();
                    result = true;
                }
            }
            return result;
        }
        private void InitSkinGalery()
        {
            BonusSkins.Register();
            SkinHelper.InitSkinGallery(BtnThemeGallary, true);
        }
        WinFormProperty WinFormProperty
        {
            get
            {
                if (_winFormProperty == null)
                    _winFormProperty = _winFormPropertyService.Get_WinFormProperty_By_UserId(SessionHelper.CurrentUserId);

                if(_winFormProperty == null)
                {
                    _winFormProperty = new WinFormProperty
                    {
                        IsEdit = true,
                        UserId = SessionHelper.CurrentUserId
                    };
                }
                return _winFormProperty;
            }
            set
            {
                _winFormProperty = value;
            }
        }
        void SaveWinFormProperty()
        {
            if (WinFormProperty != null)
            {
                WinFormProperty.UserId = SessionHelper.CurrentUserId;
                WinFormProperty.DefaultSkinName = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
                WinFormProperty.IsEdit = true;
                WinFormProperty.IsDeleted = false;
                WinFormProperty = _winFormPropertyService.Save(WinFormProperty);
            }
        }
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DbsContext"].ConnectionString;
            }
        }
        void ConnectionStringReader()
        {
            var builder = new SqlConnectionStringBuilder(ConnectionString);
            ServerName = builder.DataSource.Split('\\')[0];
            DatabaseName = builder.InitialCatalog; ;
            VersiyonNumber = Assembly.GetExecutingAssembly().GetName().Version.ToString(); ;
        }
        private string ServerName
        {
            get;
            set;
        }
        private string DatabaseName
        {
            get;
            set;
        }
        string VersiyonNumber
        {
            get;
            set;
        }
        #endregion
        private void BtnThemeGallary_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
          
        }

        private void BtnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenUsers(this);
        }

        private void BtnExpenseTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenExpenseTypes(this);
        }

        private void BtnRealities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenRealities(this);
        }

        private void BtnTenants_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenTenants(this);
        }

        private void BtnContracts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenRentContracts(this);
        }

        private void BtnMailSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenMailSettings(this);
        }

        private void BtnMailList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenMailHeaders(this);
        }

        private void BtnPolicies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOpenHelper.OpenInsurancePolicies(this);
        }
    }
}