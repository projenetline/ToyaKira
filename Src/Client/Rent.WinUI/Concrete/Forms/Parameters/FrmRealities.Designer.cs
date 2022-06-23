﻿namespace Rent.WinUI.Concrete.Forms.Parameters
{
    partial class FrmRealities
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
            this.BsRealitys = new System.Windows.Forms.BindingSource(this.components);
            this.GvMain = new Rent.WinUI.Concrete.NetlineControls.GvList();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogoFirmNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLuFirm1 = new Rent.WinUI.RentControls.RepositoryItemLuFirm();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemIcbRealityType1 = new Rent.WinUI.RentControls.RepositoryItemIcbRealityType();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.BsRealitys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLuFirm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbRealityType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.GcMain);
            this.LcMain.Margin = new System.Windows.Forms.Padding(4);
            this.LcMain.Size = new System.Drawing.Size(1356, 587);
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(1356, 587);
            // 
            // RcMain
            // 
            this.RcMain.ExpandCollapseItem.Id = 0;
            this.RcMain.Location = new System.Drawing.Point(0, 587);
            this.RcMain.Margin = new System.Windows.Forms.Padding(4);
            this.RcMain.Size = new System.Drawing.Size(1356, 31);
            this.RcMain.Toolbar.ShowCustomizeItem = false;
            // 
            // GcMain
            // 
            this.GcMain.DataSource = this.BsRealitys;
            this.GcMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GcMain.Location = new System.Drawing.Point(12, 12);
            this.GcMain.MainView = this.GvMain;
            this.GcMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GcMain.MenuManager = this.RcMain;
            this.GcMain.Name = "GcMain";
            this.GcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemIcbRealityType1,
            this.repositoryItemLuFirm1});
            this.GcMain.Size = new System.Drawing.Size(1332, 563);
            this.GcMain.TabIndex = 4;
            this.GcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvMain});
            // 
            // BsRealitys
            // 
            this.BsRealitys.DataSource = typeof(Rent.Domain.Concrete.Models.Rent.Reality);
            // 
            // GvMain
            // 
            this.GvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colLogoFirmNo,
            this.colType,
            this.colCode,
            this.colName,
            this.colAddress,
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
            this.colId.VisibleIndex = 1;
            // 
            // colLogoFirmNo
            // 
            this.colLogoFirmNo.Caption = "Şirket";
            this.colLogoFirmNo.ColumnEdit = this.repositoryItemLuFirm1;
            this.colLogoFirmNo.FieldName = "LogoFirmNo";
            this.colLogoFirmNo.Name = "colLogoFirmNo";
            this.colLogoFirmNo.Visible = true;
            this.colLogoFirmNo.VisibleIndex = 2;
            this.colLogoFirmNo.Width = 120;
            // 
            // repositoryItemLuFirm1
            // 
            this.repositoryItemLuFirm1.AutoHeight = false;
            this.repositoryItemLuFirm1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLuFirm1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOGICALREF", "Referans No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Firma Kodu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Firma Adı")});
            this.repositoryItemLuFirm1.DisplayMember = "CODE";
            this.repositoryItemLuFirm1.Name = "repositoryItemLuFirm1";
            this.repositoryItemLuFirm1.NullText = "";
            this.repositoryItemLuFirm1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.repositoryItemLuFirm1.ValueMember = "LOGICALREF";
            // 
            // colType
            // 
            this.colType.Caption = "Taşınmaz Türü";
            this.colType.ColumnEdit = this.repositoryItemIcbRealityType1;
            this.colType.FieldName = "TypeId";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            this.colType.Width = 120;
            // 
            // repositoryItemIcbRealityType1
            // 
            this.repositoryItemIcbRealityType1.AutoHeight = false;
            this.repositoryItemIcbRealityType1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIcbRealityType1.Name = "repositoryItemIcbRealityType1";
            // 
            // colCode
            // 
            this.colCode.Caption = "Taşınmaz Kodu";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 4;
            this.colCode.Width = 144;
            // 
            // colName
            // 
            this.colName.Caption = "Taşınmaz Tanımı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 5;
            this.colName.Width = 162;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Adres";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            this.colAddress.Width = 582;
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GcMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1336, 567);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmRealities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 618);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRealities";
            this.ShowIcon = false;
            this.Text = "Taşınmazlar";
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsRealitys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLuFirm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbRealityType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NetlineControls.GcList GcMain;
        private System.Windows.Forms.BindingSource BsRealitys;
        private NetlineControls.GvList GvMain;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private RentControls.RepositoryItemIcbRealityType repositoryItemIcbRealityType1;
        private DevExpress.XtraGrid.Columns.GridColumn colLogoFirmNo;
        private RentControls.RepositoryItemLuFirm repositoryItemLuFirm1;
    }
}