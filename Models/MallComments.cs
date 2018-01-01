using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Models
{
    public class MallComments
    {
        public int MallCommentsID { get; set; }
        public int GoodsID { get; set; }
        public int UserID { get; set; }
        public DateTime Comments_time { get; set; }
        public string Comments_contents { get; set; }
    }
}
