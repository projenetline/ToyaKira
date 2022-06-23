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
    [UserRepositoryItem("RegisterIcbExpenseType")]
    public class RepositoryItemIcbExpenseType : RepositoryItemImageComboBox
    {
        static RepositoryItemIcbExpenseType()
        {
            RegisterIcbExpenseType();
        }

        public const string CustomEditName = "IcbExpenseType";

        public RepositoryItemIcbExpenseType()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterIcbExpenseType()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(IcbExpenseType), typeof(RepositoryItemIcbExpenseType), typeof(IcbExpenseTypeViewInfo), new IcbExpenseTypePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemIcbExpenseType source = item as RepositoryItemIcbExpenseType;
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
            Array arr = Enum.GetValues(typeof(EnumExpenseType));
            this.Items.Clear();
            foreach (EnumExpenseType RowType in arr)
            {
                string Description = EnumHelper.GetEnumDescription(RowType);
                this.Items.Add(new ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(Description), (byte)RowType, -1));
            }
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class IcbExpenseType : ImageComboBoxEdit
    {
        static IcbExpenseType()
        {
            RepositoryItemIcbExpenseType.RegisterIcbExpenseType();
        }

        public IcbExpenseType()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemIcbExpenseType Properties => base.Properties as RepositoryItemIcbExpenseType;

        public override string EditorTypeName => RepositoryItemIcbExpenseType.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new IcbExpenseTypePopupForm(this);
        }
    }

    public class IcbExpenseTypeViewInfo : ImageComboBoxEditViewInfo
    {
        public IcbExpenseTypeViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class IcbExpenseTypePainter : ImageComboBoxEditPainter
    {
        public IcbExpenseTypePainter()
        {
        }
    }

    public class IcbExpenseTypePopupForm : PopupImageComboBoxEditListBoxForm
    {
        public IcbExpenseTypePopupForm(IcbExpenseType ownerEdit) : base(ownerEdit)
        {
        }
    }
}
