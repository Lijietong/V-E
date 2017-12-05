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
    public class ActivitiesManager
    {
        private static IActivities iactivities = DataAccess.CreateActivities();
        public static int InsertActivity(Activities activities)
        {
            return iactivities.InsertActivity(activities);
        }
        public static int DeleteActivity(int Act_id)
        {
            return iactivities.DeleteActivity(Act_id);
        }
        public static DataTable SelectTop5()
        {
            return iactivities.SelectTop5();
        }

    }
}
