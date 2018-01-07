using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Goods
    {
        public int GoodsID { get; set; }
        public string GoodsType { get; set; }
        public string GoodsGrade { get; set; }
        public string GoodsName { get; set; }
        public string Author { get; set; }
        public string Tec_name { get; set; }
        public string introduce { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public int Sale_name { get; set; }
        public int Rest_num { get; set; }
        public DateTime Release_time { get; set; }
        public string MoreDetails { get; set; }
    }
}
