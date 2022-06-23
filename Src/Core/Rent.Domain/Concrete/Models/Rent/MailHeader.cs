using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class MailHeader : BaseEntity
    {
        public MailHeader()
        {
            this.MailHeaderLines = new HashSet<MailHeaderLine>();
        }
        public byte ModuleId { get; set; }
        public bool IsActive { get; set; }
        [Write(false)]
        public ICollection<MailHeaderLine> MailHeaderLines { get; set; }
    }
}
