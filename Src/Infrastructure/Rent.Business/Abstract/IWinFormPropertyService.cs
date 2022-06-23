using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IWinFormPropertyService
    {
        WinFormProperty Save(WinFormProperty entity);
        WinFormProperty Get_WinFormProperty_By_UserId(int nUserId);
    }
}
