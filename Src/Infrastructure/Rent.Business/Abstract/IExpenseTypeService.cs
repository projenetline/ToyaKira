using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IExpenseTypeService
    {
        List<ExpenseType> GetAll();
        List<ExpenseType> GetSluDataSourceAll();
        ExpenseType GetById(int nId);
        ExpenseType Save(ExpenseType entity);
        bool Delete(ExpenseType entity);
        bool Exists(ExpenseType entity);
        string UsedControl(ExpenseType entity);
        bool SuccsessOperation { get; set; }
        List<ExpenseType> GetsByTypeId(int typeId);
    }
}
