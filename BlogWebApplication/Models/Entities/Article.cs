using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace BlogWebApplication.Models.Entities
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public int Rank { get; set; }
        public virtual User Author { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime LastCommentTime { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}