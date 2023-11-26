﻿using DoubleCode.Domain.Entity.Permissions;
using Fara.Services.Identity.Application.Common.Interfaces;
using Fara.Services.Identity.Domain.Entity.Permissions;
using Fara.Services.Identity.Domain.Entity.User;
using Fara.Services.Identity.Infrastructure.FluentConfigs.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoubleCode.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<
                                    User,
                                    Role,
                                    int,
                                    IdentityUserClaim<int>,
                                    UserRole,
                                    IdentityUserLogin<int>,
                                    IdentityRoleClaim<int>,
                                    IdentityUserToken<int>>,
                                    IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    #region User
    public DbSet<User> User { get; set; }
    public DbSet<UserRole> UserRole { get; set; }
    #endregion

    #region Permission
    public DbSet<Role> Role { get; set; }
    public DbSet<RolePermission> RolePermission { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new UserConfigs());
        modelBuilder.ApplyConfiguration(new UserRoleConfigs());
        modelBuilder.ApplyConfiguration(new RoleConfigs());
        modelBuilder.ApplyConfiguration(new RolePermissionConfigs());

    }
}