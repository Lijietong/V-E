<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MallDetails.aspx.cs" Inherits="WEB.Mall" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商品详情</title>
    <link href="CSS/mall.css" rel="stylesheet" />  
    <script src="JS/jquery-1.11.3.min.js"></script> 
    <style type="text/css">
        a {
            text-decoration: none;
        }

            a:hover {
                text-decoration: none;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="header">
            <div class="header_l"><a href="Index.aspx"><asp:Image ID="Logo" runat="server"  ImageUrl="~/images/Picture/Logo.png" CssClass="logo"/></a></div>
            <div class="header_r">
                <div class="mall"><asp:LinkButton ID="lbmall" runat="server" OnClick="lbmall_Click">商城首页</asp:LinkButton></div>
                <div class="function"><asp:LinkButton ID="lbfunction" runat="server">我的功能</asp:LinkButton></div>
                
                <div class="shopcar">
                    <asp:Button ID="btnshoucar" runat="server" CssClass="btnshopcar" Text="购 物 车"/>
                    <span class="badge">0</span>
                </div>
            </div>
        </div> 
        <div class="clear"></div>  
        <!--商品详情-->
        <asp:ScriptManager runat="server" ID="scriptmanager01"></asp:ScriptManager> 
        <asp:UpdatePanel runat="server" ID="updatepanel01">
            <ContentTemplate>
                <asp:ListView ID="LVDetails" runat="server"  OnItemCommand="ShoppingProduct" OnPreRender="LVDetails_PreRender">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>                
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="container">
                            <div style="height:50px;width:100%;"></div>
                            <div class="center">
                                <div class="center_left">
                                    <image src="<%# Eval("Picture") %>"></image>
                                </div>
                                <div class="center_right">
                                    <p><%# Eval("GoodsName") %></p>
                                    
                                    <div style="font-size:14px;font-family:'Microsoft YaHei'"><%# Eval("Author") %>&nbsp;&nbsp;<%# Eval("Release_time") %></div>
                                    <hr  style="border:solid 0.5px;width:70%;margin-left:15%;margin-top:2px;"/>
                                    <div style="text-align:center;height:33px"><p style="font-size:16px;margin-top:5px;float:left;">促销价<h2 style="color:red;float:left;">¥<%# Eval("Price") %></h2></p></div>
                                    <div class="clear"></div>
                                    <div class="pro_size">
	    					                <span style="float:left;margin-top:6px;">数量&nbsp;</span>
                                            <asp:LinkButton ID="NumMinus" runat="server"  CSSClass="pro_size_a" CommandName="Minus">-</asp:LinkButton>
                                            <asp:TextBox ID="TextNum" runat="server" CSSClass="pro_size_a" Text='<%#ViewState["ShoppingCartNumber"]%>'></asp:TextBox>
                                            <asp:LinkButton ID="NumAdd" runat="server" CSSClass="pro_size_a" CommandName="Add">+</asp:LinkButton>
	    			                </div>
                                    <div class="clear"></div>
                                    <div>
                                            <span style="float:left;">库存&nbsp;&nbsp;</span>
                                            <p style="font-size:16px;float:left"><%# Eval("Rest_num") %></p>
                                            <div class="clear"></div>
                                    </div>
                                    <div style="text-align:center">
                                            <asp:Button runat="server" ID="BtnAdd" CssClass="BtnAdd" Text="加入购物车" OnClick="BtnAdd_Click"/>
                                    </div>
                                  </div>
                              </div>
                         </div>
                    </ItemTemplate>
                </asp:ListView>
            </ContentTemplate>
        </asp:UpdatePanel>
           
        <div class="clear"></div>
        <br /><br />
        <div class="details">&nbsp;&nbsp;
            <div style="height:40px;width:10px;background-color:forestgreen;float:left;"></div>
            <div style="height:40px;width:150px;float:left;padding-top:3px">&nbsp;&nbsp;商&nbsp;品&nbsp;简&nbsp;介&nbsp;及&nbsp;评&nbsp;论</div>
        </div><br /><br />
        <!-- 商品简介及评论 -->
        <hr  style="background-image:url(../images/mall/圣诞3.jpg);height:3px;width:70%;margin-left:15%;"/> 
        <ul id="myTab" class="nav nav-tabs">
            <li class="active"><a href="#A" data-toggle="tab">商品简介</a></li>
            <li><a href="#B" data-toggle="tab">商品评论&nbsp;</a></li>
        </ul>
        <hr  style="background-image:url(../images/mall/圣诞3.jpg);height:3px;width:70%;margin-left:15%;margin-top:44px"/> 
            <div id="myTabContent" class="tab-content">
                <!-- 商品简介 -->
                <div class="tab-pane fade in active" id="A">                           
                       <asp:ListView ID="LVIntroduce" runat="server">
                           <LayoutTemplate>
                               <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                           </LayoutTemplate>
                           <ItemTemplate>
                               <div style="padding:20px 10% 20px 10%"><%# Eval("introduce") %></div>
                           </ItemTemplate>
                       </asp:ListView>     
                </div>
                <!-- 商品评论 -->
                <div class="tab-pane fade" id="B">
                    <asp:ListView runat="server" ID="LVComments">
                        <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="Box">
                                <div class="Box_left">
                                    <div class="Box_left_top"><%# Eval("Photo") %></div>
                                    <div class="Box_left_bottom"><%# Eval("UserName") %></div>
                                </div>
                                <div class="Box_right"><%# Eval("MallComments") %></div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
        <script src="JS/bootstrap.min.js"></script>
        <hr  style="height:5px;background-color:#fff;"/>
        <!--底部-->    
        <div class="footer">
            <div class="footer_top"></div>
            <div style="width:70%;margin-left:15%">
                <div class="footer_left">
                    <ul>
                        <li>友情链接</li>
                        <li><a href="http://www.jxnu.edu.cn" target="_blank">江西师范大学</a></li>
                        <li><a href="http://www.jxedu.gov.cn/" target="_blank">江西教育网</a></li>
                        <li><a href="http://gaojiao.jxedu.gov.cn/" target="_blank">江西高教网</a></li>
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
