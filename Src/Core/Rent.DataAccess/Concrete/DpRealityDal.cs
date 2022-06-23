using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpRealityDal : DapperHelper, IRealityDal
    {
        public bool Delete(Reality entity)
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

        public bool Exists(Reality entity)
        {
            string code = entity.Code;
            int nId = entity.Id;
            string query = "SELECT *FROM Realities ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND Code = @Code ORDER BY Id ";
            return RentDb.Query<Reality>(query, new { Id = nId, Code = code }).Any();
        }

        public List<Reality> GetAll()
        {
            string query = " Select * from Realities ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<Reality>(query).ToList();
        }

        public Reality GetById(int nId)
        {
            string query = "select * from Realities ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<Reality>(query, new { Id = nId }).FirstOrDefault();
        }

        public List<Reality> GetsByTypeId(int typeId)
        {
            string query = "select * from Realities ";
            query += " where IsDeleted <> 1 And TypeId = @TypeId order by Id ";
            return RentDb.Query<Reality>(query, new { TypeId = typeId }).ToList();
        }
        public List<Reality> GetSluDataSourceAll()
        {
            string query = "select Code, Id from Realities ";
            query += " where IsDeleted <> 1 order by Code ";
            return RentDb.Query<Reality>(query).ToList();
        }

        public Reality Save(Reality entity)
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

        public string UsedControl(Reality entity)
        {
            return string.Empty;
        }
    }
}
