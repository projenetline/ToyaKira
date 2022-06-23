using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class ExpenseTypeManager : IExpenseTypeService
    {
        IExpenseTypeDal _ExpenseTypeDal;
        public ExpenseTypeManager(IExpenseTypeDal ExpenseTypeDal)
        {
            _ExpenseTypeDal = ExpenseTypeDal;
        }
        public bool SuccsessOperation { get; set ; }

        public bool Delete(ExpenseType entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _ExpenseTypeDal.Delete(entity);
            }
        }

        public bool Exists(ExpenseType entity)
        {
            return _ExpenseTypeDal.Exists(entity);
        }

        public List<ExpenseType> GetAll()
        {
            return _ExpenseTypeDal.GetAll();
        }

        public ExpenseType GetById(int nId)
        {
            return _ExpenseTypeDal.GetById(nId);
        }

        public List<ExpenseType> GetsByTypeId(int typeId)
        {
            return _ExpenseTypeDal.GetsByTypeId(typeId);
        }

        public List<ExpenseType> GetSluDataSourceAll()
        {
            return _ExpenseTypeDal.GetSluDataSourceAll();
        }

        public ExpenseType Save(ExpenseType entity)
        {
            ExpenseType ExpenseType;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                ExpenseType = _ExpenseTypeDal.Save(entity);
                SuccsessOperation = true;
                return ExpenseType;
            }
        }

        public string UsedControl(ExpenseType entity)
        {
            return _ExpenseTypeDal.UsedControl(entity);
        }
    }
}
