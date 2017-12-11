using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace IDAL
{
    public interface IArticle
    {
        DataTable SelectHotArticle(int num);
        int InsertArticle(Article article);
        int DeleteArticle(int Art_id);
        DataTable SelectxxTop8();
        DataTable SelectczTop8();
        DataTable SelectgzTop8();
    }
}
