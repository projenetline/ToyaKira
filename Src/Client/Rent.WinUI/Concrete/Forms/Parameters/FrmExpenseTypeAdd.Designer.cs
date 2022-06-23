namespace Rent.WinUI.Concrete.Forms.Parameters
{
    partial class FrmExpenseTypeAdd
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
            this.TxtCode = new DevExpress.XtraEditors.TextEdit();
            this.LciCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.LciName = new DevExpress.XtraLayout.LayoutControlItem();
            this.CbType = new Rent.WinUI.RentControls.IcbExpenseType();
            this.LciType = new DevExpress.XtraLayout.LayoutControlItem();
            this.CeResponsible = new Rent.WinUI.RentControls.ceCheckEdit();
            this.LciResponsible = new DevExpress.XtraLayout.LayoutControlItem();
            this.LuLogoFirm = new Rent.WinUI.RentControls.LuFirm();
            this.LciLogoFirm = new DevExpress.XtraLayout.LayoutControlItem();
            this.luItem1 = new Rent.WinUI.RentControls.LuItem();
            this.LciLogoExpenseType = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeResponsible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciResponsible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuLogoFirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoFirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luItem1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoExpenseType)).BeginInit();
            this.SuspendLayout();
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.luItem1);
            this.LcMain.Controls.Add(this.LuLogoFirm);
            this.LcMain.Controls.Add(this.CeResponsible);
            this.LcMain.Controls.Add(this.CbType);
            this.LcMain.Controls.Add(this.TxtName);
            this.LcMain.Controls.Add(this.TxtCode);
            this.LcMain.Margin = new System.Windows.Forms.Padding(3);
            this.LcMain.Size = new System.Drawing.Size(412, 175);
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciCode,
            this.LciName,
            this.LciType,
            this.LciResponsible,
            this.LciLogoFirm,
            this.LciLogoExpenseType});
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(412, 175);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(323, 4);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(248, 4);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(3);
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(97, 84);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(1);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(303, 20);
            this.TxtCode.StyleController = this.LcMain;
            this.TxtCode.TabIndex = 5;
            // 
            // LciCode
            // 
            this.LciCode.Control = this.TxtCode;
            this.LciCode.Location = new System.Drawing.Point(0, 72);
            this.LciCode.Name = "LciCode";
            this.LciCode.Size = new System.Drawing.Size(392, 24);
            this.LciCode.Text = "Gider Kodu";
            this.LciCode.TextSize = new System.Drawing.Size(80, 13);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(97, 108);
            this.TxtName.Margin = new System.Windows.Forms.Padding(1);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(303, 20);
            this.TxtName.StyleController = this.LcMain;
            this.TxtName.TabIndex = 7;
            // 
            // LciName
            // 
            this.LciName.Control = this.TxtName;
            this.LciName.Location = new System.Drawing.Point(0, 96);
            this.LciName.Name = "LciName";
            this.LciName.Size = new System.Drawing.Size(392, 24);
            this.LciName.Text = "Gder Tanımı";
            this.LciName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // CbType
            // 
            this.CbType.Location = new System.Drawing.Point(97, 36);
            this.CbType.Margin = new System.Windows.Forms.Padding(1);
            this.CbType.Name = "CbType";
            this.CbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbType.Size = new System.Drawing.Size(303, 20);
            this.CbType.StyleController = this.LcMain;
            this.CbType.TabIndex = 8;
            // 
            // LciType
            // 
            this.LciType.Control = this.CbType;
            this.LciType.Location = new System.Drawing.Point(0, 24);
            this.LciType.Name = "LciType";
            this.LciType.Size = new System.Drawing.Size(392, 24);
            this.LciType.Text = "Gider Türü";
            this.LciType.TextSize = new System.Drawing.Size(80, 13);
            // 
            // CeResponsible
            // 
            this.CeResponsible.Location = new System.Drawing.Point(97, 132);
            this.CeResponsible.Margin = new System.Windows.Forms.Padding(1);
            this.CeResponsible.Name = "CeResponsible";
            this.CeResponsible.Properties.Caption = "";
            this.CeResponsible.Properties.DisplayValueChecked = "Evet";
            this.CeResponsible.Properties.DisplayValueUnchecked = "Hayır";
            this.CeResponsible.Properties.ValueChecked = ((byte)(1));
            this.CeResponsible.Properties.ValueUnchecked = ((byte)(0));
            this.CeResponsible.Size = new System.Drawing.Size(303, 19);
            this.CeResponsible.StyleController = this.LcMain;
            this.CeResponsible.TabIndex = 9;
            // 
            // LciResponsible
            // 
            this.LciResponsible.Control = this.CeResponsible;
            this.LciResponsible.Location = new System.Drawing.Point(0, 120);
            this.LciResponsible.Name = "LciResponsible";
            this.LciResponsible.Size = new System.Drawing.Size(392, 35);
            this.LciResponsible.Text = "Mülk Sahibine Ait";
            this.LciResponsible.TextSize = new System.Drawing.Size(80, 13);
            // 
            // LuLogoFirm
            // 
            this.LuLogoFirm.Location = new System.Drawing.Point(97, 12);
            this.LuLogoFirm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LuLogoFirm.Name = "LuLogoFirm";
            this.LuLogoFirm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuLogoFirm.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOGICALREF", "Referans No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Firma Kodu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Firma Adı")});
            this.LuLogoFirm.Properties.DisplayMember = "CODE";
            this.LuLogoFirm.Properties.NullText = "";
            this.LuLogoFirm.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuLogoFirm.Properties.ValueMember = "LOGICALREF";
            this.LuLogoFirm.Size = new System.Drawing.Size(303, 20);
            this.LuLogoFirm.StyleController = this.LcMain;
            this.LuLogoFirm.TabIndex = 10;
            // 
            // LciLogoFirm
            // 
            this.LciLogoFirm.Control = this.LuLogoFirm;
            this.LciLogoFirm.Location = new System.Drawing.Point(0, 0);
            this.LciLogoFirm.Name = "LciLogoFirm";
            this.LciLogoFirm.Size = new System.Drawing.Size(392, 24);
            this.LciLogoFirm.Text = "Logo Şirket No";
            this.LciLogoFirm.TextSize = new System.Drawing.Size(80, 13);
            // 
            // luItem1
            // 
            this.luItem1.Location = new System.Drawing.Point(97, 60);
            this.luItem1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.luItem1.Name = "luItem1";
            this.luItem1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luItem1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOGICALREF", "Referans No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.luItem1.Properties.DisplayMember = "CODE";
            this.luItem1.Properties.NullText = "";
            this.luItem1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luItem1.Properties.ValueMember = "LOGICALREF";
            this.luItem1.Size = new System.Drawing.Size(303, 20);
            this.luItem1.StyleController = this.LcMain;
            this.luItem1.TabIndex = 11;
            this.luItem1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.luItem1_QueryPopUp);
            // 
            // LciLogoExpenseType
            // 
            this.LciLogoExpenseType.Control = this.luItem1;
            this.LciLogoExpenseType.Location = new System.Drawing.Point(0, 48);
            this.LciLogoExpenseType.Name = "LciLogoExpenseType";
            this.LciLogoExpenseType.Size = new System.Drawing.Size(392, 24);
            this.LciLogoExpenseType.Text = "Logo Gider Kodu";
            this.LciLogoExpenseType.TextSize = new System.Drawing.Size(80, 13);
            // 
            // FrmExpenseTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 212);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FrmExpenseTypeAdd";
            this.Text = "Gider Türü Detayı";
            this.Load += new System.EventHandler(this.FrmExpenseTypeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeResponsible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciResponsible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuLogoFirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoFirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luItem1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoExpenseType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.TextEdit TxtCode;
        private DevExpress.XtraLayout.LayoutControlItem LciCode;
        private DevExpress.XtraLayout.LayoutControlItem LciName;
        private RentControls.ceCheckEdit CeResponsible;
        private RentControls.IcbExpenseType CbType;
        private DevExpress.XtraLayout.LayoutControlItem LciType;
        private DevExpress.XtraLayout.LayoutControlItem LciResponsible;
        private RentControls.LuItem luItem1;
        private RentControls.LuFirm LuLogoFirm;
        private DevExpress.XtraLayout.LayoutControlItem LciLogoFirm;
        private DevExpress.XtraLayout.LayoutControlItem LciLogoExpenseType;
    }
}