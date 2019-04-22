using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey("id");
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Login).HasColumnName("login");
            builder.Property(x => x.Password).HasColumnName("password");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.Active).HasColumnName("active");
        }
    }
}
