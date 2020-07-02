using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AzSM.EntityFrameworkCore;
using AzSM.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AzSM.Web.Tests
{
    [DependsOn(
        typeof(AzSMWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AzSMWebTestModule : AbpModule
    {
        public AzSMWebTestModule(AzSMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AzSMWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AzSMWebMvcModule).Assembly);
        }
    }
}