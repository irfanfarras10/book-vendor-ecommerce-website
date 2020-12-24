using BookVendor.Handler;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Controller
{
    public class BookController
    {
        public static List<Book> GetRandomBook()
        {
            return BookHandler.GetRandomBook();
        }

        public static List<Book> GetAll()
        {
            return BookHandler.GetAll();
        }

        public static Book GetBook(int BookID)
        {
            return BookHandler.GetBook(BookID);
        }

        public static void InsertBook(int genreid, string name, string description,
            int stock, int price)
        {
            BookHandler.InsertBook(genreid, name, description, stock, price);
        }

        public static void DeleteBook(int bookid)
        {
            BookHandler.DeleteBook(bookid);
        }

        public static void UpdateBook(int id, string name, int genre, string description,
            int stock, int price)
        {
            BookHandler.UpdateBook(id, name, genre, description, stock, price);
        }

        public static Book cekref(int genid)
        {
            return BookHandler.cekref(genid);
        }

        public static List<Book> getSearch(string name)
        {
            return BookHandler.getSearch(name);
        }

        public static List<Book> getSingle(int id)
        {
            return BookHandler.getSingle(id);
        }

        public static Book find(int id)
        {
            return BookHandler.find(id);
        }

        public static void decreaseStock(int id, int qty)
        {
            BookController.decreaseStock(id, qty);
        }

    }
}