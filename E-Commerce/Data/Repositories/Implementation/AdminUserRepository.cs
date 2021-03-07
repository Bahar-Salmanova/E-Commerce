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
    public class AdminUserRepository:Repository<AdminUser>,IAdminUserRepository
    {
        public AdminUserRepository(ApplicationDbContext context) : base(context) { }
        private ApplicationDbContext _context => Context as ApplicationDbContext;

        public async Task <IEnumerable<AdminUser>> GetFeaturedNameByAdmin(string username,string password)
        {
          return  await _context.AdminUsers.Include(a=>a.Permissions)
                .Where(a => a.UserName == username)
                .Where(a=>a.Password==password)
                .Where(a=>!a.Permissions.IsBuyPermision)
                .Where(a=>a.Permissions.IsCreatePermission)
                 .ToListAsync();
           
        }
       
    }
}
