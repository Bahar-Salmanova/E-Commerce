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
   public class CustomerUserRepository:Repository<CustomerUser>, ICustomerUserRepository
    {public CustomerUserRepository(ApplicationDbContext context) : base(context) { }
        private ApplicationDbContext _context => Context as ApplicationDbContext;

        public async Task<IEnumerable<CustomerUser>> GetEmailByCustomer(string email,string password)
        {
        return await _context.CustomerUsers
                .Include(c=>c.Permissions)
                .Where(c => c.Email == email)
                .Where(c=>c.Password==password)
                .Where(a => a.Permissions.IsBuyPermision)
                .Where(a =>! a.Permissions.IsCreatePermission)
                .ToListAsync();
            
                
            
           
        }

    } ;
}
