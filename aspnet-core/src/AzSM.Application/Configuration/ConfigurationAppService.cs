using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AzSM.Configuration.Dto;

namespace AzSM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AzSMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
