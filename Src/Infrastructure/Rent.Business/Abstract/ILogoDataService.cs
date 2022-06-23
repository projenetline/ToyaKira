using Rent.Domain.Concrete.Models.Logo;
using System.Collections.Generic;

namespace Rent.Business.Abstract
{
    public interface ILogoDataService
    {
        LogoDataModel Get_ClCardInformation(int logicalREF);
        List<LogoDataModel> Get_All_ClCards();
        List<LogoDataModel> Get_Firms();
        List<LogoDataModel> Get_All_Items();
        List<LogoDataModel> Get_ClCards();
        List<LogoDataModel> Get_ClCards(string cSpeCode);
        List<LogoDataModel> Get_ClCards(int firmNo);
        List<LogoDataModel> Get_ClCards(int firmNo, string cSpeCode);
        List<LogoDataModel> Get_Items(int firmNo, string cSpeCode);
        List<LogoDataModel> Get_Items(int firmNo, int type);
        List<LogoDataModel> Get_Items(int type);
        LogoDataModel Get_ItemInformation(int logicalREF);
        LogoDataModel Get_ClCardInformation(int firmNo, int logicalREF);
        LogoDataModel Get_ItemInformation(int firmNo, int logicalREF);
    }
}
