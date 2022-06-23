namespace Rent.WinUI.Concrete.Forms.Contract
{
    partial class FrmContracts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContracts));
            this.GcMain = new Rent.WinUI.Concrete.NetlineControls.GcList();
            this.BsContracts = new System.Windows.Forms.BindingSource(this.components);
            this.GvMain = new Rent.WinUI.Concrete.NetlineControls.GvList();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemsluTenant1 = new Rent.WinUI.RentControls.RepositoryItemsluTenant();
            this.repositoryItemsluTenant1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemdeDateEdit1 = new Rent.WinUI.RentControls.RepositoryItemdeDateEdit();
            this.colContractEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemse15x21 = new Rent.WinUI.RentControls.RepositoryItemse15x2();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemIcbCurrency1 = new Rent.WinUI.RentControls.RepositoryItemIcbCurrency();
            this.colRentPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemIcbPeriodType1 = new Rent.WinUI.RentControls.RepositoryItemIcbPeriodType();
            this.colRentPeriodNot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepositAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdvancePayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentAdditionPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentAdditionRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentAdditionNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentContractExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentContractRealities = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractEndDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BtnAdditionContract = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluTenant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluTenant1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemse15x21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbCurrency1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbPeriodType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.GcMain);
            this.LcMain.Size = new System.Drawing.Size(1356, 587);
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.LcgMain.Size = new System.Drawing.Size(1356, 587);
            // 
            // RcMain
            // 
            this.RcMain.ExpandCollapseItem.Id = 0;
            this.RcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnAdditionContract});
            this.RcMain.Location = new System.Drawing.Point(0, 587);
            this.RcMain.MaxItemId = 13;
            this.RcMain.Size = new System.Drawing.Size(1356, 31);
            this.RcMain.Toolbar.ShowCustomizeItem = false;
            // 
            // RpgMainMenu
            // 
            this.RpgMainMenu.ItemLinks.Add(this.BtnAdditionContract, true);
            // 
            // GcMain
            // 
            this.GcMain.DataSource = this.BsContracts;
            this.GcMain.Location = new System.Drawing.Point(12, 12);
            this.GcMain.MainView = this.GvMain;
            this.GcMain.MenuManager = this.RcMain;
            this.GcMain.Name = "GcMain";
            this.GcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemsluTenant1,
            this.repositoryItemdeDateEdit1,
            this.repositoryItemse15x21,
            this.repositoryItemIcbCurrency1,
            this.repositoryItemIcbPeriodType1});
            this.GcMain.Size = new System.Drawing.Size(1332, 563);
            this.GcMain.TabIndex = 4;
            this.GcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvMain});
            // 
            // BsContracts
            // 
            this.BsContracts.DataSource = typeof(Rent.Domain.Concrete.Models.Rent.RentContract);
            // 
            // GvMain
            // 
            this.GvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTenantId,
            this.colContactNo,
            this.colContractStartDate,
            this.colContractEndDate,
            this.colRentAmount,
            this.colTaxAmount,
            this.colTotalAmount,
            this.colRentCurrencyId,
            this.colRentPeriod,
            this.colRentPeriodNot,
            this.colDepositAmount,
            this.colDepCurrencyId,
            this.colAdvancePayment,
            this.colAPCurrencyId,
            this.colRentAdditionPeriod,
            this.colRentAdditionRate,
            this.colRentAdditionNote,
            this.colCreatedDate,
            this.colCreatedBy,
            this.colModifiedDate,
            this.colModifiedBy,
            this.colDeletedDate,
            this.colDeletedBy,
            this.colIsDeleted,
            this.colIsEdit,
            this.colRentContractExpenses,
            this.colRentContractRealities,
            this.colContractEndDate1,
            this.colIsPaid});
            this.GvMain.GridControl = this.GcMain;
            this.GvMain.Name = "GvMain";
            this.GvMain.OptionsBehavior.Editable = false;
            this.GvMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.GvMain.OptionsBehavior.ReadOnly = true;
            this.GvMain.OptionsFind.AlwaysVisible = true;
            this.GvMain.OptionsPrint.AutoWidth = false;
            this.GvMain.OptionsSelection.MultiSelect = true;
            this.GvMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GvMain.OptionsView.ColumnAutoWidth = false;
            this.GvMain.OptionsView.EnableAppearanceEvenRow = true;
            this.GvMain.OptionsView.EnableAppearanceOddRow = true;
            this.GvMain.OptionsView.ShowAutoFilterRow = true;
            this.GvMain.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.Caption = "Kayıt No";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 18;
            // 
            // colTenantId
            // 
            this.colTenantId.Caption = "Kiracı";
            this.colTenantId.ColumnEdit = this.repositoryItemsluTenant1;
            this.colTenantId.FieldName = "TenantId";
            this.colTenantId.Name = "colTenantId";
            this.colTenantId.Visible = true;
            this.colTenantId.VisibleIndex = 1;
            // 
            // repositoryItemsluTenant1
            // 
            this.repositoryItemsluTenant1.AutoHeight = false;
            this.repositoryItemsluTenant1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemsluTenant1.Name = "repositoryItemsluTenant1";
            this.repositoryItemsluTenant1.PopupFormSize = new System.Drawing.Size(600, 600);
            this.repositoryItemsluTenant1.View = this.repositoryItemsluTenant1View;
            // 
            // repositoryItemsluTenant1View
            // 
            this.repositoryItemsluTenant1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemsluTenant1View.Name = "repositoryItemsluTenant1View";
            this.repositoryItemsluTenant1View.OptionsFind.AllowFindPanel = false;
            this.repositoryItemsluTenant1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemsluTenant1View.OptionsView.ShowGroupPanel = false;
            // 
            // colContactNo
            // 
            this.colContactNo.Caption = "Sözleşme No";
            this.colContactNo.FieldName = "ContactNo";
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.Visible = true;
            this.colContactNo.VisibleIndex = 2;
            // 
            // colContractStartDate
            // 
            this.colContractStartDate.Caption = "Sözleşme Başlangıç Tarihi";
            this.colContractStartDate.ColumnEdit = this.repositoryItemdeDateEdit1;
            this.colContractStartDate.FieldName = "ContractStartDate";
            this.colContractStartDate.Name = "colContractStartDate";
            this.colContractStartDate.Visible = true;
            this.colContractStartDate.VisibleIndex = 4;
            // 
            // repositoryItemdeDateEdit1
            // 
            this.repositoryItemdeDateEdit1.AutoHeight = false;
            this.repositoryItemdeDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemdeDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemdeDateEdit1.Name = "repositoryItemdeDateEdit1";
            // 
            // colContractEndDate
            // 
            this.colContractEndDate.Caption = "Sözleşme Bitiş Tarihi";
            this.colContractEndDate.ColumnEdit = this.repositoryItemdeDateEdit1;
            this.colContractEndDate.FieldName = "ContractEndDate";
            this.colContractEndDate.Name = "colContractEndDate";
            this.colContractEndDate.Visible = true;
            this.colContractEndDate.VisibleIndex = 3;
            // 
            // colRentAmount
            // 
            this.colRentAmount.Caption = "Kira Tutarı";
            this.colRentAmount.ColumnEdit = this.repositoryItemse15x21;
            this.colRentAmount.FieldName = "RentAmount";
            this.colRentAmount.Name = "colRentAmount";
            this.colRentAmount.Visible = true;
            this.colRentAmount.VisibleIndex = 5;
            // 
            // repositoryItemse15x21
            // 
            this.repositoryItemse15x21.AutoHeight = false;
            this.repositoryItemse15x21.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemse15x21.Name = "repositoryItemse15x21";
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.Caption = "Kdv";
            this.colTaxAmount.ColumnEdit = this.repositoryItemse15x21;
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 6;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "Toplam Tuta";
            this.colTotalAmount.ColumnEdit = this.repositoryItemse15x21;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 7;
            // 
            // colRentCurrencyId
            // 
            this.colRentCurrencyId.Caption = "Döviz Cinsi";
            this.colRentCurrencyId.ColumnEdit = this.repositoryItemIcbCurrency1;
            this.colRentCurrencyId.FieldName = "RentCurrencyId";
            this.colRentCurrencyId.Name = "colRentCurrencyId";
            this.colRentCurrencyId.Visible = true;
            this.colRentCurrencyId.VisibleIndex = 8;
            // 
            // repositoryItemIcbCurrency1
            // 
            this.repositoryItemIcbCurrency1.AutoHeight = false;
            this.repositoryItemIcbCurrency1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIcbCurrency1.Name = "repositoryItemIcbCurrency1";
            // 
            // colRentPeriod
            // 
            this.colRentPeriod.Caption = "Kira Periyodu";
            this.colRentPeriod.ColumnEdit = this.repositoryItemIcbPeriodType1;
            this.colRentPeriod.FieldName = "RentPeriod";
            this.colRentPeriod.Name = "colRentPeriod";
            this.colRentPeriod.Visible = true;
            this.colRentPeriod.VisibleIndex = 9;
            // 
            // repositoryItemIcbPeriodType1
            // 
            this.repositoryItemIcbPeriodType1.AutoHeight = false;
            this.repositoryItemIcbPeriodType1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIcbPeriodType1.Name = "repositoryItemIcbPeriodType1";
            // 
            // colRentPeriodNot
            // 
            this.colRentPeriodNot.Caption = "Kira Periyot Notu";
            this.colRentPeriodNot.FieldName = "RentPeriodNot";
            this.colRentPeriodNot.Name = "colRentPeriodNot";
            this.colRentPeriodNot.Visible = true;
            this.colRentPeriodNot.VisibleIndex = 10;
            // 
            // colDepositAmount
            // 
            this.colDepositAmount.Caption = "Depozito Tutar";
            this.colDepositAmount.ColumnEdit = this.repositoryItemse15x21;
            this.colDepositAmount.FieldName = "DepositAmount";
            this.colDepositAmount.Name = "colDepositAmount";
            this.colDepositAmount.Visible = true;
            this.colDepositAmount.VisibleIndex = 11;
            // 
            // colDepCurrencyId
            // 
            this.colDepCurrencyId.Caption = "Deposito Döviz Cinsi";
            this.colDepCurrencyId.ColumnEdit = this.repositoryItemIcbCurrency1;
            this.colDepCurrencyId.FieldName = "DepCurrencyId";
            this.colDepCurrencyId.Name = "colDepCurrencyId";
            this.colDepCurrencyId.Visible = true;
            this.colDepCurrencyId.VisibleIndex = 12;
            // 
            // colAdvancePayment
            // 
            this.colAdvancePayment.Caption = "Peşinat Tutar";
            this.colAdvancePayment.ColumnEdit = this.repositoryItemse15x21;
            this.colAdvancePayment.FieldName = "AdvancePayment";
            this.colAdvancePayment.Name = "colAdvancePayment";
            this.colAdvancePayment.Visible = true;
            this.colAdvancePayment.VisibleIndex = 13;
            // 
            // colAPCurrencyId
            // 
            this.colAPCurrencyId.Caption = "Peşinat Döviz Cinsi";
            this.colAPCurrencyId.ColumnEdit = this.repositoryItemIcbCurrency1;
            this.colAPCurrencyId.FieldName = "APCurrencyId";
            this.colAPCurrencyId.Name = "colAPCurrencyId";
            this.colAPCurrencyId.Visible = true;
            this.colAPCurrencyId.VisibleIndex = 14;
            // 
            // colRentAdditionPeriod
            // 
            this.colRentAdditionPeriod.Caption = "Sözleşme Yenileme Periyodu";
            this.colRentAdditionPeriod.ColumnEdit = this.repositoryItemIcbPeriodType1;
            this.colRentAdditionPeriod.FieldName = "RentAdditionPeriod";
            this.colRentAdditionPeriod.Name = "colRentAdditionPeriod";
            this.colRentAdditionPeriod.Visible = true;
            this.colRentAdditionPeriod.VisibleIndex = 15;
            // 
            // colRentAdditionRate
            // 
            this.colRentAdditionRate.Caption = "Sözleşme Kira Artış Oranı";
            this.colRentAdditionRate.ColumnEdit = this.repositoryItemse15x21;
            this.colRentAdditionRate.FieldName = "RentAdditionRate";
            this.colRentAdditionRate.Name = "colRentAdditionRate";
            this.colRentAdditionRate.Visible = true;
            this.colRentAdditionRate.VisibleIndex = 16;
            // 
            // colRentAdditionNote
            // 
            this.colRentAdditionNote.Caption = "Söleşme Yenileme Notu";
            this.colRentAdditionNote.FieldName = "RentAdditionNote";
            this.colRentAdditionNote.Name = "colRentAdditionNote";
            this.colRentAdditionNote.Visible = true;
            this.colRentAdditionNote.VisibleIndex = 17;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.Caption = "Kayıt Tarihi";
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.AllowShowHide = false;
            this.colCreatedDate.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.Caption = "Kayıt Sahibi";
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowShowHide = false;
            this.colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.Caption = "Güncelleme Tarihi";
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.OptionsColumn.AllowShowHide = false;
            this.colModifiedDate.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.Caption = "Son Güncelleyen";
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.OptionsColumn.AllowShowHide = false;
            this.colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDeletedDate
            // 
            this.colDeletedDate.FieldName = "DeletedDate";
            this.colDeletedDate.Name = "colDeletedDate";
            this.colDeletedDate.OptionsColumn.AllowShowHide = false;
            this.colDeletedDate.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDeletedBy
            // 
            this.colDeletedBy.FieldName = "DeletedBy";
            this.colDeletedBy.Name = "colDeletedBy";
            this.colDeletedBy.OptionsColumn.AllowShowHide = false;
            this.colDeletedBy.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.OptionsColumn.AllowShowHide = false;
            this.colIsDeleted.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIsEdit
            // 
            this.colIsEdit.FieldName = "IsEdit";
            this.colIsEdit.Name = "colIsEdit";
            this.colIsEdit.OptionsColumn.AllowShowHide = false;
            this.colIsEdit.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colRentContractExpenses
            // 
            this.colRentContractExpenses.FieldName = "RentContractExpenses";
            this.colRentContractExpenses.Name = "colRentContractExpenses";
            this.colRentContractExpenses.OptionsColumn.AllowShowHide = false;
            this.colRentContractExpenses.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colRentContractRealities
            // 
            this.colRentContractRealities.FieldName = "RentContractRealities";
            this.colRentContractRealities.Name = "colRentContractRealities";
            // 
            // colContractEndDate1
            // 
            this.colContractEndDate1.FieldName = "ContractEndDate";
            this.colContractEndDate1.Name = "colContractEndDate1";
            this.colContractEndDate1.Visible = true;
            this.colContractEndDate1.VisibleIndex = 19;
            // 
            // colIsPaid
            // 
            this.colIsPaid.Caption = "Ödendi";
            this.colIsPaid.FieldName = "IsPaid";
            this.colIsPaid.Name = "colIsPaid";
            this.colIsPaid.Visible = true;
            this.colIsPaid.VisibleIndex = 20;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GcMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1336, 567);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // BtnAdditionContract
            // 
            this.BtnAdditionContract.Caption = "Sözleşme Yenile";
            this.BtnAdditionContract.Id = 12;
            this.BtnAdditionContract.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdditionContract.ImageOptions.SvgImage")));
            this.BtnAdditionContract.Name = "BtnAdditionContract";
            this.BtnAdditionContract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdditionContract_ItemClick);
            // 
            // FrmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 618);
            this.Name = "FrmContracts";
            this.ShowIcon = false;
            this.Text = "Sözleşmeler";
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluTenant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluTenant1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemse15x21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbCurrency1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbPeriodType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NetlineControls.GcList GcMain;
        private System.Windows.Forms.BindingSource BsContracts;
        private NetlineControls.GvList GvMain;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenantId;
        private RentControls.RepositoryItemsluTenant repositoryItemsluTenant1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemsluTenant1View;
        private DevExpress.XtraGrid.Columns.GridColumn colContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn colContractStartDate;
        private RentControls.RepositoryItemdeDateEdit repositoryItemdeDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colContractEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRentAmount;
        private RentControls.RepositoryItemse15x2 repositoryItemse15x21;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRentCurrencyId;
        private RentControls.RepositoryItemIcbCurrency repositoryItemIcbCurrency1;
        private DevExpress.XtraGrid.Columns.GridColumn colRentPeriod;
        private RentControls.RepositoryItemIcbPeriodType repositoryItemIcbPeriodType1;
        private DevExpress.XtraGrid.Columns.GridColumn colRentPeriodNot;
        private DevExpress.XtraGrid.Columns.GridColumn colDepositAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDepCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvancePayment;
        private DevExpress.XtraGrid.Columns.GridColumn colAPCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colRentAdditionPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colRentAdditionRate;
        private DevExpress.XtraGrid.Columns.GridColumn colRentAdditionNote;
        private DevExpress.XtraGrid.Columns.GridColumn colRentContractExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colRentContractRealities;
        private DevExpress.XtraBars.BarButtonItem BtnAdditionContract;
        private DevExpress.XtraGrid.Columns.GridColumn colContractEndDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaid;
    }
}