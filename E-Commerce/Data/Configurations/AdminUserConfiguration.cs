using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class AdminUserConfiguration : IEntityTypeConfiguration<AdminUser>
    {
        public void Configure(EntityTypeBuilder<AdminUser> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
               .Property(m => m.Status)
               .IsRequired()
               .HasDefaultValue(true);

            builder
              .Property(m => m.UserName)
              .HasMaxLength(50)
              .IsRequired();

            builder
              .Property(m => m.FirstName)
              .HasMaxLength(50)
              .IsRequired();
            //builder
            // .Property(m => m.Token)
            // .HasMaxLength(200)
            // .IsRequired();

            builder
              .Property(m => m.LastName)
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(m => m.Password)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(m => m.Permissions)
                    .WithMany(m => m.AdminUsers)
                    .HasForeignKey(m => m.PermissionsId)
                    .OnDelete(DeleteBehavior.Cascade);
                    
            builder.ToTable("AdminUsers");
        }
    }
}
