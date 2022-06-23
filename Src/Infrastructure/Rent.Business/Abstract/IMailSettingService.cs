using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Abstract
{
    public interface IMailSettingService
    {
        List<MailSetting> GetAll();
        List<MailSetting> GetSluDataSourceAll();
        MailSetting GetById(int nId);
        MailSetting Save(MailSetting entity);
        bool Delete(MailSetting entity);
        bool Exists(MailSetting entity);
        string UsedControl(MailSetting entity);
    }
}
