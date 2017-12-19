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
                string name = txtName.Text.Trim();//读取用户输入的用户名
                string password = txtPassword.Text.Trim();//读取用户输入的密码
                cmd.CommandText = "select * from UserInfo where UserID=@UserId and PassWord=@Password";
                //为Command对象准备@UserId参数
                //SqlParameter userIdparam = new SqlParameter();//定义参数对象
                //userIdparam.ParameterName = "@UserId";//参数名
                //userIdparam.SqlDbType = SqlDbType.VarChar;//设置参数值的数据库参数类型
                //userIdparam.Size = 20;//设置参数值的大小
                //userIdparam.Direction = ParameterDirection.Input;//设置参数的方向为输入参数
                //userIdparam.Value = name;//设置参数的值为用户输入的用户名
                //cmd.Parameters.Add(userIdparam);//将准备好的参数对象添加到Command对象中
                cmd.Parameters.AddWithValue("@UserName", name);

                //为Command对象准备@UserId参数
                //SqlParameter passwordparam = new SqlParameter();//定义参数对象
                //passwordparam.ParameterName = "@Password";//参数名
                //passwordparam.SqlDbType = SqlDbType.VarChar;//设置参数值的数据库参数类型
                //passwordparam.Size = 20;//设置参数值的大小
                //passwordparam.Direction = ParameterDirection.Input;//设置参数的方向为输入参数
                //passwordparam.Value = password;//设置参数的值为用户输入的用户名
                //cmd.Parameters.Add(passwordparam);//将准备好的参数对象添加到Command对象中
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
                        Session["UserName"] = name;
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