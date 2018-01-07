using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;
using IDAL;
using System.Data;
using BLL;

namespace WEB
{
    public partial class shoppingcar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAllTotal();
                BindShoppingCart();
            }
            if (Session["UserName"] != null)
            {
                HadLogin.Visible = true;
                NotLogin.Visible = false;
                lbusername.InnerText = Session["UserName"].ToString();
            }
            else
            {
                NotLogin.Visible = true;
                HadLogin.Visible = false;
            }
            int ID = Convert.ToInt32(Session["UserID"]);
            DataTable ys = GoodsManager.JudgeShoppingCart(ID);
            if (ys != null && ys.Rows.Count != 0)
            {
                Panel01.Visible = true;
                Panel02.Visible = false;
            }
            else
            {
                Panel01.Visible = false;
                Panel02.Visible = true;
            }
            BindUserMallCart();
        }
        protected void lbtnregister_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
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
        protected void BindAllTotal()
        {
            string UserName = Convert.ToString(Session["UserName"]);
            DataTable dt = GoodsManager.SelectAllTot_amt(UserName);
            if (dt != null && dt.Rows.Count != 0)
            {
                RPBuy.DataSource = dt;
                RPBuy.DataBind();
            }
            string a = dt.Rows[0][0].ToString();
        }
        protected void BindShoppingCart()
        {
            string UserID = Convert.ToString(Session["UserName"]);
            DataTable dt = GoodsManager.SelectShoppingCart(UserID);
            if (dt != null && dt.Rows.Count != 0)
            {
                LVShoppingcart.DataSource = dt;
                LVShoppingcart.DataBind();
            }
        }

        protected void RPBuy_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Eventname = e.CommandName;
            switch (Eventname)
            {
                case "BuyRightNow":
                    {
                        try
                        {
                            int ID = Convert.ToInt32(Session["UserID"]);
                            int result = GoodsManager.InsertOrder(ID);
                            if (result >= 1)
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('下单成功 谢谢惠顾');location='WebMallOrders.aspx';</script>");
                                BindAllTotal();
                                BindShoppingCart();
                                DataTable ys = GoodsManager.JudgeShoppingCart(ID);
                                if (ys != null && ys.Rows.Count != 0)
                                {
                                    Panel01.Visible = true;
                                    Panel02.Visible = false;
                                }
                                else
                                {
                                    Panel01.Visible = false;
                                    Panel02.Visible = true;
                                }
                            }
                        }
                        catch
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('购物车里什么也没有');</script>");
                        }
                    }
                    break;
            }
         }

        protected void LVShoppingcart_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Label lbl = (Label)e.Item.FindControl("lbshoppingcartid");
            string Eventname = e.CommandName;
            switch (Eventname)
            {
                case "Delete":
                    {
                        int ID = Convert.ToInt32(lbl.Text);
                        int result = GoodsManager.DeleteShoppingCart(ID);
                        if (result >= 1)
                        {
                            int ID02 = Convert.ToInt32(Session["UserID"]);
                            DataTable ys = GoodsManager.JudgeShoppingCart(ID02);
                            if (ys != null && ys.Rows.Count != 0)
                            {
                                Panel01.Visible = true;
                                Panel02.Visible = false;
                            }
                            else
                            {
                                Panel01.Visible = false;
                                Panel02.Visible = true;
                            }
                            string UserName = Convert.ToString(Session["UserName"]);
                            DataTable dt = GoodsManager.SelectAllTot_amt(UserName);
                            if (dt != null && dt.Rows.Count != 0)
                            {
                                RPBuy.DataSource = dt;
                                RPBuy.DataBind();
                            }
                            string UserID = Convert.ToString(Session["UserName"]);
                            DataTable dt02 = GoodsManager.SelectShoppingCart(UserID);
                            if (dt02 != null && dt02.Rows.Count != 0)
                            {
                                LVShoppingcart.DataSource = dt02;
                                LVShoppingcart.DataBind();
                            }
                        }
                    }
                    break;
            }
        }

        protected void lbmall_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mall.aspx");
        }
    }
}