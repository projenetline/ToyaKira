using Ninject.Modules;
using Rent.Business.Abstract;
using Rent.Business.Concrete;
using Rent.DataAccess.Abstract;
using Rent.DataAccess.Concrete;

namespace Rent.Business.DependencyResolves.Ninject
{
    public class BusinessModule : NinjectModule, INinjectModule
    {
        public override void Load()
        {
            Bind<IDbInitiliazerDal>().To<DpDbInitiliazer>();
            Bind<IDbInitiliazerService>().To<DbInitiliazerManager>();

            Bind<IExpenseTypeDal>().To<DpExpenseTypeDal>();
            Bind<IExpenseTypeService>().To<ExpenseTypeManager>();

            Bind<ILogDal>().To<DpLogDal>();
            Bind<ILogService>().To<LogManager>();

            Bind<IMailSettingDal>().To<DpMailSettingDal>();
            Bind<IMailSettingService>().To<MailSettingManager>();

            Bind<IMailHeaderDal>().To<DpMailHeaderDal>();
            Bind<IMailHeaderService>().To<MailHeaderManager>();

            Bind<IMailHeaderLineDal>().To<DpMailHeaderLineDal>();
            Bind<IMailHeaderLineService>().To<MailHeaderLineManager>();

            Bind<IInsurancePolicyDal>().To<DpInsurancePolicyDal>();
            Bind<IInsurancePolicyService>().To<InsurancePolicyManager>();

            Bind<IPaymentDal>().To<DpPaymentDal>();
            Bind<IPaymentService>().To<PaymentManager>();

            Bind<IRealityDal>().To<DpRealityDal>();
            Bind<IRealityService>().To<RealityManager>();

            Bind<IRentContractDal>().To<DpRentContractDal>();
            Bind<IRentContractService>().To<RentContractManager>();

            Bind<IRentContractExpenseDal>().To<DpRentContractExpenseDal>();
            Bind<IRentContractExpenseService>().To<RentContractExpenseManager>();

            Bind<IRentContractRealityDal>().To<DpRentContractRealityDal>();
            Bind<IRentContractRealityService>().To<RentContractRealityManager>();

            Bind<ITenantDal>().To<DpTenantDal>();
            Bind<ITenantService>().To<TenantManager>();

            Bind<ILogoDataDal>().To<DpLogoDataDal>();
            Bind<ILogoDataService>().To<LogoDataManager>();

            Bind<IUserDal>().To<DpUserDal>();
            Bind<IUserService>().To<UserManager>();

            Bind<IWinFormPropertyService>().To<WinFormPropertyManager>();
            Bind<IWinFormPropertyDal>().To<DpWinFormPropertyDal>();

            Bind<IWinFormLayoutService>().To<WinFormLayoutManager>();
            Bind<IWinFormLayoutDal>().To<DpWinFormLayoutDal>();
        }
    }
}
