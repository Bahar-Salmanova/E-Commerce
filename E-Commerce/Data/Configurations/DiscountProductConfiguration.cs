using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class DiscountProductConfiguration : IEntityTypeConfiguration<DiscountProduct>
    {
        public void Configure(EntityTypeBuilder<DiscountProduct> builder)
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
            builder.HasOne(m => m.Product)
                    .WithMany(m => m.DiscountProducts)
                    .HasForeignKey(m => m.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(m => m.Discount)
                    .WithMany(m => m.DiscountProducts)
                    .HasForeignKey(m => m.DiscountId)
                    .OnDelete(DeleteBehavior.Cascade);
            builder.ToTable("DiscountProduct");

        }
    }
}
