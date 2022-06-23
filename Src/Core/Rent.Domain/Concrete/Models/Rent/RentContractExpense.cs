using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class RentContractExpense : BaseEntity
    {
        public int RentContractId { get; set; }
        public byte TypeId { get; set; }
        public int ExpensetTypeId { get; set; }
        public int ExpenseCompanyLogicalRef { get; set; }
        public string ExpenseCompany { get; set; }
        public string CompanyAccountNo { get; set; }
        public string CompanyIbanNo { get; set; }
        public double ExpenseAmount { get; set; }
        public string ExpenseContractNo { get; set; }
        public int RentAdditionPeriod { get; set; }
        public int RentAdditionPeriodNr { get; set; }
        public DateTime ExpenseEndDate { get; set; }
        public byte Responsible { get; set; }
        public bool IsPaid { get; set; }

        [Write(false)]
        public virtual RentContract RentContract { get; set; }
    }
}
