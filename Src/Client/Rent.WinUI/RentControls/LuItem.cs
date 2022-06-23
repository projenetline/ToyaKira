using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegisterLuItem")]
    public class RepositoryItemLuItem : RepositoryItemLookUpEdit
    {
        static RepositoryItemLuItem()
        {
            RegisterLuItem();
        }

        public const string CustomEditName = "LuItem";

        public RepositoryItemLuItem()
        {
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterLuItem()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(LuItem), typeof(RepositoryItemLuItem), typeof(LuItemViewInfo), new LuItemPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemLuItem source = item as RepositoryItemLuItem;
                if (source == null)
                {
                    return;
                }
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
            this.NullText = string.Empty;
            SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            Columns.Clear();
            Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOGICALREF", "Referans No"));
            Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Kod"));
            Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad"));

            ValueMember = "LOGICALREF";
            DisplayMember = "CODE";
        }
    }

    [ToolboxItem(true)]
    public class LuItem : LookUpEdit
    {
        static LuItem()
        {
            RepositoryItemLuItem.RegisterLuItem();
        }

        public LuItem()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemLuItem Properties => base.Properties as RepositoryItemLuItem;

        public override string EditorTypeName => RepositoryItemLuItem.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new LuItemPopupForm(this);
        }
    }

    public class LuItemViewInfo : LookUpEditViewInfo
    {
        public LuItemViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class LuItemPainter : ButtonEditPainter
    {
        public LuItemPainter()
        {
        }
    }

    public class LuItemPopupForm : PopupLookUpEditForm
    {
        public LuItemPopupForm(LuItem ownerEdit) : base(ownerEdit)
        {
        }
    }
}
