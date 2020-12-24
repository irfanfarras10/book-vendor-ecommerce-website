using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Handler
{
    public class BookHandler
    {
        public static List<Book> GetRandomBook()
        {
            return BookRepository.GetRandomBook();
        }

        public static List<Book> GetAll()
        {
            return BookRepository.GetAll();
        }

        public static Book GetBook(int BookID)
        {
            return BookRepository.GetBook(BookID);
        }

        public static void InsertBook(int genreid, string name, string description,
            int stock, int price)
        {
            BookRepository.InsertBook(genreid, name, description, stock, price);
        }

        public static void DeleteBook(int bookid)
        {
            BookRepository.DeleteBook(bookid);
        }

        public static void UpdateBook(int id, string name, int genre, string description,
            int stock, int price)
        {
            BookRepository.UpdateBook(id, name, genre, description, stock, price);
        }

        public static Book cekref(int genid)
        {
            return BookRepository.cekref(genid);
        }

        public static List<Book> getSearch(string name)
        {
            return BookRepository.getSearch(name);
        }

        public static List<Book> getSingle(int id)
        {
            return BookRepository.getSingle(id);
        }

        public static Book find(int id)
        {
            return BookRepository.find(id);
        }

        public static void decreaseStock(int id, int qty)
        {
            BookRepository.decreaseStock(id, qty);
        }

    }
}