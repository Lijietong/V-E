using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class ShopCart
    {
        public int ShopCartID { get; set; }
        public int UserID { get; set; }
        public int GoodsID { get; set; }
        public int Qty { get; set; }
        public decimal Unit_price { get; set; }
        public bool Flag { get; set; }
    }
}
