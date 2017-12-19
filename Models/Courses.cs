using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Courses
    {
        public int Cno { get; set; }
        public string Cname { get; set; }
        public string Csubject { get; set; }
        public int Cgrade { get; set; }
        public int TecID { get; set; }
        public int SpoID { get; set; }
        public string course_picture { get; set; }
        public int Cclick_num { get; set; }
        public string C_introduce { get; set; }
    }
}
