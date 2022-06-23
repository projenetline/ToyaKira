using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("Registerse15x2")]
    public class RepositoryItemse15x2 : RepositoryItemSpinEdit
    {
        static RepositoryItemse15x2()
        {
            Registerse15x2();
        }

        public const string CustomEditName = "se15x2";

        public RepositoryItemse15x2()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void Registerse15x2()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(se15x2), typeof(RepositoryItemse15x2), typeof(se15x2ViewInfo), new se15x2Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemse15x2 source = item as RepositoryItemse15x2;
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
            Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            Mask.EditMask = "###,###,###,##0.00";
            Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            Mask.UseMaskAsDisplayFormat = true;
            Buttons.Clear();
        }
    }

    [ToolboxItem(true)]
    public class se15x2 : SpinEdit
    {
        static se15x2()
        {
            RepositoryItemse15x2.Registerse15x2();
        }

        public se15x2()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemse15x2 Properties => base.Properties as RepositoryItemse15x2;

        public override string EditorTypeName => RepositoryItemse15x2.CustomEditName;
    }

    public class se15x2ViewInfo : BaseSpinEditViewInfo
    {
        public se15x2ViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class se15x2Painter : ButtonEditPainter
    {
        public se15x2Painter()
        {
        }
    }
}
