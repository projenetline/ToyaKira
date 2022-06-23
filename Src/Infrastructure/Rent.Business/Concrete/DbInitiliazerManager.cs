using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Concrete
{
    public class DbInitiliazerManager : IDbInitiliazerService
    {
        IDbInitiliazerDal _dbInitiliazerDal;
        public DbInitiliazerManager(IDbInitiliazerDal dbInitiliazerDal)
        {
            _dbInitiliazerDal = dbInitiliazerDal;
        }
        public void AddDefaultUser()
        {
            _dbInitiliazerDal.AddDefaultUser(); 
        }
    }
}
