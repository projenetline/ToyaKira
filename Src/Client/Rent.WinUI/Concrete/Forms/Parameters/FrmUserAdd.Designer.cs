namespace Rent.WinUI.Concrete.Forms.Parameters
{
    partial class FrmUserAdd
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
            this.TxtUserName = new DevExpress.XtraEditors.TextEdit();
            this.LciUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.LciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            this.LcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // LcMain
            // 
            this.LcMain.Controls.Add(this.TxtPassword);
            this.LcMain.Controls.Add(this.TxtUserName);
            this.LcMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LcMain.Size = new System.Drawing.Size(618, 292);
            // 
            // LcgMain
            // 
            this.LcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciUserName,
            this.LciPassword});
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(618, 292);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(484, 6);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(372, 6);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(110, 18);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(490, 26);
            this.TxtUserName.StyleController = this.LcMain;
            this.TxtUserName.TabIndex = 4;
            // 
            // LciUserName
            // 
            this.LciUserName.Control = this.TxtUserName;
            this.LciUserName.Location = new System.Drawing.Point(0, 0);
            this.LciUserName.Name = "LciUserName";
            this.LciUserName.Size = new System.Drawing.Size(588, 32);
            this.LciUserName.Text = "Kullanıcı Adı";
            this.LciUserName.TextSize = new System.Drawing.Size(87, 19);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(110, 50);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(490, 26);
            this.TxtPassword.StyleController = this.LcMain;
            this.TxtPassword.TabIndex = 5;
            // 
            // LciPassword
            // 
            this.LciPassword.Control = this.TxtPassword;
            this.LciPassword.Location = new System.Drawing.Point(0, 32);
            this.LciPassword.Name = "LciPassword";
            this.LciPassword.Size = new System.Drawing.Size(588, 230);
            this.LciPassword.Text = "Parola";
            this.LciPassword.TextSize = new System.Drawing.Size(87, 19);
            // 
            // FrmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 346);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUserAdd";
            this.Text = "Kullanıcı Detayı";
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            this.LcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.TextEdit TxtUserName;
        private DevExpress.XtraLayout.LayoutControlItem LciUserName;
        private DevExpress.XtraLayout.LayoutControlItem LciPassword;
    }
}