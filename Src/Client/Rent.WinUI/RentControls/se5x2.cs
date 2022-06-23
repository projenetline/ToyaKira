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
    [UserRepositoryItem("Registerse5x2")]
    public class RepositoryItemse5x2 : RepositoryItemSpinEdit
    {
        static RepositoryItemse5x2()
        {
            Registerse5x2();
        }

        public const string CustomEditName = "se5x2";

        public RepositoryItemse5x2()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void Registerse5x2()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(se5x2), typeof(RepositoryItemse5x2), typeof(se5x2ViewInfo), new se5x2Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemse5x2 source = item as RepositoryItemse5x2;
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
            Mask.EditMask = "##0.00";
            Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            Mask.UseMaskAsDisplayFormat = true;
            Buttons.Clear();
        }
    }

    [ToolboxItem(true)]
    public class se5x2 : SpinEdit
    {
        static se5x2()
        {
            RepositoryItemse5x2.Registerse5x2();
        }

        public se5x2()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemse5x2 Properties
        {
            get
            {
                return base.Properties as RepositoryItemse5x2;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemse5x2.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new se5x2PopupForm(this);
        }
    }

    public class se5x2ViewInfo : BaseSpinEditViewInfo
    {
        public se5x2ViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class se5x2Painter : ButtonEditPainter
    {
        public se5x2Painter()
        {
        }
    }

    public class se5x2PopupForm : PopupBaseForm
    {
        public se5x2PopupForm(se5x2 ownerEdit)
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
