using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IRentContractService
    {
        List<RentContract> GetAll();
        List<RentContract> GetNotPaid();
        List<RentContract> GetSluDataSourceAll();
        RentContract GetById(int nId);
        RentContract GetByIdWithDetails(int nId);
        RentContract Save(RentContract entity);
        bool Delete(RentContract entity);
        bool Exists(RentContract entity);
        string UsedControl(RentContract entity);
        bool SuccsessOperation { get; set; }
    }
}
