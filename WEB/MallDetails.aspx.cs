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
            BindGoodsDetails();
          
        }
        protected void lbtnregister_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
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
                ViewState["Rest_num"] = dt.Rows[0]["Rest_num"].ToString();
            }
        }
        public int BindMallComments()
        {
            int comnum;
            int goodsid = Convert.ToInt32(ViewState["GoodsID"]);
            DataTable dt = GoodsManager.SelectMallComments(goodsid);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVMallComment.DataSource = dt;
                LVMallComment.DataBind();
                return comnum = dt.Rows.Count;
            }
            else
            {
                return comnum = 0;
            }
        }
        protected void lbtnReply_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel panelreply = bt.Parent.FindControl("PanelReply") as Panel;
            panelreply.Visible = true;
        }
        protected void btnRply_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    Button btn = (Button)sender;
                    string a = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text.Trim();
                    ReplyMallComments replymallcomments = new ReplyMallComments();
                    replymallcomments.MallCommentsID = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    replymallcomments.UserID = int.Parse(Session["UserID"].ToString());
                    replymallcomments.ReplyContents = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text.Trim();
                    replymallcomments.ReplyTime = DateTime.Now;
                    int result = GoodsManager.InsertReplyMallComments(replymallcomments);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(UpP003, this.GetType(), "click", "alert('回复成功')", true);
                        BindMallComments();
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(UpP003, this.GetType(), "click", "alert('未知原因 回复失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(UpP003, this.GetType(), "click", "alert('请先登录');", true);
            }
        }

        protected void LVMallComment_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                HiddenField hiddenComID = e.Item.FindControl("HiddenFieldComID") as HiddenField; //找到评论ID
                int ComID = int.Parse(hiddenComID.Value); //化为整型
                Repeater rpt = e.Item.FindControl("RepeaterReplyComments") as Repeater;
                DataTable dt = GoodsManager.SelectReplyMallComments(ComID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.DataBind();
                }
            }
        }
        protected void lbmall_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mall.aspx");
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
        protected void ShoppingProduct(object sender, ListViewCommandEventArgs e)
        {
            int num = int.Parse(ViewState["Rest_num"].ToString());
            string Eventname = e.CommandName; //三个按钮 OnClick名
            switch (Eventname)
            {
                case "Minus":
                    {
                        int i = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        if (i >0)
                        {
                            i--;
                            ViewState["ShoppingCartNumber"] = i;
                            BindGoodsDetails();
                        }
                    }
                    break;
                case "Add":
                    {
                        int i = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        if (i < num)
                        {
                            i++;
                            ViewState["ShoppingCartNumber"] = i;
                            BindGoodsDetails();
                        }
                                               
                    }
                    break;
            }
        }

        protected void LVDetails_PreRender(object sender, EventArgs e)//初始化绑定
        {
            LVDetails.DataBind();
        }
        protected void btnComments_Click(object sender, EventArgs e) //发表评论
        {
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    try
                    {
                        MallComments mallcomments = new MallComments();
                        mallcomments.GoodsID = Convert.ToInt32(ViewState["GoodsID"]);
                        mallcomments.UserID = Convert.ToInt32(Session["UserID"]);
                        mallcomments.Comments_time = DateTime.Now;
                        mallcomments.Comments_contents= txtComments.Text;
                        int result = GoodsManager.InsertMallComments(mallcomments);
                        if (result >= 1)
                        {
                            ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('评论成功！')", true);
                            BindMallComments();
                            txtComments.Text = "";
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('未知原因 评论失败')", true);
                        }
                    }
                    catch
                    {
                        ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('未知原因 评论失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(UpP002, this.GetType(), "click", "alert('请先登录')", true);
            }
        }

        protected void btnshoucar_Click(object sender, EventArgs e)
        {
            Response.Redirect("shoppingcar.aspx");
        }

        protected void AddShoppingCart_Click(object sender, EventArgs e)
        {
            int num = int.Parse(ViewState["Rest_num"].ToString());
            if (num > 0)
            {
                if (Session["UserName"] != null)//判断用户是否登录
                {
                    int Qty = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                    
                    if (Qty > 0) //判断购买商品数量是否>0
                    {
                        if ((int)Session["UserID"] != 0)
                        {
                            int UserID = Convert.ToInt32(Session["UserID"]);
                        
                        int GoodsID = Convert.ToInt32(ViewState["GoodsID"]);
                        DataTable goods = GoodsManager.JudgeMallYorN(UserID, GoodsID);
                        if (goods != null && goods.Rows.Count != 0) //判断购物车是否被创建
                        {
                            //若购物车已经创建 里面有商品 则更新购物车
                            decimal Tot_amt = ((decimal)(ViewState["Price"])) * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));//单价乘数量                                                                                                                   
                            int Result = GoodsManager.UpdateShoppingCart(UserID, GoodsID, Qty, Tot_amt);
                            if (Result >= 1)
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('加入购物车成功！');</script>");
                                BindUserMallCart();
                            }
                        }
                        else //若没有 则新建购物车
                        {                          
                            MallItemcart mallitemcart = new MallItemcart();
                            mallitemcart.UserID = Convert.ToInt32(Session["UserID"]);
                            mallitemcart.GoodsID = Convert.ToInt32(ViewState["GoodsID"]);
                            mallitemcart.Unit_price = Convert.ToDecimal((ViewState["Price"]));
                            mallitemcart.Qty = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                            mallitemcart.Tot_amt = Convert.ToDecimal((ViewState["Price"])) * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));
                            int result = GoodsManager.InsertShoppingCart(mallitemcart);
                            if (result >= 1)
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('加入购物车成功！');</script>");
                                BindUserMallCart();
                            }
                        }
                    }
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请确定购买数量');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请先登录');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('已经卖光了。。。');</script>");
            }
        }       
        }
}