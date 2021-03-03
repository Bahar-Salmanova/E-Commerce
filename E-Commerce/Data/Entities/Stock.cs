using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Stock:BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double Quantity { get; set; }

    }
}
