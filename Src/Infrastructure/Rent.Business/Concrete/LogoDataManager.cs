using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Logo;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class LogoDataManager : ILogoDataService
    {
        private readonly ILogoDataDal _logoDataDal;

        public LogoDataManager(ILogoDataDal logoDataDal)
        {
            _logoDataDal = logoDataDal;
        }

        public List<LogoDataModel> Get_All_ClCards()
        {
            return _logoDataDal.Get_All_ClCards();
        }

        public List<LogoDataModel> Get_All_Items()
        {
            return _logoDataDal.Get_All_Items();
        }

        public LogoDataModel Get_ClCardInformation(int logicalREF)
        {
            return _logoDataDal.Get_ClCardInformation(logicalREF);
        }

        public LogoDataModel Get_ClCardInformation(int firmNo, int logicalREF)
        {
            return _logoDataDal.Get_ClCardInformation(firmNo, logicalREF);
        }

        public List<LogoDataModel> Get_ClCards()
        {
            return _logoDataDal.Get_ClCards();
        }

        public List<LogoDataModel> Get_ClCards(string cSpeCode)
        {
            return _logoDataDal.Get_ClCards(cSpeCode);
        }

        public List<LogoDataModel> Get_ClCards(int firmNo)
        {
            return _logoDataDal.Get_ClCards(firmNo);
        }

        public List<LogoDataModel> Get_ClCards(int firmNo, string cSpeCode)
        {
            return _logoDataDal.Get_ClCards(firmNo, cSpeCode);
        }

        public List<LogoDataModel> Get_Firms()
        {
            return _logoDataDal.Get_Firms();
        }

        public LogoDataModel Get_ItemInformation(int logicalREF)
        {
            return _logoDataDal.Get_ItemInformation(logicalREF);
        }

        public LogoDataModel Get_ItemInformation(int firmNo, int logicalREF)
        {
            return _logoDataDal.Get_ItemInformation(firmNo, logicalREF);
        }

        public List<LogoDataModel> Get_Items(int type)
        {
            return _logoDataDal.Get_Items(type);
        }

        public List<LogoDataModel> Get_Items(int firmNo, string cSpeCode)
        {
            return _logoDataDal.Get_Items(firmNo, cSpeCode);
        }

        public List<LogoDataModel> Get_Items(int firmNo, int type)
        {
            return _logoDataDal.Get_Items(firmNo, type);
        }
    }
}
