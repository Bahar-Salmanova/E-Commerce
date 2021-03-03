using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Discount:BaseEntity
    {
        public int Value { get; set; }
        public bool IsMoney { get; set; }
        public ICollection<DiscountProduct> DiscountProducts { get; set; }
    }
}
