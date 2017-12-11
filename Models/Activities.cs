using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Activities
    {
        public string Act_id { get; set; }
        public string Act_theme { get; set; }
        public string Act_content { get; set; }
        public DateTime Act_time { get; set; }
        public string Act_address { get; set; }
        public string Spo_id { get; set; }
        public int Click_num { get; set; }
        public string Act_images { get; set; }
        public string Act_grade { get; set; }
    }
}
