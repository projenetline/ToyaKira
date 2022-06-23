using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistertxtTextEditmail")]
    public class RepositoryItemtxtTextEditmail : RepositoryItemTextEdit
    {
        static RepositoryItemtxtTextEditmail()
        {
            RegistertxtTextEditmail();
        }

        public const string CustomEditName = "txtTextEditmail";

        public RepositoryItemtxtTextEditmail()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegistertxtTextEditmail()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(txtTextEditmail), typeof(RepositoryItemtxtTextEditmail), typeof(txtTextEditmailViewInfo), new txtTextEditmailPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemtxtTextEditmail source = item as RepositoryItemtxtTextEditmail;
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
            this.Mask.EditMask = @"((((\w+-*)|(-*\w+))+\.*((\w+-*)|(-*\w+))+)|(((\w+-*)|(-*\w+))+))+@((((\w+-*)|(-*\w+))+\.*((\w+-*)|(-*\w+))+)|(((\w+-*)|(-*\w+))+))+\.[A-Za-z]+";
            this.Mask.UseMaskAsDisplayFormat = true;
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class txtTextEditmail : TextEdit
    {
        static txtTextEditmail()
        {
            RepositoryItemtxtTextEditmail.RegistertxtTextEditmail();
        }

        public txtTextEditmail()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemtxtTextEditmail Properties => base.Properties as RepositoryItemtxtTextEditmail;

        public override string EditorTypeName => RepositoryItemtxtTextEditmail.CustomEditName;
    }

    public class txtTextEditmailViewInfo : TextEditViewInfo
    {
        public txtTextEditmailViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class txtTextEditmailPainter : TextEditPainter
    {
        public txtTextEditmailPainter()
        {
        }
    }

}

