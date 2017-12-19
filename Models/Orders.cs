using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Orders
    {
        public int Order_no { get; set; }
        public int UserID { get; set; }
        public DateTime Order_date { get; set; }
        public decimal Tot_amt { get; set; }
        public string Address { get; set; }
        public string Telphone { get; set; }
    }
}
