namespace Rent.WinUI.Concrete.Forms.Mails
{
    partial class FrmMailHeaders
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
            this.GcMain = new Rent.WinUI.Concrete.NetlineControls.GcList();
            this.BsContracts = new System.Windows.Forms.BindingSource(this.components);
            this.GvMain = new Rent.WinUI.Concrete.NetlineControls.GvList();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModuleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemIcbModule1 = new Rent.WinUI.RentControls.RepositoryItemIcbModule();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemceCheckEdit1 = new Rent.WinUI.RentControls.RepositoryItemceCheckEdit();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMailHeaderLines = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemsluTenant1 = new Rent.WinUI.RentControls.RepositoryItemsluTenant();
            this.repositoryItemsluTenant1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemdeDateEdit1 = new Rent.WinUI.RentControls.RepositoryItemdeDateEdit();
            this.repositoryItemse15x21 = new Rent.WinUI.RentControls.RepositoryItemse15x2();
            this.repositoryItemIcbCurrency1 = new Rent.WinUI.RentControls.RepositoryItemIcbCurrency();
            this.repositoryItemIcbPeriodType1 = new Rent.WinUI.RentControls.RepositoryItemIcbPeriodType();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbModule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemceCheckEdit1)).BeginInit();
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
            this.RcMain.Location = new System.Drawing.Point(0, 587);
            this.RcMain.Size = new System.Drawing.Size(1356, 31);
            this.RcMain.Toolbar.ShowCustomizeItem = false;
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
            this.repositoryItemIcbPeriodType1,
            this.repositoryItemceCheckEdit1,
            this.repositoryItemIcbModule1});
            this.GcMain.Size = new System.Drawing.Size(1332, 563);
            this.GcMain.TabIndex = 4;
            this.GcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvMain});
            // 
            // BsContracts
            // 
            this.BsContracts.DataSource = typeof(Rent.Domain.Concrete.Models.Rent.MailHeader);
            // 
            // GvMain
            // 
            this.GvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colModuleId,
            this.colIsActive,
            this.colCreatedDate,
            this.colCreatedBy,
            this.colModifiedDate,
            this.colModifiedBy,
            this.colDeletedDate,
            this.colDeletedBy,
            this.colIsDeleted,
            this.colIsEdit,
            this.colMailHeaderLines});
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
            this.colId.VisibleIndex = 1;
            // 
            // colModuleId
            // 
            this.colModuleId.Caption = "Modül Adı";
            this.colModuleId.ColumnEdit = this.repositoryItemIcbModule1;
            this.colModuleId.FieldName = "ModuleId";
            this.colModuleId.Name = "colModuleId";
            this.colModuleId.Visible = true;
            this.colModuleId.VisibleIndex = 2;
            this.colModuleId.Width = 264;
            // 
            // repositoryItemIcbModule1
            // 
            this.repositoryItemIcbModule1.AutoHeight = false;
            this.repositoryItemIcbModule1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIcbModule1.Name = "repositoryItemIcbModule1";
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktif";
            this.colIsActive.ColumnEdit = this.repositoryItemceCheckEdit1;
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 3;
            this.colIsActive.Width = 135;
            // 
            // repositoryItemceCheckEdit1
            // 
            this.repositoryItemceCheckEdit1.AutoHeight = false;
            this.repositoryItemceCheckEdit1.Caption = "ceCheckEdit";
            this.repositoryItemceCheckEdit1.Name = "repositoryItemceCheckEdit1";
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
            // colMailHeaderLines
            // 
            this.colMailHeaderLines.FieldName = "MailHeaderLines";
            this.colMailHeaderLines.Name = "colMailHeaderLines";
            this.colMailHeaderLines.OptionsColumn.AllowShowHide = false;
            this.colMailHeaderLines.OptionsColumn.ShowInCustomizationForm = false;
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
            // repositoryItemdeDateEdit1
            // 
            this.repositoryItemdeDateEdit1.AutoHeight = false;
            this.repositoryItemdeDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemdeDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemdeDateEdit1.Name = "repositoryItemdeDateEdit1";
            // 
            // repositoryItemse15x21
            // 
            this.repositoryItemse15x21.AutoHeight = false;
            this.repositoryItemse15x21.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemse15x21.Name = "repositoryItemse15x21";
            // 
            // repositoryItemIcbCurrency1
            // 
            this.repositoryItemIcbCurrency1.AutoHeight = false;
            this.repositoryItemIcbCurrency1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIcbCurrency1.Name = "repositoryItemIcbCurrency1";
            // 
            // repositoryItemIcbPeriodType1
            // 
            this.repositoryItemIcbPeriodType1.AutoHeight = false;
            this.repositoryItemIcbPeriodType1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIcbPeriodType1.Name = "repositoryItemIcbPeriodType1";
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
            // FrmMailHeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 618);
            this.Name = "FrmMailHeaders";
            this.ShowIcon = false;
            this.Text = "Mail Listeleri";
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbModule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemceCheckEdit1)).EndInit();
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
        private RentControls.RepositoryItemsluTenant repositoryItemsluTenant1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemsluTenant1View;
        private RentControls.RepositoryItemdeDateEdit repositoryItemdeDateEdit1;
        private RentControls.RepositoryItemse15x2 repositoryItemse15x21;
        private RentControls.RepositoryItemIcbCurrency repositoryItemIcbCurrency1;
        private RentControls.RepositoryItemIcbPeriodType repositoryItemIcbPeriodType1;
        private DevExpress.XtraGrid.Columns.GridColumn colModuleId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private RentControls.RepositoryItemceCheckEdit repositoryItemceCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMailHeaderLines;
        private RentControls.RepositoryItemIcbModule repositoryItemIcbModule1;
    }
}