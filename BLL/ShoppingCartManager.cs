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
    public class ShoppingCartManager
    {
        private static IShoppingCart ishopcart = DataAccess.CreateShoppingCart();
    }
}
