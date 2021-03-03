using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
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

            builder.HasOne(m => m.Unit)
                   .WithMany(m => m.Products)
                   .HasForeignKey(m => m.UnitId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(m => m.Seller)
                   .WithMany(m => m.Products)
                   .HasForeignKey(m => m.SellerId)
                   .OnDelete(DeleteBehavior.Cascade);
            
            builder.ToTable("Products");
        }
    }
}
