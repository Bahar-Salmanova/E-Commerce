using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementation
{
    public class SellerRepository:Repository<Seller>, ISellerRepository
    {
        public SellerRepository(ApplicationDbContext context) : base(context) { }
    }
}

