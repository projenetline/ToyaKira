using DevExpress.XtraEditors.DXErrorProvider;
using Rent.Business.Abstract;
using Rent.Core.Concrete.Helpers;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;

namespace Rent.WinUI.Concrete.Forms.Parameters
{
    public partial class FrmExpenseTypeAdd : FrmBaseAdd
    {
        ExpenseType _ExpenseType;
        private readonly IUserService _userService;
        private readonly IExpenseTypeService _ExpenseTypeService;
        private readonly ILogoDataService _logoDataService;
        public FrmExpenseTypeAdd(IExpenseTypeService ExpenseTypeService, IUserService ColorService, ILogoDataService logoDataService)
        {
            _userService = ColorService;
            _ExpenseTypeService = ExpenseTypeService;
            _logoDataService = logoDataService;
            InitializeComponent();
        }
        protected override void InitData()
        {
            if (ExpenseType != null)
            {
                if (ExpenseType.Id <= 0)
                    LuLogoFirm.EditValue = DbHelper.GetLogoFirmNumber_Int;
                else
                    LuLogoFirm.EditValue = ExpenseType.LogoFirmNo;

                luItem1.EditValue = ExpenseType.LogoLogicalRef;
                TxtCode.Text =  ExpenseType.Code;
                TxtName.Text = ExpenseType.Name;
                CbType.EditValue = ExpenseType.TypeId;
                CeResponsible.EditValue = ExpenseType.Responsible;
            }
            base.InitData();
        }
        protected override void InitEditor()
        {
            LuLogoFirm.Properties.DataSource = _logoDataService.Get_Firms();
            luItem1.Properties.DataSource = _logoDataService.Get_All_Items();
            base.InitEditor();
        }
        protected override void SetChangedDataValue()
        {
            ExpenseType.IsEdit = true;
            base.SetChangedDataValue();
        }
        protected override bool ValidateData()
        {
            try
            {
                ValidationRule rule = null;
                if (string.IsNullOrEmpty(TxtCode.Text.Trim()) || CbType.EditValue == null)
                    rule = ValidationRulesHelper.RuleIsNotBlank;
                ValidationProvider.SetValidationRule(TxtCode, rule);
                ValidationProvider.SetValidationRule(CbType, rule);
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
                ExpenseType.LogoFirmNo = LuLogoFirm.EditValue != DBNull.Value ? Convert.ToInt32(LuLogoFirm.EditValue) : 0;
                ExpenseType.LogoLogicalRef = luItem1.EditValue != DBNull.Value ? Convert.ToInt32(luItem1.EditValue) : 0;
                ExpenseType.Code = TxtCode.Text.Trim();
                ExpenseType.Name = TxtName.Text.Trim();
                ExpenseType.TypeId = CbType.EditValue != DBNull.Value ? Convert.ToByte(CbType.EditValue) : (byte)0;
                ExpenseType.Responsible = CeResponsible.CheckState == System.Windows.Forms.CheckState.Checked;
                _ExpenseType = _ExpenseTypeService.Save(ExpenseType);
                if (_ExpenseTypeService.SuccsessOperation)
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

        ExpenseType ExpenseType
        {
            get
            {
                if (ObjectId > 0 && _ExpenseType == null)
                {
                    _ExpenseType = _ExpenseTypeService.GetById(ObjectId);
                }
                else
                {
                    if (_ExpenseType == null)
                    {
                        _ExpenseType = new ExpenseType
                        {
                            IsEdit = true,
                            IsDeleted = false,
                            Responsible = false
                        };
                    }
                }
                return _ExpenseType;
            }
        }
        int FirmNo => LuLogoFirm.EditValue != DBNull.Value ? Convert.ToInt32(LuLogoFirm.EditValue) : 0;
        private void luItem1_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // firma numarasına göre logodan çekilecek
        }

        private void FrmExpenseTypeAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
