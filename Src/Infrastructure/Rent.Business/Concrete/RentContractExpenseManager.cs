using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class RentContractExpenseManager : IRentContractExpenseService
    {
        IRentContractExpenseDal _rentContractExpenseDal;
        public RentContractExpenseManager(IRentContractExpenseDal RentContractExpenseDal)
        {
            _rentContractExpenseDal = RentContractExpenseDal;
        }
        public bool SuccsessOperation { get; set; }
        public bool Delete(RentContractExpense entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _rentContractExpenseDal.Delete(entity);
            }
        }
        public bool Exists(RentContractExpense entity)
        {
            return _rentContractExpenseDal.Exists(entity);
        }
        public List<RentContractExpense> GetAll()
        {
            return _rentContractExpenseDal.GetAll();
        }
        public RentContractExpense GetById(int nId)
        {
            return _rentContractExpenseDal.GetById(nId);
        }
        public List<RentContractExpense> GetsByMasterId(int rentContractId)
        {
            return _rentContractExpenseDal.GetsByMasterId(rentContractId);
        }
        public List<RentContractExpense> GetsByMasterIdExpenseTypeId(int rentContractId, int expenseTypeId)
        {
            return _rentContractExpenseDal.GetsByMasterIdExpenseTypeId(rentContractId, expenseTypeId);
        }
        public List<RentContractExpense> GetSluDataSourceAll()
        {
            return _rentContractExpenseDal.GetSluDataSourceAll();
        }
        public List<RentContractExpense> GetsOverAndNearPaid()
        {
            return _rentContractExpenseDal.GetsOverAndNearPaid(); 
        }
        public List<RentContractExpense> GetsOverPaid()
        {
            return _rentContractExpenseDal.GetsOverPaid();
        }
        public List<RentContractExpense> GetsPaymentIsNear()
        {
            return _rentContractExpenseDal.GetsPaymentIsNear();
        }
        public RentContractExpense Save(RentContractExpense entity)
        {
            RentContractExpense RentContractExpense;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                RentContractExpense = _rentContractExpenseDal.Save(entity);
                SuccsessOperation = true;
                return RentContractExpense;
            }
        }
        public string UsedControl(RentContractExpense entity)
        {
            return _rentContractExpenseDal.UsedControl(entity);
        }
    }
}