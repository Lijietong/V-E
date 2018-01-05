<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActivitiesDetails.aspx.cs" Inherits="WEB.ActivitiesDetails" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <title>精品活动</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="CSS/activities.css" rel="stylesheet" />
    <asp:ListView ID="LVactivities" runat="server">
         <LayoutTemplate>
                 <table>
                      <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                  </table>
         </LayoutTemplate>
        <ItemTemplate>
            <div id="header"><%# Eval("Act_theme") %></div>
            <div id="pageHome">
                <div id="message">
                    <ul>
                        <li><%# Eval("Act_time") %></li>
                        <li><%# Eval("Act_address") %></li>
                        <li><%# Eval("Act_grade") %></li>
                        <li>浏览量:<%# Eval("Click_num") %></li>
                    </ul>
                </div>        
                <div id="summary"><%# Eval("Act_summary") %></div>       
                <div id="content">
                    <div id="picture">
                        <asp:Image ID="Act_images" runat="server" ImageUrl='<%#Eval("Act_images") %>' />
                    </div>
                    <div id="txt"><%# Eval("Act_content") %></div>       
                </div>
            </div>
               </ItemTemplate>
       </asp:ListView>
            <div id="sidebar">
                <h2>推荐活动</h2>
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                      <ul>
                         <li><a href="ActivitiesDetails.aspx?id=<%# Eval("ActID") %>"><%# Eval("Act_theme") %></a></li>
                      </ul>
                    </ItemTemplate>
                </asp:DataList>
            </div>
</asp:Content>
