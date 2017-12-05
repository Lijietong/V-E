using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class News
    {
        public string News_id { get; set; }
        public string News_content { get; set; }
        public string News_theme { get; set; }
        public int Keep_days { get; set; }
        public DateTime Release_time { get; set; }
    }
}
