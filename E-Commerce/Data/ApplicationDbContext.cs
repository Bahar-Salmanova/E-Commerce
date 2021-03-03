using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdminUserConfiguration());
            builder.ApplyConfiguration(new CustomerUserConfiguration());
            builder.ApplyConfiguration(new DiscountConfiguration());
            builder.ApplyConfiguration(new DiscountProductConfiguration());
            builder.ApplyConfiguration(new PermissionsConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new SellerConfiguration());
            builder.ApplyConfiguration(new StockConfiguration());
            builder.ApplyConfiguration(new UnitConfiguration());
            builder.ApplyConfiguration(new SuperAdminConfiguration());

        }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<CustomerUser> CustomerUsers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountProduct> DiscountProducts { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<SuperAdmin> SuperAdmins { get; set; }



    }
}
