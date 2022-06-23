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
    [UserRepositoryItem("RegisterIcbPeriodType")]
    public class RepositoryItemIcbPeriodType : RepositoryItemImageComboBox
    {
        static RepositoryItemIcbPeriodType()
        {
            RegisterIcbPeriodType();
        }

        public const string CustomEditName = "IcbPeriodType";

        public RepositoryItemIcbPeriodType()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterIcbPeriodType()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(IcbPeriodType), typeof(RepositoryItemIcbPeriodType), typeof(IcbPeriodTypeViewInfo), new IcbPeriodTypePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemIcbPeriodType source = item as RepositoryItemIcbPeriodType;
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
            Array arr = Enum.GetValues(typeof(EnumPeriod));
            this.Items.Clear();
            foreach (EnumPeriod RowType in arr)
            {
                string Description = EnumHelper.GetEnumDescription(RowType);
                this.Items.Add(new ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(Description), RowType.GetHashCode(), -1));
            }
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class IcbPeriodType : ImageComboBoxEdit
    {
        static IcbPeriodType()
        {
            RepositoryItemIcbPeriodType.RegisterIcbPeriodType();
        }

        public IcbPeriodType()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemIcbPeriodType Properties => base.Properties as RepositoryItemIcbPeriodType;

        public override string EditorTypeName => RepositoryItemIcbPeriodType.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new IcbPeriodTypePopupForm(this);
        }
    }

    public class IcbPeriodTypeViewInfo : ImageComboBoxEditViewInfo
    {
        public IcbPeriodTypeViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class IcbPeriodTypePainter : ImageComboBoxEditPainter
    {
        public IcbPeriodTypePainter()
        {
        }
    }

    public class IcbPeriodTypePopupForm : PopupImageComboBoxEditListBoxForm
    {
        public IcbPeriodTypePopupForm(IcbPeriodType ownerEdit) : base(ownerEdit)
        {
        }
    }
}
