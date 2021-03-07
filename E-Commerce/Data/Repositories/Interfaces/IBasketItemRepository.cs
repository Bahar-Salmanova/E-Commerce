using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
   public  interface IBasketItemRepository : IRepository<BasketItem>
    {
        Task<IEnumerable<BasketItem>> GetBasketItemsAsync(int adminUserId);
        Task <IEnumerable<BasketItem>>AddItemintoBasketAsync(BasketItem basketItem);
        Task<IEnumerable<BasketItem>> ChangeBasketItemQuantityAsync(int basketItemId, int quantity);
        Task<IEnumerable<BasketItem>> ClearBasketAsync(int adminuserId);


        

    }
}
