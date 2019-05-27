using System;
using System.Collections.Generic;

namespace BlogWebApplication.Models.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public int Rank { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime LastCommentTime { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public Article()
        {
            Id = new Guid();
        }
    }
}