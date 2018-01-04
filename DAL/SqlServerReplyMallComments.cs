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
    public class SqlServerReplyMallComments:IReplyMallComments
    {
        public int InsertReplyMallComments(ReplyMallComments replymallcomments)
        {
            string sql = "insert into ReplyComments values(@ReplyMallCommentsID,@UserID,@ReplyContents,@ReplyTime)";
            SqlParameter[] para = {
                new SqlParameter ("@ReplyMallCommentsID",replymallcomments.ReplyMallCommentsID),
                new SqlParameter ("@UserID",replymallcomments.UserID),
                new SqlParameter ("@ReplyContents",replymallcomments.ReplyContents),
                new SqlParameter ("@ReplyTime",replymallcomments.ReplyTime)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public DataTable SelectAllReplyMallComments()
        {
            string sql = "select ReplyMallComments.*,a.UserName as 回复者,b.UserName as 被回复者 from UserInfo a,UserInfo b,ReplyMallComments,MallComments where a.UserID=ReplyMallComments.UserID and b.UserID=MallComments.UserID and ReplyMallComments.ComID=MallComments.ComID ";
            return DBHelper.GetFillData(sql);
        }
        public int DeleteReplyMallComments(int ReplyMallComID)
        {
            string sql = "delete from ReplyMallComments where ReplyMallCommentsID=@ReplyMallComID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ReplyComID",ReplyMallComID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
