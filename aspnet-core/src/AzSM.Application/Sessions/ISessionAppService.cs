using System.Threading.Tasks;
using Abp.Application.Services;
using AzSM.Sessions.Dto;

namespace AzSM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
