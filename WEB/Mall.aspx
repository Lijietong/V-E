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
                    <asp:Button ID="btnshoucar" runat="server" CssClass="btnshopcar" Text="购 物 车"/>
                    <span class="badge">0</span>
                </div>
            </div>
        </div>   
        <div class="clear"></div>
        <!--轮播图-->
        <div class="js-silder">
           <div class="silder-scroll">
		        <div class="silder-main">
			        <div class="silder-main-img">
				        <img src="../images/mall/圣诞5.jpg" alt=""/>
			        </div>
			        <div class="silder-main-img">
				        <img src="../images/mall/圣诞4.jpg" alt=""/>
			        </div>
			        <div class="silder-main-img">
				        <img src="../images/mall/圣诞3.jpg" alt=""/>
			        </div>
		        </div>
	        </div>
        </div><br />
        <!--商品展示-->  
        <hr  style="background-image:url(../images/mall/圣诞3.jpg);height:3px;width:70%;margin-left:15%;"/> 
                    <ul id="myTab" class="nav nav-tabs">
                        <li class="active"><a href="#A" data-toggle="tab">视频课程</a></li>
                        <li><a href="#B" data-toggle="tab">热销书籍&nbsp;</a></li>
                    </ul>
        <hr  style="background-image:url(../images/mall/圣诞3.jpg);height:3px;width:70%;margin-left:15%;margin-top:44px"/> 
                    <asp:ScriptManager runat="server" ID="Scriptmanager1"></asp:ScriptManager>
                    <asp:updatepanel runat="server" ID="updatepanel1">
                        <ContentTemplate>
                            <div id="myTabContent" class="tab-content">
                                <!-- 视频课程 -->
                                <div class="tab-pane fade in active" id="A">                           
                                    <ul id="myTab1" class="nav nav-tabs">
                                        <li class="active"><a href="#a" data-toggle="tab">全部</a></li>
                                        <li><a href="#b" data-toggle="tab">小学&nbsp;</a></li>
                                        <li><a href="#c" data-toggle="tab">初中&nbsp;</a></li>
                                        <li><a href="#d" data-toggle="tab">高中&nbsp;</a></li>
                                    </ul> 
                                    <hr  style="background-image:url(../images/mall/圣诞3.jpg);height:3px;width:70%;margin-left:15%;"/> 
                                    <div id="myTabContent1" class="tab-content">
                                        <div class="tab-pane fade in active" id="a">
                                            <asp:ListView  ID="LVVideo" runat="server" GroupItemCount="3">
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="groupplaceholder"></asp:PlaceHolder>
                                                    </div>                                  
                                                </LayoutTemplate>
                                                <GroupTemplate>
                                                    <div >
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                                                    </div>
                                                </GroupTemplate>
                                                <ItemTemplate>
                                                    <div style="padding:5px;width:290px;height:165px;float:left;margin-left:2.5%;margin-top:10px"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></div>                                                  
                                                </ItemTemplate>
                                            </asp:ListView>     
                                            <div class="clear"></div>  
                                            <div style="text-align:center; margin-top:25px;">
                                                <asp:DataPager runat="server" PagedControlID="LVVideo" PageSize="15" ID="DPVideo" OnPreRender="DPVideo_PreRender">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" ButtonCssClass="btn-default btn-sm" />
                                                        <asp:NumericPagerField ButtonCount="3" NumericButtonCssClass="btn-default btn-sm" />
                                                        <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="尾页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" ButtonCssClass="btn-default btn-sm" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </div>
                                        </div>
                                        <div class="tab-pane fade" id="b">
                                            <asp:ListView runat="server" ID="LVxxVideo" GroupItemCount="3">                    
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="groupplaceholder"></asp:PlaceHolder>
                                                    </div>                 
                                                </LayoutTemplate>
                                                <GroupTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                                                    </div>
                                                </GroupTemplate>
                                                <ItemTemplate>
                                                    <div style="padding:5px;width:290px;height:165px;float:left;margin-left:2.5%;margin-top:10px"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></div>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </div>
                                        <div class="tab-pane fade" id="c">
                                            <asp:ListView runat="server" ID="LVczVideo" GroupItemCount="3">
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="groupplaceholder"></asp:PlaceHolder>
                                                    </div>
                                                </LayoutTemplate>
                                                <GroupTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                                                    </div>
                                                </GroupTemplate>
                                                <ItemTemplate>
                                                    <div style="padding:5px;width:290px;height:165px;float:left;margin-left:2.5%;margin-top:10px"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></div>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </div>
                                        <div class="tab-pane fade" id="d">
                                            <asp:ListView runat="server" ID="LVgzVideo" GroupItemCount="3">
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="groupplaceholder"></asp:PlaceHolder>
                                                    </div>
                                                </LayoutTemplate>
                                                <GroupTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                                                    </div>
                                                </GroupTemplate>
                                                <ItemTemplate>
                                                    <div style="padding:5px;width:290px;height:165px;float:left;margin-left:2.5%;margin-top:10px"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></div>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </div>                               
                                    </div>                  
                                </div>
                                <!-- 热销书籍 -->
                                <div class="tab-pane fade" id="B">
                                    <ul id="myTab2" class="nav nav-tabs">
                                        <li class="active"><a href="#1" data-toggle="tab">全部</a></li>
                                        <li><a href="#2" data-toggle="tab">小学&nbsp;</a></li>
                                        <li><a href="#3" data-toggle="tab">初中&nbsp;</a></li>
                                        <li><a href="#4" data-toggle="tab">高中&nbsp;</a></li>
                                    </ul>
                                    <hr  style="background-image:url(../images/mall/圣诞3.jpg);height:3px;width:70%;margin-left:15%;"/> 
                                    <div id="myTabContent2" class="tab-content">
                                        <div class="tab-pane fade in active" id="1">
                                            <asp:ListView runat="server" ID="LVBooks">
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder" />
                                                    </div>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <div >
                                                        <div style="width:20%;height:200px;float:left;margin-top:10px">
                                                            <p style="padding:10px 7px 4px 5px;height:195px;width:145px;"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></p>
                                                        </div>                    
                                                        <div style="width:80%;height:200px;float:left;padding-top:20px;margin-top:10px">
                                                            <p><a href="<%#"MallDetails.aspx?id="+Eval("GoodsID") %>"><%# Eval("GoodsName") %></a></p>
                                                            <p><h2 style="color:red">¥<%# Eval("Price") %></h2></p>
                                                            <p style="font-size:12px;font-family:'Microsoft YaHei'"><%# Eval("Author") %>/<%# Eval("Release_time") %></p>
                                                            <p style="font-size:15px;font-family:'Microsoft YaHei'"><%# Eval("introduce") %></p><br />
                                                            <asp:Button runat="server" ID="BtnAdd" CssClass="BtnAdd" Text="加入购物车" OnClick="BtnAdd_Click"/>
                                                        </div>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:ListView>
                                            <div style="text-align:center">
                                                <asp:DataPager runat="server" PagedControlID="LVBooks" PageSize="8" ID="DPBooks" OnPreRender="DPBooks_PreRender">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" ButtonCssClass="btn-default btn-sm" />
                                                        <asp:NumericPagerField ButtonCount="3" NumericButtonCssClass="btn-default btn-sm" />
                                                        <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="尾页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" ButtonCssClass="btn-default btn-sm" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </div>
                                        </div>
                                        <div class="tab-pane fade" id="2">
                                            <asp:ListView runat="server" ID="LVxxBooks">
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder" />
                                                    </div>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <div >
                                                        <div style="width:20%;height:200px;float:left;margin-top:10px">
                                                            <p style="padding:10px 7px 4px 5px;height:195px;width:145px;"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></p>
                                                        </div>                    
                                                        <div style="width:80%;height:200px;float:left;padding-top:20px;margin-top:10px">
                                                            <p><a href="<%#"MallDetails.aspx?id="+Eval("GoodsID") %>"><%# Eval("GoodsName") %></a></p>
                                                            <p><h2 style="color:red">¥<%# Eval("Price") %></h2></p>
                                                            <p style="font-size:12px;font-family:'Microsoft YaHei'"><%# Eval("Author") %>/<%# Eval("Release_time") %></p>
                                                            <p style="font-size:15px;font-family:'Microsoft YaHei'"><%# Eval("introduce") %></p><br />
                                                            <asp:Button runat="server" ID="BtnAdd" CssClass="BtnAdd" Text="加入购物车" OnClick="BtnAdd_Click"/>
                                                        </div>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </div>
                                        <div class="tab-pane fade" id="3">
                                            <asp:ListView runat="server" ID="LVczBooks">
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder" />
                                                    </div>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <div >
                                                        <div style="width:20%;height:200px;float:left;margin-top:10px">
                                                            <p style="padding:10px 7px 4px 5px;height:195px;width:145px;"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></p>
                                                        </div>                    
                                                        <div style="width:80%;height:200px;float:left;padding-top:20px;margin-top:10px">
                                                            <p><a href="<%#"MallDetails.aspx?id="+Eval("GoodsID") %>"><%# Eval("GoodsName") %></a></p>
                                                            <p><h2 style="color:red">¥<%# Eval("Price") %></h2></p>
                                                            <p style="font-size:12px;font-family:'Microsoft YaHei'"><%# Eval("Author") %>/<%# Eval("Release_time") %></p>
                                                            <p style="font-size:15px;font-family:'Microsoft YaHei'"><%# Eval("introduce") %></p><br />
                                                            <asp:Button runat="server" ID="BtnAdd" CssClass="BtnAdd" Text="加入购物车" OnClick="BtnAdd_Click"/>
                                                        </div>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </div>
                                        <div class="tab-pane fade" id="4">
                                            <asp:ListView runat="server" ID="LVgzBooks">
                                                <LayoutTemplate>
                                                    <div>
                                                        <asp:PlaceHolder runat="server" ID="itemplaceholder" />
                                                    </div>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <div>
                                                        <div style="width:20%;height:200px;float:left;margin-top:10px">
                                                            <p style="padding:10px 7px 4px 5px;height:195px;width:145px;"><a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><image src="<%# Eval("Picture") %>"></image></a></p>
                                                        </div>                    
                                                        <div style="width:80%;height:200px;float:left;padding-top:20px;margin-top:10px">
                                                            <p><a href="<%#"MallDetails.aspx?id="+Eval("GoodsID") %>"><%# Eval("GoodsName") %></a></p>
                                                            <p><h2 style="color:red">¥<%# Eval("Price") %></h2></p>
                                                            <p style="font-size:12px;font-family:'Microsoft YaHei'"><%# Eval("Author") %>/<%# Eval("Release_time") %></p>
                                                            <p style="font-size:15px;font-family:'Microsoft YaHei'"><%# Eval("introduce") %></p><br />
                                                            <asp:Button runat="server" ID="BtnAdd" CssClass="BtnAdd" Text="加入购物车" OnClick="BtnAdd_Click"/>
                                                        </div>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </div>
                                    </div> 
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:updatepanel>
        <script src="JS/bootstrap.min.js"></script>
        <br /><br />
        <hr  style="background-image:url(../images/mall/圣诞3.jpg);height:3px;width:70%;margin-left:15%;"/> 
        <!--底部-->
        <div class="footer">
            <div class="footer_top"></div>
            <div style="width:70%;margin-left:15%">
                <div class="footer_left">
                    <ul>
                        <li><h3><strong>友情链接</strong></h3></li>
                        <li><a href="http://www.jxnu.edu.cn" target="_blank">江西师范大学</a></li>
                        <li><a href="http://www.jxedu.gov.cn/" target="_blank">江西教育网</a></li>
                        <li><a href="http://gaojiao.jxedu.gov.cn/" target="_blank">江西高教网</a></li>
                    </ul>
                </div>
                <div class="footer_center">
                    <ul>
                        <li><h3><strong>服务支持</strong></h3></li>
                        <li><a href="#">隐私保护</a></li>
                        <li><a href="#">使用协议</a></li>
                        <li><a href="#">版权声明</a></li>
                        <li><a href="#">意见反馈</a></li>
                    </ul>                    
                </div>
                <div class="footer_right">
                    <ul>
                        <li><h3><strong>V教育</strong></h3></li>
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
