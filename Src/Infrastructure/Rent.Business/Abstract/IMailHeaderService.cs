using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IMailHeaderService
    {
        List<MailHeader> GetAll();
        List<MailHeader> GetSluDataSourceAll();
        MailHeader GetById(int nId);
        MailHeader GetByIdWithDetails(int nId);
        MailHeader Save(MailHeader entity);
        bool Delete(MailHeader entity);
        bool Exists(MailHeader entity);
        string UsedControl(MailHeader entity);
        bool SuccsessOperation { get; set; }
    }
}
