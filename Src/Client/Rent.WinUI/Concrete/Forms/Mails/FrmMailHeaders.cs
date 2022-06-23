using DevExpress.XtraGrid.Views.Base;
using Rent.Business.Abstract;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;

namespace Rent.WinUI.Concrete.Forms.Mails
{
    public partial class FrmMailHeaders : FrmBaseList
    {
        IMailHeaderService _mailHeaderService;
        IMailHeaderLineService _mailHeaderLineService;
        public FrmMailHeaders(IMailHeaderService mailHeaderService, IMailHeaderLineService mailHeaderLineService)
        {
            _mailHeaderService = mailHeaderService;
            _mailHeaderLineService = mailHeaderLineService;
            InitializeComponent();
        }
        protected override void GetRecordList()
        {
            GcMain.DataSource = _mailHeaderService.GetAll();
            GvMain.ExpandAllGroups();
            GvMain.BestFitColumns();
            base.GetRecordList();
        }
        protected override void Add()
        {
            FrmMailHeaderDetail frm = InstanceFactory.GetInstance<FrmMailHeaderDetail>();
            frm.SetParent(0, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Add();
        }
        protected override void Edit()
        {
            FrmMailHeaderDetail frm = InstanceFactory.GetInstance<FrmMailHeaderDetail>();
            frm.SetParent(CurrentObjectId, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Edit();
        }
        protected override void Examine()
        {
            FrmMailHeaderDetail frm = InstanceFactory.GetInstance<FrmMailHeaderDetail>();
            frm.SetParent(CurrentObjectId, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Examine();
        }
        protected override void Copy()
        {
            FrmMailHeaderDetail frm = InstanceFactory.GetInstance<FrmMailHeaderDetail>();
            frm.SetParent(CurrentObjectId, this.MdiParent, true, false, false, false, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            base.Edit();
        }
        protected override void Delete()
        {
            if (CurrentEditObject != null)
            {
                if (MessageHelper.DeleteQuestionMessage)
                {

                    var mailHeaderLines = _mailHeaderLineService.GetsByMasterId(CurrentObjectId);
                    foreach (var mailHeaderLine in mailHeaderLines)
                    {
                        mailHeaderLine.IsEdit = true;
                        mailHeaderLine.IsDeleted = true;
                        _mailHeaderLineService.Delete(mailHeaderLine);
                    }
                    CurrentEditObject.IsDeleted = true;
                    CurrentEditObject.IsEdit = true;
                    _mailHeaderService.Delete((MailHeader)CurrentEditObject);
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
        protected override BaseEntity CurrentEditObject => GvMain.GetRow(GvMain.FocusedRowHandle) as MailHeader;
        protected override string DetailFormName => "FrmColorAdd";
        #endregion

    }
}
