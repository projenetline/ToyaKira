using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.DataAccess.Abstract
{
    public interface IRentContractDal : IRepository<RentContract>
    {
        List<RentContract> GetNotPaid();
    }
}
