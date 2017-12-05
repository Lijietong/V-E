using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Announcement
    {
        public string Ann_id { get; set; }
        public string Ann_content { get; set; }
        public DateTime Release_time { get; set; }
        public int Keep_days { get; set; }
        public string Digest { get; set; }
    }
}
