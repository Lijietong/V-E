using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Models;
using BLL;
using DAL;

namespace WEB
{
    public partial class Mall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                ViewState["BooksID"] = Convert.ToInt32(Request.QueryString["id"]);
            }
        }
        protected void btnComments_Click(object sender, EventArgs e)
        {
            //if (Session["UserName"] != null)
            //{
            //    if (Page.IsValid)
            //    {
            //        try
            //        {
            //            MallComments mallcomments = new MallComments();
            //            mallcomments.GoodsID = Convert.ToInt32(ViewState["GoodsID"]);
            //            mallcomments.UserID = Convert.ToInt32(Session["UserID"]);
            //            mallcomments.Comments_time = DateTime.Now;
            //            mallcomments.Comments_contents = txtComments.Text;
            //            int result = MallCommentsManager.InsertMallComments(mallcomments);
            //            if (result >= 1)
            //            {
            //                ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('评论成功！')", true);
            //                BindMallComments();
            //                txtComments.Text = "";
            //            }
            //            else
            //            {
            //                ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('未知原因 评论失败')", true);
            //            }
            //        }
            //        catch
            //        {
            //            ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('未知原因 评论失败')", true);
            //        }
            //    }
            //}
            //else
            //{
            //    ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('请先登录')", true);
            //}
        }

        protected void lbtnReply_Click(object sender, EventArgs e)
        {

        }

        protected void btnRply_Click(object sender, EventArgs e)
        {
            //if (Session["UserName"] != null)
            //{
            //    if (Page.IsValid)
            //    {
            //        Button btn = (Button)sender;
            //        string a = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text.Trim();
            //        ReplyMallComments replymallcomments = new ReplyMallComments();
            //        replymallcomments.MallCommentsID = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
            //        replymallcomments.UserID = int.Parse(Session["UserID"].ToString());
            //        replymallcomments.ReplyContents = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text.Trim();
            //        replymallcomments.ReplyTime = DateTime.Now;
            //        int result = GoodsManager.InsertReplyMallComments(replymallcomments);
            //        if (result >= 1)
            //        {
            //            ScriptManager.RegisterClientScriptBlock(UpP003, this.GetType(), "click", "alert('回复成功')", true);
            //            BindMallComments();
            //        }
            //        else
            //        {
            //            ScriptManager.RegisterClientScriptBlock(UpP003, this.GetType(), "click", "alert('未知原因 回复失败')", true);
            //        }
            //    }
            //}
            //else
            //{
            //    ScriptManager.RegisterClientScriptBlock(UpP003, this.GetType(), "click", "alert('请先登录');", true);
            //}
        }

        protected void LVMallComment_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

        }

        protected void lbmall_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mall.aspx");
        }
    }
}