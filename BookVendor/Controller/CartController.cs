using BookVendor.Handler;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Controller
{
    public class CartController
    {
        public static void insertCart(int userid, int bookid, int qty)
        {
            CartHandler.insertCart(userid, bookid, qty);
        }

        public static List<Cart> GetCart(int id)
        {
            return CartHandler.GetCart(id);
        }

        public static Cart Sumqty(int userid,int id, int qty)
        {
            return CartHandler.Sumqty(userid,id, qty);
        }

        public static int Total(int userid)
        {
            return CartHandler.Total(userid);
        }

        public static int cartqty(int id)
        {
            return CartHandler.cartqty(id);
        }

        public static void delAll(int userid)
        {
            CartHandler.delAll(userid);
        }

        public static void delete1(int bookid)
        {
            CartHandler.delete1(bookid);
        }

    }
}