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
    public class SqlServerCourses:ICourses
    {
        public DataTable SelectxxTop3()
        {
            string sql = "select top 3 * from courses where Cgrade='小学' order by Cclick_num desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczTop3()
        {
            string sql = "select top 3 * from courses where Cgrade='初中' order by Cclick_num desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzTop3()
        {
            string sql = "select top 3 * from courses where Cgrade='高中' order by Cclick_num desc";
            return DBHelper.GetFillData(sql);
        }
    }
}
