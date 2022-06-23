using Rent.Core.Abstract.DataAccess;
using Rent.Core.Concrete.Helpers;
using Rent.DataAccess.Abstract;
using System;

namespace Rent.DataAccess.Concrete
{
    public class DpDbInitiliazer : DapperHelper, IDbInitiliazerDal
    {
        IUserDal _userDal;
        public DpDbInitiliazer(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void AddDefaultUser()
        {
            var defaultUser = _userDal.GetBy_UsrName_Pass("Admin", SessionHelper.GetEncrypt("Admin"));
            if(defaultUser == null)
            {
                defaultUser = new Domain.Concrete.Models.Rent.User
                {
                    CreatedDate = DateTime.Now,
                    IsEdit = true,
                    IsDeleted = false,
                    UserName = "Admin",
                    Password = SessionHelper.GetEncrypt("Admin")
                };
                _userDal.Save(defaultUser);
            }
        }
    }
}
