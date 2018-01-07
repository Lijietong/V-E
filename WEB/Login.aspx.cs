using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                string strCnn = ConfigurationManager.ConnectionStrings["cnnStr"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCnn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string username = txtName.Text.Trim();//读取用户输入的用户名
                string password = txtPassword.Text.Trim();//读取用户输入的密码
                cmd.CommandText = "select * from UserInfo where UserName=@UserName and PassWord=@Password";               
                cmd.Parameters.AddWithValue("@UserName", username);                
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader UserReader = null;//创建DataReader对象的引用
                try
                {
                    if (cnn.State == ConnectionState.Closed)
                        cnn.Open();
                    UserReader = cmd.ExecuteReader();
                    if (UserReader.Read())
                    {
                        //验证通过，保存用户名信息，并跳转到其它页面
                        Session["UserName"] = username;
                        Session["UserID"] = UserReader[0];
                        Response.Redirect("~/Index.aspx");
                    }
                    else
                    {
                        lblMsg.Text = "用户名,密码不正确！";
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("用户登录失败，失败原因：" + ex.Message);
                }
                finally
                {
                    if (UserReader.IsClosed == false)
                        UserReader.Close();
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
            }
        }
    }
}