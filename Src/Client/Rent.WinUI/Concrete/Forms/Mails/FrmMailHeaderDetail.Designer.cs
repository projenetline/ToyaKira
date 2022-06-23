namespace Rent.WinUI.Concrete.Forms.Mails
{
    partial class FrmMailHeaderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailHeaderDetail));
            this.GcExpnses = new Rent.WinUI.Concrete.NetlineControls.GcDetail();
            this.BsMailHeaderLine = new System.Windows.Forms.BindingSource(this.components);
            this.GvExpnses = new Rent.WinUI.Concrete.NetlineControls.GvDetail();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMailAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemtxtTextEditmail1 = new Rent.WinUI.RentControls.RepositoryItemtxtTextEditmail();
            this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemtxtTextEdit1001 = new Rent.WinUI.RentControls.RepositoryItemtxtTextEdit100();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemceCheckEdit1 = new Rent.WinUI.RentControls.RepositoryItemceCheckEdit();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMailHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMailHeaderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemIcbExpenseType1 = new Rent.WinUI.RentControls.RepositoryItemIcbExpenseType();
            this.repositoryItemsluExpenseType1 = new Rent.WinUI.RentControls.RepositoryItemsluExpenseType();
            this.repositoryItemsluExpenseType1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemdeDateEdit1 = new Rent.WinUI.RentControls.RepositoryItemdeDateEdit();
            this.repositoryItemse15x21 = new Rent.WinUI.RentControls.RepositoryItemse15x2();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LcgMailHeader = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LciIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.CeIsActive = new Rent.WinUI.RentControls.ceCheckEdit();
            this.LciModuleId = new DevExpress.XtraLayout.LayoutControlItem();
            this.IcbModule1 = new Rent.WinUI.RentControls.IcbModule();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcExpnses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsMailHeaderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvExpnses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtTextEditmail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtTextEdit1001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemceCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbExpenseType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluExpenseType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluExpenseType1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemse15x21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMailHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciModuleId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcbModule1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.LcgMailHeader,
            this.emptySpaceItem1});
            this.LcgMain.Name = "Root";
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(1002, 769);
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.IcbModule1);
            this.LcMain.Controls.Add(this.CeIsActive);
            this.LcMain.Controls.Add(this.GcExpnses);
            this.LcMain.Margin = new System.Windows.Forms.Padding(2);
            this.LcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(596, 347, 675, 600);
            this.LcMain.Size = new System.Drawing.Size(1002, 769);
            // 
            // RcMain
            // 
            this.RcMain.ExpandCollapseItem.Id = 0;
            this.RcMain.Location = new System.Drawing.Point(0, 769);
            this.RcMain.Margin = new System.Windows.Forms.Padding(2);
            this.RcMain.Size = new System.Drawing.Size(1002, 31);
            // 
            // RBtnSave
            // 
            this.RBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnSave.ImageOptions.Image")));
            this.RBtnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnSave.ImageOptions.LargeImage")));
            // 
            // RBtnSaveClose
            // 
            this.RBtnSaveClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RBtnSaveClose.ImageOptions.Image")));
            this.RBtnSaveClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnSaveClose.ImageOptions.LargeImage")));
            // 
            // GcExpnses
            // 
            this.GcExpnses.DataSource = this.BsMailHeaderLine;
            this.GcExpnses.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(108, 88, 108, 88);
            this.GcExpnses.Location = new System.Drawing.Point(12, 90);
            this.GcExpnses.MainView = this.GvExpnses;
            this.GcExpnses.Margin = new System.Windows.Forms.Padding(108, 88, 108, 88);
            this.GcExpnses.MenuManager = this.RcMain;
            this.GcExpnses.Name = "GcExpnses";
            this.GcExpnses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemIcbExpenseType1,
            this.repositoryItemsluExpenseType1,
            this.repositoryItemdeDateEdit1,
            this.repositoryItemse15x21,
            this.repositoryItemceCheckEdit1,
            this.repositoryItemtxtTextEdit1001,
            this.repositoryItemtxtTextEditmail1});
            this.GcExpnses.Size = new System.Drawing.Size(978, 667);
            this.GcExpnses.TabIndex = 4;
            this.GcExpnses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvExpnses});
            // 
            // BsMailHeaderLine
            // 
            this.BsMailHeaderLine.DataSource = typeof(Rent.Domain.Concrete.Models.Rent.MailHeaderLine);
            // 
            // GvExpnses
            // 
            this.GvExpnses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMailAddress,
            this.colDisplayName,
            this.colIsActive,
            this.colCreatedDate,
            this.colCreatedBy,
            this.colModifiedDate,
            this.colModifiedBy,
            this.colDeletedDate,
            this.colDeletedBy,
            this.colIsDeleted,
            this.colMailHeader,
            this.colMailHeaderId,
            this.colIsEdit});
            this.GvExpnses.GridControl = this.GcExpnses;
            this.GvExpnses.Name = "GvExpnses";
            this.GvExpnses.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.GvExpnses.OptionsPrint.AutoWidth = false;
            this.GvExpnses.OptionsView.ColumnAutoWidth = false;
            this.GvExpnses.OptionsView.EnableAppearanceEvenRow = true;
            this.GvExpnses.OptionsView.EnableAppearanceOddRow = true;
            this.GvExpnses.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.GvExpnses.OptionsView.ShowFooter = true;
            this.GvExpnses.OptionsView.ShowGroupPanel = false;
            this.GvExpnses.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GvExpnses_InitNewRow);
            this.GvExpnses.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GvExpnses_CellValueChanged);
            this.GvExpnses.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.GvExpnses_InvalidRowException);
            this.GvExpnses.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GvExpnses_ValidateRow);
            this.GvExpnses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GvExpnses_KeyDown);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowShowHide = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colMailAddress
            // 
            this.colMailAddress.Caption = "Mail Adresi";
            this.colMailAddress.ColumnEdit = this.repositoryItemtxtTextEditmail1;
            this.colMailAddress.FieldName = "MailAddress";
            this.colMailAddress.Name = "colMailAddress";
            this.colMailAddress.Visible = true;
            this.colMailAddress.VisibleIndex = 1;
            this.colMailAddress.Width = 171;
            // 
            // repositoryItemtxtTextEditmail1
            // 
            this.repositoryItemtxtTextEditmail1.AutoHeight = false;
            this.repositoryItemtxtTextEditmail1.Mask.EditMask = "((((\\w+-*)|(-*\\w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+@((((\\w+-*)|(-*\\" +
    "w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+\\.[A-Za-z]+";
            this.repositoryItemtxtTextEditmail1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemtxtTextEditmail1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemtxtTextEditmail1.Name = "repositoryItemtxtTextEditmail1";
            // 
            // colDisplayName
            // 
            this.colDisplayName.Caption = "Görünen İsim";
            this.colDisplayName.ColumnEdit = this.repositoryItemtxtTextEdit1001;
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 0;
            this.colDisplayName.Width = 178;
            // 
            // repositoryItemtxtTextEdit1001
            // 
            this.repositoryItemtxtTextEdit1001.AutoHeight = false;
            this.repositoryItemtxtTextEdit1001.MaxLength = 100;
            this.repositoryItemtxtTextEdit1001.Name = "repositoryItemtxtTextEdit1001";
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktif";
            this.colIsActive.ColumnEdit = this.repositoryItemceCheckEdit1;
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            // 
            // repositoryItemceCheckEdit1
            // 
            this.repositoryItemceCheckEdit1.AutoHeight = false;
            this.repositoryItemceCheckEdit1.Caption = "ceCheckEdit";
            this.repositoryItemceCheckEdit1.Name = "repositoryItemceCheckEdit1";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.AllowShowHide = false;
            this.colCreatedDate.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowShowHide = false;
            this.colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.OptionsColumn.AllowShowHide = false;
            this.colModifiedDate.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colModifiedBy
            // 
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
            // colMailHeader
            // 
            this.colMailHeader.FieldName = "MailHeader";
            this.colMailHeader.Name = "colMailHeader";
            this.colMailHeader.OptionsColumn.AllowShowHide = false;
            this.colMailHeader.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colMailHeaderId
            // 
            this.colMailHeaderId.FieldName = "MailHeaderId";
            this.colMailHeaderId.Name = "colMailHeaderId";
            this.colMailHeaderId.OptionsColumn.AllowShowHide = false;
            this.colMailHeaderId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIsEdit
            // 
            this.colIsEdit.FieldName = "IsEdit";
            this.colIsEdit.Name = "colIsEdit";
            this.colIsEdit.OptionsColumn.AllowShowHide = false;
            this.colIsEdit.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // repositoryItemIcbExpenseType1
            // 
            this.repositoryItemIcbExpenseType1.AutoHeight = false;
            this.repositoryItemIcbExpenseType1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIcbExpenseType1.Name = "repositoryItemIcbExpenseType1";
            // 
            // repositoryItemsluExpenseType1
            // 
            this.repositoryItemsluExpenseType1.AutoHeight = false;
            this.repositoryItemsluExpenseType1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemsluExpenseType1.Name = "repositoryItemsluExpenseType1";
            this.repositoryItemsluExpenseType1.PopupFormSize = new System.Drawing.Size(600, 600);
            this.repositoryItemsluExpenseType1.View = this.repositoryItemsluExpenseType1View;
            // 
            // repositoryItemsluExpenseType1View
            // 
            this.repositoryItemsluExpenseType1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemsluExpenseType1View.Name = "repositoryItemsluExpenseType1View";
            this.repositoryItemsluExpenseType1View.OptionsFind.AllowFindPanel = false;
            this.repositoryItemsluExpenseType1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemsluExpenseType1View.OptionsView.ShowGroupPanel = false;
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GcExpnses;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(982, 671);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // LcgMailHeader
            // 
            this.LcgMailHeader.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciIsActive,
            this.LciModuleId});
            this.LcgMailHeader.Location = new System.Drawing.Point(0, 0);
            this.LcgMailHeader.Name = "LcgMailHeader";
            this.LcgMailHeader.OptionsItemText.TextToControlDistance = 5;
            this.LcgMailHeader.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.LcgMailHeader.Size = new System.Drawing.Size(243, 78);
            this.LcgMailHeader.Text = "Mail Genel Bilgileri";
            // 
            // LciIsActive
            // 
            this.LciIsActive.Control = this.CeIsActive;
            this.LciIsActive.Location = new System.Drawing.Point(0, 24);
            this.LciIsActive.Name = "LciIsActive";
            this.LciIsActive.Size = new System.Drawing.Size(231, 23);
            this.LciIsActive.Text = "Aktif";
            this.LciIsActive.TextSize = new System.Drawing.Size(46, 13);
            // 
            // CeIsActive
            // 
            this.CeIsActive.Location = new System.Drawing.Point(69, 61);
            this.CeIsActive.MenuManager = this.RcMain;
            this.CeIsActive.Name = "CeIsActive";
            this.CeIsActive.Properties.Caption = "";
            this.CeIsActive.Properties.DisplayValueChecked = "Evet";
            this.CeIsActive.Properties.DisplayValueUnchecked = "Hayır";
            this.CeIsActive.Properties.ValueChecked = ((byte)(1));
            this.CeIsActive.Properties.ValueUnchecked = ((byte)(0));
            this.CeIsActive.Size = new System.Drawing.Size(176, 19);
            this.CeIsActive.StyleController = this.LcMain;
            this.CeIsActive.TabIndex = 6;
            // 
            // LciModuleId
            // 
            this.LciModuleId.Control = this.IcbModule1;
            this.LciModuleId.Location = new System.Drawing.Point(0, 0);
            this.LciModuleId.Name = "LciModuleId";
            this.LciModuleId.Size = new System.Drawing.Size(231, 24);
            this.LciModuleId.Text = "Modul Adı";
            this.LciModuleId.TextSize = new System.Drawing.Size(46, 13);
            // 
            // IcbModule1
            // 
            this.IcbModule1.Location = new System.Drawing.Point(69, 37);
            this.IcbModule1.MaximumSize = new System.Drawing.Size(176, 20);
            this.IcbModule1.MenuManager = this.RcMain;
            this.IcbModule1.Name = "IcbModule1";
            this.IcbModule1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IcbModule1.Size = new System.Drawing.Size(176, 20);
            this.IcbModule1.StyleController = this.LcMain;
            this.IcbModule1.TabIndex = 7;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(243, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(739, 78);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmMailHeaderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 800);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMailHeaderDetail";
            this.Text = "Mail Liste Detayı";
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcExpnses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsMailHeaderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvExpnses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtTextEditmail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtTextEdit1001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemceCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIcbExpenseType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluExpenseType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsluExpenseType1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemdeDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemse15x21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMailHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciModuleId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcbModule1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private NetlineControls.GcDetail GcExpnses;
        private System.Windows.Forms.BindingSource BsMailHeaderLine;
        private NetlineControls.GvDetail GvExpnses;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdit;
        private RentControls.RepositoryItemIcbExpenseType repositoryItemIcbExpenseType1;
        private DevExpress.XtraLayout.LayoutControlGroup LcgMailHeader;
        private RentControls.RepositoryItemsluExpenseType repositoryItemsluExpenseType1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemsluExpenseType1View;
        private RentControls.RepositoryItemdeDateEdit repositoryItemdeDateEdit1;
        private RentControls.RepositoryItemse15x2 repositoryItemse15x21;
        private RentControls.RepositoryItemceCheckEdit repositoryItemceCheckEdit1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private RentControls.ceCheckEdit CeIsActive;
        private DevExpress.XtraLayout.LayoutControlItem LciIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colMailAddress;
        private RentControls.RepositoryItemtxtTextEdit100 repositoryItemtxtTextEdit1001;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colMailHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colMailHeaderId;
        private RentControls.IcbModule IcbModule1;
        private DevExpress.XtraLayout.LayoutControlItem LciModuleId;
        private RentControls.RepositoryItemtxtTextEditmail repositoryItemtxtTextEditmail1;
    }
}