using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class BasketItemsConfiguation : IEntityTypeConfiguration<BasketItem>
    {
        public void Configure(EntityTypeBuilder<BasketItem> builder)
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
           .Property(m => m.Quantity)
           .IsRequired();

            builder.HasOne(m => m.AdminUsers)
                    .WithMany(m => m.BasketItems)
                    .HasForeignKey(m => m.AdminUserId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Product)
                    .WithMany(m => m.BasketItems)
                    .HasForeignKey(m => m.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
            builder.ToTable("BasketItem");
        }
    }
}
