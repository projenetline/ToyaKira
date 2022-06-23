using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class RentContractRealityManager : IRentContractRealityService
    {
        IRentContractRealityDal _rentContractRealityDal;
        public RentContractRealityManager(IRentContractRealityDal rentContractRealityDal)
        {
            _rentContractRealityDal = rentContractRealityDal;
        }
        public bool SuccsessOperation { get; set ; }

        public bool Delete(RentContractReality entity)
        {
            string cMsg = UsedControl(entity);
            if (!string.IsNullOrEmpty(cMsg))
            {
                return false;
            }
            else
            {
                return _rentContractRealityDal.Delete(entity);
            }
        }

        public bool Exists(RentContractReality entity)
        {
            return _rentContractRealityDal.Exists(entity);
        }

        public List<RentContractReality> GetAll()
        {
            return _rentContractRealityDal.GetAll();
        }

        public RentContractReality GetById(int nId)
        {
            return _rentContractRealityDal.GetById(nId);
        }

        public List<RentContractReality> GetsByMasterId(int rentContractId)
        {
            return _rentContractRealityDal.GetsByMasterId(rentContractId);
        }

        public List<RentContractReality> GetSluDataSourceAll()
        {
            return _rentContractRealityDal.GetSluDataSourceAll();
        }

        public RentContractReality Save(RentContractReality entity)
        {
            RentContractReality RentContractReality;
            if (this.Exists(entity))
            {
                XtraMessageBox.Show("Tekrarlanan Kayıt");
                return entity;
            }
            else
            {
                entity.CreatedDate = DateTime.Now;
                RentContractReality = _rentContractRealityDal.Save(entity);
                SuccsessOperation = true;
                return RentContractReality;
            }
        }

        public string UsedControl(RentContractReality entity)
        {
            return _rentContractRealityDal.UsedControl(entity);
        }
    }
}
