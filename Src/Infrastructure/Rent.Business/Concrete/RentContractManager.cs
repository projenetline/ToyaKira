using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class RentContractManager : IRentContractService
    {
        readonly IRentContractDal _rentContractDal;
        readonly IRentContractExpenseDal _rentContractExpenseDal;
        readonly IRentContractRealityDal _rentContractRealityDal;

        public RentContractManager(IRentContractDal rentContractDal, IRentContractExpenseDal rentContractExpenseDal, IRentContractRealityDal rentContractRealityDal)
        {
            _rentContractDal = rentContractDal;
            _rentContractExpenseDal = rentContractExpenseDal;
            _rentContractRealityDal = rentContractRealityDal;
        }
        public bool SuccsessOperation { get; set ; }

        public bool Delete(RentContract entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _rentContractDal.Delete(entity);
            }
        }

        public bool Exists(RentContract entity)
        {
            return _rentContractDal.Exists(entity);
        }

        public List<RentContract> GetAll()
        {
            return _rentContractDal.GetAll();
        }
        public RentContract GetById(int nId)
        {
            return _rentContractDal.GetById(nId);
        }

        public RentContract GetByIdWithDetails(int id)
        {
            var rentContract = GetById(id);
            if (rentContract != null)
            {
                var rentContractDetails = _rentContractExpenseDal.GetsByMasterId(id);
                foreach (var rentContractExpense in rentContractDetails)
                {
                    rentContract.RentContractExpenses.Add(rentContractExpense);
                }
                var rentContractRealities = _rentContractRealityDal.GetsByMasterId(id);
                foreach (var rentContractReality in rentContractRealities)
                {
                    rentContract.RentContractRealities.Add(rentContractReality);
                }
            }
            return rentContract;
        }

        public List<RentContract> GetSluDataSourceAll()
        {
            return _rentContractDal.GetSluDataSourceAll();
        }

        public RentContract Save(RentContract entity)
        {
            RentContract rentContract;
            entity.CreatedDate = DateTime.Now;
           if(entity.RentAdditionPeriodNr==0)
                entity.RentAdditionPeriodNr = 1;
           if(entity.RentPeriodNr==0)
                entity.RentPeriodNr = 1;

            rentContract = _rentContractDal.Save(entity);
            SaveRealities(rentContract);
            SaveExpenses(rentContract);
            SuccsessOperation = true;
            return rentContract;
        }
        private void SaveExpenses(RentContract entity)
        {
            if(entity != null)
            {
                foreach (var rentContractExpense in entity.RentContractExpenses)
                {
                    rentContractExpense.RentContractId = entity.Id;
                    _rentContractExpenseDal.Save(rentContractExpense);
                }
            }
        }
        private void SaveRealities(RentContract entity)
        {
            if (entity != null)
            {
                foreach (var rentContractReality in entity.RentContractRealities)
                {
                    rentContractReality.RentContractId = entity.Id;
                    _rentContractRealityDal.Save(rentContractReality);
                }
            }
        }
        public string UsedControl(RentContract entity)
        {
            return _rentContractDal.UsedControl(entity);
        }

        public List<RentContract> GetNotPaid()
        {
            return _rentContractDal.GetNotPaid();
        }
    }
}
