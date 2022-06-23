using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetSluDataSourceAll();
        User GetById(int nId);
        User Save(User entity);
        bool Delete(User entity);
        User GetBy_UsrName_Pass(string userName, string password);
        bool Exists(User entity);
        string UsedControl(User entity);
        bool SuccsessOperation { get; set; }
    }
}
