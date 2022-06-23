using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistertxtTextEdit100")]
    public class RepositoryItemtxtTextEdit100 : RepositoryItemTextEdit
    {
        static RepositoryItemtxtTextEdit100()
        {
            RegistertxtTextEdit100();
        }

        public const string CustomEditName = "txtTextEdit100";

        public RepositoryItemtxtTextEdit100()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.AllowDpiScale = true;
            MaxLength = 100;
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegistertxtTextEdit100()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(txtTextEdit100), typeof(RepositoryItemtxtTextEdit100), typeof(txtTextEdit100ViewInfo), new txtTextEdit100Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemtxtTextEdit100 source = item as RepositoryItemtxtTextEdit100;
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
        }
    }

    [ToolboxItem(true)]
    public class txtTextEdit100 : TextEdit
    {
        static txtTextEdit100()
        {
            RepositoryItemtxtTextEdit100.RegistertxtTextEdit100();
        }

        public txtTextEdit100()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemtxtTextEdit100 Properties
        {
            get
            {
                return base.Properties as RepositoryItemtxtTextEdit100;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemtxtTextEdit100.CustomEditName;
            }
        }
    }

    public class txtTextEdit100ViewInfo : TextEditViewInfo
    {
        public txtTextEdit100ViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class txtTextEdit100Painter : TextEditPainter
    {
        public txtTextEdit100Painter()
        {
        }
    }
}
