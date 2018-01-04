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
                string uid = txtName.Text.Trim();
                string pwd = txtPassword.Text.Trim();
                string tel = txtTel.Text.Trim();
                cmd.CommandText = "insert into UserInfo(UserID,PassWord,UserName,T) values('" + uid + "','" + pwd + "','" + tel + "')";
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    lblMsg.Text = "注册成功!";
                }
                catch (Exception)
                {
                    
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
                if(lblMsg.Text=="注册成功!")
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