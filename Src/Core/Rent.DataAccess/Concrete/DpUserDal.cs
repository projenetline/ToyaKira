using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpUserDal : DapperHelper, IUserDal
    {
        public bool Delete(User entity)
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

        public bool Exists(User entity)
        {
            string userName = entity.UserName;
            int nId = entity.Id;
            string query = "SELECT *FROM Users ";
            query += " WHERE IsDeleted <> 1 AND Id<>@Id AND UserName = @UserName ORDER BY Id ";
            return RentDb.Query<User>(query, new { Id = nId, UserName = userName }).Any();
        }

        public List<User> GetAll()
        {
            string query = " Select * from Users ";
            query += "where IsDeleted <> 1";
            return RentDb.Query<User>(query).ToList();
        }

        public User GetById(int nId)
        {
            string query = "select * from Users ";
            query += " where IsDeleted <> 1 And Id = @Id order by Id ";
            return RentDb.Query<User>(query, new { Id = nId }).FirstOrDefault();
        }

        public List<User> GetSluDataSourceAll()
        {
            string query = "select UserName, Id from Users ";
            query += " where IsDeleted <> 1 order by UserName ";
            return RentDb.Query<User>(query).ToList();
        }

        public User Save(User entity)
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

        public string UsedControl(User entity)
        {
            return string.Empty;
        }

        public User GetBy_UsrName_Pass(string userName, string password)
        {
            string query = "SELECT * FROM Users ";
            query += " WHERE IsDeleted <> 1 AND UserName = @UserName AND Password = @Password";
            query += " ORDER BY Id ";

            return RentDb.Query<User>(query, new { UserName = userName, Password = password }).FirstOrDefault();
        }
    }
}
