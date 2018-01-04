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
        int InsertMallComments(MallComments mallcomments);
        DataTable SelectAllComments();
        int DeleteMallComments(int ComID);
    }
}
