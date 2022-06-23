using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Erp_Win;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Core.Concrete.Helpers;
using Rent.Core.Concrete.Resources;
using Rent.DataAccess.Concrete;
using Rent.Domain.Helpers;
using System;
using System.Windows.Forms;

namespace Rent.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                InstanceFactory.Wire(new BusinessModule());
                var settings = DbHelper.LogoDbSettings;
                BonusSkins.Register();
                SkinManager.EnableFormSkins();
                TableAttribute.InsertWithCustomTableNameMapper();
                UserLookAndFeel.Default.SkinName = "Office 2010 Blue";
                DialogResult result;
                using (var loginForm = InstanceFactory.GetInstance<FrmLogin>())
                    result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // login was successful
                    Application.Run(InstanceFactory.GetInstance<FrmMain>());
                }
                else if (result == DialogResult.Cancel)
                {

                }
                else
                {
                    MessageBox.Show(AppStrings.Error);
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
