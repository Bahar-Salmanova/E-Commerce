using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Permissions:BaseEntity
    {
           public bool  IsBuyPermision { get; set; }
        public bool IsCreatePermission { get; set; }
        public ICollection<AdminUser> AdminUsers { get; set; }
       
        public ICollection<CustomerUser> CustomerUsers { get; set; }

    }
}
