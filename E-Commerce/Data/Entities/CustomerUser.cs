using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class CustomerUser:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PermissionsId { get; set; }
        public Permissions Permissions { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }

    }
}
