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
    [UserRepositoryItem("RegistersluReality")]
    public class RepositoryItemsluReality : RepositoryItemsluDbsBase
    {

        static RepositoryItemsluReality()
        {
            RegistersluReality();
        }

        public const string CustomEditName = "sluReality";

        public RepositoryItemsluReality()
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

        public static void RegistersluReality()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(sluReality), typeof(RepositoryItemsluReality), typeof(sluRealityViewInfo), new sluRealityPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemsluReality source = item as RepositoryItemsluReality;
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
            colName.Caption = "Taşınmaz Kodu";
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
    public class sluReality : sluDbsBase
    {
        static sluReality()
        {
            RepositoryItemsluReality.RegistersluReality();
        }

        public sluReality()
        {
            if (IsDesignMode) return;
            QueryPopUp += new CancelEventHandler(SearchLookUpEdit_Popup);
        }
        void SearchLookUpEdit_Popup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IRealityService _realityService = InstanceFactory.GetInstance<IRealityService>();
            this.Properties.DataSource = _realityService.GetSluDataSourceAll();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemsluReality Properties
        {
            get
            {
                return base.Properties as RepositoryItemsluReality;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemsluReality.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new sluRealityPopupForm(this);
        }
    }

    public class sluRealityViewInfo : SearchLookUpEditBaseViewInfo
    {
        public sluRealityViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class sluRealityPainter : ButtonEditPainter
    {
        public sluRealityPainter()
        {
        }
    }

    public class sluRealityPopupForm : PopupSearchLookUpEditForm
    {
        public sluRealityPopupForm(sluReality ownerEdit)
            : base(ownerEdit)
        {
        }
    }

}
