using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent.Domain.Concrete.Models.Rent;

namespace Rent.Business.Abstract
{
    public interface IInsurancePolicyService
    {
        List<InsurancePolicy> GetAll();
        List<InsurancePolicy> GetSluDataSourceAll();
        List<InsurancePolicy> GetContractId(int nId);
        InsurancePolicy GetById(int nId);
        InsurancePolicy Save(InsurancePolicy entity); 
        int MaxId();
        bool Delete(InsurancePolicy entity);
        bool Exists(InsurancePolicy entity);
        string UsedControl(InsurancePolicy entity);
        bool SuccsessOperation { get; set; }
    }
}
