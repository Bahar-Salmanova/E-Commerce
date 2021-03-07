using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
  public  class BasketItem:BaseEntity
    {
        public BasketItem()
        {
            Product = new Product();
        }
       public int Quantity { get; set; }
        public int ProductId { get; set; }
        public  Product Product { get; set; }        
        public int AdminUserId { get; set; }
        public AdminUser AdminUsers { get; set; }
        public int CustomerUserId { get; set; }
        public CustomerUser CustomerUser { get; set; }
       
    }
}
