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
        public DataTable SelectAllComments()
        {
            string sql = "select Photo,UserName,Comments_contents,GoodsID from UserInfo,Mallcomments where Mallcomments.UserID=UserInfo.UserID and Mallcomments.GoodsID=Goods.GoodsID";
            return DBHelper.GetFillData(sql);
        }
        public int DeleteMallComments(int ComID)
        {
            string sql = "delete from ReplyMallComments where CommentsID=@ComID delete from MallComments where CommentsID=@ComID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ComID",ComID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
