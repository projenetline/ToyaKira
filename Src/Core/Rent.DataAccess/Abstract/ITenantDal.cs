using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;

namespace Rent.DataAccess.Abstract
{
    public interface ITenantDal : IRepository<Tenant>
    {
    }
}
