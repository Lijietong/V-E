using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order_items
    {
        public int ItemsID { get; set; }
        public int Order_no { get; set; }
        public int GoodsID { get; set; }
        public int UserID { get; set; }
        public int Qty { get; set; }
        public decimal Unit_price { get; set; }        
    }
}
