using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace IDAL
{
    public interface ICourses
    {
        DataTable SelectxxTop3();
        DataTable SelectczTop3();
        DataTable SelectgzTop3();
        
    }
}
