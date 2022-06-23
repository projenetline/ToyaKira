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
    public class DpWinFormLayoutDal : DapperHelper, IWinFormLayoutDal
    {
        public bool Delete(WinFormLayout entity)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAllLayouts()
        {
            string query = " Delete from WinFormLayouts ";
            var result = RentDb.Execute(query);
            return result > 0;
        }
        public bool DeleteUserLayouts(int nUserId)
        {
            string query = " Delete from WinFormLayouts ";
            query += "where UserId = @UserId";
            var result = RentDb.Execute(query, new { UserId = nUserId });
            return result > 0;
        }

        public bool Exists(WinFormLayout entity)
        {
            throw new NotImplementedException();
        }
        public List<WinFormLayout> GetAll()
        {
            throw new NotImplementedException();
        }
        public WinFormLayout GetById(int nId)
        {
            throw new NotImplementedException();
        }
        public List<WinFormLayout> GetSluDataSourceAll()
        {
            throw new NotImplementedException();
        }

        public WinFormLayout GetWinLayoutBy_UserId_WitFormName(int nUserId, string cFormName)
        {
            string query = "SELECT * FROM WinFormLayouts ";
            query += " WHERE IsDeleted <> 1 AND UserId=@UserId AND Name = @Name ORDER BY Id ";
            return RentDb.Query<WinFormLayout>(query, new { UserId = nUserId, Name = cFormName }).FirstOrDefault();
        }

        public WinFormLayout GetWinLayoutBy_UserId_WithoutFormName(int nUserId)
        {
            string query = "SELECT * FROM WinFormLayouts ";
            query += " WHERE IsDeleted <> 1 AND UserId=@UserId ORDER BY Id ";
            return RentDb.Query<WinFormLayout>(query, new { UserId = nUserId }).FirstOrDefault();
        }
        public WinFormLayout Save(WinFormLayout entity)
        {
            if (entity.Id <= 0)
            {
                long Id = RentDb.Insert(entity);
                entity.Id = (int)Id;
                return entity;
            }
            else
            {
                RentDb.Update(entity);
                return entity;
            }
        }
        public string UsedControl(WinFormLayout entity)
        {
            throw new NotImplementedException();
        }
    }
}
