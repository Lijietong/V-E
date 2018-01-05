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
    public interface IActivities
    {
        DataTable SelectxxTop4();
        DataTable SelectczTop4();
        DataTable SelectgzTop4();
        DataTable SelectactTop8();
        DataTable SelectActID(int ActID);
        int InsertActivity(Activities activities);
        int DeleteActivity(int Act_id);

    }
}
