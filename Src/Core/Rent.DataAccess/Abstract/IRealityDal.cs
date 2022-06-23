using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.DataAccess.Abstract
{
    public interface IRealityDal : IRepository<Reality>
    {
        List<Reality> GetsByTypeId(int typeId);
    }
}
