using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Links;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Rent.Business.Abstract;
using Rent.Business.Concrete;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Core.Concrete.Helpers;
using Rent.Core.Concrete.Resources;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Forms
{
    public partial class FrmBaseList : XtraForm
    {
        bool _detailForm = true;
        bool _isLoading, _isEditable, _afterSaveRefresh, _showAll, _showImage =  false;
        Form _parentFormMain = null;
        string _cSelectedRow = "-1";
        WinFormLayout _layoutData;
        IWinFormLayoutService _winFormLayoutService;
        IUserService _userService;
        public FrmBaseList()
        {
            InitializeComponent();
        }
        public void FormLoad(Form parent)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(FrmWaitForm));
                IsLoading = true;
                SetInjections();
                LoadLayoutForm();
                this.ParentFormMain = parent;
                IsLoading = true;
                if (MainView01 != null)
                    MainView01.BeginUpdate();
                GetRecordList();
                InitEditors();
                if (MainView01 != null)
                    MainView01.EndUpdate();
                IsLoading = false;
                InitGridOptions();
                IsLoading = false;
                SplashScreenManager.CloseDefaultWaitForm();
            }
            catch(Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
                if (SplashScreenManager.FormInPendingState == true)
                    SplashScreenManager.CloseDefaultWaitForm();
            }
        }
        void DataEdit()
        {
            if (ActiveChildFormControl) return;
            Cursor.Current = Cursors.WaitCursor;
            Edit();
            Cursor.Current = Cursors.Default;
        }
        void DataExamine()
        {
            if (ActiveChildFormControl) return;
            Cursor.Current = Cursors.WaitCursor;
            Examine();
            Cursor.Current = Cursors.Default;
        }
        void DataAdd()
        {
            if (ActiveChildFormControl) return;
            Cursor.Current = Cursors.WaitCursor;
            Add();
            Cursor.Current = Cursors.Default;
        }
        void DataCopy()
        {
            if (ActiveChildFormControl) return;
            Cursor.Current = Cursors.WaitCursor;
            Copy();
            Cursor.Current = Cursors.Default;
        }
        private void FrmBaseList_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLayoutForm();
        }
        #region VIRTUALMETHODS
        protected virtual void SetInjections()
        {
            _winFormLayoutService = InstanceFactory.GetInstance<WinFormLayoutManager>();
            _userService = InstanceFactory.GetInstance<UserManager>();
        }
        protected virtual void GetRecordList()
        {
            if (!IsLoading)
            {
                InitEditors();
            }
        }
        protected virtual void InitEditors() { }
        protected virtual void FormActivated()
        {
            if (!IsLoading && AfterSaveRehresh)
            {
                GetRecordList();
                AfterSaveRehresh = false;
            }
        }
        protected virtual void Print() { }
        protected virtual void PrintPreview() { }
        protected virtual void Edit()
        {
            
            if (ActiveChildFormControl)
            {
                AfterSaveRehresh = false;
                return;
            }

        } 
        protected virtual void Examine()
        {
            if (ActiveChildFormControl)
            {
                AfterSaveRehresh = false;
                return;
            }
        } 
        protected virtual void Add()
        {
            if (ActiveChildFormControl)
            {
                AfterSaveRehresh = false;
                return;
            }
        }
        protected virtual void Copy()
        {
            if (ActiveChildFormControl)
            {
                AfterSaveRehresh = false;
                return;
            }
        }
        protected virtual void Delete()
        {
            GetRecordList();
        }
        #endregion

        #region LAYOUTOPTIONS
        byte[] GetLayoutData(GridView view)
        {
            MemoryStream stream = new MemoryStream();
            view.SaveLayoutToStream(stream);
            return stream.GetBuffer();
        }
        void SetLayoutData(GridView view, byte[] data)
        {
            if (data == null || data.Length == 0) return;
            MemoryStream stream = new MemoryStream(data);
            try
            {
                view.RestoreLayoutFromStream(stream);
            }
            catch (Exception ex)
            {
                throw new Exception("Wrong data format", ex);
            }
        }
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
                if (MainView01 == null) return;
                var layout = GetWinFormLayout;
                if (layout == null)
                {
                    layout = new WinFormLayout();
                }

                layout.UserId = SessionHelper.CurrentUserId;
                layout.Name = this.Name;
                MemoryStream stream = new MemoryStream();
                MainView01.SaveLayoutToStream(stream);
                layout.MainColumnViewLayout01 = stream.GetBuffer();
                layout = _winFormLayoutService.Save(layout);
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
                var layout = GetWinFormLayout;
                if (layout != null)
                {
                    if (layout.MainColumnViewLayout01 != null || layout.MainColumnViewLayout01.Length != 0)
                    {
                        MemoryStream stream = new MemoryStream(layout.MainColumnViewLayout01);
                        MainView01.RestoreLayoutFromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }

        }
        #endregion

        #region GRIDOPTIONS
        void InitGridOptions()
        {
            if (MainView01 != null)
            {
                MainView01.FocusedRowChanged += new FocusedRowChangedEventHandler(MainView_FocusedRowChanged);
                MainView01.ColumnFilterChanged += new EventHandler(MainView_ColumnFilterChanged);
                MainView01.GridControl.MouseDoubleClick += new MouseEventHandler(GridControl_MouseDoubleClick);
                MainView01.SelectionChanged += new SelectionChangedEventHandler(MainView_SelectionChanged);
                MainView01.KeyDown += new KeyEventHandler(MainView_KeyDown);
            }
        }
        void MainView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Delete();
            else if (_cSelectedRow != null && e.KeyCode == Keys.Enter)
            {
                    DataEdit();
            }
        }
        void GridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (((GridControl)sender).MainView is GridView gv)
                {
                    GridHitInfo info = gv.CalcHitInfo(new Point(e.X, e.Y));
                    if (!info.InRow) return;
                    DataEdit();
                }
                else
                {
                    if (((GridControl)sender).MainView is ColumnView cv)
                    {
                        if (CurrentEditObject == null) return;
                        if (IsEditable == true) DataEdit();
                        DataExamine();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        void MainView_ColumnFilterChanged(object sender, EventArgs e)
        {
            DoFocusedRowChanged();
        }
        void MainView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DoFocusedRowChanged();
        }
        bool isRunning = false;
        void MainView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isRunning) return;
            isRunning = true;

            GridView View = sender as GridView;

            if (e.Action == CollectionChangeAction.Add && View.IsGroupRow(e.ControllerRow))
            {
                View.UnselectRow(e.ControllerRow);
            }

            if (e.Action == CollectionChangeAction.Refresh && View.SelectedRowsCount > 0)
            {
                View.BeginSelection();
                foreach (int Row in View.GetSelectedRows())
                {
                    if (View.IsGroupRow(Row)) View.UnselectRow(Row);
                }
                View.EndSelection();
            }
            isRunning = false;
        }
        void MainView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((DXMouseEventArgs)e).Handled = true;
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
                if (hitInfo.InRow)
                {
                    view.FocusedColumn = hitInfo.Column;
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    view.ShowEditor();
                    view.ActiveEditor.SendMouse(view.ActiveEditor.PointToClient(Cursor.Position), MouseButtons.Right);
                }
            }
        }
        protected virtual void DoFocusedRowChanged()
        {
            SetCurrentRow(CurrentEditObject);
        }
        void SetCurrentRow(object editobject)
        {
            if (CurrentView == null) return;
        }
        #endregion

        #region CONTEXMENU
        public DXMenuItem[] menuItems;
        private void ItemAdd_Click(object sender, System.EventArgs e)
        {
            Add();
        }
        private void ItemEdit_Click(object sender, System.EventArgs e)
        {
            Edit();
        }
        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            Delete();
        }
        private void ItemExamine_Click(object sender, System.EventArgs e)
        {
            Examine();
        }
        private void ItemRefresh_Click(object sender, System.EventArgs e)
        {
            Refresh();
        }
        private void ItemCopy_Click(object sender, System.EventArgs e)
        {
            Copy();
        }
        private void ItemRepPreview_Click(object sender, System.EventArgs e)
        {
            PrintPreview();
        }
        private void ItemRepPrint_Click(object sender, System.EventArgs e)
        {
            Print();
        }
        #endregion

        #region PROPERTIES
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
        public virtual string EditObjectName { get { return string.Empty; } }
        protected virtual String DetailFormName
        {
            get
            {
                return null;
            }
        }
        public bool IsDetailForm { get { return _detailForm; } }
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
            }
        }
        public bool IsEditable
        {
            get
            {
                return _isEditable;
            }
            set
            {
                _isEditable = value;
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
        public bool ShowImage
        {
            get
            {
                return _showImage;
            }
            set
            {
                _showImage = value;
            }
        }
        public bool AfterSaveRehresh
        {
            get
            {
                return _afterSaveRefresh;
            }
            set
            {
                _afterSaveRefresh = value;
            }
        }
        bool ActiveChildFormControl
        {
            get
            {
                bool result = false;
                foreach (Form frm in this.MdiParent.MdiChildren)
                {
                    if (frm.Name == DetailFormName)
                    {
                        frm.BringToFront();
                        result = true;
                    }
                }
                return result;
            }
        }
        public virtual int CurrentObjectId
        {
            get
            {
                if (CurrentView != null)
                    return CurrentView.GetRowCellValue(CurrentView.FocusedRowHandle, "id") != DBNull.Value
                             ? Convert.ToInt32(CurrentView.GetRowCellValue(CurrentView.FocusedRowHandle, "id"))
                             : 0;
                else
                    return 0;
            }
        }
        protected virtual ColumnView CurrentView { get { return MainView01; } }
        protected virtual ColumnView MainView01 { get { return null; } }
        protected virtual GridControl MainGridControl { get { return null; } }
        protected virtual BaseEntity CurrentEditObject { get { return null; } set { } }
        #endregion

        #region PRINTING
        protected virtual void AllowExport()
        {
            EnabledPrintExportActions(true, true, true, true);
        }
        internal void EnabledPrintExportActions(bool allow)
        {
            EnabledPrintExportActions(allow, allow, allow, allow);
        }
        internal void EnabledPrintExportActions(bool allowPrintPreview, bool allowExportToPDF, bool allowExportToXLS, bool allowExportToXLSX)
        {
            RBtnExportPdf.Enabled = allowExportToPDF;
            RBtnExportXls.Enabled = allowExportToXLS;
            RBtnExportXlsx.Enabled = allowExportToXLSX;
        }
        protected void ShowRibbonPreviewDialog(LinkBase link)
        {
            InitPrintTool(new LinkPrintTool(link));
        }
        protected void ShowRibbonPreviewDialog(IReport report)
        {
            InitPrintTool(new ReportPrintTool(report));
        }
        protected virtual void InitPrintTool(PrintTool tool)
        {
            //tool.PreviewRibbonForm.AllowFormGlass = this.ParentFormMain.AllowFormGlass;
            tool.PreviewRibbonForm.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            tool.PreviewRibbonForm.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            tool.PreviewRibbonForm.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            tool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
        }
        PrintingSystem printingSystem = null;
        PrintingSystem Printing
        {
            get
            {
                if (printingSystem == null) printingSystem = new PrintingSystem();
                return printingSystem;
            }
        }
        protected virtual BaseView ExportView { get { return MainView01; } }
        protected virtual bool Landscape { get { return false; } }
        protected virtual string ExportFileName { get { return EditObjectName; } }
        void ExportTo(string ext, string filter)
        {
            string fileName = NetlineAppHelper.GetFileName(string.Format("*.{0}", ext), filter, NetlineAppHelper.GetPossibleFileName(ExportFileName));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    ExportToCore(fileName, ext);
                    NetlineAppHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    NetlineAppHelper.ShowExportErrorMessage();
                }
        }
        void ExportToCore(String filename, string ext)
        {
            if (ExportView == null) return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (ext == "pdf") ExportView.ExportToPdf(filename);
            if (ext == "xls") ExportView.ExportToXls(filename);
            if (ext == "xlsx") ExportView.ExportToXlsx(filename);
            Cursor.Current = currentCursor;
        }
        protected void ExportToXLS()
        {
            ExportTo("xls", AppStrings.XLSOpenFileFilter);
        }
        protected void ExportToXLSX()
        {
            ExportTo("xlsx", AppStrings.XLSXOpenFileFilter);
        }
        protected void ExportToPDF()
        {
            ExportTo("pdf", AppStrings.PDFOpenFileFilter);
        }
        #endregion

        #region BUTTONCLİCK
        private void RbtnAddNewRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add();
        }
        private void RBtnEditRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit();
        }
        private void RBtnExamineRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Examine();
        }
        private void RBtnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Copy();
        }
        private void RBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }
        private void RBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetRecordList();
        }
        private void RBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void FrmBaseList_Activated(object sender, EventArgs e)
        {
            FormActivated();
        }
        private void RBtnShowAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_isLoading) return;
            if (RBtnShowAll.Caption == AppStrings.ShowActiveRecords)
            {
                RBtnShowAll.ImageUri = "clearfilter";
                RBtnShowAll.Caption = AppStrings.ShowAll;
                RBtnShowAll.Tag = 0;
                ShowAll = false;
                GetRecordList();
            }
            else
            {
                RBtnShowAll.ImageUri = "filter";
                RBtnShowAll.Caption = AppStrings.ShowActiveRecords;
                RBtnShowAll.Tag = 1;
                ShowAll = true;
                GetRecordList();
            }
        }
        private void RBtnExportPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportToPDF();
        }
        private void RBtnExportXlsx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportToXLSX();
        }
        private void RBtnExportXls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportToXLS();
        }
        #endregion
    }
}