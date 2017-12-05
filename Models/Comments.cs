using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Comments
    {
        public string Com_id { get; set; }
        public string Sno { get; set; }
        public string Cno { get; set; }
        public string Com_content { get; set; }
        public DateTime Com_time { get; set; }
        public int Com_cai_nums { get; set; }
        public int Com_zan_nums { get; set; }
    }
}
