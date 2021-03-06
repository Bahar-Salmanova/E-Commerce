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


        //Task<BasketItem> AddItemintoBasketAsync(BasketItem basketItem);
        //Task<IList<BasketItem>> ChangeBasketItemQuantityAsync(int id, int quantity);
        //Task<IList<BasketItem>> ClearBasketAsync(int userId);
        //Task<IList<BasketItem>> DeleteBasketItemByIdAsync(int id);
        //Task<IList<BasketItem>> GetBasketItemsAsync(int userId);

    }
}
