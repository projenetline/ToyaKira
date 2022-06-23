using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        User GetBy_UsrName_Pass(string userName, string password);
    }
}
