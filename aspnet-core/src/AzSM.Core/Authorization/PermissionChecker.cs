using Abp.Authorization;
using AzSM.Authorization.Roles;
using AzSM.Authorization.Users;

namespace AzSM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
