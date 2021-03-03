using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Product :BaseEntity
    {
        public string Name { get; set; }
        public LanguageType Type { get; set; }
        public int UnitId { get; set; }
        
        public int SellerId { get; set; }
        public int Price { get; set; }
        public Seller Seller { get; set; }
        public Unit Unit { get; set; }
        public ICollection<DiscountProduct> DiscountProducts { get; set; }
        public ICollection<Stock> Stocks { get; set; }

    }
}
