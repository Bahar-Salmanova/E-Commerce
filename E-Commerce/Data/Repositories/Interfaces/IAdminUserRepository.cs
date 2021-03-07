using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IAdminUserRepository : IRepository<AdminUser>
    {
        Task<IEnumerable<AdminUser>> GetFeaturedNameByAdmin(string email, string password);
        
    }
}
