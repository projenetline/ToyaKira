using Rent.Business.Concrete;
using Rent.Business.DependencyResolves.Ninject;
using Rent.Core.Concrete.Helpers;
using Rent.Domain.Helpers;
using System;
using Topshelf;

namespace Rent.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            TableAttribute.InsertWithCustomTableNameMapper();
            var exitCode = HostFactory.Run(x =>
              {
                  x.Service<PaymentManager>(d =>
                  {
                      d.ConstructUsing(service => InstanceFactory.GetInstance<PaymentManager>());
                      d.WhenStarted(service => service.Start());
                     // d.WhenContinued(service => service.Continued());
                      d.WhenStopped(service => service.Stop());
                  });
                  x.RunAsLocalSystem();
                  x.SetServiceName("NetLineLogoKiraPaymentService");
                  x.SetDisplayName("NetLineLogo Gayrimenkul Ödeme Control Servisi");
                  x.SetDescription("Netline Kira Programý - Logo arasýn da ödemeleri kontrol eden servistir.");
              });
            Environment.ExitCode= (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
        }
    }
}
