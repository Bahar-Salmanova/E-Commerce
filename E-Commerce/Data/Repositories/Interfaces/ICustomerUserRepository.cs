using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface ICustomerUserRepository : IRepository<CustomerUser>
    {
        Task<IEnumerable<CustomerUser>> GetEmailByCustomer(string email);
        Task<IEnumerable<CustomerUser>> GetPasswordByCustomer(string password);
    }
}
