using Dapper;
using Rent.Core.Abstract.DataAccess;
using Rent.Core.Concrete.Helpers;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Logo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rent.DataAccess.Concrete
{
    public class DpLogoDataDal : DapperHelper, ILogoDataDal
    {
        public List<LogoDataModel> Get_All_ClCards()
        {
            string cSql = " SELECT  LOGICALREF, CODE AS 'Code', DEFINITION_ AS 'NAME' FROM LG_" + DbHelper.GetLogoFirmNumber + "_CLCARD";
            return LogoDb.Query<LogoDataModel>(cSql).ToList();
        }
        public List<LogoDataModel> Get_All_Items()
        {
            List<LogoDataModel> allItems = new List<LogoDataModel>();
            List<LogoDataModel> logoDatas = Get_Firms();
            foreach (LogoDataModel logoData in logoDatas)
            {
                string firmNR = logoData.LOGICALREF.ToString();
                firmNR = firmNR.PadLeft(3, '0');
                string cSql = " SELECT LOGICALREF, CODE AS 'CODE', NAME AS 'NAME' FROM LG_" + firmNR + "_ITEMS WHERE SPECODE2='GM'";
                allItems.AddRange(LogoDb.Query<LogoDataModel>(cSql).ToList());
            }
            return allItems;
        }
        public LogoDataModel Get_ClCardInformation(int logicalREF)
        {
            string cSql = " SELECT  * FROM LG_" + DbHelper.GetLogoFirmNumber + "_CLCARD";
            cSql += " WHERE LOGICALREF = @LOGICALREF ";
            return LogoDb.Query<LogoDataModel>(cSql, new { LOGICALREF = logicalREF }).FirstOrDefault();
        }
        public LogoDataModel Get_ClCardInformation(int firmNo, int logicalREF)
        {
            string firmNR = firmNo.ToString().PadLeft(3, '0');
            string cSql = " SELECT  * FROM LG_" + firmNR + "_CLCARD";
            cSql += " WHERE LOGICALREF = @LOGICALREF ";
            return LogoDb.Query<LogoDataModel>(cSql, new { LOGICALREF = logicalREF }).FirstOrDefault();
        }
        /*
             SELECT * FROM LG_005_01_BNFLINE WHERE TRCODE IN (3,4)


            select SPECODE2,SPECODE5,SPECODE3,SPECODE5, * from  LG_046_ITEMS

    
            SELECT convert(int,NR) as 'LOGICALREF', NAME AS 'CODE' ,* FROM L_CAPIFIRM 

         */
        public List<LogoDataModel> Get_ClCards()
        {
            List<LogoDataModel> allCompanies = new List<LogoDataModel>();
            List<LogoDataModel> logoDatas = Get_All_ClCards();
            foreach (LogoDataModel logoData in logoDatas)
            {
                string firmNR = logoData.LOGICALREF.ToString();
                firmNR = firmNR.PadLeft(3, '0');
                string cSql = " SELECT LOGICALREF, CODE AS 'CODE', DEFINITION_ AS 'NAME' FROM LG_" + firmNR + "_CLCARD";
                allCompanies.AddRange(LogoDb.Query<LogoDataModel>(cSql).ToList());
            }
            return allCompanies;
        }
        public List<LogoDataModel> Get_ClCards(string cSpeCode)
        {
            string cSql = " SELECT  LOGICALREF, CODE AS 'Code', DEFINITION_ AS 'NAME' FROM LG_" + DbHelper.GetLogoFirmNumber + "_CLCARD";
            cSql += " WHERE SPECODE = @SPECODE";
            return LogoDb.Query<LogoDataModel>(cSql, new { SPECODE = cSpeCode }).ToList();
        }
        public List<LogoDataModel> Get_ClCards(int firmNo)
        {
            string firmNR = firmNo.ToString().PadLeft(3, '0');
            string cSql = " SELECT  LOGICALREF, CODE AS 'Code', DEFINITION_ AS 'NAME' FROM LG_" + firmNR + "_CLCARD";

            return LogoDb.Query<LogoDataModel>(cSql).ToList();
        }
        public List<LogoDataModel> Get_ClCards(int firmNo, string cSpeCode)
        {
            string firmNR = firmNo.ToString().PadLeft(3, '0');
            string cSql = " SELECT  LOGICALREF, CODE AS 'Code', DEFINITION_ AS 'NAME' FROM LG_" + firmNR + "_CLCARD";
            cSql += " WHERE SPECODE = @SPECODE";
            return LogoDb.Query<LogoDataModel>(cSql, new { SPECODE = cSpeCode }).ToList();
        }
        public List<LogoDataModel> Get_Firms()
        {
            string cSql = " SELECT convert(int,NR) as 'LOGICALREF', NAME AS 'CODE' FROM L_CAPIFIRM ";
            return LogoDb.Query<LogoDataModel>(cSql).ToList();
        }
        public LogoDataModel Get_ItemInformation(int logicalREF)
        {
            string cSql = " SELECT  * FROM LG_" + DbHelper.GetLogoFirmNumber + "_ITEMS";
            cSql += " WHERE LOGICALREF = @LOGICALREF ";
            return LogoDb.Query<LogoDataModel>(cSql, new { LOGICALREF = logicalREF }).FirstOrDefault();
        }
        public LogoDataModel Get_ItemInformation(int firmNo, int logicalREF)
        {
            string firmNR = firmNo.ToString().PadLeft(3, '0');
            string cSql = " SELECT  * FROM LG_" + firmNR + "_ITEMS";
            cSql += " WHERE LOGICALREF = @LOGICALREF ";
            return LogoDb.Query<LogoDataModel>(cSql, new { LOGICALREF = logicalREF }).FirstOrDefault();
        }
        public List<LogoDataModel> Get_Items(int type)
        {
            string cSql = " SELECT  LOGICALREF, CODE AS 'CODE', NAME AS 'NAME' FROM LG_" + DbHelper.GetLogoFirmNumber + "_ITEMS";
            cSql += " WHERE CARDTYPE = @CARDTYPE ";
            return LogoDb.Query<LogoDataModel>(cSql, new { CARDTYPE = type }).ToList();
        }
        public List<LogoDataModel> Get_Items(int firmNo, string cSpeCode = "GM")
        {
            string firmNR = firmNo.ToString().PadLeft(3, '0');
            string cSql = " SELECT  LOGICALREF, CODE AS 'CODE', NAME AS 'NAME' FROM LG_" + firmNR + "_ITEMS  ";
            //cSql += " WHERE CARDTYPE = @CARDTYPE ";
            cSql += " WHERE SPECODE2 = @SPECODE2 ";
            return LogoDb.Query<LogoDataModel>(cSql, new { SPECODE2 = cSpeCode }).ToList();
        }
        public List<LogoDataModel> Get_Items(int firmNo, int type)
        {
            string firmNR = firmNo.ToString().PadLeft(3, '0');
            string cSql = " SELECT  LOGICALREF, CODE AS 'CODE', NAME AS 'NAME' FROM LG_" + firmNR + "_ITEMS  ";
            cSql += " WHERE CARDTYPE = @CARDTYPE ";
            return LogoDb.Query<LogoDataModel>(cSql, new { CARDTYPE = type }).ToList();
        }
    }
}
