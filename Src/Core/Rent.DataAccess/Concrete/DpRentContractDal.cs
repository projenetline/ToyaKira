using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpRentContractDal : DapperHelper, IRentContractDal
    {
        public bool Delete(RentContract entity)
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

        public bool Exists(RentContract entity)
        {
            string contractNo = entity.ContactNo;
            int nId = entity.Id;
            string query = "SELECT *FROM RentContracts ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND ContactNo = @ContactNo ORDER BY Id ";
            return RentDb.Query<RentContract>(query, new { Id = nId, ContactNo = contractNo }).Any();
        }
        public List<RentContract> GetAll()
        {
            string query = " Select * from RentContracts ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<RentContract>(query).ToList();
        }
        public RentContract GetById(int nId)
        {
            string query = "select * from RentContracts ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<RentContract>(query, new { Id = nId }).FirstOrDefault();
        }
        public List<RentContract> GetSluDataSourceAll()
        {
            string query = "select Name, Id from RentContracts ";
            query += " where IsDeleted <> 1 order by ContactNo ";
            return RentDb.Query<RentContract>(query).ToList();
        }
        public List<RentContract> GetNotPaid()
        {
            string query = " Select * from RentContracts ";
            query += "  where IsDeleted<>1   and IsPaid =0";
            return RentDb.Query<RentContract>(query).ToList();
        }
        public List<RentContract> GetsOverAndNearPaid()
        {
            string query = " Select * from RentContracts ";
            query += "  where IsDeleted<>1 and DATEDIFF(DAY, GETDATE(), ExpenseEndDate)<15  and IsPaid =0";
            return RentDb.Query<RentContract>(query).ToList();
        }
        public List<RentContract> GetsOverPaid()
        {
            string query = " Select * from RentContracts ";
            query += " where IsDeleted<>1 and DATEDIFF(DAY, GETDATE(), ExpenseEndDate)<0 and IsPaid =0";
            return RentDb.Query<RentContract>(query).ToList();
        }
        public List<RentContract> GetsPaymentIsNear()
        {
            string query = " Select * from RentContracts ";
            query += " where IsDeleted<>1 and DATEDIFF(DAY, GETDATE(), ExpenseEndDate)<15 and DATEDIFF(DAY, GETDATE(), ExpenseEndDate)>0 and IsPaid =0";
            return RentDb.Query<RentContract>(query).ToList();
        }
        public RentContract Save(RentContract entity)
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
        public string UsedControl(RentContract entity)
        {
            return string.Empty;
        }
    }
}
