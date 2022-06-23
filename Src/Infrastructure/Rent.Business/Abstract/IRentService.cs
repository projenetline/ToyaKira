using Rent.DataAccess.Concrete;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Abstract
{
    public interface IRentService
    {
        void SendMail();
        List<MailHeaderLine> GetsMailList(EnumModule module);
        MailSetting GetMailSettings();
    }
}
