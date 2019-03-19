using System.Collections.Generic;

namespace BlogWebApplication.Models.Entities
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}