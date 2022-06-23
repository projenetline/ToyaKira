using DevExpress.XtraEditors.DXErrorProvider;
using Rent.Business.Abstract;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using Rent.WinUI.Concrete.NetlineControls;
using Rent.WinUI.RentControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Forms.Contract
{
    public partial class FrmContractDetail : FrmBaseDetail
    {
        RentContract _rentContract;
        ILogoDataService _logoDataService;
        IRentContractService _rentContractService;
        IRentContractExpenseService _rentContractExpenseService;
        IRentContractRealityService _rentContractRealityService;
        ITenantService _tenantService;
        IRealityService _realityService;
        IExpenseTypeService _expenseTypeService;
        public FrmContractDetail(IRentContractService rentContractService, IRentContractExpenseService rentContractExpenseService, IRentContractRealityService rentContractRealityService,
            ITenantService tenantService, IRealityService realityService, IExpenseTypeService expenseTypeService, ILogoDataService logoDataService)
        {
            _rentContractService = rentContractService;
            _rentContractExpenseService = rentContractExpenseService;
            _rentContractRealityService = rentContractRealityService;
            _tenantService = tenantService;
            _realityService = realityService;
            _expenseTypeService = expenseTypeService;
            _logoDataService = logoDataService;
            InitializeComponent();
        }
        protected override void InitData()
        {
            if (RentContract != null)
            {
                LuFirm.EditValue = RentContract.FirmNo;
                TxtId.Text = RentContract.Id > 0 ? RentContract.Id.ToString() : "0";
                TxtContactNo.Text = RentContract.ContactNo;
                sluTenant1.EditValue = RentContract.TenantId;
                DeContractStartDate.EditValue = RentContract.ContractStartDate;
                DeContractEndDate.EditValue = RentContract.ContractEndDate;
                SeRentAmount.EditValue = RentContract.RentAmount;
                SeTaxAmount.EditValue = RentContract.TaxAmount;
                SeTotalAmount.EditValue = RentContract.TotalAmount;
                CbRentCurrency1.EditValue = RentContract.RentCurrencyId;
                CbPeriodType1.EditValue = RentContract.RentPeriod;
                TxtRentPeriodNot.Text = RentContract.RentPeriodNot;
                SeAdvancePayment.EditValue = RentContract.AdvancePayment;
                CbAPCurrencyId.EditValue = RentContract.APCurrencyId;
                SeDepositAmount.EditValue = RentContract.DepositAmount;
                CbDepCurrencyId.EditValue = RentContract.DepCurrencyId;
                CbRentAdditionPeriod.EditValue = RentContract.RentAdditionPeriod;
                TxtRentAdditionNote.Text = RentContract.RentAdditionNote;
                SeRentAdditionRate.EditValue = RentContract.RentAdditionRate;
                SeRentAdditionAmount.EditValue = RentContract.RentAdditionAmount;
                InitRealities();
                IniExpenses();
            }
            base.InitData();
        }
        protected override void SetChangedDataValue()
        {
            RentContract.IsEdit = true;
            IsChangeData = true;
            base.SetChangedDataValue();
        }
        private void InitRealities()
        {
            BsRealities.DataSource = RentContract.RentContractRealities.Where(x => x.IsDeleted != true).ToList();
            GcReality.DataSource = BsRealities;
        }
        private void IniExpenses()
        {
            BsExpenses.DataSource = RentContract.RentContractExpenses.Where(x => x.IsDeleted != true).ToList();
            GcExpnses.DataSource = BsExpenses;
        }
        protected override void InitEditors()
        {
            List<Tenant> tenants = _tenantService.GetSluDataSourceAll();
            List<ExpenseType> expenseTypes = _expenseTypeService.GetSluDataSourceAll();
            List<Reality> realities = _realityService.GetSluDataSourceAll();
            
            sluTenant1.Properties.DataSource = tenants;
            repositoryItemsluReality1.DataSource = realities;
            repositoryItemsluExpenseType1.DataSource = expenseTypes;
            LuFirm.Properties.DataSource = _logoDataService.Get_Firms();
            repositoryItemLuClCard1.DataSource = _logoDataService.Get_All_ClCards();
            base.InitEditors();
            SeTotalAmount.Properties.ReadOnly = true;
        }
        protected override bool ValidateData()
        {
            try
            {
                ValidationRule rule = null;
                if (string.IsNullOrEmpty(TxtContactNo.Text.Trim()) || sluTenant1.EditValue == null || LuFirm.EditValue == null)
                    rule = ValidationRulesHelper.RuleIsNotBlank;
                ValidationProvider.SetValidationRule(TxtContactNo, rule);
                ValidationProvider.SetValidationRule(sluTenant1, rule);
                ValidationProvider.SetValidationRule(LuFirm, rule);
                return base.ValidateData();
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
                return base.ValidateData();
            }
        }
        protected override void SaveData()
        {
            try
            {

                GvExpnses.CloseEditor();
                GvExpnses.UpdateCurrentRow();
                GvExpnses.ActiveFilter.Clear();
                GvReality.CloseEditor();
                GvReality.UpdateCurrentRow();
                GvReality.ActiveFilter.Clear();

                if (RentContract != null)
                {
                    if (ValidateData())
                    {
                        RentContract.ContactNo = TxtContactNo.Text.Trim();
                        RentContract.TenantId = sluTenant1.EditValue != DBNull.Value ?
                            Convert.ToInt32(sluTenant1.EditValue)
                            : 0;
                        RentContract.FirmNo = LuFirm.EditValue != DBNull.Value ?
                                Convert.ToInt32(LuFirm.EditValue)
                               : 0;
                        RentContract.ContractStartDate = DeContractStartDate.EditValue != DBNull.Value ?
                            Convert.ToDateTime(DeContractStartDate.EditValue)
                            : NetlineAppHelper.GetDefaultDateTime;
                        RentContract.ContractEndDate = DeContractStartDate.EditValue != DBNull.Value ?
                            Convert.ToDateTime(DeContractStartDate.EditValue)
                            : NetlineAppHelper.GetDefaultDateTime;
                        RentContract.RentAmount = SeRentAmount.EditValue != DBNull.Value ?
                            Convert.ToDouble(SeRentAmount.EditValue)
                            : 0;
                        RentContract.TaxAmount = SeTaxAmount.EditValue != DBNull.Value ?
                            Convert.ToDouble(SeTaxAmount.EditValue)
                            : 0;
                        RentContract.TotalAmount = SeTotalAmount.EditValue != DBNull.Value ?
                            Convert.ToDouble(SeTotalAmount.EditValue)
                            : 0;
                        RentContract.RentCurrencyId = CbRentCurrency1.EditValue != DBNull.Value ?
                            Convert.ToByte(CbRentCurrency1.EditValue)
                            : (byte)0;
                        RentContract.RentPeriod = CbPeriodType1.EditValue != DBNull.Value ?
                            Convert.ToInt32(CbPeriodType1.EditValue)
                            : 0;
                        RentContract.RentPeriodNot = TxtRentPeriodNot.Text.Trim();
                        RentContract.AdvancePayment = SeAdvancePayment.EditValue != DBNull.Value ?
                            Convert.ToDouble(SeAdvancePayment.EditValue)
                            : 0;
                        RentContract.APCurrencyId = CbAPCurrencyId.EditValue != DBNull.Value ?
                            Convert.ToByte(CbAPCurrencyId.EditValue)
                          : (byte)0;
                        RentContract.DepositAmount = SeDepositAmount.EditValue != DBNull.Value ?
                            Convert.ToDouble(SeDepositAmount.EditValue)
                            : 0;
                        RentContract.DepCurrencyId = CbDepCurrencyId.EditValue != DBNull.Value ?
                            Convert.ToByte(CbDepCurrencyId.EditValue)
                           : (byte)0;
                        RentContract.RentAdditionPeriod = CbRentAdditionPeriod.EditValue != DBNull.Value ?
                            Convert.ToInt32(CbRentAdditionPeriod.EditValue)
                            : 0;
                        RentContract.RentAdditionRate = SeRentAdditionRate.EditValue != DBNull.Value ?
                            Convert.ToDouble(SeRentAdditionRate.EditValue)
                            : 0;
                        RentContract.RentAdditionAmount = SeRentAdditionAmount.EditValue != DBNull.Value ?
                           Convert.ToDouble(SeRentAdditionAmount.EditValue)
                           : 0;
                        RentContract.RentAdditionNote = TxtRentAdditionNote.Text.Trim();

                        for (int i = 0; i < GvExpnses.DataRowCount; i++)
                        {
                            RentContractExpense rentContractExpense = GvExpnses.GetRow(i) as RentContractExpense;
                            if (rentContractExpense != null)
                            {
                                if (rentContractExpense.Id <= 0 && rentContractExpense.IsDeleted != true)
                                {
                                    RentContract.RentContractExpenses.Add(rentContractExpense);
                                }
                            }
                        }

                        for (int i = 0; i < GvReality.DataRowCount; i++)
                        {
                            RentContractReality rentContractReality = GvReality.GetRow(i) as RentContractReality;
                            if (rentContractReality != null)
                            {
                                if (rentContractReality.Id <= 0 && rentContractReality.IsDeleted != true)
                                {
                                    RentContract.RentContractRealities.Add(rentContractReality);
                                }
                            }
                        }

                        _rentContractService.Save(RentContract);
                        if (_rentContractService.SuccsessOperation)
                        {
                            TxtId.Text = RentContract.Id.ToString();
                            SaveObj = true;
                            NewObj = false;
                            EditObj = true;
                            MessageHelper.SuccessfulSaveMessage();
                        }
                    }
                }
                base.SaveData();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void SetRentAdditionAmount()
        {
            SeRentAdditionAmount.EditValue = CalcRentAddtionAmount;
        }
        #region PROPERTIES
        public bool CreateAdditionalContract { get; set; }
        RentContract RentContract
        {
            get
            {
                if(CreateAdditionalContract)
                {
                    if (ObjectId > 0 && _rentContract == null)
                    {
                        RentContract sourceRentContract = _rentContractService.GetByIdWithDetails(ObjectId);
                        _rentContract =  sourceRentContract.CreateAdditionContract();
                        SetChangedDataValue();
                    }
                }
                else
                {
                    if (ObjectId > 0 && _rentContract == null)
                    {
                        _rentContract = _rentContractService.GetByIdWithDetails(ObjectId);
                    }
                    else
                    {
                        if (_rentContract == null)
                        {
                            _rentContract = new RentContract
                            {
                                IsEdit = true,
                                IsDeleted = false,
                                APCurrencyId = Convert.ToByte(EnumCurrency.TL.GetHashCode()),
                                ContractEndDate = NetlineAppHelper.GetDefaultDateTime,
                                ContractStartDate = NetlineAppHelper.GetDefaultDateTime,
                                DepCurrencyId = Convert.ToByte(EnumCurrency.TL.GetHashCode()),
                                RentCurrencyId = Convert.ToByte(EnumCurrency.TL.GetHashCode()),
                                DepositAmount = 0,
                            };
                        }
                    }
                }
               
                return _rentContract;
            }
        }
        int CurrentFirmNo => LuFirm.EditValue != DBNull.Value ? Convert.ToInt32(LuFirm.EditValue) : -1;
        bool Exists
        {
            get
            {
                return _rentContractService.Exists(RentContract);
            }
        }
        int CurrentRowRealityTypeId => GvReality.GetFocusedRowCellValue("TypeId") != DBNull.Value ?
            Convert.ToInt32(GvReality.GetFocusedRowCellValue("TypeId"))
            : 0;
        int CurrentRowExpenseTypeId => GvExpnses.GetFocusedRowCellValue("TypeId") != DBNull.Value ?
           Convert.ToInt32(GvExpnses.GetFocusedRowCellValue("TypeId"))
           : 0;
        int CurrentRowClCardLogicalRef => GvExpnses.GetFocusedRowCellValue("ExpenseCompanyLogicalRef") != DBNull.Value ?
         Convert.ToInt32(GvExpnses.GetFocusedRowCellValue("ExpenseCompanyLogicalRef"))
         : 0;
        int CurrentExpenseId => GvExpnses.GetFocusedRowCellValue("ExpensetTypeId") != DBNull.Value ?
           Convert.ToInt32(GvExpnses.GetFocusedRowCellValue("ExpensetTypeId"))
           : 0;
        double CurrentRentAmount
        {
            get
            {
                return SeRentAmount.EditValue != DBNull.Value ?
                    Convert.ToDouble(SeRentAmount.EditValue)
                    : 0;
            }
          
        }
        double CurrentRentAdditionRate
        {
            get
            {
                return SeRentAdditionRate.EditValue != DBNull.Value ?
                    Convert.ToDouble(SeRentAdditionRate.EditValue)
                    : 0;
            }

        }
        double CurrentTaxAmount
        {
            get
            {
                return SeTaxAmount.EditValue != DBNull.Value ?
           Convert.ToDouble(SeTaxAmount.EditValue)
           : 0;
            }

        }
        double TotalAmount
        {
            get
            {
                if (Loading)
                    return 0;
                return CurrentRentAmount + CurrentTaxAmount;
            }
        }
        bool GetExpenseResponsible(int expenseId)
        {
            if (Loading) return false;
            var result = _expenseTypeService.GetById(expenseId);
            if (result != null)
                return result.Responsible;
            else
                return false;

        }
        private double CalcRentAddtionAmount
        {
            get
            {
                return CurrentRentAmount + (CurrentRentAmount * CurrentRentAdditionRate) / 100;
            }
        }
        #endregion

        private void GvExpnses_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (Loading) return;
            GridHelper.InitNewRow(GvExpnses, e.RowHandle);
            GvExpnses.SetRowCellValue(e.RowHandle, "ExpenseEndDate", NetlineAppHelper.GetDefaultDateTime);
        }
        private void GvExpnses_KeyDown(object sender, KeyEventArgs e)
        {
            if (Loading) return;
            if (e.KeyCode == Keys.Delete)
            {
                DeletingObj = true;
                GridHelper.DeleteRow(GvExpnses, DeletingObj);
                DeletingObj = false;
            }
        }
        private void GvExpnses_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (Loading) return;

            if (e.Column.FieldName != "IsEdit")
            {
                GvExpnses.SetRowCellValue(e.RowHandle, "IsEdit", true);
            }

            if (e.Column.FieldName == "ExpensetTypeId")
            {
                GvExpnses.SetRowCellValue(e.RowHandle, "Responsible", GetExpenseResponsible(CurrentExpenseId));
            }
            if(CurrentFirmNo>0)
            if (e.Column.FieldName == "ExpenseCompanyLogicalRef")
            {
                var clCardInf = _logoDataService.Get_ClCardInformation(CurrentFirmNo, CurrentRowClCardLogicalRef);
                if(clCardInf != null)
                {
                    GvExpnses.SetRowCellValue(e.RowHandle, "ExpenseCompany", clCardInf.NAME);
                    GvExpnses.SetRowCellValue(e.RowHandle, "CompanyAccountNo",clCardInf.BANKACCOUNTS1);
                    GvExpnses.SetRowCellValue(e.RowHandle, "CompanyIbanNo", clCardInf.BANKIBANS1);
                }
            }

            SetChangedDataValue();
        }
        private void GvReality_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (Loading) return;
            if (e.Column.FieldName != "IsEdit")
            {
                GvReality.SetRowCellValue(e.RowHandle, "IsEdit", true);
            }
            SetChangedDataValue();
        }
        private void GvReality_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (Loading) return;
            GridHelper.InitNewRow(GvReality, e.RowHandle);
           
        }
        private void GvReality_KeyDown(object sender, KeyEventArgs e)
        {
            if (Loading) return;
            if (e.KeyCode == Keys.Delete)
            {
                DeletingObj = true;
                GridHelper.DeleteRow(GvReality, DeletingObj);
                DeletingObj = false;
            }
        }
        private void GvExpnses_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (Loading) return;
            GvDetail view = sender as GvDetail;
            if (view == null) return;
          
            string fieldName = view.FocusedColumn.FieldName;
            switch (fieldName)
            {
                case "ExpensetTypeId":

                    RepositoryItemsluExpenseType rsluExpenseType = new RepositoryItemsluExpenseType();
                    rsluExpenseType.DataSource = _expenseTypeService.GetsByTypeId(CurrentRowExpenseTypeId);
                    e.RepositoryItem = rsluExpenseType;
                    break;
                case "ExpenseCompanyLogicalRef":
                    if (CurrentFirmNo <= 0)
                        return;
                    RepositoryItemLuClCard rsluClCard = new RepositoryItemLuClCard();
                    rsluClCard.DataSource = _logoDataService.Get_ClCards(CurrentFirmNo).Select(s=>new { LOGICALREF =s.LOGICALREF,CODE=s.CODE,NAME=s.NAME});
                    rsluClCard.NullText = string.Empty;
                    rsluClCard.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
                    rsluClCard.Columns.Clear();
                    rsluClCard.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOGICALREF", "Referans No"));
                    rsluClCard.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Firma Kodu"));
                    rsluClCard.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Firma Ünvanı"));
                    rsluClCard.ValueMember = "LOGICALREF";
                    rsluClCard.DisplayMember = "CODE";

                    e.RepositoryItem = rsluClCard;
                    break;
            }
        }
        private void GvReality_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (Loading) return;
            GvDetail view = sender as GvDetail;
            if (view == null) return;
            string fieldName = view.FocusedColumn.FieldName;
            switch (fieldName)
            {
                case "RealityId":
                    RepositoryItemsluReality rsluReality = new RepositoryItemsluReality();
                    rsluReality.DataSource = _realityService.GetsByTypeId(CurrentRowRealityTypeId);
                    e.RepositoryItem = rsluReality;
                    break;
            }
        }
        private void RentAmountChabnged_EditValueChanged(object sender, EventArgs e)
        {
            if (Loading) return;
            SeTotalAmount.EditValue = TotalAmount;
        }
        private void SeRentAdditionRate_EditValueChanged(object sender, EventArgs e)
        {
            SetRentAdditionAmount();
        }

        private void GcExpnses_Click(object sender, EventArgs e)
        {

        }
    }
}
