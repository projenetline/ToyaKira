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
    [UserRepositoryItem("RegisterIcbModule")]
    public class RepositoryItemIcbModule : RepositoryItemImageComboBox
    {
        static RepositoryItemIcbModule()
        {
            RegisterIcbModule();
        }

        public const string CustomEditName = "IcbModule";

        public RepositoryItemIcbModule()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterIcbModule()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(IcbModule), typeof(RepositoryItemIcbModule), typeof(IcbModuleViewInfo), new IcbModulePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemIcbModule source = item as RepositoryItemIcbModule;
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
            Array arr = Enum.GetValues(typeof(EnumModule));
            this.Items.Clear();
            foreach (EnumModule RowType in arr)
            {
                string Description = EnumHelper.GetEnumDescription(RowType);
                this.Items.Add(new ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(Description), (byte)RowType, -1));
            }
            base.OnLoaded();
        }
    }

    [ToolboxItem(true)]
    public class IcbModule : ImageComboBoxEdit
    {
        static IcbModule()
        {
            RepositoryItemIcbModule.RegisterIcbModule();
        }

        public IcbModule()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemIcbModule Properties => base.Properties as RepositoryItemIcbModule;

        public override string EditorTypeName => RepositoryItemIcbModule.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new IcbModulePopupForm(this);
        }
    }

    public class IcbModuleViewInfo : ImageComboBoxEditViewInfo
    {
        public IcbModuleViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class IcbModulePainter : ImageComboBoxEditPainter
    {
        public IcbModulePainter()
        {
        }
    }

    public class IcbModulePopupForm : PopupImageComboBoxEditListBoxForm
    {
        public IcbModulePopupForm(IcbModule ownerEdit) : base(ownerEdit)
        {
        }
    }
}
