<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WEB.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>V教育 新用户注册</title>
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <meta name="viewport" content="width=device-width, initial-scale=1"/>
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <meta name="keywords" content="Existing Login Form Widget Responsive, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"/>
     <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
     <link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
     <link rel="stylesheet" href="css/style.css" type="text/css" media="all"/>
     <link href="//fonts.googleapis.com/css?family=Quicksand:300,400,500,700" rel="stylesheet"/>
</head>
<body>
    <div>
       <h1>新用户注册</h1>
	    <div class="Login">
	<h2>Register</h2>
		<form id="form1" runat="server" action="#" method="post">
            <asp:TextBox ID="txtName" runat="server" placeholder="请输入用户名"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtRepassword" runat="server" placeholder="请输入确认密码" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtTel" runat="server" placeholder="请输入电话"></asp:TextBox>
			<div class="aitssendbuttonw3ls">
                <asp:Button ID="UserAdd" runat="server" Text="立即注册" OnClick="UserAdd_Click" />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
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
