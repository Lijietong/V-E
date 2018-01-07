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
    public partial class Mall1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    HadLogin.Visible = true;
                    NotLogin.Visible = false;
                    lbusername.InnerText = "欢迎您，" + Session["UserName"].ToString();
                }
                else
                {
                    NotLogin.Visible = true;
                    HadLogin.Visible = false;
                }
            }
            BindAllVideo();
            BindxxVideo();
            BindczVideo();
            BindgzVideo();
            BindAllBooks();
            BindxxBooks();
            BindczBooks();
            BindgzBooks();                
        }
        protected void lbtnregister_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
        }
        public void BindAllVideo()
        {
            DataTable dt = GoodsManager.SelectAllVideo();
            if(dt != null && dt.Rows.Count != 0)
            {
                LVVideo.DataSource = dt;
                LVVideo.DataBind();
            }          
        }
        public void BindxxVideo()
        {
            DataTable dt = GoodsManager.SelectxxVideo();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVxxVideo.DataSource = dt;
                LVxxVideo.DataBind();
            }
        }
        public void BindczVideo()
        {
            DataTable dt = GoodsManager.SelectczVideo();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVczVideo.DataSource = dt;
                LVczVideo.DataBind();
            }
        }
        public void BindgzVideo()
        {
            DataTable dt = GoodsManager.SelectgzVideo();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVgzVideo.DataSource = dt;
                LVgzVideo.DataBind();
            }
        }
        public void BindAllBooks()
        {
            DataTable dt = GoodsManager.SelectAllBooks();
            if(dt != null && dt.Rows.Count != 0)
            {
                LVBooks.DataSource = dt;
                LVBooks.DataBind();
            }
        }
        public void BindxxBooks()
        {
            DataTable dt = GoodsManager.SelectxxBooks();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVxxBooks.DataSource = dt;
                LVxxBooks.DataBind();
            }
        }
        public void BindczBooks()
        {
            DataTable dt = GoodsManager.SelectczBooks();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVczBooks.DataSource = dt;
                LVczBooks.DataBind();
            }
        }
        public void BindgzBooks()
        {
            DataTable dt = GoodsManager.SelectgzBooks();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVgzBooks.DataSource = dt;
                LVgzBooks.DataBind();
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {

        }
        protected int BindUserMallCart()
        {
            int UserMallCartNum;
            if (Session["UserID"] != null)
            {
                int userID = Convert.ToInt32(Session["UserID"]);
                DataTable VSS = GoodsManager.SelectUserMallCart(userID);
                if (VSS != null && VSS.Rows.Count > 0)
                {
                    return UserMallCartNum = VSS.Rows.Count;
                }
                else
                {
                    return UserMallCartNum = 0;
                }
            }
            else
            {
                return UserMallCartNum = 0;
            }
        }

        protected void DPVideo_PreRender(object sender, EventArgs e)
        {
            LVVideo.DataBind();
        }

        protected void DPBooks_PreRender(object sender, EventArgs e)
        {
            LVBooks.DataBind();
        }

        protected void btnshoucar_Click(object sender, EventArgs e)
        {
            Response.Redirect("shoppingcar.aspx");
        }
    }
}