using Rent.Business.DependencyResolves.Ninject;
using Rent.WinUI.Concrete.Forms;
using Rent.WinUI.Concrete.Forms.Contract;
using Rent.WinUI.Concrete.Forms.Mails;
using Rent.WinUI.Concrete.Forms.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent.WinUI.Concrete.Helpers
{
    public static class FormOpenHelper
    {
        public static void OpenTenants(Form parentForm)
        {
            FrmTenants frm = InstanceFactory.GetInstance<FrmTenants>();
            frm.FormLoad(parentForm);
            frm.MdiParent = parentForm;
            frm.Show();
        }

        public static void OpenUsers(Form parentForm)
        {
            FrmUsers frm = InstanceFactory.GetInstance<FrmUsers>();
            frm.FormLoad(parentForm);
            frm.MdiParent = parentForm;
            frm.Show();
        }

        public static void OpenExpenseTypes(Form parentForm)
        {
            FrmExpenseTypes frm = InstanceFactory.GetInstance<FrmExpenseTypes>();
            frm.FormLoad(parentForm);
            frm.MdiParent = parentForm;
            frm.Show();
        }

        public static void OpenRealities(Form parentForm)
        {
            FrmRealities frm = InstanceFactory.GetInstance<FrmRealities>();
            frm.FormLoad(parentForm);
            frm.MdiParent = parentForm;
            frm.Show();
        }
        public static void OpenRentContracts(Form parentForm)
        {
            FrmContracts frm = InstanceFactory.GetInstance<FrmContracts>();
            frm.FormLoad(parentForm);
            frm.MdiParent = parentForm;
            frm.Show();
        }

        public static void OpenMailSettings(Form parentForm)
        {
            FrmMailSettingAdd frm = InstanceFactory.GetInstance<FrmMailSettingAdd>();
            frm.SetParent(parentForm, true, false, false);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK && frm.SaveObj)
            {
                return;
            }
        }
        public static void OpenMailHeaders(Form parentForm)
        {
            FrmMailHeaders frm = InstanceFactory.GetInstance<FrmMailHeaders>();
            frm.FormLoad(parentForm);
            frm.MdiParent = parentForm;
            frm.Show();
        }
        public static void OpenInsurancePolicies(Form parentForm)
        {
            FrmInsurancePolicy frm = InstanceFactory.GetInstance<FrmInsurancePolicy>();
            frm.FormLoad(parentForm);
            frm.MdiParent = parentForm;
            frm.Show();
        }
    }
}
