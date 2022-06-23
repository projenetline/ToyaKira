using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Abstract
{
    public interface ILogService
    {
        List<LogModel> GetAll();
        LogModel GetById(int nId);
        LogModel Save(LogModel entity);
        bool Delete(LogModel entity);
    }
}
