using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ReplyMallComments
    {
        public int ReplyMallCommentsID { get; set; }
        public int MallCommentsID { get; set; }
        public DateTime ReplyTime { get; set; }
        public int UserID { get; set; }
        public string ReplyContents { get; set; }

    }
}
