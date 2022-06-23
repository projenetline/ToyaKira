using AutoMapper;
using Ninject.Modules;

namespace Rent.Business.DependencyResolves.Ninject
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToConstant(CreateCongiration().CreateMapper()).InSingletonScope();
        }
        private MapperConfiguration CreateCongiration()
        {
            var config = new MapperConfiguration(cfg =>
            {
#pragma warning disable CS0618 // Type or member is obsolete
                cfg.AddProfiles((System.Collections.Generic.IEnumerable<Profile>)GetType().Assembly);
#pragma warning restore CS0618 // Type or member is obsolete
            });
            return config;
        }
    }
}
