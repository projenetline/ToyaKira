using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public class InsurancePolicy:BaseEntity
    {
        public  int LOGICALREF { get; set; }
        public int RentContractId { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PaymentEndDate { get; set; }
        public double Amount { get; set; }
        public bool IsActive { get; set; }
        public bool IsPaid { get; set; }

        [Write(false)]
        public double Paid { get; set; }

        [Write(false)]
        public string Statu
        {
            get
            {
                if (IsPaid)
                    return $"{PaymentDate.ToShortDateString()} tarihin de ödendi";
                if ((PaymentEndDate - DateTime.Now.Date).TotalDays < 15 && (PaymentEndDate - DateTime.Now.Date).TotalDays > 0)
                    return $"Ödeme Tarihine { (PaymentEndDate - DateTime.Now.Date).TotalDays} gün kaldı";
                if(PaymentEndDate > DateTime.Now.Date)
                        return $"Ödenme tarihi { (DateTime.Now.Date - PaymentEndDate).TotalDays} gün gecikti";
                return "Ödenmedi!";
            }
        }
        [Write(false)]
        public virtual RentContract RentContract { get; set; }
    }
}
