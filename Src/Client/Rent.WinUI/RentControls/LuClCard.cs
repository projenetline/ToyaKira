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
    [UserRepositoryItem("RegisterLuClCard")]
    public class RepositoryItemLuClCard : RepositoryItemLookUpEdit
    {
        static RepositoryItemLuClCard()
        {
            RegisterLuClCard();
        }

        public const string CustomEditName = "LuClCard";

        public RepositoryItemLuClCard()
        {
            QueryPopUp += new CancelEventHandler(SearchLookUpEdit_Popup);
        }
        void SearchLookUpEdit_Popup(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
        public override string EditorTypeName => CustomEditName;

        public static void RegisterLuClCard()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(LuClCard), typeof(RepositoryItemLuClCard), typeof(LuClCardViewInfo), new LuClCardPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemLuClCard source = item as RepositoryItemLuClCard;
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
            Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Firma Ünvanı"));

            ValueMember = "LOGICALREF";
            DisplayMember = "CODE";
        }
    }

    [ToolboxItem(true)]
    public class LuClCard : LookUpEdit
    {
        static LuClCard()
        {
            RepositoryItemLuClCard.RegisterLuClCard();
        }

        public LuClCard()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemLuClCard Properties => base.Properties as RepositoryItemLuClCard;

        public override string EditorTypeName => RepositoryItemLuClCard.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new LuClCardPopupForm(this);
        }
    }

    public class LuClCardViewInfo : LookUpEditViewInfo
    {
        public LuClCardViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class LuClCardPainter : ButtonEditPainter
    {
        public LuClCardPainter()
        {
        }
    }

    public class LuClCardPopupForm : PopupLookUpEditForm
    {
        public LuClCardPopupForm(LuClCard ownerEdit) : base(ownerEdit)
        {
        }
    }
}
