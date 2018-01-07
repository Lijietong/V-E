using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    HadLogin.Visible = true;
                    NotLogin.Visible = false;
                    lbusername.InnerText="欢迎您，"+ Session["UserName"].ToString();
                }
                else
                {
                    NotLogin.Visible = true;
                    HadLogin.Visible = false;
                }
            }
        }

        protected void houtairukou_Click(object sender, EventArgs e)
        {

        }
        protected void Logobtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void lbtnregister_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
        }
    }
}