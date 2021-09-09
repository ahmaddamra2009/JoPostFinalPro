using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime CreationDate { get; set; }
        public string img { get; set; }
        public bool isPublished { get; set; }
        public bool isDeleted { get; set; }
    }
}
