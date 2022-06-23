
namespace Rent.WinUI.Concrete.Forms
{
    partial class FrmBaseAdd
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
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LcMain = new DevExpress.XtraLayout.LayoutControl();
            this.LcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BtnCancel);
            this.panelControl1.Controls.Add(this.BtnOk);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 244);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(467, 37);
            this.panelControl1.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(389, 5);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 27);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Vazgeç";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(314, 5);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(71, 27);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Tamam";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LcMain
            // 
            this.LcMain.AllowCustomization = false;
            this.LcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LcMain.Location = new System.Drawing.Point(0, 0);
            this.LcMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LcMain.Name = "LcMain";
            this.LcMain.Root = this.LcgMain;
            this.LcMain.Size = new System.Drawing.Size(467, 244);
            this.LcMain.TabIndex = 1;
            this.LcMain.Text = "layoutControl1";
            // 
            // LcgMain
            // 
            this.LcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LcgMain.GroupBordersVisible = false;
            this.LcgMain.Location = new System.Drawing.Point(0, 0);
            this.LcgMain.Name = "LcgMain";
            this.LcgMain.OptionsItemText.TextToControlDistance = 5;
            this.LcgMain.Size = new System.Drawing.Size(467, 244);
            this.LcgMain.TextVisible = false;
            // 
            // FrmBaseAdd
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(467, 281);
            this.Controls.Add(this.LcMain);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBaseAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBaseAdd";
            this.Load += new System.EventHandler(this.FrmBaseAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LcgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraLayout.LayoutControl LcMain;
        public DevExpress.XtraLayout.LayoutControlGroup LcgMain;
        protected System.Windows.Forms.Button BtnCancel;
        protected System.Windows.Forms.Button BtnOk;
    }
}