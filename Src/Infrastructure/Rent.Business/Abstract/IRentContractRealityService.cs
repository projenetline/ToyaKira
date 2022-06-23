using Rent.Domain.Concrete.Models.Rent;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface IRentContractRealityService
    {
        List<RentContractReality> GetAll();
        List<RentContractReality> GetSluDataSourceAll();
        RentContractReality GetById(int nId);
        List<RentContractReality> GetsByMasterId(int rentContractId);
        RentContractReality Save(RentContractReality entity);
        bool Delete(RentContractReality entity);
        bool Exists(RentContractReality entity);
        string UsedControl(RentContractReality entity);
        bool SuccsessOperation { get; set; }
    }
}
