﻿using Identity_Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity_Infrastructure.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(i => i.Id).IsRequired();
        builder.Property(r => r.Name).IsRequired();
        builder.HasMany(r => r.Identities).WithMany(i => i.Roles);
        builder.HasMany(r => r.Claims).WithMany(r => r.Roles);
    }
}