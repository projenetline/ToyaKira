using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace Rent.WinUI.Concrete.NetlineControls
{
    [ToolboxItem(true)]
    public class GcList : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("GvList");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GvListInfoRegistrator());
        }
    }

    public class GvListInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName => "GvList";

        public override BaseView CreateView(GridControl grid)
        {
            return new GvList(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new GvListInfo(view as GvList);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new GvListHandler(view as GvList);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new GvListPainter(view as GvList);
        }
    }

    public class GvList : DevExpress.XtraGrid.Views.Grid.GridView
    {
        public GvList()
        {
        }

        public GvList(GridControl grid) : base(grid)
        {
            this.OptionsFind.AlwaysVisible = true;
            this.OptionsBehavior.Editable = false;
            this.OptionsBehavior.ReadOnly = true;
            this.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.OptionsView.ColumnAutoWidth = false;
            this.OptionsView.ShowAutoFilterRow = true;
            this.OptionsView.EnableAppearanceOddRow = true;
            this.OptionsView.EnableAppearanceEvenRow = true;
            this.OptionsView.ShowFooter = true;
            this.OptionsPrint.ExpandAllGroups = true;
            this.OptionsPrint.AutoWidth = false;
            this.OptionsSelection.MultiSelect = true;
            this.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            this.RowStyle += new RowStyleEventHandler(this.GvMain_RowStyle);
        }
        private void GvMain_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == this.FocusedRowHandle)
            {
                e.Appearance.Font = new Font(this.Appearance.Row.Font, System.Drawing.FontStyle.Bold);
            }
        }

        protected override string ViewName => "GvList";
    }

    public class GvListInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo
    {
        public GvListInfo(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class GvListHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public GvListHandler(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class GvListPainter : DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter
    {
        public GvListPainter(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }
}
