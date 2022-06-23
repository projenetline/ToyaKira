using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class MailHeaderLine : BaseEntity
    {
        public int MailHeaderId { get; set; }
        public string DisplayName { get; set; }
        public string MailAddress { get; set; }
        public bool IsActive { get; set; }
        [Write(false)]
        public virtual MailHeader MailHeader  { get;set;}
    }
}
