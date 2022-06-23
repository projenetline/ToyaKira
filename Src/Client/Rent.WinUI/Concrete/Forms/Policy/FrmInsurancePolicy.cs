using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using Rent.Business.Abstract;
using Rent.Business.DependencyResolves.Ninject;
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

namespace Rent.WinUI.Concrete.Forms
{
    public partial class FrmInsurancePolicy : FrmBaseList
    {
        IRentContractService _rentContractService;
        IRentContractExpenseService _rentContractExpenseService;
        IInsurancePolicyService _insurancePolicyService;
        ITenantService _tenantService;
        public FrmInsurancePolicy(IRentContractExpenseService rentContractExpenseService, IInsurancePolicyService insurancePolicyService, IRentContractService rentContractService, ITenantService tennantService)
        {
            _rentContractExpenseService = rentContractExpenseService;
            _insurancePolicyService = insurancePolicyService;
            _rentContractService = rentContractService;
            _tenantService = tennantService;
            InitializeComponent();
            RcMain.Visible = false;
        }
        protected override void GetRecordList()
        {

            BsContract.DataSource = _rentContractService.GetNotPaid();
            GcRentContract.DataSource = BsContract;
            GvRentContract.ExpandAllGroups();
            GvRentContract.BestFitColumns();
            base.GetRecordList();
        }
        private void IniInsurancePolicy()
        {
            RentContract contract = _rentContractService.GetById(CurrentObjectId);
            Tenant tenant= _tenantService.GetById(contract.TenantId);
            int totalChart = 0;
            switch (contract.RentAdditionPeriod)//Yenileme
            {
                case 0://Haftalık
                    totalChart = 1;
                    break;
                case 1:
                    totalChart = 1;
                    break;
                case 2://Aylık
                    if (contract.RentPeriod == 0)
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 4 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    else if (contract.RentPeriod == 1)
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 4 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    else if (contract.RentPeriod == 2)
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 1 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    else
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 1 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    break;
                case 3://Yıllık
                    if (contract.RentPeriod == 0)
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 52 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    else if (contract.RentPeriod == 1)
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 52 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    else if (contract.RentPeriod == 2)
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 12 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    else
                        totalChart = (int)Math.Ceiling(decimal.Parse((1 * 1 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
                    break;
            }
            IList<InsurancePolicy> policyList = _insurancePolicyService.GetContractId(contract.Id);
            if (policyList.Count < totalChart)
            {
                DateTime dat;
                if (policyList.Count > 0)
                    dat = policyList[0].PaymentEndDate;
                else
                    if (contract.RentPeriod == 1)
                        dat = contract.ContractStartDate.AddDays(contract.RentPeriodNr*7);
                    else if(contract.RentPeriod == 2)
                        dat = contract.ContractStartDate.AddMonths(contract.RentPeriodNr);
                    else
                        dat = contract.ContractStartDate.AddYears(contract.RentPeriodNr);
                for (int i = policyList.Count; i < totalChart; i++)
                {
                    policyList.Add(new InsurancePolicy
                    {
                        Id = i,
                        Amount = 0,
                        CreatedDate = dat,
                        PaymentEndDate=dat,
                        LOGICALREF = tenant.LogoLogicalRef,
                        IsPaid = false,
                        Paid = contract.RentAdditionAmount,
                    });
                    if (contract.RentPeriod == 1)
                        dat = dat.AddDays(contract.RentPeriodNr * 7);
                    else if (contract.RentPeriod == 2)
                        dat = dat.AddMonths(contract.RentPeriodNr);
                    else
                        dat = dat.AddYears(contract.RentPeriodNr);
                }
            }
            BsStatu.DataSource = policyList;
            GcInsurancePolicy.DataSource = BsStatu;
        }
        protected override ColumnView MainView01 => GvRentContract;
        public override int CurrentObjectId => GvRentContract.GetFocusedRowCellValue("Id") != DBNull.Value
            ? Convert.ToInt32(GvRentContract.GetFocusedRowCellValue("Id"))
            : 0;
        bool Locked => GvRentContract.GetFocusedRowCellValue("Lock") != DBNull.Value
                       && Convert.ToBoolean(GvRentContract.GetFocusedRowCellValue("Lock"));
        protected override BaseEntity CurrentEditObject => GvRentContract.GetRow(GvRentContract.FocusedRowHandle) as RentContract;
        protected override string DetailFormName => "FrmColorAdd";

        private void GvRentContractExpense_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (CurrentObjectId != 0)
                IniInsurancePolicy();
        }
    }
}
