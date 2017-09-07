using Abp.Authorization;
using HQF.Daily.Authorization.Roles;
using HQF.Daily.Authorization.Users;

namespace HQF.Daily.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
