using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public partial class WinFormProperty : BaseEntity
    {
        public Int32 UserId { get; set; }
        public string DefaultSkinName { get; set; }
        public string ImagePath
        {
            get; set;
        }
    }
}
