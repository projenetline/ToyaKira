using DevExpress.XtraEditors.DXErrorProvider;
using Rent.Business.Abstract;
using Rent.Core.Concrete.Helpers;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;

namespace Rent.WinUI.Concrete.Forms.Parameters
{
    public partial class FrmTenantAdd : FrmBaseAdd
    {
        Tenant _tenant;
        private readonly ILogoDataService _logoDataService;
        private readonly IUserService _userService;
        private readonly ITenantService _tenantService;
        public FrmTenantAdd(ITenantService tenantService, IUserService ColorService, ILogoDataService logoDataService)
        {
            _userService = ColorService;
            _tenantService = tenantService;
            _logoDataService = logoDataService;
            InitializeComponent();
        }
        protected override void InitData()
        {
            if (Tenant != null)
            {
                if (Tenant.Id <= 0)
                    LuLogoFirm.EditValue = DbHelper.GetLogoFirmNumber_Int;
                else
                    LuLogoFirm.EditValue = Tenant.LogoFirmNo;
                
                LuClCard1.EditValue = Tenant.LogoLogicalRef;
                TxtAddress.Text = Tenant.Address;
                TxtBankAccountNo.Text = Tenant.BankAccountNo;
                TxtIbanNumber.Text = Tenant.BankIBanNumber;
                TxtIdentityNo.Text = Tenant.IdentityNo;
                TxtName.Text = Tenant.Name;
            }
            base.InitData();
        }
        protected override void InitEditor()
        {
            LuLogoFirm.Properties.DataSource = _logoDataService.Get_Firms();
            LuClCard1.Properties.DataSource = _logoDataService.Get_All_ClCards();
            base.InitEditor();
        }
        protected override void SetChangedDataValue()
        {
            Tenant.IsEdit = true;
            base.SetChangedDataValue();
        }
        private void SetLogoClCardInformation()
        {
            SetChangedDataValue();
            var clCardInformation = _logoDataService.Get_ClCardInformation(FirmNo, ClCardId);
            if (clCardInformation != null)
            {
                TxtIdentityNo.Text = clCardInformation.TCKNO;
                TxtBankAccountNo.Text = clCardInformation.BANKACCOUNTS1;
                TxtIbanNumber.Text = clCardInformation.BANKIBANS1;
                TxtName.Text = clCardInformation.DEFINITION_;
                TxtAddress.Text =  $" {clCardInformation.ADDR1}  ,  { clCardInformation.ADDR2 } , {clCardInformation.DISTRICT}, {clCardInformation.TOWN} , {clCardInformation.CITY}";
            }
        }
        protected override bool ValidateData()
        {
            try
            {
                ValidationRule rule = null;
                if (string.IsNullOrEmpty(TxtIbanNumber.Text.Trim()) || string.IsNullOrEmpty(TxtName.Text.Trim()))
                    rule = ValidationRulesHelper.RuleIsNotBlank;
                ValidationProvider.SetValidationRule(TxtIdentityNo, rule);
                ValidationProvider.SetValidationRule(TxtName, rule);
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
                Tenant.LogoFirmNo = LuLogoFirm.EditValue != DBNull.Value ? Convert.ToInt32(LuLogoFirm.EditValue) : 0;
                Tenant.LogoLogicalRef = LuClCard1.EditValue != DBNull.Value ? Convert.ToInt32(LuClCard1.EditValue) : 0;
                Tenant.Address = TxtAddress.Text.Trim();
                Tenant.BankAccountNo = TxtBankAccountNo.Text.Trim();
                Tenant.BankIBanNumber = TxtIbanNumber.Text.Trim();
                Tenant.IdentityNo = TxtIdentityNo.Text.Trim();
                Tenant.Name = TxtName.Text.Trim();
                _tenant = _tenantService.Save(Tenant);
                if (_tenantService.SuccsessOperation)
                {
                    EditObj = true;
                    ExamineObj = false;
                    SaveObj = true;
                    MessageHelper.SuccessfulSaveMessage();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
                SaveObj = false;
            }
        }

        Tenant Tenant
        {
            get
            {
                if (ObjectId > 0 && _tenant == null)
                {
                    _tenant = _tenantService.GetById(ObjectId);
                }
                else
                {
                    if (_tenant == null)
                    {
                        _tenant = new Tenant
                        {
                            IsEdit = true,
                            IsDeleted = false
                        };
                    }
                }
                return _tenant;
            }
        }
        int FirmNo => LuLogoFirm.EditValue != DBNull.Value ? Convert.ToInt32(LuLogoFirm.EditValue) : 0;
        int ClCardId => LuClCard1.EditValue != DBNull.Value ? Convert.ToInt32(LuClCard1.EditValue) : 0;
        private void LuClCard1_EditValueChanged(object sender, EventArgs e)
        {
            if (Loading) return;
            SetLogoClCardInformation();
        }

       

        private void LuClCard1_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LuClCard1.Properties.DataSource = _logoDataService.Get_ClCards(FirmNo);
        }
    }
}
