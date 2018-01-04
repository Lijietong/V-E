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
    public class ReplyMallCommentsManager
    {
        private static IReplyMallComments ireplymallcomments = DataAccess.CreateReplyMallComments();
        public static DataTable SelectAllReplyMallComments()
        {
            return ireplymallcomments.SelectAllReplyMallComments();
        }
        public static int InsertReplyMallComments(ReplyMallComments replymallcomments)
        {
            return ireplymallcomments.InsertReplyMallComments(replymallcomments);
        }
        public static int DeleteReplyMallComments(int ComID)
        {
            return ireplymallcomments.DeleteReplyMallComments(ComID);
        }
    }
}
