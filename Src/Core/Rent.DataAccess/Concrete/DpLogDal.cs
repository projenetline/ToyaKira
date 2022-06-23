using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rent.DataAccess.Concrete
{
    public class DpLogDal : DapperHelper, ILogDal
    {
        public bool Delete(LogModel entity)
        {
            entity.IsDeleted = true;
            return RentDb.Update(entity);
        }
        public bool Exists(LogModel entity)
        {
            return false;
        }
        public List<LogModel> GetAll()
        {
            string cSql = "SELECT *FROM IntegrationLogs WHERE Deleted <> 'true'";
            return RentDb.Query<LogModel>(cSql).ToList();
        }
        public LogModel GetById(int nId)
        {
            string cSql = "SELECT *FROM IntegrationLogs WHERE Id = @Id";
            return RentDb.Query<LogModel>(cSql, new { Id = nId }).FirstOrDefault();
        }
        public List<LogModel> GetSluDataSourceAll()
        {
            string cSql = "SELECT *FROM IntegrationLogs WHERE Deleted <> 'true'";
            return RentDb.Query<LogModel>(cSql).ToList();
        }
        public LogModel Save(LogModel entity)
        {
            if (entity.Id <= 0 && !entity.IsDeleted)
            {
                long id = RentDb.Insert(entity);
                entity.Id = (int)id;
            }
            else
            {
                if (entity.IsEdit)
                {
                    RentDb.Update(entity);
                }
            }
            return entity;
        }
        public string UsedControl(LogModel entity)
        {
            return string.Empty;
        }
    }
}
