using Abp.Application.Services;
using AzSM.MultiTenancy.Dto;

namespace AzSM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

