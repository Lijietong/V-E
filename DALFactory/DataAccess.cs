using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using IDAL;

namespace DALFactory
{
    public class DataAccess
    {
        private static string assemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IActivities CreateActivities()
        {
            string className = assemblyName + "." + db + "Activities";
            return (IActivities)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IAdminister CreateAdminister()
        {
            string className = assemblyName + "." + db + "Administer";
            return (IAdminister)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IAddress CreateAddress()
        {
            string className = assemblyName + "." + db + "Address";
            return (IAddress)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IMallComments CreateMallComments()
        {
            string className = assemblyName + "." + db + "MallComments";
            return (IMallComments)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ICourses CreateCourses()
        {
            string className = assemblyName + "." + db + "Courses";
            return (ICourses)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IArticle CreateArticle()
        {
            string className = assemblyName + "." + db + "Article";
            return (IArticle)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IOrder_items CreateOrder_items()
        {
            string className = assemblyName + "." + db + "Order_items";
            return (IOrder_items)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IOrders CreateOrders()
        {
            string className = assemblyName + "." + db + "Orders";
            return (IOrders)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IGoods CreateGoods()
        {
            string className = assemblyName + "." + db + "Goods";
            return (IGoods)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IReplyMallComments CreateReplyMallComments()
        {
            string className = assemblyName + "." + db + "ReplyMallComments";
            return (IReplyMallComments)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IShoppingCart CreateShoppingCart()
        {
            string className = assemblyName + "." + db + "ShoppingCart";
            return (IShoppingCart)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ISponsor CreateSponsor()
        {
            string className = assemblyName + "." + db + "Sponsor";
            return (ISponsor)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IStudents CreateStudents()
        {
            string className = assemblyName + "." + db + "Students";
            return (IStudents)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ITeachers CreateTeachers()
        {
            string className = assemblyName + "." + db + "Teachers";
            return (ITeachers)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IUserInfo CreateUserInfo()
        {
            string className = assemblyName + "." + db + "UserInfo";
            return (IUserInfo)Assembly.Load(assemblyName).CreateInstance(className);
        }
    }
}
