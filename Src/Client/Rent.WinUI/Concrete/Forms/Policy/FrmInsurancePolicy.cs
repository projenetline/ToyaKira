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
        private RentContract contract => _rentContractService.GetById(CurrentObjectId);
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
            GcMain.DataSource = BsContract;
            GvMain.ExpandAllGroups();
            GvMain.BestFitColumns();
            base.GetRecordList();
        }
        private void IniInsurancePolicy()
        {
            RentContract contract = _rentContractService.GetById(CurrentObjectId);
            if (contract != null)
            {
                BsStatu.DataSource = _insurancePolicyService.GetContractId(contract.Id);
                GcInsurancePolicy.DataSource = BsStatu;
            }
            #region Old Code
            //Tenant tenant= _tenantService.GetById(contract.TenantId);
            //int totalChart = 0;
            //switch (contract.RentAdditionPeriod)//Yenileme
            //{
            //    case 0://Haftalık
            //        totalChart = 1;
            //        break;
            //    case 1:
            //        totalChart = 1;
            //        break;
            //    case 2://Aylık
            //        if (contract.RentPeriod == 0)
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 4 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        else if (contract.RentPeriod == 1)
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 4 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        else if (contract.RentPeriod == 2)
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 1 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        else
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 1 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        break;
            //    case 3://Yıllık
            //        if (contract.RentPeriod == 0)
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 52 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        else if (contract.RentPeriod == 1)
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 52 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        else if (contract.RentPeriod == 2)
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 12 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        else
            //            totalChart = (int)Math.Ceiling(decimal.Parse((1 * 1 * contract.RentAdditionPeriodNr / contract.RentPeriodNr).ToString()));
            //        break;
            //}
            //IList<InsurancePolicy> policyList = _insurancePolicyService.GetContractId(contract.Id);
            //if (policyList.Count < totalChart)
            //{
            //    DateTime dat;
            //    if (policyList.Count > 0)
            //        dat = policyList[0].PaymentEndDate;
            //    else
            //        if (contract.RentPeriod == 1)
            //            dat = contract.ContractStartDate.AddDays(contract.RentPeriodNr*7);
            //        else if(contract.RentPeriod == 2)
            //            dat = contract.ContractStartDate.AddMonths(contract.RentPeriodNr);
            //        else
            //            dat = contract.ContractStartDate.AddYears(contract.RentPeriodNr);
            //    for (int i = policyList.Count; i < totalChart; i++)
            //    {
            //        policyList.Add(new InsurancePolicy
            //        {
            //            Id = i,
            //            Amount = 0,
            //            CreatedDate = dat,
            //            PaymentEndDate=dat,
            //            LOGICALREF = tenant.LogoLogicalRef,
            //            IsPaid = false,
            //            Paid = contract.RentAdditionAmount,
            //        });
            //        if (contract.RentPeriod == 1)
            //            dat = dat.AddDays(contract.RentPeriodNr * 7);
            //        else if (contract.RentPeriod == 2)
            //            dat = dat.AddMonths(contract.RentPeriodNr);
            //        else
            //            dat = dat.AddYears(contract.RentPeriodNr);
            //    }
            //}
            //BsStatu.DataSource = policyList;
            //GcInsurancePolicy.DataSource = BsStatu;
            #endregion
        }
        protected override ColumnView MainView01 => GvMain;
        public override int CurrentObjectId => GvMain.GetFocusedRowCellValue("Id") != DBNull.Value
            ? Convert.ToInt32(GvMain.GetFocusedRowCellValue("Id"))
            : 0;
        bool Locked => GvMain.GetFocusedRowCellValue("Lock") != DBNull.Value
                       && Convert.ToBoolean(GvMain.GetFocusedRowCellValue("Lock"));
        protected override BaseEntity CurrentEditObject => GvMain.GetRow(GvMain.FocusedRowHandle) as RentContract;
        protected override string DetailFormName => "FrmColorAdd";
        private void tileView1_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
             RentContract contract =  CurrentEditObject as RentContract;
            if (tileView1.GetRowCellValue(e.RowHandle, columnPaid) == null)
                return;
            var fff = tileView1.GetRowCellValue(e.RowHandle, columnPaid).ToString();
            if (tileView1.GetRowCellValue(e.RowHandle, columnPaid).ToString() == "true" )
            {
                object ad = e.Item.Elements;
                e.Item.Elements[6].Appearance.Normal.ForeColor = Color.Green;
            }
            else
            {
                //e.Item.Elements[6].Appearance.Normal.BackColor = Color.Red;
                //e.Item.Elements[6].Appearance.Normal.BackColor2 = Color.Red;
                e.Item.Elements[6].Appearance.Normal.ForeColor = Color.Red;
                //e.Item.Elements[6].Appearance.Normal.BorderColor = Color.Red;
            }
        }

        private void GvMain_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (CurrentObjectId != 0)
                IniInsurancePolicy();
        }
    }
}
