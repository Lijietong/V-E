using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reply
    {
        public string Rep_id { get; set; }
        public string Rep_content { get; set; }
        public DateTime Rep_time { get; set; }
        public string Sno { get; set; }
        public string Post_id { get; set; }
    }
}
