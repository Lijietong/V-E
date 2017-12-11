using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Article
    {
        public string Art_id { get; set; }
        public string Art_content { get; set; }
        public string Art_theme { get; set; }
        public DateTime Release_time { get; set; }
        public int Art_clicknum { get; set; }
        public string Art_grade { get; set; }
    }
}
