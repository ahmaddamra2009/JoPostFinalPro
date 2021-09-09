using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string ClientName { get; set; }
        public string JobTitle { get; set; }
        public string Desc { get; set; }
        public bool isPublished { get; set; }
        public bool isDeleted { get; set; }
    }
}
