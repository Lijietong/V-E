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
        public static IAddress CreateAddress()
        {
            string className = assemblyName + "." + db + "Address";
            return (IAddress)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IAdminister CreateAdminister()
        {
            string className = assemblyName + "." + db + "Administer";
            return (IAdminister)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IAnnouncement CreateAnnouncement()
        {
            string className = assemblyName + "." + db + "Announcement";
            return (IAnnouncement)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IComments CreateComments()
        {
            string className = assemblyName + "." + db + "Comments";
            return (IComments)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ICourses CreateCourses()
        {
            string className = assemblyName + "." + db + "Courses";
            return (ICourses)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IExercises CreateExercises()
        {
            string className = assemblyName + "." + db + "Exercises";
            return (IExercises)Assembly.Load(assemblyName).CreateInstance(className);
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
        public static IPost CreatePost()
        {
            string className = assemblyName + "." + db + "Post";
            return (IPost)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IReference_books CreateReference_books()
        {
            string className = assemblyName + "." + db + "Reference_books";
            return (IReference_books)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IReply CreateReply()
        {
            string className = assemblyName + "." + db + "Reply";
            return (IReply)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ISA CreateSA()
        {
            string className = assemblyName + "." + db + "SA";
            return (ISA)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ISection CreateSection()
        {
            string className = assemblyName + "." + db + "Section";
            return (ISection)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ISponsor CreateSponsor()
        {
            string className = assemblyName + "." + db + "Sponsor";
            return (ISponsor)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static ISR CreateSR()
        {
            string className = assemblyName + "." + db + "SR";
            return (ISR)Assembly.Load(assemblyName).CreateInstance(className);
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
            string className = assemblyName + "." + db + "UserInfo ";
            return (IUserInfo)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IVideo CreateVideo()
        {
            string className = assemblyName + "." + db + "Video";
            return (IVideo)Assembly.Load(assemblyName).CreateInstance(className);
        }
    }
}
