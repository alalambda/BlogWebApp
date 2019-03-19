using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebApplication.Models.Entities
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}