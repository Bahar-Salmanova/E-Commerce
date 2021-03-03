using Data.Repositories.Implementation;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private AdminUserRepository _adminUsersRepository;
        private CustomerUserRepository _customerUserRepository;
        private DiscountProductRepository _discountProductRepository;
        private DiscountRepository _discountRepository;
        private PermissionRepository _permissionRepository;
        private ProductRepository _productRepository;
        private SellerRepository _sellerRepository;
        private UnitRepository _unitRepository;
        private StockRepository _stockRepository;
        private SuperAdminRepository _superAdminRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }

       
        public ICustomerUserRepository CustomerUser => _customerUserRepository ??= new CustomerUserRepository(_context);
        public IDiscountProductRepository DiscountProduct => _discountProductRepository ??= new DiscountProductRepository(_context);
        public IDiscountRepository Discount => _discountRepository ??= new DiscountRepository(_context);
        public IPermissionRepository Permission => _permissionRepository ??= new PermissionRepository(_context);
        public IProductRepository Product => _productRepository ??= new ProductRepository(_context);

        public ISellerRepository Seller => _sellerRepository ??= new SellerRepository(_context);
        public IUnitRepository Unit => _unitRepository ??= new UnitRepository(_context);
        public IStockRepository Stock => _stockRepository ??= new StockRepository(_context);
        public IAdminUserRepository AdminUsers => _adminUsersRepository ??= new AdminUserRepository(_context);
        public ISuperAdminRepository SuperAdmin => _superAdminRepository ??= new SuperAdminRepository(_context);



        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
  
    }
}
