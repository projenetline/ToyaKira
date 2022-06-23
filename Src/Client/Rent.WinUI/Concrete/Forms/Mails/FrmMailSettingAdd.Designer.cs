namespace Rent.WinUI.Concrete.Forms.Mails
{
    partial class FrmMailSettingAdd
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
            this.TxtDisplayName = new Rent.WinUI.RentControls.txtTextEdit50();
            this.LciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtUserName = new Rent.WinUI.RentControls.txtTextEdit50();
            this.LciUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtPassword = new Rent.WinUI.RentControls.txtTextEdit50();
            this.LciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtSmtpServer = new Rent.WinUI.RentControls.txtTextEdit50();
            this.LciSmtpServer = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtServerPortName = new Rent.WinUI.RentControls.txtTextEdit50();
            this.LciServerPortName = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciMailAccount = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LciMailAddres = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtMailAddres = new Rent.WinUI.RentControls.txtTextEdit50();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSmtpServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciSmtpServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServerPortName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciServerPortName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciMailAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciMailAddres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMailAddres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.TxtMailAddres);
            this.LcMain.Controls.Add(this.TxtServerPortName);
            this.LcMain.Controls.Add(this.TxtSmtpServer);
            this.LcMain.Controls.Add(this.TxtPassword);
            this.LcMain.Controls.Add(this.TxtUserName);
            this.LcMain.Controls.Add(this.TxtDisplayName);
            this.LcMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.LcMain.Size = new System.Drawing.Size(385, 222);
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciMailAccount});
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(385, 222);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(298, 6);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(223, 6);
            // 
            // TxtDisplayName
            // 
            this.TxtDisplayName.Location = new System.Drawing.Point(99, 43);
            this.TxtDisplayName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtDisplayName.Name = "TxtDisplayName";
            this.TxtDisplayName.Properties.MaxLength = 50;
            this.TxtDisplayName.Size = new System.Drawing.Size(262, 20);
            this.TxtDisplayName.StyleController = this.LcMain;
            this.TxtDisplayName.TabIndex = 4;
            // 
            // LciDisplayName
            // 
            this.LciDisplayName.Control = this.TxtDisplayName;
            this.LciDisplayName.Location = new System.Drawing.Point(0, 0);
            this.LciDisplayName.Name = "LciDisplayName";
            this.LciDisplayName.Size = new System.Drawing.Size(341, 24);
            this.LciDisplayName.Text = "Görünen Ad";
            this.LciDisplayName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(99, 67);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Properties.MaxLength = 50;
            this.TxtUserName.Size = new System.Drawing.Size(262, 20);
            this.TxtUserName.StyleController = this.LcMain;
            this.TxtUserName.TabIndex = 5;
            // 
            // LciUserName
            // 
            this.LciUserName.Control = this.TxtUserName;
            this.LciUserName.Location = new System.Drawing.Point(0, 24);
            this.LciUserName.Name = "LciUserName";
            this.LciUserName.Size = new System.Drawing.Size(341, 24);
            this.LciUserName.Text = "Kullanıcı Adı";
            this.LciUserName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(99, 91);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.MaxLength = 50;
            this.TxtPassword.Size = new System.Drawing.Size(262, 20);
            this.TxtPassword.StyleController = this.LcMain;
            this.TxtPassword.TabIndex = 6;
            // 
            // LciPassword
            // 
            this.LciPassword.Control = this.TxtPassword;
            this.LciPassword.Location = new System.Drawing.Point(0, 48);
            this.LciPassword.Name = "LciPassword";
            this.LciPassword.Size = new System.Drawing.Size(341, 24);
            this.LciPassword.Text = "Parola";
            this.LciPassword.TextSize = new System.Drawing.Size(70, 13);
            // 
            // TxtSmtpServer
            // 
            this.TxtSmtpServer.Location = new System.Drawing.Point(99, 139);
            this.TxtSmtpServer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtSmtpServer.Name = "TxtSmtpServer";
            this.TxtSmtpServer.Properties.MaxLength = 50;
            this.TxtSmtpServer.Size = new System.Drawing.Size(262, 20);
            this.TxtSmtpServer.StyleController = this.LcMain;
            this.TxtSmtpServer.TabIndex = 7;
            // 
            // LciSmtpServer
            // 
            this.LciSmtpServer.Control = this.TxtSmtpServer;
            this.LciSmtpServer.Location = new System.Drawing.Point(0, 96);
            this.LciSmtpServer.Name = "LciSmtpServer";
            this.LciSmtpServer.Size = new System.Drawing.Size(341, 24);
            this.LciSmtpServer.Text = "Server Name";
            this.LciSmtpServer.TextSize = new System.Drawing.Size(70, 13);
            // 
            // TxtServerPortName
            // 
            this.TxtServerPortName.Location = new System.Drawing.Point(99, 163);
            this.TxtServerPortName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtServerPortName.Name = "TxtServerPortName";
            this.TxtServerPortName.Properties.MaxLength = 50;
            this.TxtServerPortName.Size = new System.Drawing.Size(262, 20);
            this.TxtServerPortName.StyleController = this.LcMain;
            this.TxtServerPortName.TabIndex = 8;
            // 
            // LciServerPortName
            // 
            this.LciServerPortName.Control = this.TxtServerPortName;
            this.LciServerPortName.Location = new System.Drawing.Point(0, 120);
            this.LciServerPortName.Name = "LciServerPortName";
            this.LciServerPortName.Size = new System.Drawing.Size(341, 39);
            this.LciServerPortName.Text = "Port No";
            this.LciServerPortName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // LciMailAccount
            // 
            this.LciMailAccount.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciDisplayName,
            this.LciUserName,
            this.LciPassword,
            this.LciSmtpServer,
            this.LciServerPortName,
            this.LciMailAddres});
            this.LciMailAccount.Location = new System.Drawing.Point(0, 0);
            this.LciMailAccount.Name = "LciMailAccount";
            this.LciMailAccount.Size = new System.Drawing.Size(365, 202);
            this.LciMailAccount.Text = "Ana Hesap Bilgileri";
            // 
            // LciMailAddres
            // 
            this.LciMailAddres.Control = this.TxtMailAddres;
            this.LciMailAddres.Location = new System.Drawing.Point(0, 72);
            this.LciMailAddres.Name = "LciMailAddres";
            this.LciMailAddres.Size = new System.Drawing.Size(341, 24);
            this.LciMailAddres.Text = "E-Posta Adresi";
            this.LciMailAddres.TextSize = new System.Drawing.Size(70, 13);
            // 
            // TxtMailAddres
            // 
            this.TxtMailAddres.Location = new System.Drawing.Point(99, 115);
            this.TxtMailAddres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMailAddres.Name = "TxtMailAddres";
            this.TxtMailAddres.Properties.MaxLength = 50;
            this.TxtMailAddres.Size = new System.Drawing.Size(262, 20);
            this.TxtMailAddres.StyleController = this.LcMain;
            this.TxtMailAddres.TabIndex = 15;
            // 
            // FrmMailSettingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 259);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "FrmMailSettingAdd";
            this.Text = "Mail Hesap Ayarları";
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSmtpServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciSmtpServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServerPortName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciServerPortName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciMailAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciMailAddres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMailAddres.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RentControls.txtTextEdit50 TxtServerPortName;
        private RentControls.txtTextEdit50 TxtSmtpServer;
        private RentControls.txtTextEdit50 TxtPassword;
        private RentControls.txtTextEdit50 TxtUserName;
        private RentControls.txtTextEdit50 TxtDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem LciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem LciUserName;
        private DevExpress.XtraLayout.LayoutControlItem LciPassword;
        private DevExpress.XtraLayout.LayoutControlItem LciSmtpServer;
        private DevExpress.XtraLayout.LayoutControlItem LciServerPortName;
        private DevExpress.XtraLayout.LayoutControlGroup LciMailAccount;
        private RentControls.txtTextEdit50 TxtMailAddres;
        private DevExpress.XtraLayout.LayoutControlItem LciMailAddres;
    }
}