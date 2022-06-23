using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IMailHeaderLineService
    {
        List<MailHeaderLine> GetAll();
        List<MailHeaderLine> GetSluDataSourceAll();
        MailHeaderLine GetById(int nId);
        List<MailHeaderLine> GetsByMasterId(int mailHeaderId);
        List<MailHeaderLine> GetsByModuleId(EnumModule module);
        MailHeaderLine Save(MailHeaderLine entity);
        bool Delete(MailHeaderLine entity);
        bool Exists(MailHeaderLine entity);
        string UsedControl(MailHeaderLine entity);
        bool SuccsessOperation { get; set; }
    }
}
