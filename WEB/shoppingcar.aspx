<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shoppingcar.aspx.cs" Inherits="WEB.shoppingcar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>我的购物车</title>
    <link href="CSS/mall.css" rel="stylesheet" />
    <link href="CSS/shoppingcar.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--顶部-->
        <div class="header">
            <div class="header_l"><a href="Index.aspx"><asp:Image ID="Logo" runat="server"  ImageUrl="~/images/Picture/Logo.png" CssClass="logo"/></a></div>
            <div class="header_r">
                <div class="mall"><asp:LinkButton ID="lbmall" runat="server" OnClick="lbmall_Click">商城首页</asp:LinkButton></div>
                <div class="function"><asp:LinkButton ID="lbfunction" runat="server">我的功能</asp:LinkButton></div>
                <div class="LorR">
                    <asp:Panel runat="server" ID="HadLogin">
                        <label runat="server" id="lbusername" text="" />&nbsp;&nbsp;
                        <asp:Linkbutton runat="server" ID="lbtnregister" OnClick="lbtnregister_Click">注销</asp:Linkbutton>
                    </asp:Panel>
                    <asp:Panel runat="server" ID="NotLogin">
                        <a href="Login.aspx">登录</a>&nbsp;|
                        <a href="Register.aspx">注册</a>
                    </asp:Panel>
                </div>      
                <div class="shopcar">
                    <asp:Button ID="btnshoucar" runat="server" CssClass="btnshopcar" Text="购 物 车"/>
                    <span class="badge"><%=BindUserMallCart() %></span>
                </div>
            </div>
        </div>   
        <div class="clear"></div> <br /><br />
        <hr style="height:3px;background-color:#fff;"/> 
        <br /> 
         <!-- 订单 -->
        <asp:Panel runat="server" ID="Panel01">
            <div class="order">
            <asp:Listview runat="server" ID="LVShoppingcart" OnItemCommand="LVShoppingcart_ItemCommand">
                <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="Box">
                        <div class="Box_left">
                            <div class="Box_left_top"><image src="<%# Eval("Picture") %>"></image></div>
                            <div class="Box_left_bottom"><%# Eval("GoodsName") %></div>
                        </div>
                        <div class="Box_right">
                            <span><asp:Label ID="lbshoppingcartid" runat="server" Visible="false" Text='<%#Eval("ShoppingCartID")%>' /></span>
                            <span>单价：<%# Eval("Price") %></span>&nbsp;
                            <span>数量：<%# Eval("Qty") %></span>&nbsp;
                            <span>总额<%# Eval("Tot_amt") %></span>&nbsp;&nbsp;&nbsp;&nbsp;
                            <span style="margin-left:30px"><asp:LinkButton runat="server" ID="LBClose" CommandName="Delete">删除</asp:LinkButton></span>
                        </div>                      
                    </div>
                </ItemTemplate>
            </asp:Listview>
                <div class="clear"></div>
            <asp:Repeater runat="server" ID="RPBuy" OnItemCommand="RPBuy_ItemCommand">
                   <ItemTemplate>
                       <div style="padding-left:850px;">总计金额：<label runat="server" id="lbfinaltot_amt"><%# Eval("FinalTot_amt") %></label>&nbsp&nbsp&nbsp<asp:LinkButton ID="BuyRightNow" runat="server" Class="btn btn-danger" CommandName="BuyRightNow">立即购买</asp:LinkButton></h3></div>
                   </ItemTemplate>
            </asp:Repeater>
        </div>
        </asp:Panel>
        <asp:Panel runat="server" ID="Panel02">
            <div class="image"><img src="images/mall/nothing.png" /></div>
        </asp:Panel>
        <!--底部--> 
        <br />
        <hr style="height:3px;background-color:#fff" /> 
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
