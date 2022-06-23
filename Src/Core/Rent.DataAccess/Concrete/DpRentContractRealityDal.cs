using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpRentContractRealityDal : DapperHelper, IRentContractRealityDal
    {
        public bool Delete(RentContractReality entity)
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

        public bool Exists(RentContractReality entity)
        {
            int RealityId = entity.RealityId;
            int nId = entity.Id;
            int contractId = entity.RentContractId;

            string query = "SELECT *FROM RentContractRealities ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND RentContractId = @RentContractId AND RealityId = @RealityId ORDER BY Id ";
            return RentDb.Query<RentContractReality>(query, new { Id = nId, RentContractId = contractId, RealityId = RealityId }).Any();
        }

        public List<RentContractReality> GetAll()
        {
            string query = " Select * from RentContractRealities ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<RentContractReality>(query).ToList();
        }

        public RentContractReality GetById(int nId)
        {
            string query = "select * from RentContractRealities ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<RentContractReality>(query, new { Id = nId }).FirstOrDefault();
        }

        public List<RentContractReality> GetsByMasterId(int rentContractId)
        {
            string query = "SELECT *FROM RentContractRealities ";
            query += " WHERE IsDeleted <> 1 AND RentContractId = @RentContractId ORDER BY Id ";
            return RentDb.Query<RentContractReality>(query, new {RentContractId = rentContractId }).ToList();
        }

        public List<RentContractReality> GetsByMasterIdRealityTypeId(int rentContractId, int realityId)
        {
            string query = "SELECT *FROM RentContractRealities ";
            query += " WHERE IsDeleted <> 1 AND RentContractId  = @RentContractId AND RealityId = @RealityId ORDER BY Id ";
            return RentDb.Query<RentContractReality>(query, new { RentContractId = rentContractId, RealityId = realityId }).ToList();
        }

        public List<RentContractReality> GetSluDataSourceAll()
        {
            string query = "select Name, Id from RentContractRealities ";
            query += " where IsDeleted <> 1 order by Id ";
            return RentDb.Query<RentContractReality>(query).ToList();
        }

        public RentContractReality Save(RentContractReality entity)
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

        public string UsedControl(RentContractReality entity)
        {
            return string.Empty;
        }
    }
}
