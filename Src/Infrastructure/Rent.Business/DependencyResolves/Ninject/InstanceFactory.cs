using Ninject;
using Ninject.Modules;

namespace Rent.Business.DependencyResolves.Ninject
{
    public class InstanceFactory
    {
        private static IKernel _ninjectKernel;
        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }
        public static T GetInstance<T>()
        {
            _ninjectKernel = new StandardKernel(new BusinessModule());
            return _ninjectKernel.Get<T>();
        }
    }
}
