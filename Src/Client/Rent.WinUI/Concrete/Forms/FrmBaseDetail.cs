using DevExpress.Utils.Serializing;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using Rent.Business.Abstract;
using Rent.Business.Concrete;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Core.Concrete.Helpers;
using Rent.Core.Concrete.Resources;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Forms
{
    public partial class FrmBaseDetail : DevExpress.XtraEditors.XtraForm
    {
        IUserService _userService;
        IWinFormLayoutService _winFormLayoutService;
        WinFormLayout _layoutData;
        bool _loading, _showClosedialog = true;
        bool _newObj, _editObj, _examineObj, _copyObj, _dirtyObj, _isChangeData, _saveObj,
            _cancelClose, _deletingObj, _showAll = false;
        int _nObjectId = 0;
        Form _parentFormMain = null;
        FrmBaseList _baseListForm = null;
        public DialogResult ReturnResult = DialogResult.Cancel;
        public FrmBaseDetail()
        {
            InitializeComponent();
        }
        public void SetParent(int nObjectId, Form frmmain, bool newobj, bool editobj, bool examine, bool copy, FrmBaseList listForm)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(FrmWaitForm));
                ParentFormMain = frmmain;
                if (ParentFormMain != null)
                    this.Location = new Point(ParentFormMain.Left + (ParentFormMain.Width - this.Width) / 2, ParentFormMain.Top + (ParentFormMain.Height - this.Height) / 2);
                this._nObjectId = nObjectId;
                this.NewObj = newobj;
                this.EditObj = editobj;
                this.ExamineObj = examine;
                this._baseListForm = listForm;
                this.CopyObj = copy;
                BaseDetailLoad();
                SplashScreenManager.CloseDefaultWaitForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseDefaultWaitForm();
                MessageHelper.ExeptionMessage(ex);
            }
        }
        void BaseDetailLoad()
        {
            Loading = true;
            SetInjections();
            LoadLayoutForm();
            InitData();
            UpdateReadOnlyData();
            InitGridOptions();
            InitEditors();
            SetDetailUserRights();
            Loading = false;
        }
        private void FormClose()
        {
            _cancelClose = false;

            if (!ExamineObj && IsChangeData)
            {
                if (ReturnResult != DialogResult.OK)
                {
                    if (_showClosedialog)
                    {
                        DialogResult result = XtraMessageBox.Show(this, AppStrings.CloseCancelFormWarning, AppStrings.Warning, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Cancel)
                        {

                            _cancelClose = true;
                            return;
                        }
                        else if (result == DialogResult.Yes)
                        {
                            Save();
                        }
                        // satış ekranına özel gibi duruyor, incelenmeli
                        else if (result == DialogResult.No)
                        {
                            DeleteStoreTableStatus();
                        }
                    }
                    else
                    {

                        CloseCancelForm();
                    }
                }
            }

            Cursor.Current = Cursors.Default;
            DisposeCancelledObject();
        }
        private void ClearFilters()
        {
            if (MainView01 != null)
                MainView01.ActiveFilter.Clear();

            if (MainView02 != null)
                MainView02.ActiveFilter.Clear();

            if (MainView03 != null)
                MainView03.ActiveFilter.Clear();

            if (MainView04 != null)
                MainView04.ActiveFilter.Clear();

            if (MainView05 != null)
                MainView05.ActiveFilter.Clear();

            if (MainView06 != null)
                MainView06.ActiveFilter.Clear();

            if (MainView07 != null)
                MainView07.ActiveFilter.Clear();

            if (MainView08 != null)
                MainView08.ActiveFilter.Clear();

            if (MainView09 != null)
                MainView09.ActiveFilter.Clear();

            if (MainView10 != null)
                MainView10.ActiveFilter.Clear();
        }
        public void Message(string headerName, string msg, Image img)
        {
            if (MainAlertControl == null) return;
            MainAlertControl.Show(this, headerName, msg, img);
        }
        
        #region VIRTUALMETHODS
        protected virtual void SetInjections()
        {
            _userService = InstanceFactory.GetInstance<UserManager>();
            _winFormLayoutService = InstanceFactory.GetInstance<WinFormLayoutManager>();
        }
        protected virtual void SetDetailUserRights(){}
        protected virtual void DeleteStoreTableStatus()
        {
        }
        protected virtual void CloseCancelForm() { }
        protected virtual void DisposeCancelledObject()
        {
        }
        protected virtual void InitData()
        {
        }
        protected virtual void InitEditors()
        {
            SetSaveButtonVisibility();
        }
        protected virtual void SetSaveButtonVisibility()
        {
            RBtnSave.Enabled = IsChangeData;
            RBtnSaveClose.Enabled = IsChangeData;
        }
        protected virtual void UpdateReadOnlyData()
        {
            if (ExamineObj)
            {
                foreach (Control item in LcMain.Controls)
                {
                    if (item is BaseEdit be)
                    {
                        be.Properties.ReadOnly = true;
                        be.EditValueChanged += new EventHandler(EditorValueChanged);
                    }
                    if (item is GridControl grid)
                    {
                        if (!(grid.MainView is ColumnView view)) continue;
                        view.OptionsBehavior.ReadOnly = true;
                    }
                }
                RBtnSave.Enabled = false;
                RBtnSaveClose.Enabled = false;
            }
            else
            {
                foreach (Control item in LcMain.Controls)
                {
                    if (item is BaseEdit be) if (be != null)
                        {
                            be.Properties.ReadOnly = false;
                            be.EditValueChanged += new EventHandler(EditorValueChanged);
                        }
                    if (item is GridControl grid)
                    {
                        if (!(grid.MainView is ColumnView view)) continue;
                        view.OptionsBehavior.ReadOnly = false;
                    }
                }
                RBtnSave.Enabled = true;
                RBtnSaveClose.Enabled = true;
            }
        }
        protected virtual void SaveData()
        {
            Cursor.Current = Cursors.WaitCursor;
        }
        protected virtual void Delete() { }
        protected virtual void Print()
        {

        }
        protected virtual void QuickPrint()
        {

        }
        protected virtual void SetChangedDataValue()
        {
            IsChangeData = true;
            SetSaveButtonVisibility();
        }

        #endregion

        #region CONTROLEVENTS
        protected override void OnClosing(CancelEventArgs e)
        {
            FormClose();
            SaveLayoutForm();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            e.Cancel = _cancelClose;
            base.OnClosing(e);
        }
        private void FrmBaseDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ClearOpenFormData();
            //SaveLayoutForm();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //GC.Collect();
        }
        void EditorValueChanged(object sender, EventArgs e)
        {
            SetChangedDataValue();
        }
        private void RBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }
        private void RBtnSaveClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveAndClose();
        }
        private void RBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void RBtnPrintQuick_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuickPrint();
        }

        private void RBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Print();
        }
        #endregion

        #region PROPERTIES
        public bool Save()
        {
            try
            {
                if (ValidateData())
                {
                    SplashScreenManager.ShowForm(typeof(FrmWaitForm));
                    SplashScreenManager.Default.SetWaitFormDescription(AppStrings.SavingProcess);
                    SaveData();
                    SplashScreenManager.CloseForm();

                    if (BaseListForm != null)
                    {
                        if (SaveObj)
                            BaseListForm.AfterSaveRehresh = true;
                        else
                            BaseListForm.AfterSaveRehresh = false;
                    }
                }
                return SaveObj;
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
                SplashScreenManager.CloseDefaultWaitForm();
                return false;
            }
        }
        public bool SaveAndClose()
        {
            //DeleteObjectView();
            if (Save())
            {
                ReturnResult = DialogResult.OK;
                this.Close();
                //FormClose();
                return true;
            }
            return false;
        }
        public virtual string ActiveFormName
        {
            get
            {
                return string.Empty;
            }
        }
        public virtual string ActiveFormText
        {
            get
            {
                return this.Text;
            }
        }
        public int ObjectId { get { return _nObjectId; } }
        public bool Loading
        {
            get
            {
                return _loading;
            }
            set
            {
                _loading = value;
            }
        }
        public bool ShowAll
        {
            get
            {
                return _showAll;
            }
            set
            {
                _showAll = value;
            }
        }
        public bool NewObj
        {
            get
            {
                return _newObj;
            }
            set
            {
                _newObj = value;
            }
        }
        public bool EditObj
        {
            get
            {
                return _editObj;
            }
            set
            {
                _editObj = value;
            }
        }
        public bool ExamineObj
        {
            get
            {
                return _examineObj;
            }
            set
            {
                _examineObj = value;
            }
        }
        public bool CopyObj
        {
            get
            {
                return _copyObj;
            }
            set
            {
                _copyObj = value;
            }
        }
        public bool DirtyObj
        {
            get
            {
                return _dirtyObj;
            }
            set
            {
                _dirtyObj = value;
            }
        }
        public bool SaveObj
        {
            get
            {
                return _saveObj;
            }
            set
            {
                _saveObj = value;
            }
        }
        public bool DeletingObj
        {
            get
            {
                return _deletingObj;
            }
            set
            {
                _deletingObj = value;
            }
        }
        public bool IsChangeData
        {
            get
            {
                return _isChangeData;
            }
            set
            {
                _isChangeData = value;

            }
        }
        public Form ParentFormMain
        {
            get
            {
                return _parentFormMain;
            }
            set
            {
                _parentFormMain = value;
            }
        }
        public FrmBaseList BaseListForm
        {
            get
            {
                return _baseListForm;
            }
            set
            {
                _baseListForm = value;
            }
        }
        public void SaveSuccessMessage()
        {
           MainAlertControl.Show(this, string.Empty, AppStrings.SuccessfulSaveMessage, DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/saveall_32x32.png"));
        }
        public DXValidationProvider ValidationProvider { get { return dxValidationProvider1; } }
        protected virtual bool ValidateData() { return ValidationProvider.Validate(); }
        protected virtual ColumnView CurrentView { get { return MainView01; } }
        protected virtual ColumnView MainView01 { get { return null; } }
        protected virtual ColumnView MainView02 { get { return null; } }
        protected virtual ColumnView MainView03 { get { return null; } }
        protected virtual ColumnView MainView04 { get { return null; } }
        protected virtual ColumnView MainView05 { get { return null; } }
        protected virtual ColumnView MainView06 { get { return null; } }
        protected virtual ColumnView MainView07 { get { return null; } }
        protected virtual ColumnView MainView08 { get { return null; } }
        protected virtual ColumnView MainView09 { get { return null; } }
        protected virtual ColumnView MainView10 { get { return null; } }


        protected virtual AlertControl MainAlertControl
        {
            get
            {
                return alertControl1;
            }
        }
        #endregion

        #region LAYOUTOPERATIONS
        WinFormLayout GetWinFormLayout
        {
            get
            {
                if (_layoutData == null)
                    _layoutData = _winFormLayoutService.GetWinLayoutBy_UserId_WitFormName(SessionHelper.CurrentUserId, this.Name);

                return _layoutData;
            }
        }
        public void SaveLayoutForm()
        {
            try
            {
              //  if (!AppSettingsHelper.SaveLayout) return;

                // if (!LoginHelper.isAdmin) return;
                ClearFilters();
                var _layout = GetWinFormLayout;
                if (_layout == null)
                    _layout = new WinFormLayout();

                _layout.UserId = SessionHelper.CurrentUserId;
                _layout.Name = this.Name;
                MemoryStream stream = new MemoryStream();
                MemoryStream streamMainView01 = new MemoryStream();
                MemoryStream streamMainView02 = new MemoryStream();
                MemoryStream streamMainView03 = new MemoryStream();
                MemoryStream streamMainView04 = new MemoryStream();
                MemoryStream streamMainView05 = new MemoryStream();
                MemoryStream streamMainView06 = new MemoryStream();
                MemoryStream streamMainView07 = new MemoryStream();
                MemoryStream streamMainView08 = new MemoryStream();
                MemoryStream streamMainView09 = new MemoryStream();
                MemoryStream streamMainView10 = new MemoryStream();
                LcMain.SaveLayoutToStream(stream);
                _layout.MainLayoutControlLayout = stream.GetBuffer();
                if (MainView01 != null)
                {
                    MainView01.SaveLayoutToStream(streamMainView01);
                    _layout.MainColumnViewLayout01 = streamMainView01.GetBuffer();
                }
                if (MainView02 != null)
                {
                    MainView02.SaveLayoutToStream(streamMainView02);
                    _layout.MainColumnViewLayout02 = streamMainView02.GetBuffer();
                }
                if (MainView03 != null)
                {
                    MainView03.SaveLayoutToStream(streamMainView03);
                    _layout.MainColumnViewLayout03 = streamMainView03.GetBuffer();
                }
                if (MainView04 != null)
                {
                    MainView04.SaveLayoutToStream(streamMainView04);
                    _layout.MainColumnViewLayout04 = streamMainView04.GetBuffer();
                }
                if (MainView05 != null)
                {
                    MainView05.SaveLayoutToStream(streamMainView05);
                    _layout.MainColumnViewLayout05 = streamMainView05.GetBuffer();
                }
                if (MainView06 != null)
                {
                    MainView06.SaveLayoutToStream(streamMainView06);
                    _layout.MainColumnViewLayout06 = streamMainView06.GetBuffer();
                }
                if (MainView07 != null)
                {
                    MainView07.SaveLayoutToStream(streamMainView07);
                    _layout.MainColumnViewLayout07 = streamMainView07.GetBuffer();
                }
                if (MainView08 != null)
                {
                    MainView08.SaveLayoutToStream(streamMainView08);
                    _layout.MainColumnViewLayout08 = streamMainView08.GetBuffer();
                }
                if (MainView09 != null)
                {
                    MainView09.SaveLayoutToStream(streamMainView09);
                    _layout.MainColumnViewLayout09 = streamMainView09.GetBuffer();
                }
                if (MainView10 != null)
                {
                    MainView10.SaveLayoutToStream(streamMainView10);
                    _layout.MainColumnViewLayout10 = streamMainView10.GetBuffer();
                }

                _winFormLayoutService.Save(_layout);
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }
        public void LoadLayoutForm()
        {
            try
            {
                // if (!AppSettingsHelper.SaveLayout) return;
                var _layout = GetWinFormLayout;
                if (_layout != null)
                {
                    MemoryStream stream = new MemoryStream(_layout.MainLayoutControlLayout);
                    if (LcMain != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainLayoutControlLayout), LcMain);
                    if (MainView01 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout01), MainView01);
                    if (MainView02 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout02), MainView02);
                    if (MainView03 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout03), MainView03);
                    if (MainView04 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout04), MainView04);
                    if (MainView05 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout05), MainView05);
                    if (MainView06 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout06), MainView06);
                    if (MainView07 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout07), MainView07);
                    if (MainView08 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout08), MainView08);
                    if (MainView09 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout09), MainView09);
                    if (MainView10 != null)
                        RestoreControlLayout(new MemoryStream(_layout.MainColumnViewLayout10), MainView10);
                }

                //if (LoginHelper.isAdmin)
                //{
                //    lcMain.AllowCustomization = true;
                //}
                //else
                //{
                //    lcMain.AllowCustomization = false;
                //}
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }
        public void RestoreControlLayout(MemoryStream layout, ISupportXtraSerializer control)
        {
            if (layout == null || layout == Stream.Null || control == null) return;
            layout.Seek(0, SeekOrigin.Begin);
            control.RestoreLayoutFromStream(layout);
        }
        #endregion

        #region GRIDOPTIONS
        void InitGridOptions()
        {
            if (MainView01 != null)
            {
                MainView01.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView02 != null)
            {
                MainView02.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView03 != null)
            {
                MainView03.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView04 != null)
            {
                MainView04.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView05 != null)
            {
                MainView05.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView06 != null)
            {
                MainView06.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView07 != null)
            {
                MainView07.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView08 != null)
            {
                MainView08.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView09 != null)
            {
                MainView09.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
            if (MainView10 != null)
            {
                MainView10.RowUpdated += new RowObjectEventHandler(MainView_RowUpdated);
            }
        }
        private void MainView_RowUpdated(object sender, RowObjectEventArgs e)
        {
            if (!(sender is ColumnView view)) return;
            View_RowUpdated(e.RowHandle, view);
        }
        protected virtual void View_RowUpdated(int nRowHandle, ColumnView view)
        {
            if (view != null)
            {
                view.SetRowCellValue(nRowHandle, "isEdit", true);
                IsChangeData = true;
            }
        }
        #endregion
    }
}