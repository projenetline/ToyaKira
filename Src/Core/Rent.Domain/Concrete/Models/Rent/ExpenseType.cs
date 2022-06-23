using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class ExpenseType : BaseEntity
    {
        public byte TypeId { get; set; }
        public int LogoFirmNo { get; set; }
        public int LogoLogicalRef { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Responsible { get; set; }
    }
}
