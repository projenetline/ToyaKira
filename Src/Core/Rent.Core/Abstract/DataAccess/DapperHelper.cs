using Rent.Core.Concrete.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace Rent.Core.Abstract.DataAccess
{
    public class DapperHelper
    {
        protected IDbConnection RentDb
        {
            get
            {
                return new SqlConnection(DbHelper.ConnectionString);
            }
        }
        protected IDbConnection LogoDb
        {
            get
            {
                return new SqlConnection(DbHelper.LogoConnectionString);
            }
        }
    }
}
