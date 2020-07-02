using System.Threading.Tasks;
using AzSM.Configuration.Dto;

namespace AzSM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
