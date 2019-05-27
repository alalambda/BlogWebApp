using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BlogWebApplication.Models.Entities;

namespace BlogWebApplication.Models
{
    public class BlogWebApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BlogWebApplicationContext() : base("name=BlogWebApplicationContext")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }

        public static BlogWebApplicationContext Create()
        {
            return new BlogWebApplicationContext();
        }
    }
}
