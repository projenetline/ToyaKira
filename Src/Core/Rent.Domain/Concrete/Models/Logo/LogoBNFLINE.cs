using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Logo
{
    public class LogoBNFLINE
    {
        public int LOGICALREF { get; set; }
        public int CLIENTREF { get; set; }
        public DateTime DATE_ { get; set; }
        public double AMOUNT { get; set; }
    }
}
