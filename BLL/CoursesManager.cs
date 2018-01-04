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
    public class CoursesManager
    {
        private static ICourses icourses = DataAccess.CreateCourses();
        public static DataTable SelectxxTop3()
        {
            return icourses.SelectxxTop3();
        }
        public static DataTable SelectczTop3()
        {
            return icourses.SelectczTop3();
        }
        public static DataTable SelectgzTop3()
        {
            return icourses.SelectgzTop3();
        }
        //public static DataTable SelectCourseByCno(int Cno)
        //{
        //    return icourses.SelectCourseByCno(Cno);
        //}
    }
}
