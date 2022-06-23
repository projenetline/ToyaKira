using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class LogModel:BaseEntity
    {
        public int StatusId { get; set; }
        public string Description { get; set; }
    }
}
