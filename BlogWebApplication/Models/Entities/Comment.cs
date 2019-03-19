using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebApplication.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int Content { get; set; }
        public DateTime DateTime { get; set; }
        public Users Author { get; set; }
        public bool IsReported { get; set; }
        public bool IsBlocked { get; set; }
    }
}