using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HQF.Daily.MultiTenancy.Dto;

namespace HQF.Daily.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
