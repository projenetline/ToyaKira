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
    [UserRepositoryItem("Registerse15x3")]
    public class RepositoryItemse15x3 : RepositoryItemSpinEdit
    {
        static RepositoryItemse15x3()
        {
            Registerse15x3();
        }

        public const string CustomEditName = "se15x3";

        public RepositoryItemse15x3()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void Registerse15x3()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(se15x3), typeof(RepositoryItemse15x3), typeof(se15x3ViewInfo), new se15x3Painter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemse15x3 source = item as RepositoryItemse15x3;
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
            Mask.EditMask = "###,###,###,##0.000";
            Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            Mask.UseMaskAsDisplayFormat = true;
            Buttons.Clear();
        }
    }

    [ToolboxItem(true)]
    public class se15x3 : SpinEdit
    {
        static se15x3()
        {
            RepositoryItemse15x3.Registerse15x3();
        }

        public se15x3()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemse15x3 Properties
        {
            get
            {
                return base.Properties as RepositoryItemse15x3;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemse15x3.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new se15x3PopupForm(this);
        }
    }

    public class se15x3ViewInfo : BaseSpinEditViewInfo
    {
        public se15x3ViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class se15x3Painter : ButtonEditPainter
    {
        public se15x3Painter()
        {
        }
    }

    public class se15x3PopupForm : PopupBaseForm
    {
        public se15x3PopupForm(se15x3 ownerEdit) : base(ownerEdit)
        {
        }

        protected override Size CalcFormSizeCore()
        {
            throw new NotImplementedException();
        }

        public override object ResultValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
