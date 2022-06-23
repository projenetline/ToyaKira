using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class RealityManager : IRealityService
    {
        IRealityDal _RealityDal;
        public RealityManager(IRealityDal RealityDal)
        {
            _RealityDal = RealityDal;
        }
        public bool SuccsessOperation { get; set ; }

        public bool Delete(Reality entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _RealityDal.Delete(entity);
            }
        }

        public bool Exists(Reality entity)
        {
            return _RealityDal.Exists(entity);
        }

        public List<Reality> GetAll()
        {
            return _RealityDal.GetAll();
        }

        public Reality GetById(int nId)
        {
            return _RealityDal.GetById(nId);
        }

        public List<Reality> GetsByTypeId(int typeId)
        {
            return _RealityDal.GetsByTypeId(typeId);
        }

        public List<Reality> GetSluDataSourceAll()
        {
            return _RealityDal.GetSluDataSourceAll();
        }

        public Reality Save(Reality entity)
        {
            Reality Reality;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                Reality = _RealityDal.Save(entity);
                SuccsessOperation = true;
                return Reality;
            }
        }

        public string UsedControl(Reality entity)
        {
            return _RealityDal.UsedControl(entity);
        }
    }
}
