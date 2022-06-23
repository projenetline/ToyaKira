using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using Rent.Core.Concrete.Helpers;
using Rent.Core.Concrete.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Helpers
{
    public static class GridHelper
    {
        public static bool DeleteRow(GridView view, bool deleting)
        {
            try
            {
                if (view == null) return false;
                var i = view.FocusedRowHandle;
                if (i < 0) return false;
                deleting = true;
                if (MessageBox.Show(AppStrings.DeleteRecordWarning, AppStrings.Warning, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return false;
                }
                else
                {
                    ViewColumnFilterInfo criteria = new ViewColumnFilterInfo(null, null);
                    foreach (ViewColumnFilterInfo info in view.ActiveFilter)
                    {
                        criteria = info;
                    }
                    view.CloseEditor();
                    view.SetRowCellValue(view.FocusedRowHandle, "Isdeleted", (byte)1);
                    view.SetRowCellValue(view.FocusedRowHandle, "isEdit", true);
                    view.UpdateCurrentRow();
                    view.RefreshData();
                    FilterDeletedRows(view);
                    view.ActiveFilter.Add(criteria);
                    deleting = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                deleting = false;
                MessageHelper.ExeptionMessage(ex);
                return false;
            }
        }
        public static bool DeleteRows(GridView view, bool deleting)
        {
            try
            {
                if (MessageBox.Show(AppStrings.DeleteContinue, AppStrings.Warning, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return false;
                }
                else
                {
                    foreach (int rowHandle in view.GetSelectedRows())
                    {
                        deleting = true;
                        view.CloseEditor();
                        view.SetRowCellValue(view.FocusedRowHandle, "Isdeleted", (byte)1);
                        view.UpdateCurrentRow();
                        FilterDeletedRows(view);
                        deleting = false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
                return false;
            }
        }
        public static void DeleteRow_RowNumber(GridView view, bool deleting, int nRow)
        {
            try
            {
                if (view == null) return;
                if (nRow < 0) return;
                deleting = true;
                view.CloseEditor();
                // view.SetRowCellValue(nRow, "editObj", 1);
                view.SetRowCellValue(view.FocusedRowHandle, "Isdeleted", (byte)1);
                FilterDeletedRows(view);
                deleting = false;
            }
            catch (Exception ex)
            {
                deleting = false;
                MessageHelper.ExeptionMessage(ex);
            }
        }
        public static void FilterDeletedRows(GridView view)
        {
            try
            {
                GridColumn coldeleted = view.Columns["IsDeleted"];
                //coldeleted.FilterInfo = new ColumnFilterInfo(coldeleted, (byte)0);
                ViewColumnFilterInfo FilterOr = new ViewColumnFilterInfo(coldeleted, new ColumnFilterInfo("[Isdeleted] = 0 OR [Isdeleted] = null"));
                view.ActiveFilter.Clear();
                view.ActiveFilter.Add(FilterOr);
                view.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
                view.RefreshData();
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }
        public static void FilterDeletedRowsBandedGrid(BandedGridView view)
        {
            try
            {
                GridColumn coldeleted = view.Columns["IsDeleted"];
                //coldeleted.FilterInfo = new ColumnFilterInfo(coldeleted, (byte)0);
                ViewColumnFilterInfo FilterOr = new ViewColumnFilterInfo(coldeleted, new ColumnFilterInfo("[IsDeleted] = 0 OR [IsDeleted] = null"));
                view.ActiveFilter.Clear();
                view.ActiveFilter.Add(FilterOr);
                view.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
                view.RefreshData();
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }
        public static void InitNewRow(GridView view, int nRow, [Optional] bool All)
        {
            try
            {
                view.SetRowCellValue(nRow, "IsEdit", true);
                view.SetRowCellValue(nRow, "IsDeleted", false);
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }
       
    }
}
