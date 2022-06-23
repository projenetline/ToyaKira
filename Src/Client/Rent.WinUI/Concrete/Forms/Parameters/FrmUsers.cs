using DevExpress.XtraGrid.Views.Base;
using Rent.Business.Abstract;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Forms.Parameters
{
    public partial class FrmUsers : FrmBaseList
    {
        private readonly IUserService _UserService;
        public FrmUsers(IUserService UserService)
        {
            _UserService = UserService;
            InitializeComponent();
        }
        protected override void GetRecordList()
        {
            BsUsers.DataSource = _UserService.GetAll();
            GcMain.DataSource = BsUsers;
            GvMain.ExpandAllGroups();
            base.GetRecordList();
        }
        protected override void Add()
        {
            using (var form = InstanceFactory.GetInstance<FrmUserAdd>())
            {
                form.SetParent(this.MdiParent, true, false, false);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Add();
        }
        protected override void Edit()
        {
            using (var form = InstanceFactory.GetInstance<FrmUserAdd>())
            {
                form.ObjectId = CurrentObjectId;
                form.SetParent(this.MdiParent, false, true, false);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Edit();
        }
        protected override void Examine()
        {
            using (var form = InstanceFactory.GetInstance<FrmUserAdd>())
            {
                form.ObjectId = CurrentObjectId;
                form.SetParent(this.MdiParent, false, false, true);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Examine();
        }
        protected override void Copy()
        {
            using (var form = InstanceFactory.GetInstance<FrmUserAdd>())
            {
                form.ObjectId = CurrentObjectId;
                form.SetParent(this.MdiParent, false, false, false);
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.SaveObj)
                {
                    GetRecordList();
                }
            }
            base.Edit();
        }
        protected override void Delete()
        {
            if (CurrentEditObject != null)
            {
                if (MessageHelper.DeleteQuestionMessage)
                {
                    _UserService.Delete((User)CurrentEditObject);
                    GvMain.RefreshData();
                }
            }
            base.Delete();
        }
        #region PROPERTIES
        protected override ColumnView MainView01 => GvMain;
        public override int CurrentObjectId => GvMain.GetFocusedRowCellValue("Id") != DBNull.Value
            ? Convert.ToInt32(GvMain.GetFocusedRowCellValue("Id"))
            : 0;
        bool Locked => GvMain.GetFocusedRowCellValue("Lock") != DBNull.Value
                       && Convert.ToBoolean(GvMain.GetFocusedRowCellValue("Lock"));
        protected override BaseEntity CurrentEditObject => GvMain.GetRow(GvMain.FocusedRowHandle) as User;
        protected override string DetailFormName => "FrmColorAdd";
        #endregion

    }
}
