using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebApplication.Models.Entities
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Permissions> Permissions { get; set; }
    }
}