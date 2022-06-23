using DevExpress.XtraEditors.DXErrorProvider;
using Rent.Business.Abstract;
using Rent.Core.Concrete.Helpers;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;

namespace Rent.WinUI.Concrete.Forms.Parameters
{
    public partial class FrmRealityAdd : FrmBaseAdd
    {
        Reality _Reality;
        private readonly IUserService _userService;
        private readonly IRealityService _realityService;
        private readonly ILogoDataService _logoDataService;
        public FrmRealityAdd(IRealityService RealityService, IUserService ColorService, ILogoDataService logoDataService)
        {
            _userService = ColorService;
            _realityService = RealityService;
            _logoDataService = logoDataService;
            InitializeComponent();
        }
        protected override void InitData()
        {
            if (Reality != null)
            {
                if (Reality.Id <= 0)
                    LuLogoFirm.EditValue = DbHelper.GetLogoFirmNumber_Int;
                else
                    LuLogoFirm.EditValue = Reality.LogoFirmNo;

                LuItem1.EditValue = Reality.LogoLogicalRef;
                TxtAddress.Text = Reality.Address;
                TxtCode.Text = Reality.Code;
                TxtName.Text = Reality.Name;
                CbType.EditValue = Reality.TypeId;
                CeIsRentable.EditValue = Reality.IsRentable;
            }
            base.InitData();
        }
        protected override void InitEditor()
        {
            LuLogoFirm.Properties.DataSource = _logoDataService.Get_Firms();
            LuItem1.Properties.DataSource = _logoDataService.Get_All_Items();
            base.InitEditor();

        }
        protected override void SetChangedDataValue()
        {
            Reality.IsEdit = true;
            base.SetChangedDataValue();
        }
        private void SetLogoClCardInformation()
        {
            SetChangedDataValue();
            var itemInformation = _logoDataService.Get_ItemInformation(FirmNo, ItemId);
            if (itemInformation != null)
            {
                TxtCode.Text = itemInformation.CODE;
                TxtName.Text = itemInformation.NAME;
            }
        }
        protected override bool ValidateData()
        {
            try
            {
                ValidationRule rule = null;
                if (string.IsNullOrEmpty(TxtCode.Text.Trim()) || CbType.EditValue == null )
                    rule = ValidationRulesHelper.RuleIsNotBlank;
                ValidationProvider.SetValidationRule(CbType, rule);
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
                Reality.LogoFirmNo = LuLogoFirm.EditValue != DBNull.Value ? Convert.ToInt32(LuLogoFirm.EditValue) : 0;
                Reality.LogoLogicalRef = LuItem1.EditValue != DBNull.Value ? Convert.ToInt32(LuItem1.EditValue) : 0;
                Reality.Address = TxtAddress.Text;
                Reality.Code = TxtCode.Text;
                Reality.Name = TxtName.Text;
                Reality.TypeId = CbType.EditValue != DBNull.Value ? Convert.ToByte(CbType.EditValue) : (byte)0;
                Reality.IsRentable = CeIsRentable.CheckState == System.Windows.Forms.CheckState.Checked ;

                _Reality = _realityService.Save(Reality);
                if (_realityService.SuccsessOperation)
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
        Reality Reality
        {
            get
            {
                if (ObjectId > 0 && _Reality == null)
                {
                    _Reality = _realityService.GetById(ObjectId);
                }
                else
                {
                    if (_Reality == null)
                    {
                        _Reality = new Reality
                        {
                            IsEdit = true,
                            IsDeleted = false
                        };
                    }
                }
                return _Reality;
            }
        }
        int FirmNo => LuLogoFirm.EditValue != DBNull.Value ? Convert.ToInt32(LuLogoFirm.EditValue) : 0;
        int ItemId => LuItem1.EditValue != DBNull.Value ? Convert.ToInt32(LuItem1.EditValue) : 0;
        private void LuLogoFirm_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LuLogoFirm.Properties.DataSource = _logoDataService.Get_Firms();
        }
        private void LuItem1_EditValueChanged(object sender, EventArgs e)
        {
            if (Loading) return;
            SetLogoClCardInformation();
        }
        private void LuItem1_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LuItem1.Properties.DataSource = _logoDataService.Get_Items(FirmNo ,"GM");
        }

        private void CbType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

        }

        private void FrmRealityAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
