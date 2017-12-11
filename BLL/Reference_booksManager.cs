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
    public class Reference_booksManager
    {
        private static IReference_books ireference_books = DataAccess.CreateReference_books();
        public static DataTable  SelectxxTop6()
        {
            return ireference_books.SelectxxTop6();
        }
        public static DataTable SelectczTop6()
        {
            return ireference_books.SelectczTop6();
        }
        public static DataTable SelectgzTop6()
        {
            return ireference_books.SelectgzTop6();
        }
    }
}
