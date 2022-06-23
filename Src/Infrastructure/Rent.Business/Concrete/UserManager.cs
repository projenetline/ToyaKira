using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public bool SuccsessOperation { get; set ; }

        public bool Delete(User entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _userDal.Delete(entity);
            }
        }

        public bool Exists(User entity)
        {
            return _userDal.Exists(entity);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int nId)
        {
            return _userDal.GetById(nId);
        }

        public User GetBy_UsrName_Pass(string userName, string password)
        {
            return _userDal.GetBy_UsrName_Pass(userName, password);
        }

        public List<User> GetSluDataSourceAll()
        {
            return _userDal.GetSluDataSourceAll();
        }

        public User Save(User entity)
        {
            User user;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                user = _userDal.Save(entity);
                SuccsessOperation = true;
                return user;
            }
        }

        public string UsedControl(User entity)
        {
            return _userDal.UsedControl(entity);
        }
    }
}
