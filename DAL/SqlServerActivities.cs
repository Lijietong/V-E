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
    public class SqlServerActivities:IActivities
    {
        public DataTable SelectTop5()
        {
            string sql = "select top5  from News order by Act_time desc";
            return DBHelper.GetFillData(sql);
        }
        public int InsertActivity(Activities activities)
        {
            string sql = "insert into Activities(UserID,AssID,ActName,ActTime,ActDescribe,ActContent,ActAddr,EndTime,ClickNum,ActPictures) values(@UserID,@AssID,@ActName,@ActTime,@ActDescribe,@ActContent,@ActAddr,@EndTime,@ClickNum,@ActPictures)";
            SqlParameter[] para =
            {
                new SqlParameter ("@Act_id",activities.Act_id),
                new SqlParameter ("@Act_theme",activities.Act_theme),
                new SqlParameter ("@Act_time",activities.Act_time),
                new SqlParameter ("@Act_content",activities.Act_content),
                new SqlParameter ("@Act_address",activities.Act_address),
                new SqlParameter ("@Spo_id",activities.Spo_id)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public int DeleteActivity(int Act_id)
        {
            SqlParameter[] sp = { new SqlParameter("@Act_id", Act_id) };
            return DBHelper.GetExcuteNonQuery("DeleteActivity", System.Data.CommandType.StoredProcedure, sp);
        }
    }
}
