using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;

namespace Rent.DataAccess.Abstract
{
    public interface IWinFormPropertyDal : IRepository<WinFormProperty>
    {
        WinFormProperty Get_WinFormProperty_By_UserId(int nUserId);
    }
}
