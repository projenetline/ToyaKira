using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using Rent.Business.Abstract;
using Rent.Business.Concrete;
using Rent.Business.DependencyResolves.Ninject;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Forms
{
    public partial class FrmBaseAdd : XtraForm
    {
        Form parentFormMain;
        ILogoDataService _logoDataService;
        int _objectId = 0;
        bool _examineObj, _newObj, _editObj, _saveObj, _copyObj, _isChangedData, _deleting, _loading = false;
        public FrmBaseAdd()
        {
            InitializeComponent();
        }
        public void SetParent(Form parent, bool newObj, bool editObj, bool examineObj)
        {
            Loading = true;
            SetInjections();
            this._editObj = editObj;
            this._newObj = newObj;
            this._examineObj = examineObj;
            this.parentFormMain = parent;
            InitValidation();
            if (parentFormMain != null)
                this.Location = new Point(parentFormMain.Left + (parentFormMain.Width - this.Width) / 2, parentFormMain.Top + (parentFormMain.Height - this.Height) / 2);

            UpdateReadOnlyData();
            InitData();
            Loading = false;
        }
        private void SetInjections()
        {
            _logoDataService = InstanceFactory.GetInstance<LogoDataManager>();
        }
        protected virtual void UpdateReadOnlyData()
        {
            if (ExamineObj)
            {
                foreach (System.Windows.Forms.Control item in LcMain.Controls)
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
            }
            else
            {
                foreach (System.Windows.Forms.Control item in LcMain.Controls)
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
                        view.OptionsBehavior.Editable = true;
                    }
                }
            }
        }
        protected virtual void AcceptButtonClick()
        {
            SplashScreenManager.ShowForm(typeof(FrmWaitForm));
            SplashScreenManager.Default.SetWaitFormDescription("Kaydediliyor...");
            if (Save())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            SplashScreenManager.CloseDefaultWaitForm();
        }
        protected virtual void InitData() { InitEditor(); }
        protected virtual void InitEditor() { }
        protected virtual void SetChangedDataValue()
        {
            IsChangeData = true;
            SetSaveButtonVisibility();
        }
        public void SetSaveButtonVisibility()
        {
            BtnOk.Enabled = IsChangeData;
        }
        protected virtual void SaveData()
        {
            Cursor.Current = Cursors.WaitCursor;
        }
        protected virtual bool ValidateData() { return ValidationProvider.Validate(); }
        protected virtual void CloseCancelForm() { }
        protected virtual void InitValidation() { }
        public virtual string EditObjectName
        {
            get { return string.Empty; }
        }

        #region PROPERTIES
        public string FormCaption { get; set; }
        public Int32 ObjectId
        {
            get
            {
                return _objectId;
            }
            set
            {
                _objectId = value;
            }
        }
        public bool Save()
        {
            if (ValidateData())
            {
                SaveData();
                return SaveObj;
            }
            return SaveObj;
        }
        public bool SaveObj
        {
            get { return _saveObj; }
            set
            {
                _saveObj = value;

            }
        }
        public bool ExamineObj
        {
            get { return _examineObj; }
            set
            {
                _examineObj = value;

            }
        }
        public bool EditObj
        {
            get { return _editObj; }
            set
            {
                _editObj = value;
            }
        }
        public bool CopyObj
        {
            get { return _copyObj; }
            set
            {
                _copyObj = value;
            }
        }
        public bool IsChangeData
        {
            get
            {
                return _isChangedData;
            }
            set
            {
                _isChangedData = value;

            }
        }
        public bool DeleteObj
        {
            get
            {
                return _deleting;
            }
            set
            {
                _deleting = value;

            }
        }
        public bool Loading
        {
            get { return _loading; }
            set
            {
                _loading = value;

            }
        }
        bool showCloseDialog = true;
        public bool ShowCloseDialog { get { return showCloseDialog; } set { showCloseDialog = value; } }
        public DXValidationProvider ValidationProvider { get { return dxValidationProvider1; } }

        private void FrmBaseAdd_Load(object sender, EventArgs e)
        {

        }

        protected virtual ColumnView CurrentView { get { return MainView01; } }
        protected virtual ColumnView MainView01 { get { return null; } }

        private void FrmBaseAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AcceptButtonClick();
        }
        protected virtual GridControl MainGridControl { get { return null; } }
        #endregion

        #region CONTROL_EVENTS
        private void EditorValueChanged(object sender, EventArgs e)
        {
            SetChangedDataValue();
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            AcceptButtonClick();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}