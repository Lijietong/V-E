using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order_items
    {
        public string Items_id { get; set; }
        public string Order_no { get; set; }
        public string Ref_id { get; set; }
        public string Items_name { get; set; }
        public string Items_num { get; set; }
        public string Items_unitprice { get; set; }
        public string Items_totprice { get; set; }
        public DateTime Items_ordertime { get; set; }
        public string Methods_of_delivery { get; set; }
    }
}
