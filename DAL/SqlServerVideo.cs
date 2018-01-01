using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using Models;

namespace DAL
{
    public class SqlServerVideo:IVideo
    {
        public DataTable SelectAll()
        {
            string sql = "select * from Video order by price desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectxxVideo()
        {
            string sql = "select * from Video where VGrade='小学' order by price desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczVideo()
        {
            string sql = "select * from Video where VGrade='初中' order by price desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzVideo()
        {
            string sql = "select * from Video where VGrade='高中' order by price desc";
            return DBHelper.GetFillData(sql);
        }
    }
}
