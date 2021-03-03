using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementation
{
    public class SuperAdminRepository : Repository<SuperAdmin>, ISuperAdminRepository
    {
        public SuperAdminRepository(ApplicationDbContext context) : base(context) { }
    }
}
