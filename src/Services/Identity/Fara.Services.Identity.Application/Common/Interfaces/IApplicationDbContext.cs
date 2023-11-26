using DoubleCode.Domain.Entity.Permissions;
using Fara.Services.Identity.Domain.Entity.Permissions;
using Fara.Services.Identity.Domain.Entity.User;
using Microsoft.EntityFrameworkCore;

namespace Fara.Services.Identity.Application.Common.Interfaces;

public interface IApplicationDbContext
{

    #region User
    public DbSet<User> User { get; set; }
    public DbSet<UserRole> UserRole { get; set; }

    #endregion

    #region Permission
    public DbSet<Role> Role { get; set; }
    public DbSet<RolePermission> RolePermission { get; set; }

    #endregion

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
