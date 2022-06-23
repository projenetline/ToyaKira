namespace Rent.WinUI.Concrete.Forms.Parameters
{
    partial class FrmRealityAdd
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
            this.CbType = new Rent.WinUI.RentControls.IcbRealityType();
            this.LciType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.TxtCode = new Rent.WinUI.RentControls.txtTextEdit100();
            this.LciCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtName = new Rent.WinUI.RentControls.txtTextEdit100();
            this.LciName = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtAddress = new Rent.WinUI.RentControls.txtTextEdit100();
            this.LciAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.CeIsRentable = new Rent.WinUI.RentControls.ceCheckEdit();
            this.LciIsRentable = new DevExpress.XtraLayout.LayoutControlItem();
            this.LuLogoFirm = new Rent.WinUI.RentControls.LuFirm();
            this.LciLogoFirm = new DevExpress.XtraLayout.LayoutControlItem();
            this.LuItem1 = new Rent.WinUI.RentControls.LuItem();
            this.LciLogoKartNo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeIsRentable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIsRentable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuLogoFirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoFirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuItem1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoKartNo)).BeginInit();
            this.SuspendLayout();
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.LuItem1);
            this.LcMain.Controls.Add(this.LuLogoFirm);
            this.LcMain.Controls.Add(this.CeIsRentable);
            this.LcMain.Controls.Add(this.TxtAddress);
            this.LcMain.Controls.Add(this.TxtName);
            this.LcMain.Controls.Add(this.TxtCode);
            this.LcMain.Controls.Add(this.CbType);
            this.LcMain.Margin = new System.Windows.Forms.Padding(3);
            this.LcMain.Size = new System.Drawing.Size(412, 207);
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciType,
            this.emptySpaceItem1,
            this.LciCode,
            this.LciName,
            this.LciAddress,
            this.LciIsRentable,
            this.LciLogoFirm,
            this.LciLogoKartNo});
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(412, 207);
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
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // CbType
            // 
            this.CbType.Location = new System.Drawing.Point(114, 36);
            this.CbType.Margin = new System.Windows.Forms.Padding(1);
            this.CbType.Name = "CbType";
            this.CbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbType.Size = new System.Drawing.Size(286, 20);
            this.CbType.StyleController = this.LcMain;
            this.CbType.TabIndex = 4;
            this.CbType.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.CbType_QueryPopUp);
            // 
            // LciType
            // 
            this.LciType.Control = this.CbType;
            this.LciType.Location = new System.Drawing.Point(0, 24);
            this.LciType.Name = "LciType";
            this.LciType.Size = new System.Drawing.Size(392, 24);
            this.LciType.Text = "Taşınmaz Türü";
            this.LciType.TextSize = new System.Drawing.Size(97, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 167);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(392, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(114, 84);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(1);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Properties.MaxLength = 100;
            this.TxtCode.Size = new System.Drawing.Size(286, 20);
            this.TxtCode.StyleController = this.LcMain;
            this.TxtCode.TabIndex = 5;
            // 
            // LciCode
            // 
            this.LciCode.Control = this.TxtCode;
            this.LciCode.Location = new System.Drawing.Point(0, 72);
            this.LciCode.Name = "LciCode";
            this.LciCode.Size = new System.Drawing.Size(392, 24);
            this.LciCode.Text = "Taşınmaz Kodu";
            this.LciCode.TextSize = new System.Drawing.Size(97, 13);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(114, 108);
            this.TxtName.Margin = new System.Windows.Forms.Padding(1);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.MaxLength = 100;
            this.TxtName.Size = new System.Drawing.Size(286, 20);
            this.TxtName.StyleController = this.LcMain;
            this.TxtName.TabIndex = 6;
            // 
            // LciName
            // 
            this.LciName.Control = this.TxtName;
            this.LciName.Location = new System.Drawing.Point(0, 96);
            this.LciName.Name = "LciName";
            this.LciName.Size = new System.Drawing.Size(392, 24);
            this.LciName.Text = "Taşınmaz Adı";
            this.LciName.TextSize = new System.Drawing.Size(97, 13);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(114, 132);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(1);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Properties.MaxLength = 100;
            this.TxtAddress.Size = new System.Drawing.Size(286, 20);
            this.TxtAddress.StyleController = this.LcMain;
            this.TxtAddress.TabIndex = 7;
            // 
            // LciAddress
            // 
            this.LciAddress.Control = this.TxtAddress;
            this.LciAddress.Location = new System.Drawing.Point(0, 120);
            this.LciAddress.Name = "LciAddress";
            this.LciAddress.Size = new System.Drawing.Size(392, 24);
            this.LciAddress.Text = "Taşınmaz Adresi";
            this.LciAddress.TextSize = new System.Drawing.Size(97, 13);
            // 
            // CeIsRentable
            // 
            this.CeIsRentable.Location = new System.Drawing.Point(114, 156);
            this.CeIsRentable.Margin = new System.Windows.Forms.Padding(1);
            this.CeIsRentable.Name = "CeIsRentable";
            this.CeIsRentable.Properties.Caption = "";
            this.CeIsRentable.Properties.DisplayValueChecked = "Evet";
            this.CeIsRentable.Properties.DisplayValueUnchecked = "Hayır";
            this.CeIsRentable.Properties.ValueChecked = ((byte)(1));
            this.CeIsRentable.Properties.ValueUnchecked = ((byte)(0));
            this.CeIsRentable.Size = new System.Drawing.Size(286, 19);
            this.CeIsRentable.StyleController = this.LcMain;
            this.CeIsRentable.TabIndex = 8;
            // 
            // LciIsRentable
            // 
            this.LciIsRentable.Control = this.CeIsRentable;
            this.LciIsRentable.Location = new System.Drawing.Point(0, 144);
            this.LciIsRentable.Name = "LciIsRentable";
            this.LciIsRentable.Size = new System.Drawing.Size(392, 23);
            this.LciIsRentable.Text = "Kiralanabilir";
            this.LciIsRentable.TextSize = new System.Drawing.Size(97, 13);
            // 
            // LuLogoFirm
            // 
            this.LuLogoFirm.Location = new System.Drawing.Point(114, 12);
            this.LuLogoFirm.Margin = new System.Windows.Forms.Padding(1);
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
            this.LuLogoFirm.Size = new System.Drawing.Size(286, 20);
            this.LuLogoFirm.StyleController = this.LcMain;
            this.LuLogoFirm.TabIndex = 9;
            this.LuLogoFirm.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.LuLogoFirm_QueryPopUp);
            // 
            // LciLogoFirm
            // 
            this.LciLogoFirm.Control = this.LuLogoFirm;
            this.LciLogoFirm.Location = new System.Drawing.Point(0, 0);
            this.LciLogoFirm.Name = "LciLogoFirm";
            this.LciLogoFirm.Size = new System.Drawing.Size(392, 24);
            this.LciLogoFirm.Text = "Logo Şirket No";
            this.LciLogoFirm.TextSize = new System.Drawing.Size(97, 13);
            // 
            // LuItem1
            // 
            this.LuItem1.Location = new System.Drawing.Point(114, 60);
            this.LuItem1.Margin = new System.Windows.Forms.Padding(1);
            this.LuItem1.Name = "LuItem1";
            this.LuItem1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuItem1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOGICALREF", "Referans No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Ad")});
            this.LuItem1.Properties.DisplayMember = "CODE";
            this.LuItem1.Properties.NullText = "";
            this.LuItem1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuItem1.Properties.ValueMember = "LOGICALREF";
            this.LuItem1.Size = new System.Drawing.Size(286, 20);
            this.LuItem1.StyleController = this.LcMain;
            this.LuItem1.TabIndex = 10;
            this.LuItem1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.LuItem1_QueryPopUp);
            this.LuItem1.EditValueChanged += new System.EventHandler(this.LuItem1_EditValueChanged);
            // 
            // LciLogoKartNo
            // 
            this.LciLogoKartNo.Control = this.LuItem1;
            this.LciLogoKartNo.Location = new System.Drawing.Point(0, 48);
            this.LciLogoKartNo.Name = "LciLogoKartNo";
            this.LciLogoKartNo.Size = new System.Drawing.Size(392, 24);
            this.LciLogoKartNo.Text = "Logo Taşınmaz Kodu";
            this.LciLogoKartNo.TextSize = new System.Drawing.Size(97, 13);
            // 
            // FrmRealityAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 244);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FrmRealityAdd";
            this.Text = "Taşınmaz Detayı";
            this.Load += new System.EventHandler(this.FrmRealityAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeIsRentable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIsRentable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuLogoFirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoFirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuItem1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoKartNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RentControls.ceCheckEdit CeIsRentable;
        private RentControls.txtTextEdit100 TxtAddress;
        private RentControls.txtTextEdit100 TxtName;
        private RentControls.txtTextEdit100 TxtCode;
        private RentControls.IcbRealityType CbType;
        private DevExpress.XtraLayout.LayoutControlItem LciType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem LciCode;
        private DevExpress.XtraLayout.LayoutControlItem LciName;
        private DevExpress.XtraLayout.LayoutControlItem LciAddress;
        private DevExpress.XtraLayout.LayoutControlItem LciIsRentable;
        private RentControls.LuFirm LuLogoFirm;
        private DevExpress.XtraLayout.LayoutControlItem LciLogoFirm;
        private RentControls.LuItem LuItem1;
        private DevExpress.XtraLayout.LayoutControlItem LciLogoKartNo;
    }
}