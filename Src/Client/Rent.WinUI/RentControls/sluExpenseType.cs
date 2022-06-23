using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Rent.Business.Abstract;
using Rent.Business.DependencyResolves.Ninject;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistersluExpenseType")]
    public class RepositoryItemsluExpenseType : RepositoryItemsluDbsBase
    {

        static RepositoryItemsluExpenseType()
        {
            RegistersluExpenseType();
        }

        public const string CustomEditName = "sluExpenseType";

        public RepositoryItemsluExpenseType()
        {
            QueryPopUp += new CancelEventHandler(SearchLookUpEdit_Popup);
        }
        void SearchLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        void SearchLookUpEdit_Popup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //SearchLookUpEdit edit = sender as SearchLookUpEdit;
            //var obj = edit.Properties.View.GetRow(edit.Properties.GetIndexByKeyValue(edit.EditValue));
            //if (obj != null)
            //    cancel = true;
            //else
            //    cancel = false;

            //if(!showPopup)
            //    e.Cancel = cancel;
        }
        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegistersluExpenseType()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(sluExpenseType), typeof(RepositoryItemsluExpenseType), typeof(sluExpenseTypeViewInfo), new sluExpenseTypePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemsluExpenseType source = item as RepositoryItemsluExpenseType;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }
        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (IsDesignMode) return;
            
            GridColumn colId = new GridColumn();
            colId.Name = "colId";
            colId.FieldName = "Id";
            colId.Visible = false;

            GridColumn colName = new GridColumn();
            colName.Name = "colName";
            colName.FieldName = "Code";
            colName.Caption = "Kod";
            colName.VisibleIndex = 0;

            GridView gView = this.View;
            gView.Columns.Clear();
            gView.Columns.Add(colId);
            gView.Columns.Add(colName);
            
            NullText = string.Empty;
            DisplayMember = "Code";
            ValueMember = "Id";
        }
    }

    [ToolboxItem(true)]
    public class sluExpenseType : sluDbsBase
    {
        static sluExpenseType()
        {
            RepositoryItemsluExpenseType.RegistersluExpenseType();
        }

        public sluExpenseType()
        {
            if (IsDesignMode) return;
            QueryPopUp += new CancelEventHandler(SearchLookUpEdit_Popup);
        }
        void SearchLookUpEdit_Popup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IExpenseTypeService _ExpenseTypeService = InstanceFactory.GetInstance<IExpenseTypeService>();
            this.Properties.DataSource = _ExpenseTypeService.GetSluDataSourceAll();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemsluExpenseType Properties
        {
            get
            {
                return base.Properties as RepositoryItemsluExpenseType;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemsluExpenseType.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new sluExpenseTypePopupForm(this);
        }
    }

    public class sluExpenseTypeViewInfo : SearchLookUpEditBaseViewInfo
    {
        public sluExpenseTypeViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class sluExpenseTypePainter : ButtonEditPainter
    {
        public sluExpenseTypePainter()
        {
        }
    }

    public class sluExpenseTypePopupForm : PopupSearchLookUpEditForm
    {
        public sluExpenseTypePopupForm(sluExpenseType ownerEdit)
            : base(ownerEdit)
        {
        }
    }

}
