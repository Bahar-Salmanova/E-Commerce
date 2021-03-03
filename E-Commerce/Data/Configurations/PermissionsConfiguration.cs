using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class PermissionsConfiguration : IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
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
              .Property(m => m.IsBuyPermision)
              .IsRequired()
              .HasDefaultValue(true);
            builder
              .Property(m => m.IsCreatePermission)
              .IsRequired()
              .HasDefaultValue(true);
            builder.ToTable("Permissions");
        }
    }
}
