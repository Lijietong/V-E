using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using IDAL;
using DALFactory;

namespace BLL
{
    public class UserInfoManager
    {
        private static IUserInfo iuserinfo = DataAccess.CreateUserInfo();

    }
}
