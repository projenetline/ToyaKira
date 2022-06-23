using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.DataAccess.Abstract
{
    public interface IMailHeaderLineDal : IRepository<MailHeaderLine>
    {
        List<MailHeaderLine> GetsByMasterId(int mailHeaderId);
        List<MailHeaderLine> GetsByModuleId(EnumModule module);
    }
}