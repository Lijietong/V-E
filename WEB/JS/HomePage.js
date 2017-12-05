//$(function ()
//{
//     var i=0;
//     var len=$("#scroll ul li").length-1;
//     $(".subl").click(function(){
//         if(i==len){
//             i=-1;
//         }
//         i++;
//         $("#scroll ul li").eq(i).fadeIn().siblings().hide();
//     });
//     //到这里分开！上面的是上一张点击的效果代码，下面的是下一张点击的效果代码．
//     $(".subr").click(function(){//获取类名的点击事件．
//         if(i==0){
//             i=len+1;
//         }
//         i--;
//         $("#scroll ul li").eq(i).fadeIn().siblings().hide();
//     });
// });
$(function () {
    // 轮播
    bannerRotate.bannerInit();
});

// banner rotating
var bannerRotate = {
    _time: 3000,
    _fade: 200,
    _i: 0,
    _interval: null,
    _navId: "#mb-inav",
    _navBox: "#mb-ibox",
    _navTxt: "#mb-itxt",
    bannerShow: function () {
        $(this._navId).find("li a").removeClass("cur");
        $(this._navId).find("li:eq(" + this._i + ")").find("a").addClass("cur");

        $(this._navBox).find("a").fadeOut(this._fade);
        $(this._navBox).find("a:eq(" + this._i + ")").fadeIn(this._fade);

        $(this._navTxt).find("div").hide();
        $(this._navTxt).find("div:eq(" + this._i + ")").fadeIn(this._fade);
    },
    bannerStart: function () {
        var _this = this;
        _this._interval = setInterval(function () {
            if (_this._i >= 2) {
                _this._i = 0;
            }
            else {
                _this._i++;
            }
            _this.bannerShow();
        }, _this._time);
    },
    bannerInit: function () {
        var _this = this;
        _this.bannerStart();

        $(_this._navId).find("li a").bind("mouseover", function () {
            clearInterval(_this._interval);
            _this._i = $(this).parent().index();
            _this.bannerShow();
            _this.bannerStart();
        });
    }
};