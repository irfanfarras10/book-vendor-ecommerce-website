using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int userid, int bookid, int qty)
        {
            Cart cart = new Cart();
            cart.UserID = userid;
            cart.BookID = bookid;
            cart.Quantity = qty;
            return cart;
        }
    }
}