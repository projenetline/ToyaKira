using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistertxtTextEditPhone")]
    public class RepositoryItemtxtTextEditPhone : RepositoryItemTextEdit
    {
        static RepositoryItemtxtTextEditPhone()
        {
            RegistertxtTextEditPhone();
        }

        public const string CustomEditName = "txtTextEditPhone";

        public RepositoryItemtxtTextEditPhone()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegistertxtTextEditPhone()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(txtTextEditPhone), typeof(RepositoryItemtxtTextEditPhone), typeof(txtTextEditPhoneViewInfo), new txtTextEditPhonePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemtxtTextEditPhone source = item as RepositoryItemtxtTextEditPhone;
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
            this.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Mask.EditMask = @"\((\d{3})\)-(\d{3})-(\d{4}) (x(\d*))? ";
            this.Mask.UseMaskAsDisplayFormat = true;
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class txtTextEditPhone : TextEdit
    {
        static txtTextEditPhone()
        {
            RepositoryItemtxtTextEditPhone.RegistertxtTextEditPhone();
        }

        public txtTextEditPhone()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemtxtTextEditPhone Properties => base.Properties as RepositoryItemtxtTextEditPhone;

        public override string EditorTypeName => RepositoryItemtxtTextEditPhone.CustomEditName;
    }

    public class txtTextEditPhoneViewInfo : TextEditViewInfo
    {
        public txtTextEditPhoneViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class txtTextEditPhonePainter : TextEditPainter
    {
        public txtTextEditPhonePainter()
        {
        }
    }
}


