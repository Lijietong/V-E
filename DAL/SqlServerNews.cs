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
    public class SqlServerNews:INews
    {
        public DataTable SelectHotNews(int num)
        {
            string sql = "select top " + num + " * from News order by Release_time desc";
            return DBHelper.GetFillData(sql);
        }
        public int InsertNews(News news)
        {
            string sql = "insert into News(News_id,News_theme,News_content,eep_days,Release_time) values(@AssID,@NewsTitle,@NewsContent,@NewsImages,@NewsTime)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@News_id",news.News_id),
                new SqlParameter("@News_theme",news.News_theme),
                new SqlParameter("@News_content",news.News_content),
                new SqlParameter("@Keep_days",news.Keep_days),
                new SqlParameter("@Release_time",news.Release_time)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public int DeleteNews(int News_id)
        {
            string sql = "delete from News where News_id=@News_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@News_id", News_id)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
