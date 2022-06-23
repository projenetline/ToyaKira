using Rent.Business.Abstract;
using Rent.Core.Concrete.Helpers;
using Rent.Core.Concrete.Resources;
using Rent.Domain.Concrete.Models.Rent;
using Rent.WinUI.Concrete.Helpers;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Erp_Win
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userManager;
        private readonly ILogoDataService _logoDataService;
        private readonly IDbInitiliazerService _dbInitiliazerManager;

        bool userOk = false;
        public FrmLogin(IUserService userService, IDbInitiliazerService dbInitiliazerManager, ILogoDataService logoDataService)
        {
            _userManager = userService;
            _dbInitiliazerManager = dbInitiliazerManager;
            _logoDataService = logoDataService;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            _dbInitiliazerManager.AddDefaultUser();
            cbUserName.Properties.DataSource = _userManager.GetSluDataSourceAll();
            base.OnLoad(e);
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!userOk)
                e.Cancel = true;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Login();
        }
        void Login()
        {
            try
            {

                User user =_userManager.GetBy_UsrName_Pass(CurrentUserName, CurrentEncryptPassword);
                if (user != null)
                {
                    userOk = true;
                }
                else
                {
                    MessageHelper.StringMessage(AppStrings.Error, AppStrings.LoginError);
                    userOk = false;
                }

                if (userOk)
                    DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageHelper.ExeptionMessage(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            userOk = true;
            DialogResult = DialogResult.Cancel;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string CultureName = Thread.CurrentThread.CurrentCulture.Name;
            CultureInfo ci = new CultureInfo(CultureName);
            if (ci.NumberFormat.NumberDecimalSeparator != ".")
            {
                ci.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = ci;
            }
        }

        private string CurrentEncryptPassword
        {
            get
            {
                return SessionHelper.GetEncrypt(txtPass.Text.Trim());
            }
        }

        private string CurrentUserName
        {
            get
            {
                return cbUserName.Text.Trim();
            }
        }
    }
}