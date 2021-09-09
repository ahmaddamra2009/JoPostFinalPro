using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        public string InsName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Img { get; set; }
        public string FB { get; set; }
        public string TW { get; set; }
        public string Ins { get; set; }
        public string linkedIn { get; set; }
        public bool isPublished { get; set; }
        public bool isDeleted { get; set; }

    }
}
