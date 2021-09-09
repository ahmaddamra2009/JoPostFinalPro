using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemUrl { get; set; }
        public bool isPublished { get; set; }
        public bool isDeleted { get; set; }
    }
}
