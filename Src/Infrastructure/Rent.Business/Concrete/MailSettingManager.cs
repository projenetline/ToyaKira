using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class MailSettingManager : IMailSettingService
    {
        readonly IMailSettingDal _mailSettingDal;
        public MailSettingManager(IMailSettingDal mailSettingDal)
        {
            _mailSettingDal = mailSettingDal;
        }

        public bool Delete(MailSetting entity)
        {
            return _mailSettingDal.Delete(entity);
        }

        public bool Exists(MailSetting entity)
        {
            return _mailSettingDal.Delete(entity);
        }

        public List<MailSetting> GetAll()
        {
            return _mailSettingDal.GetAll();
        }

        public MailSetting GetById(int nId)
        {
            return _mailSettingDal.GetById(nId);
        }

        public List<MailSetting> GetSluDataSourceAll()
        {
            return _mailSettingDal.GetSluDataSourceAll();
        }

        public MailSetting Save(MailSetting entity)
        {
            return _mailSettingDal.Save(entity);
        }

        public string UsedControl(MailSetting entity)
        {
            return _mailSettingDal.UsedControl(entity);
        }
    }
}
