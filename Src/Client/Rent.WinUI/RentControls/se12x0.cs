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
    [UserRepositoryItem("Registerse12x0")]
    public class RepositoryItemse12x0 : RepositoryItemSpinEdit
    {
        static RepositoryItemse12x0()
        {
            Registerse12x0();
        }

        public const string CustomEditName = "se12x0";

        public RepositoryItemse12x0()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void Registerse12x0()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(se12x0), typeof(RepositoryItemse12x0), typeof(se12x0ViewInfo), new se12x0Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemse12x0 source = item as RepositoryItemse12x0;
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
            Mask.EditMask = "###,###,##0";
            Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            Mask.UseMaskAsDisplayFormat = true;
            Buttons.Clear();
        }
    }

    [ToolboxItem(true)]
    public class se12x0 : SpinEdit
    {
        static se12x0()
        {
            RepositoryItemse12x0.Registerse12x0();
        }

        public se12x0()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemse12x0 Properties
        {
            get
            {
                return base.Properties as RepositoryItemse12x0;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemse12x0.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new se12x0PopupForm(this);
        }
    }

    public class se12x0ViewInfo : BaseSpinEditViewInfo
    {
        public se12x0ViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class se12x0Painter : ButtonEditPainter
    {
        public se12x0Painter()
        {
        }
    }

    public class se12x0PopupForm : PopupBaseForm
    {
        public se12x0PopupForm(se12x0 ownerEdit)
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
