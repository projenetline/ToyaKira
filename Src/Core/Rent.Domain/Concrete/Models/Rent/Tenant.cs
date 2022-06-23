using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class Tenant : BaseEntity
    {
        public int LogoFirmNo { get; set; }
        public int LogoLogicalRef { get; set; }
        public string Name { get; set; }
        public string IdentityNo { get; set; }
        public string Address { get; set; }
        public string BankAccountNo { get; set; }
        public string BankIBanNumber { get; set; }
    }
}
