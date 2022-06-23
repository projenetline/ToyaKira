namespace Rent.WinUI.Concrete.Forms.Parameters
{
    partial class FrmTenants
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
            this.BsTenants = new System.Windows.Forms.BindingSource(this.components);
            this.GvMain = new Rent.WinUI.Concrete.NetlineControls.GvList();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentityNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccountNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankIBanNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsTenants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).BeginInit();
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
            this.GcMain.DataSource = this.BsTenants;
            this.GcMain.Location = new System.Drawing.Point(12, 12);
            this.GcMain.MainView = this.GvMain;
            this.GcMain.MenuManager = this.RcMain;
            this.GcMain.Name = "GcMain";
            this.GcMain.Size = new System.Drawing.Size(1332, 563);
            this.GcMain.TabIndex = 4;
            this.GcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvMain});
            // 
            // BsTenants
            // 
            this.BsTenants.DataSource = typeof(Rent.Domain.Concrete.Models.Rent.Tenant);
            // 
            // GvMain
            // 
            this.GvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colIdentityNo,
            this.colAddress,
            this.colBankAccountNo,
            this.colBankIBanNumber,
            this.colCreatedDate,
            this.colCreatedBy,
            this.colModifiedDate,
            this.colModifiedBy,
            this.colDeletedDate,
            this.colDeletedBy,
            this.colIsDeleted,
            this.colIsEdit});
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
            this.colId.VisibleIndex = 6;
            // 
            // colName
            // 
            this.colName.Caption = "Ad Soyad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 108;
            // 
            // colIdentityNo
            // 
            this.colIdentityNo.Caption = "Tc Kimlik No";
            this.colIdentityNo.FieldName = "IdentityNo";
            this.colIdentityNo.Name = "colIdentityNo";
            this.colIdentityNo.Visible = true;
            this.colIdentityNo.VisibleIndex = 2;
            this.colIdentityNo.Width = 149;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Adres";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            // 
            // colBankAccountNo
            // 
            this.colBankAccountNo.Caption = "Hesap Kodu";
            this.colBankAccountNo.FieldName = "BankAccountNo";
            this.colBankAccountNo.Name = "colBankAccountNo";
            this.colBankAccountNo.Visible = true;
            this.colBankAccountNo.VisibleIndex = 4;
            // 
            // colBankIBanNumber
            // 
            this.colBankIBanNumber.Caption = "Iban No";
            this.colBankIBanNumber.FieldName = "BankIBanNumber";
            this.colBankIBanNumber.Name = "colBankIBanNumber";
            this.colBankIBanNumber.Visible = true;
            this.colBankIBanNumber.VisibleIndex = 5;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.Caption = "Kayıt Tarihi";
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 7;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.Caption = "Kayıt Sahibi";
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 8;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.Caption = "Güncelleme Tarihi";
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.Visible = true;
            this.colModifiedDate.VisibleIndex = 9;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.Caption = "Son Güncelleyen";
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 10;
            // 
            // colDeletedDate
            // 
            this.colDeletedDate.FieldName = "DeletedDate";
            this.colDeletedDate.Name = "colDeletedDate";
            this.colDeletedDate.OptionsColumn.AllowShowHide = false;
            this.colDeletedDate.OptionsColumn.ShowInCustomizationForm = false;
            this.colDeletedDate.Visible = true;
            this.colDeletedDate.VisibleIndex = 11;
            // 
            // colDeletedBy
            // 
            this.colDeletedBy.FieldName = "DeletedBy";
            this.colDeletedBy.Name = "colDeletedBy";
            this.colDeletedBy.OptionsColumn.AllowShowHide = false;
            this.colDeletedBy.OptionsColumn.ShowInCustomizationForm = false;
            this.colDeletedBy.Visible = true;
            this.colDeletedBy.VisibleIndex = 12;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.OptionsColumn.AllowShowHide = false;
            this.colIsDeleted.OptionsColumn.ShowInCustomizationForm = false;
            this.colIsDeleted.Visible = true;
            this.colIsDeleted.VisibleIndex = 13;
            // 
            // colIsEdit
            // 
            this.colIsEdit.FieldName = "IsEdit";
            this.colIsEdit.Name = "colIsEdit";
            this.colIsEdit.OptionsColumn.AllowShowHide = false;
            this.colIsEdit.OptionsColumn.ShowInCustomizationForm = false;
            this.colIsEdit.Visible = true;
            this.colIsEdit.VisibleIndex = 14;
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
            // FrmTenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 618);
            this.Name = "FrmTenants";
            this.ShowIcon = false;
            this.Text = "Kiracılar";
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsTenants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NetlineControls.GcList GcMain;
        private System.Windows.Forms.BindingSource BsTenants;
        private NetlineControls.GvList GvMain;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccountNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBankIBanNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}