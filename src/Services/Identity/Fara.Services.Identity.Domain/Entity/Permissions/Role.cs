using DoubleCode.Domain.Entity.Permissions;
using Fara.Services.Identity.Domain.Entity.User;
using Microsoft.AspNetCore.Identity;

namespace Fara.Services.Identity.Domain.Entity.Permissions;

public class Role : IdentityRole<int>
{
    #region Relations
    public ICollection<RolePermission> RolePermissions { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }

    #endregion
}

