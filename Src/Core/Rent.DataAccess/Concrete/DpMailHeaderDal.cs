using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpMailHeaderDal : DapperHelper, IMailHeaderDal
    {
        public bool Delete(MailHeader entity)
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

        public bool Exists(MailHeader entity)
        {
            byte moduleId = entity.ModuleId;
            int nId = entity.Id;
            string query = "SELECT *FROM MailHeaders ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND ModuleId = @ModuleId ORDER BY Id ";
            return RentDb.Query<MailHeader>(query, new { Id = nId, ModuleId = moduleId }).Any();
        }

        public List<MailHeader> GetAll()
        {
            string query = " Select * from MailHeaders ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<MailHeader>(query).ToList();
        }

        public MailHeader GetById(int nId)
        {
            string query = "select * from MailHeaders ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<MailHeader>(query, new { Id = nId }).FirstOrDefault();
        }
        public List<MailHeader> GetSluDataSourceAll()
        {
            string query = "select Name, Id from MailHeaders ";
            query += " where IsDeleted <> 1 order by ModuleId ";
            return RentDb.Query<MailHeader>(query).ToList();
        }

        public MailHeader Save(MailHeader entity)
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

        public string UsedControl(MailHeader entity)
        {
            return string.Empty;
        }
    }
}
