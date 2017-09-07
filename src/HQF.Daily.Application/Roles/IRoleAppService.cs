using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HQF.Daily.Roles.Dto;

namespace HQF.Daily.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
