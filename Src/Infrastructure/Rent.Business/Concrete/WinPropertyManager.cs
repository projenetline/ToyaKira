using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.Core.Concrete.Helpers;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class WinFormPropertyManager : IWinFormPropertyService
    {
        IWinFormPropertyDal _winFormPropertyDal;
        public WinFormPropertyManager(IWinFormPropertyDal winFormPropertyDal)
        {
            _winFormPropertyDal = winFormPropertyDal;
        }
        public WinFormProperty Save(WinFormProperty entity)
        {
            if (entity.Id <= 0)
            {
                entity.CreatedDate = DateTime.Now;
                entity.CreatedBy = SessionHelper.CurrentUserId;
            }
            else
            {
                entity.ModifiedDate = DateTime.Now;
                entity.ModifiedBy = SessionHelper.CurrentUserId;
            }

            return _winFormPropertyDal.Save(entity);
        }
        public WinFormProperty Get_WinFormProperty_By_UserId(int nUserId)
        {
            return _winFormPropertyDal.Get_WinFormProperty_By_UserId(nUserId);
        }
    }
}
