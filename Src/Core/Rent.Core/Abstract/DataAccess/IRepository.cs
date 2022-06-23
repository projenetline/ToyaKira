using Rent.Domain.Abstract;
using System.Collections.Generic;

namespace Rent.Core.Abstract.DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        List<T> GetSluDataSourceAll();
        T GetById(int nId);
        T Save(T entity);
        bool Delete(T entity);
        bool Exists(T entity);
        string UsedControl(T entity);
    }
}
