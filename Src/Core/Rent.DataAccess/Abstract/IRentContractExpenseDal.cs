using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.DataAccess.Abstract
{
    public interface IRentContractExpenseDal : IRepository<RentContractExpense>
    {
        List<RentContractExpense> GetsByMasterId(int rentContractId);
        List<RentContractExpense> GetsByMasterIdExpenseTypeId(int rentContractId, int expenseTypeId);
        List<RentContractExpense> GetsPaymentIsNear();
        List<RentContractExpense> GetsOverPaid();
        List<RentContractExpense> GetsOverAndNearPaid();
    }
}