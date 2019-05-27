using System;

namespace BlogWebApplication.Models.Entities
{
    public class Permission
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Permission()
        {
            Id = Guid.NewGuid();
        }
    }
}