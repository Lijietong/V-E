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
    public class SqlServerAnnouncement:IAnnouncement
    {
        public DataTable SelectContents()
        {
            string sql = "select Ann_content from Announcement";
            return DBHelper.GetFillData(sql);
        }
    }
}
