using DevExpress.XtraEditors.DXErrorProvider;
using Rent.Business.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;

namespace Rent.WinUI.Concrete.Forms.Parameters
{
    public partial class FrmUserAdd : FrmBaseAdd
    {
        User _User;
        private readonly IUserService _userService;
        private readonly IUserService _UserService;
        public FrmUserAdd(IUserService UserService, IUserService ColorService)
        {
            _userService = ColorService;
            _UserService = UserService;
            InitializeComponent();
        }
        protected override void InitData()
        {
            if (User != null)
            {
                TxtUserName.Text = User.UserName;
                TxtPassword.Text = User.Password;
            }
            base.InitData();
        }

        protected override void SetChangedDataValue()
        {
            User.IsEdit = true;
            base.SetChangedDataValue();
        }
        protected override bool ValidateData()
        {
            try
            {
                ValidationRule rule = null;
                if (string.IsNullOrEmpty(TxtUserName.Text.Trim()) || string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                    rule = ValidationRulesHelper.RuleIsNotBlank;
                ValidationProvider.SetValidationRule(TxtPassword, rule);
                ValidationProvider.SetValidationRule(TxtUserName, rule);
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

                User.Password = TxtPassword.Text.Trim();
                User.UserName = TxtUserName.Text.Trim();
                _User = _UserService.Save(User);
                if (_UserService.SuccsessOperation)
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

        User User
        {
            get
            {
                if (ObjectId > 0 && _User == null)
                {
                    _User = _UserService.GetById(ObjectId);
                }
                else
                {
                    if (_User == null)
                    {
                        _User = new User
                        {
                            IsEdit = true,
                            IsDeleted = false
                        };
                    }
                }
                return _User;
            }
        }
    }
}
