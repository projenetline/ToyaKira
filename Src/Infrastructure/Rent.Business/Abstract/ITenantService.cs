using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Abstract
{
    public interface ITenantService
    {
        List<Tenant> GetAll();
        List<Tenant> GetSluDataSourceAll();
        Tenant GetById(int nId);
        Tenant Save(Tenant entity);
        bool Delete(Tenant entity);
        bool Exists(Tenant entity);
        string UsedControl(Tenant entity);
        bool SuccsessOperation { get; set; }
    }
}
