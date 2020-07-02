using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AzSM.Authorization;

namespace AzSM
{
    [DependsOn(
        typeof(AzSMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AzSMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AzSMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AzSMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
