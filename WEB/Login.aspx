<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>V教育 用户登录</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="keywords" content="Existing Login Form Widget Responsive, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"/>
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <link href="CSS/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="CSS/style.css" type="text/css" media="all"/>
    <link href="//fonts.googleapis.com/css?family=Quicksand:300,400,500,700" rel="stylesheet"/> 
</head>
<body>
    <div>
        <h1>用户登录</h1>
	    <div class="Login">
	<h2>Login here</h2>
		<form id="form1" runat="server" action="#" method="post">
            <asp:TextBox ID="txtName" runat="server" placeholder="用户名"></asp:TextBox>
			<asp:TextBox ID="txtPassword" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
			<ul class="agileinfotickwthree">
				<li>
					<input type="checkbox" id="brand1" value=""/>
					<label for="brand1"><span></span>记住我</label>
					<a href="#">忘记密码?</a>
				</li>
			</ul>
			<div class="aitssendbuttonw3ls">
                <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
				<p> 注册新账号 <span>→</span> <a class="w3_play_icon1" href="Register.aspx" target="_blank"> 注册新用户</a></p>
				<div class="clear"></div>
			</div>
		</form>
	</div>
        <div class="footer">
		<p> 版权所有&copy; 江西省南昌市南昌县江西师范大学瑶湖校区</p>
	</div>
    </div>
    
</body>
</html>
