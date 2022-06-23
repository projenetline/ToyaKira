using Dapper.Contrib.Extensions;

namespace Rent.Domain.Abstract
{
    public interface ILogoEntity
    {
        [Key]
        int LOGREF { get; set; }
    }
}
