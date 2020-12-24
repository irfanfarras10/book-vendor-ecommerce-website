using BookVendor.Factory;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Repository
{
    public class CartRepository
    {
        public static void insertCart(int userid, int bookid, int qty)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Cart cart = CartFactory.CreateCart(userid, bookid, qty);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static List<Cart> GetCart(int id)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<Cart> cart = new List<Cart>();
            cart = db.Carts.Where(a => a.UserID == id).ToList();
            return cart;
        }

        public static Cart Sumqty(int userid,int id, int qty)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Cart cart = new Cart();
            cart = db.Carts.Where(a => a.BookID == id && a.UserID == userid).FirstOrDefault();
            if (cart != null)
            {
                cart.Quantity += qty;
                db.SaveChanges();
            }
            return cart;
        }
        
        public static int Total(int userid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            int total = db.Carts.Where(a => a.UserID == userid).Sum(a => a.Quantity * a.Book.Price);
            return total;
        }

        public static int cartqty(int id)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Cart cart = new Cart();
            int cartqty = 0;
            try
            {
                cartqty = db.Carts.Where(a => a.BookID == id).Sum(a => (int?)a.Quantity) ?? 0;
            }
            catch(Exception e)
            {
                
            }
            
            return cartqty;
        }

        public static void delAll(int userid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<Cart> cart = new List<Cart>();
            cart = db.Carts.Where(a => a.UserID == userid).ToList();
            
            foreach(var item in cart)
            {
                db.Carts.Remove(item);
            }
            db.SaveChanges();
        }

        public static void delete1(int bookid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Cart toBeDeleted = db.Carts
                .Where(a => a.BookID == bookid)
                .First();
            db.Carts.Remove(toBeDeleted);
            db.SaveChanges();
        }

    }
}