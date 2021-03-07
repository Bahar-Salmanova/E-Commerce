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
   public class BasketItemRepository : Repository<BasketItem>, IBasketItemRepository
    {
        
        public BasketItemRepository(ApplicationDbContext context) : base(context) { }
        private ApplicationDbContext _context => Context as ApplicationDbContext;
        
        public async Task<IEnumerable<BasketItem>> GetBasketItemsAsync(int adminUserId)
        {
            return await _context.BasketItems.Include(b => b.AdminUsers)
                .Where(b => b.Id == adminUserId).ToListAsync();
                  

        }
        public async Task<IEnumerable<BasketItem>> AddItemintoBasketAsync(BasketItem basketItem)
        {


            IEnumerable<BasketItem> basketItems = await _context.BasketItems.Include(b => b.AdminUsers)
                .Where(b => b.Id == basketItem.Id).ToListAsync();

            if (basketItems.Count()>0)
            {
                basketItem.Id = basketItems.Last().Id + 1;
            }
            else
            {
                basketItem.Id = 1;
            }

            return basketItems;
        }

        public async Task<IEnumerable<BasketItem>> ChangeBasketItemQuantityAsync(int basketItemId, int quantity)
        {
            var basketItem = await _context.BasketItems
                .Include(b=>b.AdminUsers)
                .Where(b => b.Id == basketItemId)
                .Where(b => b.Quantity == quantity)
                .ToListAsync();
            if (basketItem == null)
            {
                return null;
            }
         
            return (basketItem);

        }

        public async Task<IEnumerable<BasketItem>> ClearBasketAsync(int adminuserId)
        {
            var basketItems = await _context.BasketItems.Include(b => b.AdminUsers)
                   .Where(b => b.Id == adminuserId)
                   .ToListAsync();
            foreach (var basketItem in basketItems)
            {
                _context.Remove(basketItems);
            }
            await _context.SaveChangesAsync();

            return (basketItems);
   
        }

    }
}
