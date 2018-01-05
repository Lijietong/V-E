using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;

namespace DAL
{
    class SqlServerGoods:IGoods
    {
        public DataTable SelectxxBooksTop6()
        {
            string sql = "select top 6 * from Goods where GoodsGrade='小学' and GoodsType='图书'  order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczBooksTop6()
        {
            string sql = "select top 6 * from Goods where GoodsGrade='初中' and GoodsType='图书' order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzBooksTop6()
        {
            string sql = "select top 6 * from Goods where GoodsGrade='高中' and GoodsType='图书'  order by sale_num ";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectAllBooks()
        {
            string sql = "select * from Goods where GoodsType='图书'";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectxxBooks()
        {
            string sql = "select *from Goods where GoodsType='图书' and GoodsGrade='小学'";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectczBooks()
        {
            string sql = "select *from Goods where GoodsType='图书' and GoodsGrade='初中'";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzBooks()
        {
            string sql = "select *from Goods where GoodsType='图书' and GoodsGrade='高中'";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectAllVideo()
        {
            string sql = "select * from Goods where GoodsType='视频'";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectxxVideo()
        {
            string sql = "select *from Goods where GoodsType='视频' and GoodsGrade='小学'";
            return DBHelper.GetFillData(sql);
        }
       public DataTable SelectczVideo()
        {
            string sql = "select *from Goods where GoodsType='视频' and GoodsGrade='初中'";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectgzVideo()
        {
            string sql = "select *from Goods where GoodsType='视频' and GoodsGrade='高中'";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectID(int ID)
        {
            string sql = "select * From Goods where GoodsID like '" + @ID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID",ID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectUserID(string ID)
        {
            string sql = "select * From Users,Associates where Associates.UserID=Users.UserID and Associates.UserID like '" + @ID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID",ID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectShoppingCart(string UserName)
        {
            string sql = "select * from Users,MallItemCart,Goods where MallItemCart.UserID=Users.UserID and MallItemCart.GoodsID=Goods.GoodsID and Users.UserName='" + @UserName + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserName",UserName)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int InsertShoppingCart(MallItemcart MallItemcart)
        {
            string sql = "insert into MallItemCart(UserID,GoodsID,Unit_price,Qty,Tot_amt)values(@UserID,@GoodsID,@Unit_price,@Qty,@Tot_amt)";
            SqlParameter[] para =
            {
                new SqlParameter ("@UserID",MallItemcart.UserID),
                new SqlParameter ("@GoodsID",MallItemcart.GoodsID),
                new SqlParameter ("@Unit_price",MallItemcart.Unit_price),
                new SqlParameter ("@Number",MallItemcart.Qty),
                new SqlParameter ("@TotalAmount",MallItemcart.Tot_amt)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public int DeleteShoppingCart(int ShoppingCartID)
        {
            string sql = "delete from MallItemCart where ShoppingCartID=@ShoppingCartID";
            SqlParameter[] para =
            {
                new SqlParameter("@ShoppingCartID",ShoppingCartID)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public DataTable SelectAllTot_amt(string UserName)
        {
            string sql = "select SUM(Tot_amt) FinalTot_amt from Users,MallItemCart,Goods where MallItemCart.UserID=Users.UserID and MallItemCart.GoodsID=Goods.GoodsID and Users.UserName='" + @UserName + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserName",UserName)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int UpdateShoppingCartNum(int CartID, int qty, float total)
        {
            string sql = "update MallItemCart set Qty = '" + @qty + "',Tot_amt='" + @total + "' where ShoppingCartID = '" + @CartID + "' ";
            SqlParameter[] para =
            {
                new SqlParameter("@qty",qty),
                new SqlParameter("@total",total),
                new SqlParameter("@CartID",CartID)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public DataTable JudgeShoppingCart(int UserID)
        {
            string sql = "select * from MallItemCart where UserID ='" + @UserID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable JudgeMallYorN(int UserID, int GoodsID) //判断某用户购物车是否有某商品的方法
        {
            string sql = "select * from MallItemCart where UserID ='" + @UserID + "'and GoodsID='" + @GoodsID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@GoodsID",GoodsID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int UpdateShoppingCart(int UserID, int GoodsID, int Qty, float Tot_amt) //购物车有商品时做更新操作
        {
            string sql = "update MallItemCart set Qty=Qty+'" + @Qty + "',Tot_amt=Tot_amt+'" + @Tot_amt + "' where UserID='" + @UserID + "' and GoodsID='" + @GoodsID + "'";
            SqlParameter[] para =
            {
                new SqlParameter("@Qty",Qty),
                new SqlParameter("@Tot_amt",Tot_amt),
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@GoodsID",GoodsID)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public int InsertOrder(int UserID) //从购物车表插入订单表
        {
            SqlParameter[] para =
            {
                new SqlParameter("@UserID",UserID)
            };
            return DBHelper.GetExcuteNonQuery("ShoppingCart_Order", System.Data.CommandType.StoredProcedure, para);
        }
        public DataTable SelectOrders(int UserID) //从订单表查询某用户的订单信息
        {
            string sql = "select * from Orders where UserID='" + @UserID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectOrdersIn(int Order_no) //从订单表查询某订单的订单信息
        {
            string sql = "select * from Orders where Order_no='" + @Order_no + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Order_no",Order_no)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectOrderItems(int Order_no) //从订单详细表查询订单详细信息
        {
            string sql = "select * from OrderItems,Goods where Order_no='" + @Order_no+ "'and OrderItems.GoodsID=Goods.GoodsID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@OrderID",Order_no)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int InsertMallComments(MallComments MallComments) //向商品评论表插入评论
        {
            string sql = "insert into MallComments values(@GoodsID,@UserID,@MallComTime,@MallComContent)";
            SqlParameter[] para = {
                new SqlParameter ("@GoodsID",MallComments.GoodsID),
                new SqlParameter ("@UserID",MallComments.UserID),
                new SqlParameter ("@MallComTime",MallComments.Comments_time),
                new SqlParameter ("@MallComContent",MallComments.Comments_contents)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public int InsertReplyMallComments(ReplyMallComments ReplyMallComments) //向商品回复表插入回复
        {
            string sql = "insert into ReplyMallComments values(@MallCommentID,@UserID,@ReplyTime,@ReplyContents)";
            SqlParameter[] para = {
                new SqlParameter ("@MallCommentID",ReplyMallComments.MallCommentsID),
                new SqlParameter ("@UserID",ReplyMallComments.UserID),
                new SqlParameter ("@ReplyTime",ReplyMallComments.ReplyTime),
                new SqlParameter ("@ReplyContents",ReplyMallComments.ReplyContents)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public DataTable SelectMallComments(int GoodsID) //查询商品评论
        {
            string sql = "select * from MallComments,Users where GoodsID='" + @GoodsID + "' and MallComments.UserID=Users.UserID Order by MallComTime desc";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@GoodsID",GoodsID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectReplyMallComments(int MallCommentID) //查询商品回复
        {
            string sql = "select ReplyMallComments.*,a.UserName as 评论人,b.UserName as 回复人 from Users a,Users b,MallComments,ReplyMallComments where a.UserID=MallComments.UserID and b.UserID=ReplyMallComments.UserID and MallComments.MallCommentID=ReplyMallComments.MallCommentID and ReplyMallComments.MallCommentID='" + @MallCommentID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MallCommentID",MallCommentID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int DeleteGoods(int GoodsID)
        {
            SqlParameter[] sp = { new SqlParameter("@GoodsID", GoodsID) };
            return DBHelper.GetExcuteNonQuery("DeleteGoods", System.Data.CommandType.StoredProcedure, sp);
        }
        public DataTable JudgeYorNComments(int UserID, int GoodsID) //判断用户能否对此商品评论
        {
            string sql = "select * from Orders, OrderItems where Orders.Order_no = OrderItems.Order_no and OrderItems.GoodsID = '" + @GoodsID + "'and Orders.UserID = '" + @UserID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@GoodsID",GoodsID),
                new SqlParameter("@UserID",UserID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectUserMallCart(int UserID) //查询用户购物车数量
        {
            string sql = "select * from MallItemCart where UserID='" + @UserID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
    }
}
