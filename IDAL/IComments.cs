using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace IDAL
{
    public interface IComments
    {
        DataTable SelectComments(int ActID);
        int InsertComments(Comments comments);
        DataTable SelectAllComments();
        int DeleteComments(int ComID);
    }
}
