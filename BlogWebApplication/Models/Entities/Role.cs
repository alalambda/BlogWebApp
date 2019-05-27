using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogWebApplication.Models.Entities
{
    public class Role : IdentityRole
    {
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}