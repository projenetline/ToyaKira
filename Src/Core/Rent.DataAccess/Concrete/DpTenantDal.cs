using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpTenantDal : DapperHelper, ITenantDal
    {
        public bool Delete(Tenant entity)
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

        public bool Exists(Tenant entity)
        {
            string identityNo = entity.IdentityNo;
            int nId = entity.Id;
            string query = "SELECT *FROM Tenants ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND IdentityNo = @IdentityNo ORDER BY Id ";
            return RentDb.Query<Tenant>(query, new { Id = nId, IdentityNo = identityNo }).Any();
        }

        public List<Tenant> GetAll()
        {
            string query = " Select * from Tenants ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<Tenant>(query).ToList();
        }

        public Tenant GetById(int nId)
        {
            string query = "select * from Tenants ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<Tenant>(query, new { Id = nId }).FirstOrDefault();
        }

        public List<Tenant> GetSluDataSourceAll()
        {
            string query = "select Name, Id from Tenants ";
            query += " where IsDeleted <> 1 order by Name ";
            return RentDb.Query<Tenant>(query).ToList();
        }

        public Tenant Save(Tenant entity)
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

        public string UsedControl(Tenant entity)
        {
            return string.Empty;
        }
    }
}
