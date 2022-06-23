using DevExpress.XtraGrid.Views.Base;
using Rent.Business.Abstract;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Core.Concrete.Resources;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Forms.Parameters
{
    public partial class FrmTenants : FrmBaseList
    {
        private readonly ITenantService _tenantService;
        public FrmTenants(ITenantService tenantService)
        {
            _tenantService = tenantService;
            InitializeComponent();
        }
        protected override void GetRecordList()
        {
            BsTenants.DataSource = _tenantService.GetAll();
            GcMain.DataSource = BsTenants;
            GvMain.ExpandAllGroups();
            base.GetRecordList();
        }
        protected override void Add()
        {
            using (var form = InstanceFactory.GetInstance<FrmTenantAdd>())
            {
                form.SetParent(this.MdiParent, true, false, false);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Add();
        }
        protected override void Edit()
        {
            using (var form = InstanceFactory.GetInstance<FrmTenantAdd>())
            {
                form.ObjectId = CurrentObjectId;
                form.SetParent(this.MdiParent, false, true, false);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Edit();
        }
        protected override void Examine()
        {
            using (var form = InstanceFactory.GetInstance<FrmTenantAdd>())
            {
                form.ObjectId = CurrentObjectId;
                form.SetParent(this.MdiParent, false, false, true);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Examine();
        }
        protected override void Copy()
        {
            using (var form = InstanceFactory.GetInstance<FrmTenantAdd>())
            {
                form.ObjectId = CurrentObjectId;
                form.SetParent(this.MdiParent, false, false, false);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Edit();
        }
        protected override void Delete()
        {
            if (CurrentEditObject != null)
            {
                if (MessageHelper.DeleteQuestionMessage)
                {
                    CurrentEditObject.IsDeleted = true;
                    CurrentEditObject.IsEdit = true;
                    _tenantService.Delete((Tenant)CurrentEditObject);
                    GvMain.RefreshData();
                }
            }
            base.Delete();
        }
        #region PROPERTIES
        protected override ColumnView MainView01 => GvMain;
        public override int CurrentObjectId => GvMain.GetFocusedRowCellValue("Id") != DBNull.Value
            ? Convert.ToInt32(GvMain.GetFocusedRowCellValue("Id"))
            : 0;
        bool Locked => GvMain.GetFocusedRowCellValue("Lock") != DBNull.Value
                       && Convert.ToBoolean(GvMain.GetFocusedRowCellValue("Lock"));
        protected override BaseEntity CurrentEditObject => GvMain.GetRow(GvMain.FocusedRowHandle) as Tenant;
        protected override string DetailFormName => "FrmColorAdd";
        #endregion

    }
}
