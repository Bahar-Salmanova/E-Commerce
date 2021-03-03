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

        public async Task<IEnumerable<CustomerUser>> GetEmailByCustomer(string email)
        {
           return await _context.CustomerUsers.Where(c => c.Email == email).ToListAsync();
        }

        public async Task<IEnumerable<CustomerUser>> GetPasswordByCustomer(string password)
        {
          return  await _context.CustomerUsers.Where(c => c.Password == password).ToListAsync();
        }
    }
}
