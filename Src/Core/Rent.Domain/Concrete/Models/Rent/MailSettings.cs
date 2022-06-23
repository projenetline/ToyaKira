using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class MailSetting : BaseEntity
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string MailAddress { get; set; }
        public string SmtpServer { get; set; }
        public string ServerPortName { get; set; }
    }
}
