using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IWinFormLayoutService
    {
        WinFormLayout Save(WinFormLayout entity);
        WinFormLayout GetWinLayoutBy_UserId_WithoutFormName(int nUserId);
        WinFormLayout GetWinLayoutBy_UserId_WitFormName(int nUserId, string cFormName);
        bool DeleteUserLayouts(int nUserId);
        bool DeleteAllLayouts();
      
    }
}
