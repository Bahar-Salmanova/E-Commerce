using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class CustomerUserConfiguration : IEntityTypeConfiguration<CustomerUser>
    {
        public void Configure(EntityTypeBuilder<CustomerUser> builder)
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
             .Property(m => m.Name)
             .HasMaxLength(50)
             .IsRequired();

            builder
              .Property(m => m.Surname)
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(m => m.Password)
                .HasMaxLength(50)
                .IsRequired();
            builder
             .Property(m => m.Email)
             .HasMaxLength(50)
             .IsRequired();
            builder.ToTable("CustomerUsers");

        }
    }
}
