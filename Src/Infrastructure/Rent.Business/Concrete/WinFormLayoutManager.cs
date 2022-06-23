using DevExpress.XtraEditors;
using Rent.Business.Abstract;
using Rent.Core.Concrete.Helpers;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Rent;
using System;
using System.Collections.Generic;

namespace Rent.Business.Concrete
{
    public class WinFormLayoutManager : IWinFormLayoutService
    {
        IWinFormLayoutDal _winFormLayoutDal;
        public WinFormLayoutManager(IWinFormLayoutDal winFormLayoutDal)
        {
            _winFormLayoutDal = winFormLayoutDal;
        }
        public bool DeleteAllLayouts()
        {
           return _winFormLayoutDal.DeleteAllLayouts();
        }

        

        public bool DeleteUserLayouts(int nUserId)
        {
           return _winFormLayoutDal.DeleteUserLayouts(nUserId);
        }

        public WinFormLayout GetWinLayoutBy_UserId_WitFormName(int nUserId, string cFormName)
        {
            return _winFormLayoutDal.GetWinLayoutBy_UserId_WitFormName(nUserId, cFormName);
        }

        public WinFormLayout GetWinLayoutBy_UserId_WithoutFormName(int nUserId)
        {
            return _winFormLayoutDal.GetWinLayoutBy_UserId_WithoutFormName(nUserId); ;
        }

        public WinFormLayout Save(WinFormLayout entity)
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
            return _winFormLayoutDal.Save(entity);
        }
    }
}
