using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Models
{
    public class Slider
    {

        public int SliderId { get; set; }
        public string SliderTitle { get; set; }
        public string SubTitle { get; set; }
        public string Img { get; set; }
        public int Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public bool isPublished { get; set; }
        public bool isDeleted { get; set; }

    }
}
