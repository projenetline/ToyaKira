using Dapper.Contrib.Extensions;
using System;

namespace Rent.Domain.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime? CreatedDate { get; set; }
        int CreatedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        int ModifiedBy { get; set; }
        DateTime? DeletedDate { get; set; }
        int DeletedBy { get; set; }
        bool IsDeleted { get; set; }
        bool IsEdit { get; set; }
    }
}
