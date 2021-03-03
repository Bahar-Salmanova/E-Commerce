using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementation
{
   public class PermissionRepository:Repository<Permissions>, IPermissionRepository
    {
        public PermissionRepository(ApplicationDbContext context) : base(context) { }
    }
}
