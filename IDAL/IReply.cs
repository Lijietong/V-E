﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace IDAL
{
    public interface IReply
    {
        DataTable SelectByCommentId(int id);
        int Insert(Reply reply);
    }
}
