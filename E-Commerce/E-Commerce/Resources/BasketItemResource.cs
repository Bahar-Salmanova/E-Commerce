using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Resources
{
    public class BasketItemResource
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        //public Product Product { get; set; }
        //public int AdminUserId { get; set; }
        //public AdminUser AdminUsers { get; set; }
        //public int CustomerUserId { get; set; }
        //public CustomerUser CustomerUser { get; set; }
    }
}
