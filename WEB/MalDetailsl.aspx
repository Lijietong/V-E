<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MalDetailsl.aspx.cs" Inherits="WEB.Mall" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商品详情</title>
    <link href="CSS/mall.css" rel="stylesheet" />   
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
    </div>  
        <div class="clear"></div>  
        <!--商品详情--> 
        <div class="container">
            <div style="height:50px;width:100%;"></div>
            <div class="center">
                <div style="height:48px"></div>
                <div class="center_left">

                </div>
                <div class="center_right">

                </div>
            </div>
        </div>
        <div class="clear"></div>
        <br /><br /><br /><br />
        <div class="details">&nbsp;&nbsp;
            <div style="height:40px;width:10px;background-color:forestgreen;float:left;"></div>
            <div style="height:40px;width:150px;float:left;padding-top:3px">&nbsp;&nbsp;商&nbsp;品&nbsp;简&nbsp;介&nbsp;及&nbsp;评&nbsp;论</div>
        </div><br /><br />
        <!--bootstrap-->
        <link rel="stylesheet" href="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/css/bootstrap.min.css" />
	    <script src="http://cdn.static.runoob.com/libs/jquery/2.1.1/jquery.min.js"></script>
	    <script src="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/js/bootstrap.min.js"></script>
        <div class="contents">
            <ul id="myTab" class="nav nav-tabs">
	        <li class="active">
		        <a href="#home" data-toggle="tab">商品简介</a>
	        </li>
	        <li><a href="#ios" data-toggle="tab">商品评论</a></li>
        </ul>
        <div id="myTabContent" class="tab-content">
	        <div class="tab-pane fade in active" id="home">
		        <asp:repeater ID="introduce" runat="server">
                    <ItemTemplate>
                        <hr />
                        <p><%# Eval("C_introduce") %></p>
                    </ItemTemplate>
		        </asp:repeater>
	        </div>
	        <div class="tab-pane fade" id="ios">
                <!-- 局部更新 -->
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <!-- 评论框 -->
                            <asp:UpdatePanel ID="UpP002" runat="server">
                                <ContentTemplate>
                                    <asp:Panel ID="PingLunBox" runat="server">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div id="colorbolck01" style="width: 100%; height: 15px;"></div>
                                                <asp:TextBox ID="txtComments" CssClass="commentsstyle" Width="100%" Height="100px" runat="server" TextMode="MultiLine" placeholder="说点什么吧..."></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-8 text-center">
                                                <div id="colorbolck02" style="width: 100%; height: 15px;"></div>
                                                <asp:RequiredFieldValidator ID="ReFV1" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="16px" ErrorMessage="评论内容不能为空" Display="Dynamic" ControlToValidate="txtComments" ValidationGroup="comments"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="ReEV1" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="16px" ErrorMessage="字数不能超过140字" Display="Dynamic" ControlToValidate="txtComments" ValidationGroup="comments" ValidationExpression="^[\s\S]{1,140}$"></asp:RegularExpressionValidator>
                                            </div>
                                            <div class="col-md-4 text-center">
                                                <div id="colorbolck03" style="width: 100%; height: 15px;"></div>
                                                <asp:Button ID="btnComments" CssClass="btncomments btn btn-default" runat="server" Text=" 发 表 评 论 " ValidationGroup="comments" OnClick="btnComments_Click" />
                                                <div id="colorbolck04" style="width: 100%; height: 15px;"></div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpP003" runat="server">
                                <ContentTemplate>
                                    <!-- 评论回复绑定 -->
                                    <asp:ListView ID="LVMallComment" runat="server" OnItemDataBound="LVMallComment_ItemDataBound">
                                        <LayoutTemplate>
                                            <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                                        </LayoutTemplate>
                                        <ItemTemplate>
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <hr />
                                                    <!-- 评论 -->
                                                    <div class="row">
                                                        <div class="col-md-11 col-md-offset-1">
                                                            <span><a href="#" style="font-size: 16px;"><%#Eval("UserName") %></a>：<%#Eval("MallComContent")%></span>
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-md-10 text-right">
                                                            <i style="font-size: 12px; height: 5px;"><%#Eval("MallComTime") %></i>
                                                        </div>
                                                        <div class="col-md-2 text-center">
                                                            <div class="reply_comment">
                                                                <asp:LinkButton ID="lbtnReply" runat="server" OnClick="lbtnReply_Click">回复本层</asp:LinkButton>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-md-8 col-md-offset-3">
                                                            <asp:Panel ID="PanelReply" runat="server" Visible="false">
                                                                <div class="reply_textbox">
                                                                    <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("MallCommentID") %>' Visible="false" />
                                                                    <asp:TextBox ID="txtReplyContent" Width="100%" CssClass="txtReply" TextMode="MultiLine" runat="server"></asp:TextBox>
                                                                    <asp:Button ID="btnRply" runat="server" Text="发表" OnClick="btnRply_Click" CssClass="btnReply btn btn-default btn-sm" ValidationGroup="reply_comments" />
                                                                </div>
                                                                <div style="margin-left: 30%;">
                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" Font-Bold="true" Font-Size="14px" runat="server" ErrorMessage="回复内容不能为空" Display="Dynamic" ControlToValidate="txtReplyContent" ValidationGroup="reply_comments"></asp:RequiredFieldValidator>
                                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="14px" ErrorMessage="字数不能超过140字" Display="Dynamic" ControlToValidate="txtReplyContent" ValidationExpression="^[\s\S]{1,140}$" ValidationGroup="reply_comments"></asp:RegularExpressionValidator>
                                                                </div>
                                                            </asp:Panel>
                                                        </div>
                                                    </div>
                                                    <!-- 回复 -->
                                                    <div class="row">
                                                        <asp:Repeater ID="RepeaterReplyComments" runat="server">
                                                            <ItemTemplate>
                                                                <div class="row">
                                                                    <div class="col-md-8 col-md-offset-3">
                                                                        <span><a href="#"><%#Eval("回复人")%></a>回复说 ：<%#Eval("ReplyMallComContent") %><i style="font-size: 10px; margin-left: 20px;"><%#Eval("ReplyMallComTime") %></i></span>
                                                                    </div>
                                                                </div>
                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                    </div>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </ContentTemplate>
                            </asp:UpdatePanel>		        
	        </div>
        </div>
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
