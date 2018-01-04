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
    public class SqlServerArticle:IArticle
    {
        public DataTable SelectHotArticle(int num)
        {
            string sql = "select top " + num + " * from Article order by Release_time desc";
            return DBHelper.GetFillData(sql);
        }
        public int InsertArticle(Article article)
        {
            string sql = "insert into Article(ArtID,Art_theme,Art_content,Release_time,Art_clicknum) values(@ArtID,@Art_theme,@Art_content,@Release_time,@Art_clicknum)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ArtID",article.ArtID),
                new SqlParameter("@Art_theme",article.Art_theme),
                new SqlParameter("@Art_content",article.Art_content),
                new SqlParameter("@Release_time",article.Release_time),
                new SqlParameter("@Art_clicknum",article.Art_clicknum)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public int DeleteArticle(int ArtID)
        {
            string sql = "delete from Article where ArtID=@ArtID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ArtID", ArtID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectxxTop8()
        {
            string sql = "select top 8 * from Article where Art_grade='小学' order by Art_clicknum desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczTop8()
        {
            string sql = "select top 8 * from Article where Art_grade='初中' order by Art_clicknum desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzTop8()
        {
            string sql = "select top 8 * from Article where Art_grade='高中' order by Art_clicknum desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectArticle(int ArtID)
        {
            string sql = "select * from Article where ArtID=@ArtID order by Art_clicknum desc";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ArtID",ArtID),
            };
            return DBHelper.GetFillData(sql, sp);

        }
    }
}
