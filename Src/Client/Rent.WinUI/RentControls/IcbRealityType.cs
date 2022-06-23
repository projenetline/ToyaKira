using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;
using Rent.Domain.Concrete;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Helpers;
using Rent.Core.Concrete.Helpers;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegisterIcbRealityType")]
    public class RepositoryItemIcbRealityType : RepositoryItemImageComboBox
    {
        static RepositoryItemIcbRealityType()
        {
            RegisterIcbRealityType();
        }

        public const string CustomEditName = "IcbRealityType";

        public RepositoryItemIcbRealityType()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterIcbRealityType()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(IcbRealityType), typeof(RepositoryItemIcbRealityType), typeof(IcbRealityTypeViewInfo), new IcbRealityTypePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemIcbRealityType source = item as RepositoryItemIcbRealityType;
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
            if (IsDesignMode) return;
            this.Items.Clear();
            Array arr = Enum.GetValues(typeof(EnumRealityType));
            this.Items.Clear();
            foreach (EnumRealityType RowType in arr)
            {
                string Description = EnumHelper.GetEnumDescription(RowType);
                this.Items.Add(new ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(Description), (byte)RowType, -1));
            }
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class IcbRealityType : ImageComboBoxEdit
    {
        static IcbRealityType()
        {
            RepositoryItemIcbRealityType.RegisterIcbRealityType();
        }

        public IcbRealityType()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemIcbRealityType Properties => base.Properties as RepositoryItemIcbRealityType;

        public override string EditorTypeName => RepositoryItemIcbRealityType.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new IcbRealityTypePopupForm(this);
        }
    }

    public class IcbRealityTypeViewInfo : ImageComboBoxEditViewInfo
    {
        public IcbRealityTypeViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class IcbRealityTypePainter : ImageComboBoxEditPainter
    {
        public IcbRealityTypePainter()
        {
        }
    }

    public class IcbRealityTypePopupForm : PopupImageComboBoxEditListBoxForm
    {
        public IcbRealityTypePopupForm(IcbRealityType ownerEdit) : base(ownerEdit)
        {
        }
    }
}
