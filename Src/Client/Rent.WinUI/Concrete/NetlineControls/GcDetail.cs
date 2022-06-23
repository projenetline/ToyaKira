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

namespace Rent.WinUI.Concrete.NetlineControls
{
    [ToolboxItem(true)]
    public class GcDetail : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("GvDetail");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GvDetailInfoRegistrator());
        }
    }

    public class GvDetailInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName => "GvDetail";

        public override BaseView CreateView(GridControl grid)
        {
            return new GvDetail(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new GvDetailInfo(view as GvDetail);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new GvDetailHandler(view as GvDetail);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new GvDetailPainter(view as GvDetail);
        }
    }

    public class GvDetail : DevExpress.XtraGrid.Views.Grid.GridView
    {
        public GvDetail()
        {
        }

        public GvDetail(GridControl grid) : base(grid)
        {
            this.OptionsView.EnableAppearanceOddRow = true;
            this.OptionsView.EnableAppearanceEvenRow = true;
            this.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.OptionsView.ShowFooter = true;
            this.OptionsPrint.ExpandAllGroups = true;
            this.OptionsPrint.AutoWidth = false;
            this.OptionsFind.AlwaysVisible = false;
            this.OptionsView.ShowAutoFilterRow = false;
            this.OptionsView.ShowGroupPanel = false;
            this.OptionsView.ColumnAutoWidth = false;
            this.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
        }

        protected override string ViewName => "GvDetail";
    }

    public class GvDetailInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo
    {
        public GvDetailInfo(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class GvDetailHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public GvDetailHandler(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class GvDetailPainter : DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter
    {
        public GvDetailPainter(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }
}
