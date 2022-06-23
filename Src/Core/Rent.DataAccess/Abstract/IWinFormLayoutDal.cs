using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;

namespace Rent.DataAccess.Abstract
{
    public interface IWinFormLayoutDal : IRepository<WinFormLayout>
    {
        WinFormLayout GetWinLayoutBy_UserId_WithoutFormName(int nUserId);
        WinFormLayout GetWinLayoutBy_UserId_WitFormName(int nUserId, string cFormName);
        bool DeleteUserLayouts(int nUserId);
        bool DeleteAllLayouts();
    }
}
