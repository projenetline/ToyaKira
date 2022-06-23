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
    [UserRepositoryItem("RegistersluTenant")]
    public class RepositoryItemsluTenant : RepositoryItemsluDbsBase
    {

        static RepositoryItemsluTenant()
        {
            RegistersluTenant();
        }

        public const string CustomEditName = "sluTenant";

        public RepositoryItemsluTenant()
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

        public static void RegistersluTenant()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(sluTenant), typeof(RepositoryItemsluTenant), typeof(sluTenantViewInfo), new sluTenantPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemsluTenant source = item as RepositoryItemsluTenant;
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
            colName.FieldName = "Name";
            colName.Caption = "Adı";
            colName.VisibleIndex = 0;

            GridView gView = this.View;
            gView.Columns.Clear();
            gView.Columns.Add(colId);
            gView.Columns.Add(colName);
            
            NullText = string.Empty;
            DisplayMember = "Name";
            ValueMember = "Id";
        }
    }

    [ToolboxItem(true)]
    public class sluTenant : sluDbsBase
    {
        static sluTenant()
        {
            RepositoryItemsluTenant.RegistersluTenant();
        }

        public sluTenant()
        {
            if (IsDesignMode) return;
            QueryPopUp += new CancelEventHandler(SearchLookUpEdit_Popup);
        }
        void SearchLookUpEdit_Popup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ITenantService _tenantService = InstanceFactory.GetInstance<ITenantService>();
            this.Properties.DataSource = _tenantService.GetSluDataSourceAll();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemsluTenant Properties
        {
            get
            {
                return base.Properties as RepositoryItemsluTenant;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemsluTenant.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new sluTenantPopupForm(this);
        }
    }

    public class sluTenantViewInfo : SearchLookUpEditBaseViewInfo
    {
        public sluTenantViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class sluTenantPainter : ButtonEditPainter
    {
        public sluTenantPainter()
        {
        }
    }

    public class sluTenantPopupForm : PopupSearchLookUpEditForm
    {
        public sluTenantPopupForm(sluTenant ownerEdit)
            : base(ownerEdit)
        {
        }
    }

}
