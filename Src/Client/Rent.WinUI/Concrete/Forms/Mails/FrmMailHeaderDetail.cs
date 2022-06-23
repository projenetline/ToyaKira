using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Rent.Business.Abstract;
using Rent.Core.Concrete.Resources;
using Rent.Domain.Concrete;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using Rent.WinUI.Concrete.NetlineControls;
using Rent.WinUI.RentControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Forms.Mails
{
    public partial class FrmMailHeaderDetail : FrmBaseDetail
    {
        MailHeader _mailHeader;
        IMailHeaderService _mailHeaderService;
        IMailHeaderLineService _mailHeaderLineService;
        public FrmMailHeaderDetail(IMailHeaderService mailHeaderService, IMailHeaderLineService mailHeaderLineService)
        {
            _mailHeaderService = mailHeaderService;
            _mailHeaderLineService = mailHeaderLineService;
            InitializeComponent();
        }
        protected override void InitData()
        {
            if (MailHeader != null)
            {
                IcbModule1.EditValue = MailHeader.ModuleId;
                CeIsActive.EditValue = MailHeader.IsActive;
                InitMailHeaderLines();
            }
            base.InitData();
        }
        protected override void SetChangedDataValue()
        {
            MailHeader.IsEdit = true;
            IsChangeData = true;
            base.SetChangedDataValue();
        }
        private void InitMailHeaderLines()
        {
            BsMailHeaderLine.DataSource = MailHeader.MailHeaderLines.Where(x => x.IsDeleted != true).ToList();
            GcExpnses.DataSource = BsMailHeaderLine;
        }
        protected override void InitEditors()
        {
            base.InitEditors();
        }
        protected override bool ValidateData()
        {
            try
            {
                ValidationRule rule = null;
                if (IcbModule1.EditValue == null)
                    rule = ValidationRulesHelper.RuleIsNotBlank;
                ValidationProvider.SetValidationRule(IcbModule1, rule);
                return base.ValidateData();
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
                return base.ValidateData();
            }
        }
        protected override void SaveData()
        {
            try
            {

                GvExpnses.CloseEditor();
                GvExpnses.UpdateCurrentRow();
                GvExpnses.ActiveFilter.Clear();
                if (MailHeader != null)
                {
                    if (ValidateData())
                    {
                        MailHeader.ModuleId = IcbModule1.EditValue != DBNull.Value ?
                            Convert.ToByte(IcbModule1.EditValue)
                            : (byte)0;
                        MailHeader.IsActive = CeIsActive.CheckState == CheckState.Checked;

                        if (!Exists)
                        {
                            for (int i = 0; i < GvExpnses.DataRowCount; i++)
                            {
                                MailHeaderLine mailHeaderLine = GvExpnses.GetRow(i) as MailHeaderLine;
                                if (mailHeaderLine != null)
                                {
                                    if (mailHeaderLine.Id <= 0 && mailHeaderLine.IsDeleted != true)
                                    {
                                        MailHeader.MailHeaderLines.Add(mailHeaderLine);
                                    }
                                }
                            }
                            _mailHeaderService.Save(MailHeader);
                            if (_mailHeaderService.SuccsessOperation)
                            {
                                SaveObj = true;
                                NewObj = false;
                                EditObj = true;
                                MessageHelper.SuccessfulSaveMessage();
                            }
                        }
                    }
                }
                base.SaveData();
            }
            catch (Exception)
            {

                throw;
            }

        }

        #region PROPERTIES
        private MailHeader MailHeader
        {
            get
            {
                if (ObjectId > 0 && _mailHeader == null)
                {
                    _mailHeader = _mailHeaderService.GetByIdWithDetails(ObjectId);
                }
                else
                {
                    if (_mailHeader == null)
                    {
                        _mailHeader = new MailHeader
                        {
                            IsEdit = true,
                            IsDeleted = false,
                            IsActive = true
                        };
                    }
                }
                return _mailHeader;
            }
        }
        bool Exists
        {
            get
            {
                return _mailHeaderService.Exists(MailHeader);
            }
        }
        #endregion

        private void GvExpnses_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridHelper.InitNewRow(GvExpnses, e.RowHandle);
        }
        private void GvExpnses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletingObj = true;
                GridHelper.DeleteRow(GvExpnses, DeletingObj);
                DeletingObj = false;
            }
        }
        private void GvExpnses_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != "IsEdit")
            {
                GvExpnses.SetRowCellValue(e.RowHandle, "IsEdit", true);
            }
            SetChangedDataValue();
        }

        private void GvExpnses_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                if (DeletingObj) return;
                GridView view = (GridView)sender;
                GridColumn colDisplayName = view.Columns["DisplayName"];
                GridColumn colMailAddress = view.Columns["MailAddress"];
                var displayName = view.GetFocusedRowCellDisplayText("DisplayName");
                var mailAddress = view.GetFocusedRowCellDisplayText("MailAddress");
                if (string.IsNullOrEmpty(displayName) || string.IsNullOrEmpty(mailAddress))
                {
                    e.Valid = false;
                    view.SetColumnError(colDisplayName, AppStrings.ValidateErrorString);
                    view.SetColumnError(colMailAddress, AppStrings.ValidateErrorString);
                }
                else
                {
                    view.UpdateCurrentRow();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }

        private void GvExpnses_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            try
            {
                e.ExceptionMode = ExceptionMode.NoAction;
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }
    }
}
