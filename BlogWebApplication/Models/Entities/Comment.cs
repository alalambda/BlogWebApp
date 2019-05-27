using System;

namespace BlogWebApplication.Models.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public int Content { get; set; }
        public DateTime DateTime { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public bool IsReported { get; set; }
        public bool IsBlocked { get; set; }

        public Comment()
        {
            Id = new Guid();
        }
    }
}