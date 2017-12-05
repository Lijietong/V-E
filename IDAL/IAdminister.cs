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
    public interface IAdminister
    {
        DataTable SelectAdminister(string Adm_id);
        SqlDataReader Login(string Name, string pwd);
    }
}

