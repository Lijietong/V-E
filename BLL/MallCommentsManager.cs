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
    public class MallCommentsManager
    {
        private static IMallComments imallcomments = DataAccess.CreateMallComments();
        public static int InsertMallComments(MallComments mallcomments)
        {
            return imallcomments.InsertMallComments(mallcomments);
        }
        public static DataTable SelectAllMallComments()
        {
            return imallcomments.SelectAllComments();
        }
        public static int DeleteMallComments(int ComID)
        {
            return imallcomments.DeleteMallComments(ComID);
        }
    }
}
