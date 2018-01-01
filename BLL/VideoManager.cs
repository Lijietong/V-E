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
    public class VideoManager
    {
        private static IVideo ivideo = DataAccess.CreateVideo();
        public static DataTable SelectAll()
        {
            return ivideo.SelectAll();
        }
        public static DataTable SelectxxVideo()
        {
            return ivideo.SelectxxVideo();
        }
        public static DataTable SelectczVideo()
        {
            return ivideo.SelectczVideo();
        }
        public static DataTable SelectgzVideo()
        {
            return ivideo.SelectgzVideo();
        }
    }
}
