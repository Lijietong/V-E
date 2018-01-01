using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Video
    {
        public int VideoID { get; set; }
        public string Tec_name { get; set; }
        public string VGrade { get; set; }
        public decimal Price { get; set; }
        public int Keepdays { get; set; }
        public string Pictures { get; set; }
    }
}
