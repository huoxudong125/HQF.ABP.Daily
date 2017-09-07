using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HQF.Daily.Roles.Dto;
using HQF.Daily.Users.Dto;

namespace HQF.Daily.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}