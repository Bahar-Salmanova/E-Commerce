using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool Status { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddedBy { get; set; }
        //dotnet ef --startup-project.\E-Commerce\E-Commerce.csproj migrations add ChangeBaseEntity -p.\Data\Data.csproj
    }
}
