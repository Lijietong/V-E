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
            string sql = "select top 3 * from goods where goodsgrade='小学' order by sale_num desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczTop3()
        {
            string sql = "select top 3 * from goods where goodsgrade='初中' order by sale_num desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzTop3()
        {
            string sql = "select top 3 * from goods where goodsgrade='高中' order by sale_num desc";
            return DBHelper.GetFillData(sql);
        }
        //public DataTable SelectCourseByCno(int Cno)
        //{
        //    string sql = "select * from courses where cno like '" + @Cno + "'";
        //    SqlParameter[] sp = new SqlParameter[]
        //    {
        //        new SqlParameter("@Cno",Cno)
        //    };
        //    DataTable dt = DBHelper.GetFillData(sql,sp);
        //    return dt;
        //}
    }
}
