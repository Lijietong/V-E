<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mall.aspx.cs" Inherits="WEB.Mall1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商城首页</title>
    <link href="CSS/mall.css" rel="stylesheet" />
     <script src="JS/jquery-1.11.3.min.js"></script>
    <script src="JS/wySilder.min.js"></script>
    <script src="JS/lunbotu.js"></script>
    <script src="JS/HomePage.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--头部-->
        <div class="header">
            <div class="header_l"><a href="Index.aspx"><asp:Image ID="Logo" runat="server"  ImageUrl="~/images/Picture/Logo.png" CssClass="logo"/></a></div>
            <div class="header_r">
                <div class="mall"><asp:LinkButton ID="lbmall" runat="server">商城首页</asp:LinkButton></div>
                <div class="function"><asp:LinkButton ID="lbfunction" runat="server">我的功能</asp:LinkButton></div>              
                <div class="shopcar">
                    <asp:Button ID="btnshoucar" runat="server" CssClass="btnshopcar" Text="   购 物 车"/>
                </div>
            </div>
        </div>   
        <div class="clear"></div>
        <!--轮播图-->
        <div class="js-silder">
           <div class="silder-scroll">
		        <div class="silder-main">
			        <div class="silder-main-img">
				        <img src="images/mall/3.jpg" alt=""/>
			        </div>
			        <div class="silder-main-img">
				        <img src="images/mall/圣诞2.jpg" alt=""/>
			        </div>
			        <div class="silder-main-img">
				        <img src="images/mall/圣诞1.jpg" alt=""/>
			        </div>
		        </div>
	        </div>
        </div>  
        <!--商品展示-->   
             
        <!--底部-->
        <div class="footer">
            <div class="footer_top"></div>
            <div style="width:70%;margin-left:15%">
                <div class="footer_left">
                    <ul>
                        <li>友情链接</li>
                        <li><a href="http://www.jxnu.edu.cn" target="_blank">江西师范大学</a></li>
                        <li><a href="http://www.jxedu.gov.cn/" target="_blank">江西教育网</a></li>
                        <li><a href="http://gaojiao.jxedu.gov.cn/" target="_blank">江西高等教育网</a></li>
                    </ul>
                </div>
                <div class="footer_center">
                    <ul>
                        <li>服务支持</li>
                        <li><a href="#">隐私保护</a></li>
                        <li><a href="#">使用协议</a></li>
                        <li><a href="#">版权声明</a></li>
                        <li><a href="#">意见反馈</a></li>
                    </ul>                    
                </div>
                <div class="footer_right">
                    <ul>
                        <li>V教育</li>
                        <li><a href="#">了解我们</a></li>
                        <li><a href="#">商务合作</a></li>
                        <li><a href="#">活动公告</a></li>
                    </ul>
                </div>
            </div>
            <div class="clear"></div>
            <div style="width:60%;height:5px;margin-left:20%;"></div>
            <div class ="footer_bottom">
                <p>Copyright©2017&nbsp;&nbsp;www.V-Education&nbsp;&nbsp;All Rights Reserved</p>
                <p>江西师范大学3522-1工作室</p>
            </div>           
        </div>
    </div>
    </form>
</body>
</html>
