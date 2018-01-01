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
    public class SqlServerBooks:IBooks
    {
        public DataTable SelectxxTop6()
        {
            string sql = "select top 6 * from Books where Books_grade='小学' order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczTop6()
        {
            string sql = "select top 6 * from Books where Books_grade='初中' order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzTop6()
        {
            string sql = "select top 6 * from Books where Books_grade='高中' order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectAllBooks()
        {
            string sql = "select * from Books where booksID>25 order by price desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectxxBooks()
        {
            string sql = "select * from Books where books_grade='小学'and booksid>25 order by price";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczBooks()
        {
            string sql = "select * from Books where books_grade='初中' and booksid>25 order by price";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzBooks()
        {
            string sql = "select * from Books where books_grade='高中' and booksid>25 order by price";
            return DBHelper.GetFillData(sql);
        }
    }

}
