using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Post
    {
        public string Post_id { get; set; }
        public string Post_headline { get; set; }
        public string Post_content { get; set; }
        public string Post_cai_nums { get; set; }
        public string Post_zan_nums { get; set; }
        public DateTime Post_time { get; set; }
        public DateTime Post_update_time { get; set; }
        public string Sno { get; set; }
        public string Sec_id { get; set; }
    }
}
