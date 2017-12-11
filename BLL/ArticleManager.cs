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
    public class ArticleManager
    {
        private static IArticle iarticle = DataAccess.CreateArticle();
        public static DataTable SelectHotArticles(int num)
        {
            return iarticle.SelectHotArticle(num);
        }
        public static int InsertArticle(Article article)
        {
            return iarticle.InsertArticle(article);
        }
        public static int DeleteArticle(int Art_id)
        {
            return iarticle.DeleteArticle(Art_id);
        }
        public static DataTable SelectxxTop8()
        {
            return iarticle.SelectxxTop8();
        }
        public static DataTable SelectczTop8()
        {
            return iarticle.SelectczTop8();
        }
        public static DataTable SelectgzTop8()
        {
            return iarticle.SelectgzTop8();
        }
    }
}
