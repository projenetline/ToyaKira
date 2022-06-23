using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpWinFormPropertyDal : DapperHelper, IWinFormPropertyDal
    {
        public bool Delete(WinFormProperty entity) 
        {
            bool result = false;
            if (entity.Id <= 0)
            {
                entity.IsDeleted = false;
                entity.DeletedDate = DateTime.Now;

                result = RentDb.Delete(entity);
            }
            else
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                result = RentDb.Update(entity);
            }
            return result; 
        }
        public bool Exists(WinFormProperty entity)
        {
            string query = "SELECT *FROM WinFormProperties ";
            query += " WHERE IsDeleted <> 1 AND Id <> @Id UserId = @UserId ORDER BY Id ";
            return RentDb.Query<WinFormProperty>(query, new { Id = entity.Id, UserId = entity.UserId }).Any();
        }
        public string UsedControl(WinFormProperty entity)
        {
            throw new NotImplementedException();
        }
        public WinFormProperty Get_WinFormProperty_By_UserId(int nUserId)
        {
            string query = "select * from WinFormProperties ";
            query += " where IsDeleted <> 1 and UserId=@UserId order by Id ";
            return RentDb.Query<WinFormProperty>(query, new { UserId = nUserId }).FirstOrDefault();
        }

        public List<WinFormProperty> GetAll()
        {
            string query = "SELECT * FROM WinFormProperties ";
            query += "WHERE IsDeleted <> 1";
            return RentDb.Query<WinFormProperty>(query).ToList();
        }
        public WinFormProperty GetById(int nId)
        {
            string query = "SELECT * FROM WinFormProperties ";
            query += "WHERE IsDeleted <> 1 AND Id = @Id ORDER BY Id ";
            return RentDb.Query<WinFormProperty>(query, new { Id = nId }).FirstOrDefault();
        }
        public List<WinFormProperty> GetSluDataSourceAll()
        {
            string query = "SELECT * FROM WinFormProperties ";
            query += "WHERE IsDeleted <> 1 ORDER BY Id ";
            return RentDb.Query<WinFormProperty>(query).ToList();
        }
        public List<WinFormProperty> GetSluDataSourceAllWithoutAll()
        {
            string query = "SELECT * FROM WinFormProperties ";
            query += "WHERE IsDeleted <> 1 AND Id <> 1 ORDER BY Id ";
            return RentDb.Query<WinFormProperty>(query).ToList();
        }
        public List<WinFormProperty> GetSluDataSourceById(int nId)
        {
            string query = "SELECT * FROM WinFormProperties ";
            query += "WHERE IsDeleted <> 1 AND Id = @Id ORDER BY Id ";
            return RentDb.Query<WinFormProperty>(query, new { Id = nId }).ToList();
        }
        public WinFormProperty Save(WinFormProperty entity)
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
        public string UsedControl(int nId)
        {

            return null;
        }
    }
}
