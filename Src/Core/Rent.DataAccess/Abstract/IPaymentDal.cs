using Rent.Core.Abstract.DataAccess;
using Rent.Domain.Abstract;
using Rent.Domain.Concrete.Models.Logo;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.DataAccess.Abstract
{
    public interface IPaymentDal
    {
        List<LogoBNFLINE> Get_BNF(int firmNo, int donem , int logicalRef);
        List<LogoDataModel> Get_Firms();
        InsurancePolicy Save(InsurancePolicy entity);
        void LogService(string info, int status);
        string LogServiceErr(string content);
    }
}
