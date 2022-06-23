using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class RentContractReality : BaseEntity
    {
        public int RentContractId { get; set; }
        public byte TypeId { get; set; }
        public int RealityId { get; set; }

        [Write(false)]
        public virtual RentContract RentContract { get; set; }
    }
}
