﻿using Fara.Services.Identity.Domain.Entity.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fara.Services.Identity.Infrastructure.FluentConfigs.Users;

public class UserRoleConfigs : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UserRole");
    }
}
