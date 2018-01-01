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
    public class SqlServerMallComments:IMallComments
    {

        public  int  InsertMallComments(MallComments mallcomments)
        {
            string sql = "insert into MallComments(MallCommentsID,GoodsID,UserID,Comments_time,Comments_contents) values(@MallCommentsID,@GoodsID,@UserID,@Comments_time,@Comments_contents)";
            SqlParameter[] para =
            {
                new SqlParameter ("@MallCommentsID",mallcomments.MallCommentsID),
                new SqlParameter("@GoodsID", mallcomments.GoodsID),
                new SqlParameter("@UserID", mallcomments.UserID),
                new SqlParameter("@Comments_time", mallcomments.Comments_time),
                new SqlParameter("@Comments_contents", mallcomments.Comments_contents)
            };
            return DBHelper.GetExcuteNonQuery(sql,para);
        }
        

    }
}
