using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Concrete
{
    public class LogManager : ILogService
    {
        ILogDal _logDal;
        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }
        public bool Delete(LogModel entity)
        {
           return _logDal.Delete(entity);
        }
        public List<LogModel> GetAll()
        {
            return _logDal.GetAll();
        }
        public LogModel GetById(int nId)
        {
            return _logDal.GetById(nId);
        }
        public LogModel Save(LogModel entity)
        {
            return _logDal.Save(entity);
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
    }
}
