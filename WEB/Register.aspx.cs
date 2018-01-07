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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UserAdd_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                string strCnn = ConfigurationManager.ConnectionStrings["cnnStr"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCnn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string username = txtName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string tel  = txtTel.Text.Trim();            
                cmd.CommandText = "insert into UserInfo(UserName,PassWord,Tel) values(@UserName,@PassWord,@Tel)";
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@PassWord", password);
                cmd.Parameters.AddWithValue("@Tel", tel);
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    lblMsg.Text = "注册成功!";
                }
                catch (Exception ex)
                {
                    Response.Write("用户名或密码不正确！" + ex.Message);
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
                if (lblMsg.Text == "注册成功!")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('注册成功！');location='Login.aspx'</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('用户名已使用！');location='Register.aspx'</script>");
                }
            }
        }
    }
}