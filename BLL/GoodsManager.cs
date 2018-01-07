using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using DALFactory;
using Models;

namespace BLL
{
    public class GoodsManager
    {
        private static IGoods igoods = DataAccess.CreateGoods();
        public static DataTable SelectxxBooksTop6()
        {
            return igoods.SelectxxBooksTop6();
        }
        public static DataTable SelectczBooksTop6()
        {
            return igoods.SelectczBooksTop6();
        }
        public static DataTable SelectgzBooksTop6()
        {
            return igoods.SelectgzBooksTop6();
        }
        public static DataTable SelectAllBooks()
        {
            return igoods.SelectAllBooks();
        }
        public static DataTable SelectxxBooks()
        {
            return igoods.SelectxxBooks();
        }
        public static DataTable SelectczBooks()
        {
            return igoods.SelectczBooks();
        }
        public static DataTable SelectgzBooks()
        {
            return igoods.SelectgzBooks();
        }
        public static DataTable SelectAllVideo()
        {
            return igoods.SelectAllVideo();
        }
        public static DataTable SelectxxVideo()
        {
            return igoods.SelectxxVideo();
        }
        public static DataTable SelectczVideo()
        {
            return igoods.SelectczVideo();
        }
        public static DataTable SelectgzVideo()
        {
            return igoods.SelectgzVideo();
        }
        public static DataTable SelectID(int ID)
        {
            return igoods.SelectID(ID);
        }
        public static DataTable SelectUserID(string ID)
        {
            return igoods.SelectUserID(ID);
        }
        public static DataTable SelectShoppingCart(string UserName)
        {
            return igoods.SelectShoppingCart(UserName);
        }
        public static int InsertShoppingCart(MallItemcart Mallitemcart)
        {
            return igoods.InsertShoppingCart(Mallitemcart);
        }
        public static int DeleteShoppingCart(int ShoppingCartID)
        {
            return igoods.DeleteShoppingCart(ShoppingCartID);
        }
        public static DataTable SelectAllTot_amt(string UserName)
        {
            return igoods.SelectAllTot_amt(UserName);
        }
        public static int UpdateShoppingCartNum(int CartID, int num, decimal total)
        {
            return igoods.UpdateShoppingCartNum(CartID, num, total);
        }
        public static DataTable JudgeShoppingCart(int UserID)
        {
            return igoods.JudgeShoppingCart(UserID);
        }
        public static DataTable JudgeMallYorN(int UserID, int GoodsID)//判断某用户购物车是否有某商品的方法
        {
            return igoods.JudgeMallYorN(UserID, GoodsID);
        }
        public static int UpdateShoppingCart(int UserID, int GoodsID, int Qty, decimal Tot_amt)//购物车有商品时做更新操作
        {
            return igoods.UpdateShoppingCart(UserID, GoodsID, Qty, Tot_amt);
        }
        public static int InsertOrder(int UserID) //从购物车表插入订单表
        {
            return igoods.InsertOrder(UserID);
        }
        public static DataTable SelectOrders(int UserID)//从订单表查询某用户的订单信息
        {
            return igoods.SelectOrders(UserID);
        }
        public static DataTable SelectOrdersIn(int Order_no) //从订单表查询某订单的订单信息
        {
            return igoods.SelectOrdersIn(Order_no);
        }
        public static DataTable SelectOrderItems(int Order_no)//从订单详细表查询订单详细信息
        {
            return igoods.SelectOrderItems(Order_no);
        }
        public static int InsertMallComments(MallComments MallComments) //向商品评论表插入评论
        {
            return igoods.InsertMallComments(MallComments);
        }
        public static int InsertReplyMallComments(ReplyMallComments ReplyMallComments)//向商品回复表插入回复
        {
            return igoods.InsertReplyMallComments(ReplyMallComments);
        }
        public static DataTable SelectMallComments(int GoodsID) //查询商品评论
        {
            return igoods.SelectMallComments(GoodsID);
        }
        public static DataTable SelectReplyMallComments(int MallCommentID) //查询商品回复
        {
            return igoods.SelectReplyMallComments(MallCommentID);
        }
        public static DataTable JudgeYorNComments(int UserID, int GoodsID)//判断用户能否对此商品评论
        {
            return igoods.JudgeYorNComments(UserID, GoodsID);
        }
        public static DataTable SelectUserMallCart(int UserID)//查询用户购物车数量
        {
            return igoods.SelectUserMallCart(UserID);
        }

    }
}
