using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpExpenseTypeDal : DapperHelper, IExpenseTypeDal
    {
        public bool Delete(ExpenseType entity)
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

        public bool Exists(ExpenseType entity)
        {
            string name = entity.Name;
            int nId = entity.Id;
            string query = "SELECT *FROM ExpenseTypes ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND Name = @Name ORDER BY Id ";
            return RentDb.Query<ExpenseType>(query, new { Id = nId, Name = name }).Any();
        }

        public List<ExpenseType> GetAll()
        {
            string query = " Select * from ExpenseTypes ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<ExpenseType>(query).ToList();
        }

        public ExpenseType GetById(int nId)
        {
            string query = "select * from ExpenseTypes ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<ExpenseType>(query, new { Id = nId }).FirstOrDefault();
        }

        public List<ExpenseType> GetsByTypeId(int typeId)
        {
            string query = "select * from ExpenseTypes ";
            query += " where IsDeleted <> 1 And TypeId = @TypeId order by Id ";
            return RentDb.Query<ExpenseType>(query, new { TypeId = typeId }).ToList();
        }

        public List<ExpenseType> GetSluDataSourceAll()
        {
            string query = "select Code, Id from ExpenseTypes ";
            query += " where IsDeleted <> 1 order by Name ";
            return RentDb.Query<ExpenseType>(query).ToList();
        }

        public ExpenseType Save(ExpenseType entity)
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

        public string UsedControl(ExpenseType entity)
        {
            return string.Empty;
        }
    }
}
