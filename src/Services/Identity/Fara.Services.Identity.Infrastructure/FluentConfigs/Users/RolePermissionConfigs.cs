using DoubleCode.Domain.Entity.Permissions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fara.Services.Identity.Infrastructure.FluentConfigs.Users;

public class RolePermissionConfigs : IEntityTypeConfiguration<RolePermission>
{
    public void Configure(EntityTypeBuilder<RolePermission> builder)
    {

    }
}
