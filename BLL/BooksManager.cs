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
    public class BooksManager
    {
        private static IBooks ibooks = DataAccess.CreateBooks();
        public static DataTable  SelectxxTop6()
        {
            return ibooks.SelectxxTop6();
        }
        public static DataTable SelectczTop6()
        {
            return ibooks.SelectczTop6();
        }
        public static DataTable SelectgzTop6()
        {
            return ibooks.SelectgzTop6();
        }
        public static DataTable  SelectAllBooks()
        {
            return ibooks.SelectAllBooks();
        }
        public static DataTable SelectxxBooks()
        {
            return ibooks.SelectxxBooks();
        }
        public static DataTable SelectczBooks()
        {
            return ibooks.SelectczBooks();
        }
        public static DataTable SelectgzBooks()
        {
            return ibooks.SelectgzBooks();
        }
    }
}
