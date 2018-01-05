using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Activities
    {
        public int ActID { get; set; }
        public string Act_theme { get; set; }
        public string Act_content { get; set; }
        public string Act_summary { get; set; }
        public DateTime Act_time { get; set; }
        public string Act_address { get; set; }
        public int SpoID { get; set; }
        public int Click_num { get; set; }
        public string Act_images { get; set; }
        public string Act_grade { get; set; }
    }
}
