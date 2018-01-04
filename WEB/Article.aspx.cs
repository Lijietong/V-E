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
    public partial class Article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindArtID();            
        }

        protected void Logobtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        public void BindArtID()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = ArticleManager.SelectArticle(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                ArtContentRepeater.DataSource = dt;
                ArtContentRepeater.DataBind();
            }
        }

    }
}