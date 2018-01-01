using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Books
    {
        public int BooksID { get; set; }
        public string Books_name { get; set; }
        public string Books_subject { get; set; }
        public string Books_grade { get; set; }
        public int Books_rest { get; set; }
        public int sale_num { get; set; }
        public string images { get; set; }
        public string introduce { get; set; }
        public string Author { set; get; }
        public DateTime Release_time { set; get; }
        public decimal Price { get; set; }
    }
}
