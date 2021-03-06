using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementation
{
   public class ProductRepository:Repository<Product>, IProductRepository
    {public ProductRepository(ApplicationDbContext context) : base(context) { }
        private ApplicationDbContext _context => Context as ApplicationDbContext;
      public async Task<IEnumerable<Product>> GetDiscountById(int productId)
        {
            return await _context.Products
                .Include(p => p.DiscountProducts)
                .Where(p => p.Id == productId).ToListAsync();
        }
    }
}
