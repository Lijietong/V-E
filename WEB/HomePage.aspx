<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WEB.HomePage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="CSS/index.css" />
    <link rel="stylesheet" href="CSS/HomePage.css" />
    <script src="JS/HomePage.js"></script>
    <div class="js-silder">
       <div class="silder-scroll">
		    <div class="silder-main">
			    <div class="silder-main-img">
				    <img src="images/HomePage/5.jpg" alt=""/>
			    </div>
			    <div class="silder-main-img">
				    <img src="images/HomePage/6.jpg" alt=""/>
			    </div>
			    <div class="silder-main-img">
				    <img src="images/HomePage/7.jpg" alt=""/>
			    </div>
		    </div>
	    </div>
    </div>
    <script src="JS/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="JS/wySilder.min.js" type="text/javascript"></script>
    <script>
	    $(function (){
		    $(".js-silder").silder({
			    auto: true,//自动播放，传入任何可以转化为true的值都会自动轮播
			    speed: 20,//轮播图运动速度
			    sideCtrl: true,//是否需要侧边控制按钮
			    bottomCtrl: true,//是否需要底部控制按钮
			    defaultView: 0,//默认显示的索引
			    interval: 3000,//自动轮播的时间，以毫秒为单位，默认3000毫秒
			    activeClass: "active",//小的控制按钮激活的样式，不包括作用两边，默认active
		    });
	    });
    </script>
    <br />
    <div class="News">
        <div class="News_h">新&nbsp;闻&nbsp;头&nbsp;条</div>
    </div>
    <div class="Notice">
        <div class="Notice_h">公&nbsp;告&nbsp;一&nbsp;览</div>
    </div>
    <div class="clear"></div>
    <br /><br /><hr /><br /><br />
    <div class="Hotcourses">
        <div class="Hotcourses_h">热&nbsp;门&nbsp;活&nbsp;动</div>
    </div>
    <br /><br /><br />
    <hr />
    <div class="teacher">
        <ul>
            <li>1</li>
            <li>2</li>
            <li>3</li>
            <li>4</li>
            <li>5</li>
        </ul>
    </div>
    
    
</asp:Content>
