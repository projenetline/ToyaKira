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
    [UserRepositoryItem("RegisterIcbPeriodNr")]
    public class RepositoryItemIcbPeriodNr : RepositoryItemImageComboBox
    {
        static RepositoryItemIcbPeriodNr()
        {
            RegisterIcbPeriodNr();
        }

        public const string CustomEditName = "IcbPeriodNr";

        public RepositoryItemIcbPeriodNr()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterIcbPeriodNr()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(IcbPeriodNr), typeof(RepositoryItemIcbPeriodNr), typeof(IcbPeriodNrViewInfo), new IcbPeriodNrPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemIcbPeriodNr source = item as RepositoryItemIcbPeriodNr;
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
            this.Items.Add(new ImageComboBoxItem("1", 1, -1));
            this.Items.Add(new ImageComboBoxItem("2", 2, -1));
            this.Items.Add(new ImageComboBoxItem("3", 3, -1));
            this.Items.Add(new ImageComboBoxItem("4", 4, -1));
            this.Items.Add(new ImageComboBoxItem("5", 5, -1));
            this.Items.Add(new ImageComboBoxItem("6", 6, -1));
            this.Items.Add(new ImageComboBoxItem("7", 7, -1));
            this.Items.Add(new ImageComboBoxItem("8", 8, -1));
            this.Items.Add(new ImageComboBoxItem("9", 9, -1));
            this.Items.Add(new ImageComboBoxItem("10", 10, -1));
            this.Items.Add(new ImageComboBoxItem("11", 11, -1));
            this.Items.Add(new ImageComboBoxItem("12", 12, -1));
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class IcbPeriodNr : ImageComboBoxEdit
    {
        static IcbPeriodNr()
        {
            RepositoryItemIcbPeriodNr.RegisterIcbPeriodNr();
        }

        public IcbPeriodNr()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemIcbPeriodNr Properties => base.Properties as RepositoryItemIcbPeriodNr;

        public override string EditorTypeName => RepositoryItemIcbPeriodNr.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new IcbPeriodNrPopupForm(this);
        }
    }

    public class IcbPeriodNrViewInfo : ImageComboBoxEditViewInfo
    {
        public IcbPeriodNrViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class IcbPeriodNrPainter : ImageComboBoxEditPainter
    {
        public IcbPeriodNrPainter()
        {
        }
    }

    public class IcbPeriodNrPopupForm : PopupImageComboBoxEditListBoxForm
    {
        public IcbPeriodNrPopupForm(IcbPeriodNr ownerEdit) : base(ownerEdit)
        {
        }
    }
}
