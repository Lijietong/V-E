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
                cmd.CommandText = "insert into UserInfo(UserID,PassWord,Tel) values('" + uid + "','" + pwd + "','" + tel + "')";
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    lblMsg.Text = "注册成功!";
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "用户注册失败，失败原因：" + ex.Message;
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
            }
        }
    }
}