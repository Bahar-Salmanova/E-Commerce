using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class DiscountProduct:BaseEntity
    {
       
        public int ProductId { get; set; }
        public int DiscountId { get; set; }
        public Product Product { get; set; }
        public Discount Discount { get; set; }
    }
}
