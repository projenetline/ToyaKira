using Dapper;
using Dapper.Contrib.Extensions;
using Rent.Core.Abstract.DataAccess;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Logo;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rent.DataAccess.Concrete
{
    public class DpPaymentDal:DapperHelper, IPaymentDal
    {
        private readonly ILogDal _logDal;   
        public DpPaymentDal(ILogDal logDal)
        {
            _logDal = logDal;
        }
        public void LogService(string info, int status)
        {
            try
            {
                LogModel logService = new LogModel
                {
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description = info,
                    StatusId = status,
                    IsEdit = true
                };
                _logDal.Save(logService);
            }
            catch
            {

            }
        }
        public string LogServiceErr(string content)
        {
            string rtrn = "";
            try
            {
                string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Log";

                StreamWriter sw = new StreamWriter(new FileStream(String.Format($"{filePath}\\{DateTime.Today.Day}-{ DateTime.Today.Month}-{DateTime.Today.Year}-Log.txt"), FileMode.OpenOrCreate, FileAccess.Write));
                sw.BaseStream.Seek(0, SeekOrigin.End);
                content = string.Format($"{DateTime.Now.ToLongTimeString()} | {content}");
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                rtrn = ex.Message;
            }
            return rtrn;
        }
        public List<LogoDataModel> Get_Firms()
        {
            string cSql = " SELECT convert(int,NR) as 'LOGICALREF', NAME AS 'CODE' FROM L_CAPIFIRM ";
            return LogoDb.Query<LogoDataModel>(cSql).ToList();
        }
        public List<LogoBNFLINE> Get_BNF(int firmNo, int donem, int logicalRef)
        {
            string firmaNo = firmNo.ToString().PadLeft(3, '0');
            string donemm = donem.ToString().PadLeft(2, '0');
            //string query = $" SELECT LOGICALREF, CLIENTREF, DATE_,LINEEXP, AMOUNT  FROM LG_026_{donemm}_BNFLINE ";
            string query = $" SELECT LOGICALREF, CLIENTREF, DATE_,LINEEXP, AMOUNT  FROM LG_{firmaNo}_{donemm}_BNFLINE ";
            query += " where CLIENTREF=@CLIENTREF and TRCODE = 3";
            return  LogoDb.Query<LogoBNFLINE>(query, new { CLIENTREF = logicalRef}).ToList();
        }
        public InsurancePolicy Save(InsurancePolicy entity)
        {
            if (entity.IsEdit)
            {
                if (entity.Id <= 0 && !entity.IsDeleted)
                {
                    long Id = RentDb.Insert(entity);
                    entity.Id = (int)Id;
                }
                else
                {
                    if (entity.IsEdit)
                    {
                        RentDb.Update(entity);
                    }
                }
            }
            return entity;
        }
        public List<InsurancePolicy> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<InsurancePolicy> GetSluDataSourceAll()
        {
            throw new NotImplementedException();
        }
        public InsurancePolicy GetById(int nId)
        {
            throw new NotImplementedException();
        }
        public bool Delete(InsurancePolicy entity)
        {
            throw new NotImplementedException();
        }
        public bool Exists(InsurancePolicy entity)
        {
            throw new NotImplementedException();
        }
        public string UsedControl(InsurancePolicy entity)
        {
            throw new NotImplementedException();
        }
    }
}
