using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


namespace Data.Configurations
{
    class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
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
            builder.ToTable("Unit");
        }
    }
}
