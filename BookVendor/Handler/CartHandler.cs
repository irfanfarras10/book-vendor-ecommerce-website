using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Handler
{
    public class CartHandler
    {
        public static void insertCart(int userid, int bookid, int qty)
        {
            CartRepository.insertCart(userid, bookid, qty);
        }

        public static List<Cart> GetCart(int id)
        {
            return CartRepository.GetCart(id);
        }

        public static Cart Sumqty(int userid, int id, int qty)
        {
            return CartRepository.Sumqty(userid,id, qty);
        }

        public static int Total(int userid)
        {
            return CartRepository.Total(userid);
        }

        public static int cartqty(int id)
        {
            return CartRepository.cartqty(id);
        }

        public static void delAll(int userid)
        {
            CartRepository.delAll(userid);
        }

        public static void delete1(int bookid)
        {
            CartRepository.delete1(bookid);
        }

    }
}