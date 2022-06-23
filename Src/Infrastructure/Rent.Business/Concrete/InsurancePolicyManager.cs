using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Concrete
{
    public class InsurancePolicyManager : IInsurancePolicyService
    {
        IInsurancePolicyDal _insurancePolicyDal;
        public InsurancePolicyManager(IInsurancePolicyDal insurencePolicyDal)
        {
            _insurancePolicyDal = insurencePolicyDal;
        }
        public bool SuccsessOperation { get; set; }

        public bool Delete(InsurancePolicy entity)
        {
            string message = UsedControl(entity);
            if (!string.IsNullOrEmpty(message))
            {
                return false;
            }
            else
            {
                return _insurancePolicyDal.Delete(entity);
            }
        }

        public bool Exists(InsurancePolicy entity)
        {
            return _insurancePolicyDal.Exists(entity);
        }

        public List<InsurancePolicy> GetAll()
        {
            return _insurancePolicyDal.GetAll();
        }

        public InsurancePolicy GetById(int nId)
        {
            return _insurancePolicyDal.GetById(nId);
        }

        public List<InsurancePolicy> GetContractId(int nId)
        {
           return _insurancePolicyDal.GetContractId(nId);
        }

        public List<InsurancePolicy> GetSluDataSourceAll()
        {
            return _insurancePolicyDal.GetSluDataSourceAll();
        }

        public int MaxId()
        {
           return _insurancePolicyDal.MaxId();
        }

        public InsurancePolicy Save(InsurancePolicy entity)
        {
            InsurancePolicy insurancePolicy;
            if (Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                insurancePolicy = _insurancePolicyDal.Save(entity);
                SuccsessOperation = true;
                return insurancePolicy;
            }
        }
        public string UsedControl(InsurancePolicy entity)
        {
            return _insurancePolicyDal.UsedControl(entity);
        }
    }
}
