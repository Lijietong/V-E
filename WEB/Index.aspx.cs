using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace WEB
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindxxCourses();
            BindczCourses();
            BindgzCourses();
            BindxxActivities();
            BindczActivities();
            BindgzActivities();
            BindxxArticle();
            BindczArticle();
            BindgzArticle();
            BindxxReference_books();
            BindczReference_books();
            BindgzReference_books();
            BindTeachers();
        }
        private void BindxxCourses()
        {
            DataTable dt = CoursesManager.SelectxxTop3();
            if (dt != null && dt.Rows.Count != 0)
            {
                DLxxcourses.DataSource = dt;
                DLxxcourses.DataBind();                
            }
        }
        private void BindczCourses()
        {
            DataTable dt = CoursesManager.SelectczTop3();
            if (dt != null && dt.Rows.Count != 0)
            {
                DLczcourses.DataSource = dt;
                DLczcourses.DataBind();
            }
        }
        private void BindgzCourses()
        {
            DataTable dt = CoursesManager.SelectgzTop3();
            if (dt != null && dt.Rows.Count != 0)
            {
                DLgzcourses.DataSource = dt;
                DLgzcourses.DataBind();
            }
        }
        private void BindxxActivities()
        {
            DataTable dt = ActivitiesManager.SelectxxTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                DLxxActivity.DataSource = dt;
                DLxxActivity.DataBind();
            }
        }
        private void BindczActivities()
        {
            DataTable dt = ActivitiesManager.SelectczTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                DLczActivity.DataSource = dt;
                DLczActivity.DataBind();
            }
        }
        private void BindgzActivities()
        {
            DataTable dt = ActivitiesManager.SelectgzTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                DLgzActivity.DataSource = dt;
                DLgzActivity.DataBind();
            }
        }
        private void BindxxArticle()
        {
            DataTable dt = ArticleManager.SelectxxTop8();
            if (dt != null && dt.Rows.Count != 0)
            {
                RPxxArticle.DataSource = dt;
                RPxxArticle.DataBind();
            }
        }
        private void BindczArticle()
        {
            DataTable dt = ArticleManager.SelectczTop8();
            if (dt != null && dt.Rows.Count != 0)
            {
                RPczArticle.DataSource = dt;
                RPczArticle.DataBind();
            }
        }
        private void BindgzArticle()
        {
            DataTable dt = ArticleManager.SelectgzTop8();
            if (dt != null && dt.Rows.Count != 0)
            {
                RPgzArticle.DataSource = dt;
                RPgzArticle.DataBind();
            }
        }
        private void BindxxReference_books()
        {
            DataTable dt = Reference_booksManager.SelectxxTop6();
            if (dt != null && dt.Rows.Count != 0)
            {
                RPxxpaihang.DataSource = dt;
                RPxxpaihang.DataBind();
            }
        }
        private void BindczReference_books()
        {
            DataTable dt = Reference_booksManager.SelectczTop6();
            if (dt != null && dt.Rows.Count != 0)
            {
                RPczpaihang.DataSource = dt;
                RPczpaihang.DataBind();
            }
        }
        private void BindgzReference_books()
        {
            DataTable dt = Reference_booksManager.SelectgzTop6();
            if (dt != null && dt.Rows.Count != 0)
            {
                RPgzpaihang.DataSource = dt;
                RPgzpaihang.DataBind();
            }
        }
        private void BindTeachers()
        {
            DataTable dt = TeachersManager.SelectTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVteachers.DataSource = dt;
                LVteachers.DataBind();
            }

        }
    }
}