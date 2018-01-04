<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WEB.HomePage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="CSS/index.css" />
    <script src="JS/jquery-1.11.3.min.js"></script>
    <script src="JS/wySilder.min.js"></script>
    <script src="JS/lunbotu.js"></script>
    <script src="JS/HomePage.js"></script>
    <div class="js-silder">
       <div class="silder-scroll">
		    <div class="silder-main">
			    <div class="silder-main-img">
				    <img src="images/Index/5.jpg" alt=""/>
			    </div>
			    <div class="silder-main-img">
				    <img src="images/Index/6.jpg" alt=""/>
			    </div>
			    <div class="silder-main-img">
				    <img src="images/Index/7.jpg" alt=""/>
			    </div>
		    </div>
	    </div>
    </div><br /><br />
    <div class="primary">小&nbsp;学&nbsp;培&nbsp;优</div>
    <div class="p_contents">
        <div class="best_courses">
            <div class="courses_h">
                <div class="best">精品课程</div>
                <div class="more"><a href="#">更多>></a></div>
            </div>
            <div class="courses_f">
                <asp:DataList ID="DLxxcourses" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                      <ItemTemplate>
                        <table style="padding:20px">
                            <tr >
                                <td >                  
                                   <a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><asp:Image ID="course_picture" runat="server" Width="190px" Height="130px" ImageUrl='<%#Eval("Picture") %>' /></a>                  
                                </td>
                            </tr>
                           <tr>
                                <td style="text-align:center">
                                    <asp:LinkButton ID="Cname" runat="server" CssClass="LBcname" ><%#DataBinder.Eval(Container.DataItem, "GoodsName")%></asp:LinkButton>   
                                </td>
                            </tr>           
                        </table>
                        </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
        <div class="paihang">
            <div class="paihang_h">
                <div class="">排行榜</div>
            </div>
            <div class="paihang_f">
                <asp:Repeater ID="RPxxpaihang" runat="server">
                  <ItemTemplate>
                      <table style="width:330px">
                        <tr >
                            <td  style="text-align:left;font-size:14px;line-height:30px;">
                               <a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><%# Eval("GoodsName") %></a>
                            </td>
                        </tr>                              
                    </table>
                  </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="clear"></div>
        <div class="hotact">
            <div class="hotact_h">热门活动</div>
            <div class="hotact_f">
                 <asp:DataList ID="DLxxActivity" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                      <ItemTemplate>
                        <table style="padding:20px;">
                            <tr >
                                <td >                  
                                   <a href="#"><asp:Image ID="Act_images" runat="server" Width="300px" Height="115px" ImageUrl='<%#Eval("Act_images") %>' /></a>                 
                                </td>
                            </tr>          
                        </table>
                      </ItemTemplate>
                </asp:DataList>
            </div>
        </div>             
        <div class="article">
            <div class="article_h">文章资讯</div>
            <div class="article_f">
                <asp:Repeater ID="RPxxArticle" runat="server">
                  <ItemTemplate>
                      <table style="width:330px">
                        <tr >
                            <td  style="text-align:left;font-size:14px;line-height:30px;">
                               <a href="Article.aspx?id=<%# Eval("ArtID") %>"><%# Eval("Art_theme") %></a>
                            </td>
                        </tr>                              
                    </table>
                  </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>     
    </div>   
    <div class="clear"></div>
    <div style="height: 15px; background-color: #fff;width: 70%;margin-left: 15%;"></div>
    <div style="height:50px;"></div>
    <div class="junior">初&nbsp;中&nbsp;拔&nbsp;高</div>
    <div class="p_contents">
        <div class="best_courses">
            <div class="courses_h">
                <div class="best">精品课程</div>
                <div class="more"><a href="#">更多>></a></div>
            </div>
            <div class="courses_f">
                <asp:DataList ID="DLczcourses" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                      <ItemTemplate>
                        <table style="padding:20px">
                            <tr >
                                <td >                  
                                   <a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><asp:Image ID="course_picture" runat="server" Width="190px" Height="130px" ImageUrl='<%#Eval("Picture") %>'  /></a>                  
                                </td>
                            </tr>
                           <tr>
                                <td style="text-align:center">
                                    <asp:LinkButton ID="Cname" runat="server" CssClass="LBcname" ><%#DataBinder.Eval(Container.DataItem, "GoodsName")%></asp:LinkButton>   
                                </td>
                            </tr>           
                        </table>
                        </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
        <div class="paihang">
            <div class="paihang_h">
                <div class="">排行榜</div>
            </div>
            <div class="paihang_f">
                <asp:Repeater ID="RPczpaihang" runat="server">
                  <ItemTemplate>
                      <table style="width:330px">
                        <tr >
                            <td  style="text-align:left;font-size:14px;line-height:30px;">
                                <a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><%# Eval("GoodsName") %></a>
                            </td>
                        </tr>                              
                    </table>
                  </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="clear"></div>

        <div class="hotact">
            <div class="hotact_h">热门活动</div>
            <div class="hotact_f">
                <asp:DataList ID="DLczActivity" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                      <ItemTemplate>
                        <table style="padding:20px;">
                            <tr >
                                <td >                  
                                   <a href="#"><asp:Image ID="Act_images" runat="server" Width="300px" Height="115px" ImageUrl='<%#Eval("Act_images") %>' /></a>                 
                                </td>
                            </tr>          
                        </table>
                      </ItemTemplate>
                </asp:DataList>
            </div>
        </div>       
        <div class="article">
            <div class="article_h">文章资讯</div>
            <div class="article_f">
                <asp:Repeater ID="RPczArticle" runat="server">
                  <ItemTemplate>
                      <table style="width:330px">
                        <tr >
                            <td  style="text-align:left;font-size:14px;line-height:30px;">
                                <a href="Article.aspx?id=<%# Eval("ArtID") %>"><%# Eval("Art_theme") %></a>
                            </td>
                        </tr>                              
                    </table>
                  </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>     
    </div><br /><br />
    <div class="clear"></div>
    <div style="height: 15px; background-color: #fff;width: 70%;margin-left: 15%;"></div>
    <div style="height:50px;"></div>
    <div class="senior">高&nbsp;中&nbsp;冲&nbsp;刺</div>
    <div class="p_contents">
        <div class="best_courses">
            <div class="courses_h">
                <div class="best">精品课程</div>
                <div class="more"><a href="#">更多>></a></div>
            </div>
            <div class="courses_f">
                <asp:DataList ID="DLgzcourses" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                      <ItemTemplate>
                        <table style="padding:20px">
                            <tr >
                                <td >                  
                                   <a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><asp:Image ID="course_picture" runat="server" Width="190px" Height="130px" ImageUrl='<%#Eval("Picture") %>'  /></a>                  
                                </td>
                            </tr>
                           <tr>
                                <td style="text-align:center">
                                    <asp:LinkButton ID="Cname" runat="server" CssClass="LBcname" ><%#DataBinder.Eval(Container.DataItem, "GoodsName")%></asp:LinkButton>   
                                </td>
                            </tr>           
                        </table>
                        </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
        <div class="paihang">
            <div class="paihang_h">
                <div class="">排行榜</div>
            </div>
            <div class="paihang_f">
                <asp:Repeater ID="RPgzpaihang" runat="server">
                  <ItemTemplate>
                      <table style="width:330px">
                        <tr >
                            <td  style="text-align:left;font-size:14px;line-height:30px;">
                                <a href="<%# "MallDetails.aspx?id="+Eval("GoodsID") %>"><%# Eval("GoodsName") %></a>
                            </td>
                        </tr>                              
                    </table>
                  </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="clear"></div>

        <div class="hotact">
            <div class="hotact_h">热门活动</div>
            <div class="hotact_f">
                <asp:DataList ID="DLgzActivity" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                      <ItemTemplate>
                        <table style="padding:20px;">
                            <tr >
                                <td >                  
                                   <a href="#"><asp:Image ID="Act_images" runat="server" Width="300px" Height="115px" ImageUrl='<%#Eval("Act_images") %>' /></a>                 
                                </td>
                            </tr>          
                        </table>
                      </ItemTemplate>
                </asp:DataList>
            </div>
        </div>       
        <div class="article">
            <div class="article_h">文章资讯</div>
            <div class="article_f">
                <asp:Repeater ID="RPgzArticle" runat="server">
                  <ItemTemplate>
                      <table style="width:330px">
                        <tr >
                            <td  style="text-align:left;font-size:14px;line-height:30px;">
                                <a href="Article.aspx?id=<%# Eval("ArtID") %>"><%# Eval("Art_theme") %></a>
                            </td>
                        </tr>                              
                    </table>
                  </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>     
    </div><br /><br />
    <div class="clear"></div>
    <div style="height: 15px; background-color: #fff;width: 70%;margin-left: 15%;"></div>
    <!--优秀教师-->
    <div style="height:50px;"></div>
    <hr  style="height:5px;width:45%;float:left;background-color:#fff;"/>
    <div style="width:10%;height:40px;float:left;font-size:24px;font-weight:bold;margin-top:-15px;padding-left:20px;">优&nbsp;秀&nbsp;教&nbsp;师</div>
    <hr  style="height:5px;width:45%;float:right;background-color:#fff;"/>
    <div class="clear"></div>
    <div class="teachers">
        <asp:listview ID="LVteachers" runat="server">
            <LayoutTemplate>                
                <asp:PlaceHolder runat="server" ID="itemPlaceholder" />               
            </LayoutTemplate>                
            <ItemTemplate>
                <div id="PlaceHolder" style="display:inline-block;height:500px;padding:15px">
                    <div style="width:50px;height:50px;margin-left:100px"><asp:Image ID="teachers_images" runat="server" ImageUrl='<%# Eval("picture") %>' /></div>
                    <div style="text-align:center;height:20px;width:250px"><%# Eval("Tec_name") %></div>
                    <p style="text-align:center;width:250px;height:250px"><%# Eval("introduce") %></p>
                </div>                   
            </ItemTemplate>
        </asp:listview>
    </div>
    <div class="clear"></div>
</asp:Content>
