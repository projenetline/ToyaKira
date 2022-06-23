using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.DataAccess.Concrete
{
    public class DpInsurancePolicyDal : DapperHelper, IInsurancePolicyDal
    {
        public bool Delete(InsurancePolicy entity)
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
        public bool Exists(InsurancePolicy entity)
        {
            string query = "SELECT *FROM InsurancePolicys ";
            query += " WHERE IsDeleted <> 1 AND Id <> @Id  ORDER BY Id ";
            return RentDb.Query<InsurancePolicy>(query, new { Id = entity.Id }).Any();
        }
        public List<InsurancePolicy> GetAll()
        {
            string query = " Select * from InsurancePolicys ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<InsurancePolicy>(query).ToList();
        }
        public List<InsurancePolicy> GetContractId(int nId)
        {
            string query = "select* from InsurancePolicys  ";
            query += "  where RentContractId = @RentContractId";
            return RentDb.Query<InsurancePolicy>(query, new { RentContractId = nId }).ToList();
        }
        public InsurancePolicy GetById(int nId)
        {
            string query = " Select * from InsurancePolicys ";
            query += "where IsDeleted <> 1 and Id=@Id";
            return RentDb.Query<InsurancePolicy>(query, new { Id = nId }).FirstOrDefault();
        }
        public List<InsurancePolicy> GetSluDataSourceAll()
        {
            string query = " Select * from InsurancePolicys ";
            query += "where IsDeleted <> 1 order by Id";
            return RentDb.Query<InsurancePolicy>(query).ToList();
        }
        public InsurancePolicy Save(InsurancePolicy entity)
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
        public string UsedControl(InsurancePolicy entity)
        {
            return string.Empty;
        }

        public int MaxId()
        {
            string query = "  select* from InsurancePolicys cl ";
            query += "where cl.Id = (select Max(Id) from InsurancePolicys)";
            InsurancePolicy policy = RentDb.Query<InsurancePolicy>(query).FirstOrDefault();
            return policy==null ? 0:policy.Id;
        }
    }
}
