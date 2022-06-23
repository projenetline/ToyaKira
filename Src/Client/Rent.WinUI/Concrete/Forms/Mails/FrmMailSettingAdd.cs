using Rent.Business.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.Linq;

namespace Rent.WinUI.Concrete.Forms.Mails
{
    public partial class FrmMailSettingAdd : FrmBaseAdd
    {
        MailSetting _emailSetting;
        IMailSettingService _emailManager;
        public FrmMailSettingAdd(IMailSettingService emailSettingService)
        {
            _emailManager = emailSettingService;
            InitializeComponent();
        }
        protected override void InitData()
        {
            if (CurrentEmailSetting != null) 
            {
                TxtDisplayName.Text = CurrentEmailSetting.DisplayName;
                TxtPassword.Text = CurrentEmailSetting.Password;
                TxtServerPortName.Text = CurrentEmailSetting.ServerPortName;
                TxtMailAddres.Text = CurrentEmailSetting.MailAddress;
                TxtSmtpServer.Text = CurrentEmailSetting.SmtpServer;
                TxtUserName.Text = CurrentEmailSetting.UserName;
            }
            base.InitData();
        }
        protected override void InitEditor()
        {
            this.Text = this.Text + " - " + FormCaption;
            base.InitEditor();
        }
        protected override void SaveData()
        {
            try
            {
                CurrentEmailSetting.DisplayName = TxtDisplayName.Text.Trim();
                CurrentEmailSetting.Password = TxtPassword.Text.Trim();
                CurrentEmailSetting.ServerPortName = TxtServerPortName.Text.Trim();
                CurrentEmailSetting.MailAddress = TxtMailAddres.Text.Trim();
                CurrentEmailSetting.SmtpServer = TxtSmtpServer.Text.Trim();
                CurrentEmailSetting.UserName = TxtUserName.Text.Trim();
                _emailManager.Save(CurrentEmailSetting);
                if (MessageHelper.QuestionMessage("Uyarı", "Ekran kapatılsın mı ?"))
                {
                    SaveObj = true;
                }
                else
                {
                    EditObj = false;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }
        private MailSetting CurrentEmailSetting 
        {
            get 
            {
                if (_emailSetting == null)
                {
                    _emailSetting = _emailManager.GetAll().FirstOrDefault();
                    if (_emailSetting == null)
                    {
                        _emailSetting = new MailSetting
                        {
                            IsDeleted = false,
                            IsEdit = true
                        };
                    }
                }

                _emailSetting.IsEdit = true;
                return _emailSetting;
            }
        }
        public int Current_Firm_Number { get; set; }
    }
}
