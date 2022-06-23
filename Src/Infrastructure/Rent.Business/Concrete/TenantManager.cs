using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class TenantManager : ITenantService
    {
        ITenantDal _tenantDal;
        public TenantManager(ITenantDal tenantDal)
        {
            _tenantDal = tenantDal;
        }
        public bool SuccsessOperation { get; set ; }

        public bool Delete(Tenant entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _tenantDal.Delete(entity);
            }
        }

        public bool Exists(Tenant entity)
        {
            return _tenantDal.Exists(entity);
        }

        public List<Tenant> GetAll()
        {
            return _tenantDal.GetAll();
        }

        public Tenant GetById(int nId)
        {
            return _tenantDal.GetById(nId);
        }
        public List<Tenant> GetSluDataSourceAll()
        {
            return _tenantDal.GetSluDataSourceAll();
        }

        public Tenant Save(Tenant entity)
        {
            Tenant Tenant;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                Tenant = _tenantDal.Save(entity);
                SuccsessOperation = true;
                return Tenant;
            }
        }

        public string UsedControl(Tenant entity)
        {
            return _tenantDal.UsedControl(entity);
        }
    }
}
