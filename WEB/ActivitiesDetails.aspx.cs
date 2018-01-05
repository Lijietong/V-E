using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace WEB
{
    public partial class ActivitiesDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["ActID"] = Convert.ToInt32(Request.QueryString["id"]);

            }
            Bindactivities();
            BindDataList1();
        }
        private void Bindactivities()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = ActivitiesManager.SelectActID(id);
            if (dt != null && dt.Rows.Count != 0)
            {   
                LVactivities.DataSource = dt;
                LVactivities.DataBind();
            }
        }
        private void BindDataList1()
        {
            DataTable dt = ActivitiesManager.SelectactTop8();
            if (dt != null && dt.Rows.Count != 0)
            {
                DataList1.DataSource = dt;
                DataList1.DataBind();

            }
        }
    }
}