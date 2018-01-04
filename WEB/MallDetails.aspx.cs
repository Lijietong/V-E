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
                ViewState["GoodsID"] = Convert.ToInt32(Request.QueryString["id"]);
                
            }
            BindGoodsDetails();
          
        }
        
        public void BindGoodsDetails()
        {
            int ID = Convert.ToInt32(ViewState["GoodsID"]);
            DataTable dt = GoodsManager.SelectID(ID);
            if (dt !=null&&dt.Rows.Count!=0)
            {
                LVDetails.DataSource = dt;
                LVDetails.DataBind();
                LVIntroduce.DataSource = dt;
                LVIntroduce.DataBind();
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
        protected void ShoppingProduct(object sender, ListViewCommandEventArgs e)
        {
            string Eventname = e.CommandName; //三个按钮 OnClick名
            switch (Eventname)
            {
                case "Minus":
                    {
                        int i = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        if (i > 0)
                        {
                            i--;
                            ViewState["ShoppingCartNumber"] = i;
                            //MallPhoto();
                        }
                    }
                    break;
                case "Add":
                    {
                        int i = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        i++;
                        ViewState["ShoppingCartNumber"] = i;
                        //MallPhoto();                        
                    }
                    break;
                case "AddShoppingCart":
                    {
                        //if (Session["UserName"] != null)//判断用户是否登录
                        //{
                        //    int Qty = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        //    decimal Pro_price = Convert.ToDecimal(ViewState["Pro_price"]);
                        //    if (Qty > 0) //判断购买商品数量是否>1
                        //    {
                        //        int Users_id = Convert.ToInt32(Session["Users_id"]);
                        //        int Pro_id = Convert.ToInt32(ViewState["Pro_id"]);
                        //        DataTable goods = ProductService.JudgeMallYorN(Users_id, Pro_id);
                        //        if (goods != null && goods.Rows.Count != 0) //判断购物车是否被创建
                        //        {
                        //            //若购物车已经创建 里面有商品 则更新购物车
                        //            decimal Sales_tprice = (Convert.ToDecimal(ViewState["Pro_price"])) * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));
                        //            int Result = VideoService.UpdateShoppingCart(Users_id, Pro_id, Qty, Sales_tprice);
                        //            if (Result >= 1)
                        //            {
                        //                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('加入购物车成功！');</script>");
                        //                BindUserMallCart();
                        //            }
                        //        }
                        //        else //若没有 则新建购物车
                        //        {
                        //            ShopCart mallitemcart = new ShopCart();
                        //            mallitemcart.Users_id = Convert.ToInt32(Session["Users_id"]);
                        //            mallitemcart.Pro_id = Convert.ToInt32(ViewState["Pro_id"]);
                        //            mallitemcart.Pro_price = Convert.ToDecimal(ViewState["Pro_price"]);
                        //            mallitemcart.Qty = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        //            mallitemcart.Sales_tprice = (Convert.ToDecimal(ViewState["Pro_price"])) * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));
                        //            int result = ProductService.InsertShoppingCart(mallitemcart);
                        //            if (result >= 1)
                        //            {
                        //                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('加入购物车成功！');</script>");
                        //                BindUserMallCart();
                        //            }
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请确定购买数量');</script>");
                        //    }
                        //}
                        //else
                        //{
                        //    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请先登录');</script>");
                        //}
                    }
                    break;
            }
        }

        protected void LVDetails_PreRender(object sender, EventArgs e)
        {
            LVDetails.DataBind();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}