using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class SuperAdmin : BaseEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int PermissionsId { get; set; }
        public Permissions Permissions { get; set; }
    }
}
