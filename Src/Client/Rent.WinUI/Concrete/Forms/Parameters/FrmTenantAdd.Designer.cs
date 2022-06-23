namespace Rent.WinUI.Concrete.Forms.Parameters
{
    partial class FrmTenantAdd
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
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.LciName = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtIdentityNo = new DevExpress.XtraEditors.TextEdit();
            this.LciIdentityNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtAddress = new DevExpress.XtraEditors.TextEdit();
            this.LciAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtBankAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.LciBankAccountNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtIbanNumber = new DevExpress.XtraEditors.TextEdit();
            this.LciIbanNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.LuClCard1 = new Rent.WinUI.RentControls.LuClCard();
            this.LciLogoClCard = new DevExpress.XtraLayout.LayoutControlItem();
            this.LuLogoFirm = new Rent.WinUI.RentControls.LuFirm();
            this.LciFirm = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdentityNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIdentityNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciBankAccountNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIbanNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIbanNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuClCard1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoClCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuLogoFirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciFirm)).BeginInit();
            this.SuspendLayout();
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.LuLogoFirm);
            this.LcMain.Controls.Add(this.LuClCard1);
            this.LcMain.Controls.Add(this.TxtIbanNumber);
            this.LcMain.Controls.Add(this.TxtBankAccountNo);
            this.LcMain.Controls.Add(this.TxtAddress);
            this.LcMain.Controls.Add(this.TxtIdentityNo);
            this.LcMain.Controls.Add(this.TxtName);
            this.LcMain.Margin = new System.Windows.Forms.Padding(3);
            this.LcMain.Size = new System.Drawing.Size(412, 200);
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciName,
            this.LciIdentityNo,
            this.LciAddress,
            this.LciBankAccountNo,
            this.LciIbanNumber,
            this.LciLogoClCard,
            this.LciFirm});
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(412, 200);
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
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(95, 60);
            this.TxtName.Margin = new System.Windows.Forms.Padding(1);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(305, 20);
            this.TxtName.StyleController = this.LcMain;
            this.TxtName.TabIndex = 4;
            // 
            // LciName
            // 
            this.LciName.Control = this.TxtName;
            this.LciName.Location = new System.Drawing.Point(0, 48);
            this.LciName.Name = "LciName";
            this.LciName.Size = new System.Drawing.Size(392, 24);
            this.LciName.Text = "Ad-Soyad";
            this.LciName.TextSize = new System.Drawing.Size(78, 13);
            // 
            // TxtIdentityNo
            // 
            this.TxtIdentityNo.Location = new System.Drawing.Point(95, 84);
            this.TxtIdentityNo.Margin = new System.Windows.Forms.Padding(1);
            this.TxtIdentityNo.Name = "TxtIdentityNo";
            this.TxtIdentityNo.Properties.MaxLength = 11;
            this.TxtIdentityNo.Size = new System.Drawing.Size(305, 20);
            this.TxtIdentityNo.StyleController = this.LcMain;
            this.TxtIdentityNo.TabIndex = 5;
            // 
            // LciIdentityNo
            // 
            this.LciIdentityNo.Control = this.TxtIdentityNo;
            this.LciIdentityNo.Location = new System.Drawing.Point(0, 72);
            this.LciIdentityNo.Name = "LciIdentityNo";
            this.LciIdentityNo.Size = new System.Drawing.Size(392, 24);
            this.LciIdentityNo.Text = "Kimlik no";
            this.LciIdentityNo.TextSize = new System.Drawing.Size(78, 13);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(95, 108);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(1);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Properties.AutoHeight = false;
            this.TxtAddress.Size = new System.Drawing.Size(305, 32);
            this.TxtAddress.StyleController = this.LcMain;
            this.TxtAddress.TabIndex = 6;
            // 
            // LciAddress
            // 
            this.LciAddress.Control = this.TxtAddress;
            this.LciAddress.Location = new System.Drawing.Point(0, 96);
            this.LciAddress.Name = "LciAddress";
            this.LciAddress.Size = new System.Drawing.Size(392, 36);
            this.LciAddress.Text = "Açık Adres";
            this.LciAddress.TextSize = new System.Drawing.Size(78, 13);
            // 
            // TxtBankAccountNo
            // 
            this.TxtBankAccountNo.Location = new System.Drawing.Point(95, 144);
            this.TxtBankAccountNo.Margin = new System.Windows.Forms.Padding(1);
            this.TxtBankAccountNo.Name = "TxtBankAccountNo";
            this.TxtBankAccountNo.Size = new System.Drawing.Size(305, 20);
            this.TxtBankAccountNo.StyleController = this.LcMain;
            this.TxtBankAccountNo.TabIndex = 7;
            // 
            // LciBankAccountNo
            // 
            this.LciBankAccountNo.Control = this.TxtBankAccountNo;
            this.LciBankAccountNo.Location = new System.Drawing.Point(0, 132);
            this.LciBankAccountNo.Name = "LciBankAccountNo";
            this.LciBankAccountNo.Size = new System.Drawing.Size(392, 24);
            this.LciBankAccountNo.Text = "Banka Hesap No";
            this.LciBankAccountNo.TextSize = new System.Drawing.Size(78, 13);
            // 
            // TxtIbanNumber
            // 
            this.TxtIbanNumber.Location = new System.Drawing.Point(95, 168);
            this.TxtIbanNumber.Margin = new System.Windows.Forms.Padding(1);
            this.TxtIbanNumber.Name = "TxtIbanNumber";
            this.TxtIbanNumber.Size = new System.Drawing.Size(305, 20);
            this.TxtIbanNumber.StyleController = this.LcMain;
            this.TxtIbanNumber.TabIndex = 8;
            // 
            // LciIbanNumber
            // 
            this.LciIbanNumber.Control = this.TxtIbanNumber;
            this.LciIbanNumber.Location = new System.Drawing.Point(0, 156);
            this.LciIbanNumber.Name = "LciIbanNumber";
            this.LciIbanNumber.Size = new System.Drawing.Size(392, 24);
            this.LciIbanNumber.Text = "Iban No";
            this.LciIbanNumber.TextSize = new System.Drawing.Size(78, 13);
            // 
            // LuClCard1
            // 
            this.LuClCard1.Location = new System.Drawing.Point(95, 36);
            this.LuClCard1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LuClCard1.Name = "LuClCard1";
            this.LuClCard1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuClCard1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOGICALREF", "Referans No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "Firma Kodu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Firma Ünvanı")});
            this.LuClCard1.Properties.DisplayMember = "CODE";
            this.LuClCard1.Properties.NullText = "";
            this.LuClCard1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuClCard1.Properties.ValueMember = "LOGICALREF";
            this.LuClCard1.Size = new System.Drawing.Size(305, 20);
            this.LuClCard1.StyleController = this.LcMain;
            this.LuClCard1.TabIndex = 9;
            this.LuClCard1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.LuClCard1_QueryPopUp);
            this.LuClCard1.EditValueChanged += new System.EventHandler(this.LuClCard1_EditValueChanged);
            // 
            // LciLogoClCard
            // 
            this.LciLogoClCard.Control = this.LuClCard1;
            this.LciLogoClCard.Location = new System.Drawing.Point(0, 24);
            this.LciLogoClCard.Name = "LciLogoClCard";
            this.LciLogoClCard.Size = new System.Drawing.Size(392, 24);
            this.LciLogoClCard.Text = "Logo Cari Kodu";
            this.LciLogoClCard.TextSize = new System.Drawing.Size(78, 13);
            // 
            // LuLogoFirm
            // 
            this.LuLogoFirm.Location = new System.Drawing.Point(95, 12);
            this.LuLogoFirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.LuLogoFirm.Size = new System.Drawing.Size(305, 20);
            this.LuLogoFirm.StyleController = this.LcMain;
            this.LuLogoFirm.TabIndex = 10;
            // 
            // LciFirm
            // 
            this.LciFirm.Control = this.LuLogoFirm;
            this.LciFirm.Location = new System.Drawing.Point(0, 0);
            this.LciFirm.Name = "LciFirm";
            this.LciFirm.Size = new System.Drawing.Size(392, 24);
            this.LciFirm.Text = "Logo Şirket No";
            this.LciFirm.TextSize = new System.Drawing.Size(78, 13);
            // 
            // FrmTenantAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 237);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FrmTenantAdd";
            this.Text = "Kiracı Detayı";
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdentityNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIdentityNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciBankAccountNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIbanNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciIbanNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuClCard1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciLogoClCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuLogoFirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciFirm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtIbanNumber;
        private DevExpress.XtraEditors.TextEdit TxtBankAccountNo;
        private DevExpress.XtraEditors.TextEdit TxtAddress;
        private DevExpress.XtraEditors.TextEdit TxtIdentityNo;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraLayout.LayoutControlItem LciName;
        private DevExpress.XtraLayout.LayoutControlItem LciIdentityNo;
        private DevExpress.XtraLayout.LayoutControlItem LciAddress;
        private DevExpress.XtraLayout.LayoutControlItem LciBankAccountNo;
        private DevExpress.XtraLayout.LayoutControlItem LciIbanNumber;
        private RentControls.LuClCard LuClCard1;
        private DevExpress.XtraLayout.LayoutControlItem LciLogoClCard;
        private RentControls.LuFirm LuLogoFirm;
        private DevExpress.XtraLayout.LayoutControlItem LciFirm;
    }
}