using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("Registerse15x6")]
    public class RepositoryItemse15x6 : RepositoryItemSpinEdit
    {
        static RepositoryItemse15x6()
        {
            Registerse15x6();
        }

        public const string CustomEditName = "se15x6";

        public RepositoryItemse15x6()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void Registerse15x6()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(se15x6), typeof(RepositoryItemse15x6), typeof(se15x6ViewInfo), new se15x6Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemse15x6 source = item as RepositoryItemse15x6;
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
            Mask.EditMask = "###,###,##0.000000";
            Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            Mask.UseMaskAsDisplayFormat = true;
            Buttons.Clear();
        }
    }

    [ToolboxItem(true)]
    public class se15x6 : SpinEdit
    {
        static se15x6()
        {
            RepositoryItemse15x6.Registerse15x6();
        }

        public se15x6()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemse15x6 Properties
        {
            get
            {
                return base.Properties as RepositoryItemse15x6;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemse15x6.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new se15x6PopupForm(this);
        }
    }

    public class se15x6ViewInfo : BaseSpinEditViewInfo
    {
        public se15x6ViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class se15x6Painter : ButtonEditPainter
    {
        public se15x6Painter()
        {
        }
    }

    public class se15x6PopupForm : PopupBaseForm
    {
        public se15x6PopupForm(se15x6 ownerEdit)
            : base(ownerEdit)
        {
        }

        protected override Size CalcFormSizeCore()
        {
            throw new NotImplementedException();
        }

        public override Object ResultValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
