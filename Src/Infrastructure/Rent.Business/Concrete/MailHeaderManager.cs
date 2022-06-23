using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class MailHeaderManager : IMailHeaderService
    {
        readonly IMailHeaderDal _mailHeaderDal;
        readonly IMailHeaderLineDal _mailHeaderLineDal;

        public MailHeaderManager(IMailHeaderDal mailHeaderDal, IMailHeaderLineDal mailHeaderLineDal)
        {
            _mailHeaderDal = mailHeaderDal;
            _mailHeaderLineDal = mailHeaderLineDal;
        }
        public bool SuccsessOperation { get; set ; }
        public bool Delete(MailHeader entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _mailHeaderDal.Delete(entity);
            }
        }
        public bool Exists(MailHeader entity)
        {
            return _mailHeaderDal.Exists(entity);
        }
        public List<MailHeader> GetAll()
        {
            return _mailHeaderDal.GetAll();
        }
        public MailHeader GetById(int nId)
        {
            return _mailHeaderDal.GetById(nId);
        }
        public MailHeader GetByIdWithDetails(int id)
        {
            var mailHeader = GetById(id);
            if (mailHeader != null)
            {
                var mailHeaderLines = _mailHeaderLineDal.GetsByMasterId(id);
                foreach (var mailHeaderLine in mailHeaderLines)
                {
                    mailHeader.MailHeaderLines.Add(mailHeaderLine);
                }
            }
            return mailHeader;
        }
        public List<MailHeader> GetSluDataSourceAll()
        {
            return _mailHeaderDal.GetSluDataSourceAll();
        }
        public MailHeader Save(MailHeader entity)
        {
            MailHeader mailHeader;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                mailHeader = _mailHeaderDal.Save(entity);
                SaveMailHeaderLines(mailHeader);
                SuccsessOperation = true;
                return mailHeader;
            }
        }
        private void SaveMailHeaderLines(MailHeader entity)
        {
            if(entity != null)
            {
                foreach (var mailHeaderLine in entity.MailHeaderLines)
                {
                    mailHeaderLine.MailHeaderId = entity.Id;
                    _mailHeaderLineDal.Save(mailHeaderLine);
                }
            }
        }
        public string UsedControl(MailHeader entity)
        {
            return _mailHeaderDal.UsedControl(entity);
        }
    }
}
