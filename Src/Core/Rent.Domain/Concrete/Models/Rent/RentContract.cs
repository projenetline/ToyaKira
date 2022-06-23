using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class RentContract : BaseEntity
    {
        public RentContract()
        {
            this.RentContractExpenses = new HashSet<RentContractExpense>();
            this.InsurancePolicies = new HashSet<InsurancePolicy>();
            this.RentContractRealities = new HashSet<RentContractReality>();
        }
        public string ContactNo { get; set; }
        public int FirmNo { get; set; }
        public int TenantId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public double RentAmount { get; set; }
        public double TaxAmount { get; set; }
        public double TotalAmount { get; set; }
        public byte RentCurrencyId { get; set; }
        public int RentPeriod { get; set; }
        public int RentPeriodNr { get; set; }
        public string RentPeriodNot { get; set; }
        public double AdvancePayment { get; set; }
        public byte APCurrencyId { get; set; }
        public double DepositAmount { get; set; }
        public byte DepCurrencyId { get; set; }
        public int RentAdditionPeriod { get; set; }
        public int RentAdditionPeriodNr { get; set; }
        public string RentAdditionNote { get; set; }
        public double RentAdditionRate { get; set; }
        public double RentAdditionAmount { get; set; }
        public bool IsPaid { get; set; }
        [Write(false)]
        public ICollection<RentContractReality> RentContractRealities { get; set; }
        [Write(false)]
        public ICollection<RentContractExpense> RentContractExpenses { get; set; }
        [Write(false)]
        public ICollection<InsurancePolicy> InsurancePolicies { get; set; }

        public RentContract CreateAdditionContract()
        {
            RentContract rentContract = new RentContract
            {
                AdvancePayment = this.AdvancePayment,
                APCurrencyId = this.APCurrencyId,
                ContactNo = this.ContactNo,
                ContractStartDate = this.ContractStartDate.AddYears(1),
                ContractEndDate = this.ContractEndDate.AddYears(1),
                DepCurrencyId = this.DepCurrencyId,
                DepositAmount = this.DepositAmount,
                FirmNo = this.FirmNo,
                IsEdit = true,
                RentAdditionAmount = this.RentAdditionAmount + ((this.RentAdditionAmount * RentAdditionRate)/100),
                RentAdditionNote = this.RentAdditionNote,
                RentAdditionPeriod = this.RentAdditionPeriod,
                RentAdditionPeriodNr = this.RentAdditionPeriodNr,
                RentAdditionRate = this.RentAdditionRate,
                RentAmount = this.RentAdditionAmount,
                RentCurrencyId = this.RentCurrencyId,
                RentPeriod = this.RentPeriod,
                RentPeriodNot = this.RentPeriodNot,
                RentPeriodNr = this.RentPeriodNr,
                TaxAmount = this.TaxAmount,
                TenantId = this.TenantId,
                TotalAmount = this.TotalAmount,
                IsPaid = this.IsPaid,
            };

            foreach (var reality in this.RentContractRealities)
            {
                RentContractReality rentContractReality = new RentContractReality
                {
                    RealityId = reality.RealityId,
                    IsEdit = true,
                    RentContract = rentContract,
                    TypeId = reality.TypeId,
                };
                rentContract.RentContractRealities.Add(rentContractReality);
            }

            foreach (var contractExpense in this.RentContractExpenses)
            {
                RentContractExpense rentContractExpense = new RentContractExpense
                {
                    IsEdit = true,
                    RentContract = rentContract,
                    CompanyAccountNo = contractExpense.CompanyAccountNo,
                    CompanyIbanNo = contractExpense.CompanyIbanNo,
                    RentAdditionPeriod = contractExpense.RentAdditionPeriod,
                    RentAdditionPeriodNr = contractExpense.RentAdditionPeriodNr,
                    ExpenseAmount = contractExpense.ExpenseAmount,
                    ExpenseCompany = contractExpense.ExpenseCompany,
                    ExpenseCompanyLogicalRef = contractExpense.ExpenseCompanyLogicalRef,
                    ExpenseContractNo = contractExpense.ExpenseContractNo,
                    ExpenseEndDate = contractExpense.ExpenseEndDate,
                    ExpensetTypeId = contractExpense.ExpensetTypeId,
                    Responsible = contractExpense.Responsible,
                    TypeId = contractExpense.TypeId
                };

                rentContract.RentContractExpenses.Add(rentContractExpense);
            }

            return rentContract;
        }
    }
}
