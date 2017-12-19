using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace IDAL
{
    public interface IBooks
    {
        DataTable SelectxxTop6();
        DataTable SelectczTop6();
        DataTable SelectgzTop6();
    }
}
