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
    [UserRepositoryItem("RegisterLuFirm")]
    public class RepositoryItemLuFirm : RepositoryItemLookUpEdit
    {
        static RepositoryItemLuFirm()
        {
            RegisterLuFirm();
        }

        public const string CustomEditName = "LuFirm";

        //public RepositoryItemLuFirm()
        //{
        //}

        public override string EditorTypeName => CustomEditName;

        public static void RegisterLuFirm()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(LuFirm), typeof(RepositoryItemLuFirm), typeof(LuFirmViewInfo), new LuFirmPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemLuFirm source = item as RepositoryItemLuFirm;
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
            Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Firma Kodu"));
            Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Firma Adı"));

            ValueMember = "LOGICALREF";
            DisplayMember = "CODE";
        }
    }

    [ToolboxItem(true)]
    public class LuFirm : LookUpEdit
    {
        static LuFirm()
        {
            RepositoryItemLuFirm.RegisterLuFirm();
        }

        public LuFirm()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemLuFirm Properties => base.Properties as RepositoryItemLuFirm;

        public override string EditorTypeName => RepositoryItemLuFirm.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new LuFirmPopupForm(this);
        }
    }

    public class LuFirmViewInfo : LookUpEditViewInfo
    {
        public LuFirmViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class LuFirmPainter : ButtonEditPainter
    {
        public LuFirmPainter()
        {
        }
    }

    public class LuFirmPopupForm : PopupLookUpEditForm
    {
        public LuFirmPopupForm(LuFirm ownerEdit) : base(ownerEdit)
        {
        }
    }
}
