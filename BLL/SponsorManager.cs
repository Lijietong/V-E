﻿using System;
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
    public class SponsorManager
    {
        private static ISponsor isponsor = DataAccess.CreateSponsor();

    }
}
