using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
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
            .Property(m => m.Value)
            .IsRequired();
            builder
             .Property(m => m.IsMoney)
             .IsRequired()
             .HasDefaultValue(false);
            builder.ToTable("Discount");
        }
    }
}
