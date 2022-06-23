using Dapper.Contrib.Extensions;
using Rent.Domain.Abstract;
using System;

namespace Rent.Domain.Concrete
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
        [Write(false)]
        public bool IsEdit { get; set; }
    }
}
