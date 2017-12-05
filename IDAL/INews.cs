using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace IDAL
{
    public interface INews
    {
        DataTable SelectHotNews(int num);
        int InsertNews(News news);
        int DeleteNews(int NewsID);
    }
}
