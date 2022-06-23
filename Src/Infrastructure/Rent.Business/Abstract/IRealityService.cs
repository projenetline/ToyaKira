using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IRealityService
    {
        List<Reality> GetAll();
        List<Reality> GetSluDataSourceAll();
        Reality GetById(int nId);
        Reality Save(Reality entity);
        bool Delete(Reality entity);
        bool Exists(Reality entity);
        string UsedControl(Reality entity);
        bool SuccsessOperation { get; set; }
        List<Reality> GetsByTypeId(int typeId);
    }
}
