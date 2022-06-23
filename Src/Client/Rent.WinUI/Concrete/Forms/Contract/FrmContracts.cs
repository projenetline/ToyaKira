using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Rent.Business.Abstract;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rent.WinUI.Concrete.Forms.Contract
{
    public partial class FrmContracts : FrmBaseList
    {
        private readonly IRentContractService _contractService;
        private readonly IRentContractExpenseService _rentContractExpenseService;
        private readonly IRentContractRealityService _rentContractRealityService;
        private readonly IInsurancePolicyService _insurancePolicyService;
        private readonly ITenantService _tenantService;
        public FrmContracts(IRentContractService contractService, IRentContractExpenseService rentContractExpenseService, IRentContractRealityService rentContractRealityService, IInsurancePolicyService insurancePolicyService, ITenantService tenantService)
        {
            _contractService = contractService;
            _rentContractExpenseService = rentContractExpenseService;
            _rentContractRealityService = rentContractRealityService;
            _insurancePolicyService = insurancePolicyService;
            _tenantService = tenantService;
            ControlPaid();
            InitializeComponent();
        }
        private void ControlPaid()
        {
            IList<RentContract> contractList = _contractService.GetNotPaid();
            bool refinish = false;
            bool rfinish = false;
            foreach (RentContract contract in contractList)
            {
                IList<InsurancePolicy> policy = _insurancePolicyService.GetContractId(contract.Id).Where(s => s.CreatedDate != null || s.IsPaid == false).OrderByDescending(s => s.Id).ToList();

                if (refinish && rfinish)
                    return;
                if (policy != null)
                {
                    if (policy.Count > 0)
                    {
                        if (!refinish)
                        {
                            if (policy.Where(s => (s.PaymentDate.Date - s.CreatedDate.Value).TotalDays > 0 && (s.PaymentDate.Date - s.CreatedDate.Value).TotalDays < 15).FirstOrDefault() != null)
                            {
                                XtraMessageBox.Show("Ödeme tarihi yaklaşan poliçeler var");
                                refinish = true;
                            }
                        }
                        if (!rfinish)
                        {
                            if (policy.Where(s => s.IsPaid == false && (s.PaymentDate.Date - s.CreatedDate.Value).TotalDays < 0).FirstOrDefault() != null)
                            {
                                XtraMessageBox.Show("Ödeme tarihi geçen poliçeler var");
                                rfinish = true;
                            }
                        }
                    }
                }
            }
        }
        protected override void GetRecordList()
        {
            BsContracts.DataSource = _contractService.GetAll();
            GcMain.DataSource = BsContracts;
            GvMain.ExpandAllGroups();
            GvMain.BestFitColumns();
            base.GetRecordList();
        }
        protected override void Add()
        {
            FrmContractDetail frm = InstanceFactory.GetInstance<FrmContractDetail>();
            frm.SetParent(0, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Add();
        }
        protected override void Edit()
        {
            FrmContractDetail frm = InstanceFactory.GetInstance<FrmContractDetail>();
            frm.SetParent(CurrentObjectId, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Edit();
        }
        protected override void Examine()
        {
            FrmContractDetail frm = InstanceFactory.GetInstance<FrmContractDetail>();
            frm.SetParent(CurrentObjectId, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Examine();
        }
        protected override void Copy()
        {
            FrmContractDetail frm = InstanceFactory.GetInstance<FrmContractDetail>();
            frm.SetParent(CurrentObjectId, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Edit();
        }
        private void BtnAdditionContract_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmContractDetail frm = InstanceFactory.GetInstance<FrmContractDetail>();
            frm.CreateAdditionalContract = true;
            frm.SetParent(CurrentObjectId, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Edit();
        }
        protected override void Delete()
        {
            if (CurrentEditObject != null)
            {
                if (MessageHelper.DeleteQuestionMessage)
                {

                    var expenses = _rentContractExpenseService.GetsByMasterId(CurrentObjectId);
                    foreach (var expense in expenses)
                    {
                        expense.IsEdit = true;
                        expense.IsDeleted = true;
                        _rentContractExpenseService.Delete(expense);
                    }

                    var realities = _rentContractRealityService.GetsByMasterId(CurrentObjectId);
                    foreach (var reality in realities)
                    {
                        reality.IsEdit = true;
                        reality.IsDeleted = true;
                        _rentContractRealityService.Delete(reality);
                    }

                    CurrentEditObject.IsDeleted = true;
                    CurrentEditObject.IsEdit = true;
                    _contractService.Delete((RentContract)CurrentEditObject);
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
        protected override BaseEntity CurrentEditObject => GvMain.GetRow(GvMain.FocusedRowHandle) as RentContract;
        protected override string DetailFormName => "FrmColorAdd";
        #endregion


    }
}
