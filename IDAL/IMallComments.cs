using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
using System.Data.SqlClient;

namespace IDAL
{
    public interface IMallComments
    {
        //DataTable SelectComments(int ActID);
        int InsertMallComments(MallComments mallcomments);
        //DataTable SelectAllComments();
        //int DeleteComments(int ComID);
    }
}
