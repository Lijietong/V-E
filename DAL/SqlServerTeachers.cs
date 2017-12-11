using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using Models;

namespace DAL
{
    public class SqlServerTeachers:ITeachers
    {
        public DataTable SelectTop4()
        {
            string sql = "select top 4 * from teachers order by fans desc";
            return DBHelper.GetFillData(sql);
        }
    }
}
