using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistertxtTextEditMaxx")]
    public class RepositoryItemtxtTextEditMaxx : RepositoryItemTextEdit
    {
        static RepositoryItemtxtTextEditMaxx()
        {
            RegistertxtTextEditMaxx();
        }

        public const string CustomEditName = "txtTextEditMaxx";

        public RepositoryItemtxtTextEditMaxx()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegistertxtTextEditMaxx()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(txtTextEditMaxx), typeof(RepositoryItemtxtTextEditMaxx), typeof(txtTextEditMaxxViewInfo), new txtTextEditMaxxPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemtxtTextEditMaxx source = item as RepositoryItemtxtTextEditMaxx;
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
    public class txtTextEditMaxx : TextEdit
    {
        static txtTextEditMaxx()
        {
            RepositoryItemtxtTextEditMaxx.RegistertxtTextEditMaxx();
        }

        public txtTextEditMaxx()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemtxtTextEditMaxx Properties
        {
            get
            {
                return base.Properties as RepositoryItemtxtTextEditMaxx;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemtxtTextEditMaxx.CustomEditName;
            }
        }
    }

    public class txtTextEditMaxxViewInfo : TextEditViewInfo
    {
        public txtTextEditMaxxViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class txtTextEditMaxxPainter : TextEditPainter
    {
        public txtTextEditMaxxPainter()
        {
        }
    }
}
