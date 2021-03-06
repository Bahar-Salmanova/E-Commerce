using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnitOfWork
    {
        IAdminUserRepository AdminUsers { get; }
        ICustomerUserRepository CustomerUser { get; }
        IDiscountProductRepository DiscountProduct { get; }
        IDiscountRepository Discount { get; }
        IPermissionRepository Permission { get; }
        IProductRepository Product { get; }
        ISellerRepository Seller { get; }
        IStockRepository Stock { get; }
        ISuperAdminRepository SuperAdmin { get; }
        IBasketItemRepository BasketItem { get; }
        IUnitRepository Unit { get; }
        Task<int> CommitAsync();
        
    }
}
