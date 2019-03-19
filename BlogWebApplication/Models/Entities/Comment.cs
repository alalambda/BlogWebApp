using System;

namespace BlogWebApplication.Models.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public int Content { get; set; }
        public DateTime DateTime { get; set; }
        public virtual User Author { get; set; }
        public bool IsReported { get; set; }
        public bool IsBlocked { get; set; }
    }
}