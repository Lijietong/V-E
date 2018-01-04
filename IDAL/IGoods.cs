using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace IDAL
{
    public interface IGoods
    {
        DataTable SelectxxBooksTop6();
        DataTable SelectczBooksTop6();
        DataTable SelectgzBooksTop6();
        DataTable SelectAllBooks();
        DataTable SelectxxBooks();
        DataTable SelectczBooks();
        DataTable SelectgzBooks();
        DataTable SelectAllVideo();
        DataTable SelectxxVideo();
        DataTable SelectczVideo();
        DataTable SelectgzVideo();
        DataTable SelectID(int ID);
        DataTable SelectUserID(string ID);
        DataTable SelectShoppingCart(string UserName);
        int InsertShoppingCart(MallItemcart Mallitemcart);
        int DeleteShoppingCart(int ShoppingCartID);
        DataTable SelectAllTot_amt(string UserName);
        int UpdateShoppingCartNum(int CartID, int num, float total);
        DataTable JudgeShoppingCart(int UserID);
        DataTable JudgeMallYorN(int UserID, int VideoID);//判断某用户购物车是否有某商品的方法
        int UpdateShoppingCart(int UserID, int VideoID, int Qty, float Tot_amt);//购物车有商品时做更新操作
        int InsertOrder(int UserID); //从购物车表插入订单表
        DataTable SelectOrders(int UserID); //从订单表查询某用户的订单信息
        DataTable SelectOrdersIn(int Order_no); //从订单表查询某订单的订单信息
        DataTable SelectOrderItems(int Order_no); //从订单详细表查询订单详细信息
        int InsertMallComments(MallComments MallComments); //向商品评论表插入评论
        int InsertReplyMallComments(ReplyMallComments ReplyMallComments); //向商品回复表插入回复
        DataTable SelectMallComments(int GoodsID); //查询商品评论
        DataTable SelectReplyMallComments(int MallCommentID); //查询商品回复
        DataTable JudgeYorNComments(int UserID, int GoodsID); //判断用户能否对此商品评论
        DataTable SelectUserMallCart(int UserID); //查询用户购物车数量
    }
}
