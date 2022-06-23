using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Abstract
{
    public interface IRentContractExpenseService
    {
        List<RentContractExpense> GetAll();
        List<RentContractExpense> GetSluDataSourceAll();
        RentContractExpense GetById(int nId);
        List<RentContractExpense> GetsByMasterId(int rentContractId);
        List<RentContractExpense> GetsByMasterIdExpenseTypeId(int rentContractId, int expenseTypeId);
        List<RentContractExpense> GetsPaymentIsNear();
        List<RentContractExpense> GetsOverPaid();
        List<RentContractExpense> GetsOverAndNearPaid();
        RentContractExpense Save(RentContractExpense entity);
        bool Delete(RentContractExpense entity);
        bool Exists(RentContractExpense entity);
        string UsedControl(RentContractExpense entity);
        bool SuccsessOperation { get; set; }
    }
}
