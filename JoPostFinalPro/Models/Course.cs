using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        [DataType(DataType.Date)]
        public DateTime SDate { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan STime { get; set; }
        public int Duration { get; set; }
        [Required]
        public string Period { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public string Img { get; set; }
        public Venu Venu { get; set; }
        public bool isPublished { get; set; }
        public bool isDeleted { get; set; }

    }

    public enum Venu
    {
        Online,
        Offline,
        Recorded
    }

}
