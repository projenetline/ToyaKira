using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpMailHeaderLineDal : DapperHelper, IMailHeaderLineDal
    {
        public bool Delete(MailHeaderLine entity)
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

        public bool Exists(MailHeaderLine entity)
        {
            int nId = entity.Id;
            string query = "SELECT *FROM MailHeaderLines ";
            query += " WHERE IsDeleted <> 1 AND Id <> @Id AND MailHeaderId = @MailHeaderId AND MailAddress = @MailAddress ORDER BY Id ";
            return RentDb.Query<MailHeaderLine>(query, new { Id = nId, MailHeaderId = entity.MailHeaderId, MailAddress = entity.MailAddress }).Any();
        }

        public List<MailHeaderLine> GetAll()
        {
            string query = " Select * from MailHeaderLines ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<MailHeaderLine>(query).ToList();
        }

        public MailHeaderLine GetById(int nId)
        {
            string query = "select * from MailHeaderLines ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<MailHeaderLine>(query, new { Id = nId }).FirstOrDefault();
        }

        public List<MailHeaderLine> GetsByMasterId(int mailHeaderId)
        {
            string query = "SELECT *FROM MailHeaderLines ";
            query += " WHERE IsDeleted <> 1 AND MailHeaderId = @MailHeaderId ORDER BY Id ";
            return RentDb.Query<MailHeaderLine>(query, new { MailHeaderId = mailHeaderId }).ToList();
        }

        public List<MailHeaderLine> GetsByModuleId(EnumModule module)
        {
            string query = " SELECT mh.*FROM MailHeaders mh";
            query += " INNER JOIN MailHeaderLines mhl ON mh.Id = mhl.MailHeaderId";
            query += " WHERE mh.IsDeleted <> 1 AND mh.ModuleId = @ModuleId AND mhl.IsActive = 1";
            return RentDb.Query<MailHeaderLine>(query, new { ModuleId = module.GetHashCode() }).ToList();
        }

        public List<MailHeaderLine> GetSluDataSourceAll()
        {
            string query = "select Name, Id from MailHeaderLines ";
            query += " where IsDeleted <> 1 order by Id ";
            return RentDb.Query<MailHeaderLine>(query).ToList();
        }

        public MailHeaderLine Save(MailHeaderLine entity)
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

        public string UsedControl(MailHeaderLine entity)
        {
            return string.Empty;
        }
    }
}
