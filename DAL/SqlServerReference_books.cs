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
    public class SqlServerReference_books:IReference_books
    {
        public DataTable SelectxxTop6()
        {
            string sql = "select top 6 * from Reference_books where Ref_grade='小学' order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczTop6()
        {
            string sql = "select top 6 * from Reference_books where Ref_grade='初中' order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzTop6()
        {
            string sql = "select top 6 * from Reference_books where Ref_grade='高中' order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
    }

}
