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
    [UserRepositoryItem("RegisterIcbCurrency")]
    public class RepositoryItemIcbCurrency : RepositoryItemImageComboBox
    {
        static RepositoryItemIcbCurrency()
        {
            RegisterIcbCurrency();
        }

        public const string CustomEditName = "IcbCurrency";

        public RepositoryItemIcbCurrency()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterIcbCurrency()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(IcbCurrency), typeof(RepositoryItemIcbCurrency), typeof(IcbCurrencyViewInfo), new IcbCurrencyPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemIcbCurrency source = item as RepositoryItemIcbCurrency;
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
            Array arr = Enum.GetValues(typeof(EnumCurrency));
            this.Items.Clear();
            foreach (EnumCurrency RowType in arr)
            {
                string Description = EnumHelper.GetEnumDescription(RowType);
                this.Items.Add(new ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(Description), (byte)RowType, -1));
            }
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class IcbCurrency : ImageComboBoxEdit
    {
        static IcbCurrency()
        {
            RepositoryItemIcbCurrency.RegisterIcbCurrency();
        }

        public IcbCurrency()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemIcbCurrency Properties => base.Properties as RepositoryItemIcbCurrency;

        public override string EditorTypeName => RepositoryItemIcbCurrency.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new IcbCurrencyPopupForm(this);
        }
    }

    public class IcbCurrencyViewInfo : ImageComboBoxEditViewInfo
    {
        public IcbCurrencyViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class IcbCurrencyPainter : ImageComboBoxEditPainter
    {
        public IcbCurrencyPainter()
        {
        }
    }

    public class IcbCurrencyPopupForm : PopupImageComboBoxEditListBoxForm
    {
        public IcbCurrencyPopupForm(IcbCurrency ownerEdit) : base(ownerEdit)
        {
        }
    }
}
