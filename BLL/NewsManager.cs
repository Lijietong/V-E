using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using DALFactory;
using Models;

namespace BLL
{
    public class NewsManager
    {
        private static INews inews = DataAccess.CreateNews();
        public DataTable SelectHotNews(int num)
        {
            return inews.SelectHotNews(num);
        }
        public int InsertNews(News news)
        {
            return inews.InsertNews(news);
        }
        public int DeleteNews(int News_id)
        {
            return inews.DeleteNews(News_id);
        }
    }
}
