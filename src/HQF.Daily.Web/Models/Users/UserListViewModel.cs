using System.Collections.Generic;
using HQF.Daily.Roles.Dto;
using HQF.Daily.Users.Dto;

namespace HQF.Daily.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}