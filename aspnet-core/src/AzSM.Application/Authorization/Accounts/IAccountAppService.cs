using System.Threading.Tasks;
using Abp.Application.Services;
using AzSM.Authorization.Accounts.Dto;

namespace AzSM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
