using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AzSM.Controllers
{
    public abstract class AzSMControllerBase: AbpController
    {
        protected AzSMControllerBase()
        {
            LocalizationSourceName = AzSMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
