using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace Models
{
    public class MallItemcart
    {
        public int UserID
        {
            get; set;
        }
        public int ShoppingCartID
        {
            get; set;
        }
        public int GoodsID
        {
            get; set;
        }
        public float Unit_price
        {
            get; set;
        }
        public int Qty
        {
            get; set;
        }
        public float Tot_amt
        {
            get; set;
        }
    }
}
