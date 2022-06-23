using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegisterdeDateEdit")]
    public class RepositoryItemdeDateEdit : RepositoryItemDateEdit
    {
        static RepositoryItemdeDateEdit()
        {
            RegisterdeDateEdit();
        }

        public const string CustomEditName = "deDateEdit";

        public RepositoryItemdeDateEdit()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterdeDateEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(deDateEdit), typeof(RepositoryItemdeDateEdit), typeof(deDateEditViewInfo), new deDateEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemdeDateEdit source = item as RepositoryItemdeDateEdit;
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
            this.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Mask.EditMask = "dd/MM/yyyy";
            this.NullDate = "01.01.2000";
            this.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            // this.NullText = DbsHelper.DigitexDefaultDateTime.ToString();
            DateEditFormatter formatter = new DateEditFormatter();
            this.EditFormat.Format = formatter;
            this.DisplayFormat.Format = formatter;
        }
    }

    [ToolboxItem(true)]
    public class deDateEdit : DateEdit
    {
        static deDateEdit()
        {
            RepositoryItemdeDateEdit.RegisterdeDateEdit();
        }

        public deDateEdit()
        {
            if (IsDesignMode) return;
            this.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Properties.NullDate = "01.01.2000";
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            DateEditFormatter formatter = new DateEditFormatter();
            this.Properties.EditFormat.Format = formatter;
            this.Properties.DisplayFormat.Format = formatter;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemdeDateEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemdeDateEdit;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemdeDateEdit.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new deDateEditPopupForm(this);
        }
    }

    public class deDateEditViewInfo : DateEditViewInfo
    {
        public deDateEditViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class deDateEditPainter : ButtonEditPainter
    {
        public deDateEditPainter()
        {
        }
    }

    public class deDateEditPopupForm : PopupDateEditForm
    {
        public deDateEditPopupForm(deDateEdit ownerEdit)
            : base(ownerEdit)
        {
        }
    }
}
