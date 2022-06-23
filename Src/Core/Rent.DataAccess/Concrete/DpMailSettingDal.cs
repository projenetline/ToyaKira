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
    public class DpMailSettingDal : DapperHelper, IMailSettingDal
    {
        public bool Delete(MailSetting entity)
        {
            entity.IsDeleted = true;
            return RentDb.Update(entity);
        }

        public bool Exists(MailSetting entity)
        {
            return false;
        }

        public List<MailSetting> GetAll()
        {
            string sql = " SELECT *FROM MailSettings WHERE IsDeleted <>'true' ";
            return RentDb.Query<MailSetting>(sql).ToList();
        }

        public MailSetting GetById(int nId)
        {
            string sql = " SELECT *FROM MailSettings WHERE Id = @Id  AND  IsDeleted <> 'true' ";
            return RentDb.Query<MailSetting>(sql, new { Id = nId }).FirstOrDefault();
        }


        public List<MailSetting> GetSluDataSourceAll()
        {
            string sql = " SELECT *FROM MailSettings WHERE IsDeleted <>'true' ";
            return RentDb.Query<MailSetting>(sql).ToList();
        }

        public MailSetting Save(MailSetting entity)
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

        public string UsedControl(MailSetting entity)
        {
            return string.Empty;
        }
    }
}
