using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistertxtTextEdit30")]
    public class RepositoryItemtxtTextEdit30 : RepositoryItemTextEdit
    {
        static RepositoryItemtxtTextEdit30()
        {
            RegistertxtTextEdit30();
        }

        public const string CustomEditName = "txtTextEdit30";

        public RepositoryItemtxtTextEdit30()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegistertxtTextEdit30()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(txtTextEdit30), typeof(RepositoryItemtxtTextEdit30), typeof(txtTextEdit30ViewInfo), new txtTextEdit30Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemtxtTextEdit30 source = item as RepositoryItemtxtTextEdit30;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }
    }

    [ToolboxItem(true)]
    public class txtTextEdit30 : TextEdit
    {
        static txtTextEdit30()
        {
            RepositoryItemtxtTextEdit30.RegistertxtTextEdit30();
        }

        public txtTextEdit30()
        {
            this.Properties.MaxLength = 30;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemtxtTextEdit30 Properties
        {
            get
            {
                return base.Properties as RepositoryItemtxtTextEdit30;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemtxtTextEdit30.CustomEditName;
            }
        }
    }

    public class txtTextEdit30ViewInfo : TextEditViewInfo
    {
        public txtTextEdit30ViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class txtTextEdit30Painter : TextEditPainter
    {
        public txtTextEdit30Painter()
        {
        }
    }
}
