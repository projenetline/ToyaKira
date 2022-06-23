using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpRentContractExpenseDal : DapperHelper, IRentContractExpenseDal
    {
        public bool Delete(RentContractExpense entity)
        {
            bool result = false;
            if (entity.Id <= 0)
            {
                result = RentDb.Delete(entity);
            }
            else
            {
                result = RentDb.Update(entity);
            }
            return result;
        }
        public bool Exists(RentContractExpense entity)
        {
            int expenseId = entity.ExpensetTypeId;
            int nId = entity.Id;
            int contractId = entity.RentContractId;

            string query = "SELECT *FROM RentContractExpenses ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND RentContractId = @RentContractId AND ExpenseId = @ExpenseId ORDER BY Id ";
            return RentDb.Query<RentContractExpense>(query, new { Id = nId, RentContractId = contractId, ExpenseId = expenseId }).Any();
        }
        public List<RentContractExpense> GetAll()
        {
            string query = " Select * from RentContractExpenses ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<RentContractExpense>(query).ToList();
        }
        public RentContractExpense GetById(int nId)
        {
            string query = "select * from RentContractExpenses ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<RentContractExpense>(query, new { Id = nId }).FirstOrDefault();
        }
        public List<RentContractExpense> GetsByMasterId(int rentContractId)
        {
            string query = "SELECT *FROM RentContractExpenses ";
            query += " WHERE IsDeleted <> 1 AND RentContractId = @RentContractId ORDER BY Id ";
            return RentDb.Query<RentContractExpense>(query, new { RentContractId = rentContractId }).ToList();
        }
        public List<RentContractExpense> GetsByMasterIdExpenseTypeId(int rentContractId, int expenseTypeId)
        {
            string query = "SELECT *FROM RentContractExpenses ";
            query += " WHERE IsDeleted <> 1 AND RentContractId = @RentContractId AND TypeId = @TypeId ORDER BY Id ";
            return RentDb.Query<RentContractExpense>(query, new { RentContractId = rentContractId, TypeId = expenseTypeId }).ToList();
        }
        public List<RentContractExpense> GetSluDataSourceAll()
        {
            string query = "select Name, Id from RentContractExpenses ";
            query += " where IsDeleted <> 1 order by Id ";
            return RentDb.Query<RentContractExpense>(query).ToList();
        }

        public List<RentContractExpense> GetsOverAndNearPaid()
        {
            throw new System.NotImplementedException();
        }

        public List<RentContractExpense> GetsOverPaid()
        {
            throw new System.NotImplementedException();
        }

        public List<RentContractExpense> GetsPaymentIsNear()
        {
            throw new System.NotImplementedException();
        }

        public RentContractExpense Save(RentContractExpense entity)
        {
            if (entity.IsEdit)
            {
                if (entity.Id <= 0 && !entity.IsDeleted)
                {
                    long Id = RentDb.Insert(entity);
                    entity.Id = (int)Id;
                }
                else
                {
                    if (entity.IsEdit)
                    {
                        RentDb.Update(entity);
                    }
                }
            }
            return entity;
        }
        public string UsedControl(RentContractExpense entity)
        {
            return string.Empty;
        }
    }
}
