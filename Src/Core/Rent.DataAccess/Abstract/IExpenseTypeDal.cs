using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.DataAccess.Abstract
{
    public interface IExpenseTypeDal : IRepository<ExpenseType>
    {
        List<ExpenseType> GetsByTypeId(int typeId);
    }
}