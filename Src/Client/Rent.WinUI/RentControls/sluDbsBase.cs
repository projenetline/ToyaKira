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
using DevExpress.XtraGrid.Views.Grid;

namespace Rent.WinUI.RentControls
{
    [UserRepositoryItem("RegistersluDbsBase")]
    public class RepositoryItemsluDbsBase : RepositoryItemSearchLookUpEdit
    {
        static RepositoryItemsluDbsBase()
        {
            RegistersluDbsBase();
        }

        public const string cstEditName = "sluDbsBase";

        public RepositoryItemsluDbsBase()
        {
        }
        protected override void OnLoaded()
        {
            GridView gView = this.View;
            this.PopupFormSize = new Size(600, 600);
            gView.OptionsFind.AlwaysVisible = false;
            gView.OptionsFind.AllowFindPanel = false;
            gView.OptionsView.ShowGroupPanel = false;
            gView.OptionsView.ShowAutoFilterRow = false;
            base.OnLoaded();
        }
        public override string EditorTypeName => cstEditName;

        public static void RegistersluDbsBase()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(cstEditName, typeof(sluDbsBase), typeof(RepositoryItemsluDbsBase), typeof(sluDbsBaseViewInfo), new sluDbsBasePainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemsluDbsBase source = item as RepositoryItemsluDbsBase;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }
    }

    [ToolboxItem(true)]
    public class sluDbsBase : SearchLookUpEdit
    {
        static sluDbsBase()
        {
            RepositoryItemsluDbsBase.RegistersluDbsBase();
        }

        public sluDbsBase()
        {
        }
        protected override void OnLoaded()
        {
            GridView gView = this.Properties.View;
            this.Properties.PopupFormSize = new Size(600, 600);
            gView.OptionsFind.AlwaysVisible = false;
            gView.OptionsFind.AllowFindPanel = false;
            gView.OptionsView.ShowGroupPanel = false;
            gView.OptionsView.ShowAutoFilterRow = false;
            base.OnLoaded();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemsluDbsBase Properties => base.Properties as RepositoryItemsluDbsBase;

        public override string EditorTypeName => RepositoryItemsluDbsBase.cstEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new sluDbsBasePopupForm(this);
        }
    }

    public class sluDbsBaseViewInfo : SearchLookUpEditBaseViewInfo
    {
        public sluDbsBaseViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class sluDbsBasePainter : ButtonEditPainter
    {
        public sluDbsBasePainter()
        {
        }
    }

    public class sluDbsBasePopupForm : PopupSearchLookUpEditForm
    {
        public sluDbsBasePopupForm(sluDbsBase ownerEdit) : base(ownerEdit)
        {
        }
    }
}
