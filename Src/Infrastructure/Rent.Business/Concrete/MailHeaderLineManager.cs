using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class MailHeaderLineManager : IMailHeaderLineService
    {
        IMailHeaderLineDal _mailHeaderLineDal;
        public MailHeaderLineManager(IMailHeaderLineDal mailHeaderLineDal)
        {
            _mailHeaderLineDal = mailHeaderLineDal;
        }
        public bool SuccsessOperation { get; set ; }

        public bool Delete(MailHeaderLine entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _mailHeaderLineDal.Delete(entity);
            }
        }

        public bool Exists(MailHeaderLine entity)
        {
            return _mailHeaderLineDal.Exists(entity);
        }

        public List<MailHeaderLine> GetAll()
        {
            return _mailHeaderLineDal.GetAll();
        }

        public MailHeaderLine GetById(int nId)
        {
            return _mailHeaderLineDal.GetById(nId);
        }

        public List<MailHeaderLine> GetsByMasterId(int mailHeaderId)
        {
            return _mailHeaderLineDal.GetsByMasterId(mailHeaderId);
        }

        public List<MailHeaderLine> GetsByModuleId(EnumModule module)
        {
            return _mailHeaderLineDal.GetsByModuleId(module);
        }

        public List<MailHeaderLine> GetSluDataSourceAll()
        {
            return _mailHeaderLineDal.GetSluDataSourceAll();
        }

        public MailHeaderLine Save(MailHeaderLine entity)
        {
            MailHeaderLine MailHeaderLine;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                MailHeaderLine = _mailHeaderLineDal.Save(entity);
                SuccsessOperation = true;
                return MailHeaderLine;
            }
        }

        public string UsedControl(MailHeaderLine entity)
        {
            return _mailHeaderLineDal.UsedControl(entity);
        }
    }
}
