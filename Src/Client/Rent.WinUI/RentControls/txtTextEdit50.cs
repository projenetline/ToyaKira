using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistertxtTextEdit50")]
    public class RepositoryItemtxtTextEdit50 : RepositoryItemTextEdit
    {
        static RepositoryItemtxtTextEdit50()
        {
            RegistertxtTextEdit50();
        }

        public const string CustomEditName = "txtTextEdit50";

        public RepositoryItemtxtTextEdit50()
        {
            MaxLength = 30;
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegistertxtTextEdit50()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(txtTextEdit50), typeof(RepositoryItemtxtTextEdit50), typeof(txtTextEdit50ViewInfo), new txtTextEdit50Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemtxtTextEdit50 source = item as RepositoryItemtxtTextEdit50;
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
    public class txtTextEdit50 : TextEdit
    {
        static txtTextEdit50()
        {
            RepositoryItemtxtTextEdit50.RegistertxtTextEdit50();
        }

        public txtTextEdit50()
        {
            this.Properties.MaxLength = 50;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemtxtTextEdit50 Properties
        {
            get
            {
                return base.Properties as RepositoryItemtxtTextEdit50;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemtxtTextEdit50.CustomEditName;
            }
        }
    }

    public class txtTextEdit50ViewInfo : TextEditViewInfo
    {
        public txtTextEdit50ViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class txtTextEdit50Painter : TextEditPainter
    {
        public txtTextEdit50Painter()
        {
        }
    }
}
