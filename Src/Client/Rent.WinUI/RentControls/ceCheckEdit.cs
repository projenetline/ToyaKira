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

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegisterceCheckEdit")]
    public class RepositoryItemceCheckEdit : RepositoryItemCheckEdit
    {
        static RepositoryItemceCheckEdit()
        {
            RegisterceCheckEdit();
        }

        public const string CustomEditName = "ceCheckEdit";

        public RepositoryItemceCheckEdit()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterceCheckEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(ceCheckEdit), typeof(RepositoryItemceCheckEdit), typeof(ceCheckEditViewInfo), new ceCheckEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemceCheckEdit source = item as RepositoryItemceCheckEdit;
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
            ValueChecked = (byte)1;
            ValueUnchecked = (byte)0;
            DisplayValueChecked = "Evet";
            DisplayValueUnchecked = "Hayır";
            NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
        }
    }

    [ToolboxItem(true)]
    public class ceCheckEdit : CheckEdit
    {
        static ceCheckEdit()
        {
            RepositoryItemceCheckEdit.RegisterceCheckEdit();
        }

        public ceCheckEdit()
        {
            if (IsDesignMode) return;
           this.Properties.ValueChecked = (byte)1;
           this.Properties.ValueUnchecked = (byte)0;
            this.Properties.DisplayValueChecked = "Evet";
            this.Properties.DisplayValueUnchecked = "Hayır";
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemceCheckEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemceCheckEdit;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemceCheckEdit.CustomEditName;
            }
        }
    }

    public class ceCheckEditViewInfo : CheckEditViewInfo
    {
        public ceCheckEditViewInfo(RepositoryItem item)
            : base(item)
        {
        }
    }

    public class ceCheckEditPainter : CheckEditPainter
    {
        public ceCheckEditPainter()
        {
        }
    }
}
