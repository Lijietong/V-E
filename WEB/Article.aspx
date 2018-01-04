<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="WEB.Article" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/Article.css" rel="stylesheet" />
    
    <style type="text/css">
        .Logobtn {}
    </style>
</head>
<body>
    <form id="form1" runat="server">        
        
        <!--头部-->
        <div class="center">
            <div class="logo"><asp:Button ID="Logobtn" runat="server" Text=" " CssClass="Logobtn" OnClick="Logobtn_Click"/></div>             
        </div>
        
        <!--新闻内容--> 
        <div class="main">
            <div class="rol">
                <ul>
                    <li><a href="Index.aspx">首页</a></li>                            
                    <li>>正文</li>
                </ul>
            </div>
            <br />
            <br />
            <div class="ArtContent">
                <asp:Repeater ID="ArtContentRepeater" runat="server">
                    <ItemTemplate>              
                        <div class="first-main">
                            <h3><%#Eval("Art_theme") %></h3>
                            <br />
                            <h5>发布时间:<%#Eval("Release_time") %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;点击量：<%#Eval("Art_clicknum") %></h5>
                        </div>
                        <hr />
                        <div class="second-main">
                            <div class="ArtContent">
                                <h6 style="  line-height:25px; margin-top: 15px; color: #555555; margin-left: 5px; margin-top: 5px;padding:15px; font-size:15px; ">&nbsp&nbsp&nbsp&nbsp <%#Eval("Art_Content") %></h6>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>            
            </div>
        </div>

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
                    
   
    </form>
</body>
</html>
