using BookVendor.Factory;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Repository
{
    public class BookRepository
    {
        public static List<Book> GetRandomBook()
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<Book> Books = new List<Book>();
            Books = db.Books.Where(z => z.Stock != 0).OrderBy(item=>Guid.NewGuid()).Take(5).ToList();
            return Books;
        }

        public static List<Book> GetAll()
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<Book> Books = new List<Book>();
            Books = db.Books.Where(z => z.Stock != 0).ToList();
            return Books;
        }

        public static Book GetBook(int BookID)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Book book = db.Books.Find(BookID);
            return book;
        }

        public static void InsertBook(int genreid,string name,string description,
            int stock,int price)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Book book = BookFactory.CreateBook(genreid,name,stock, price,description);
            db.Books.Add(book);
            db.SaveChanges();
        }

        public static void DeleteBook(int bookid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Book toBeDeleted = db.Books
                .Where(a => a.BookID == bookid)
                .First();
            db.Books.Remove(toBeDeleted);
            db.SaveChanges();
        }

        public static void UpdateBook(int id, string name,int genre, string description,
            int stock,int price)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Book update = db.Books.Find(id);
            update.BookID = id;
            update.Name = name;
            update.GenreID = genre;
            update.Description = description;
            update.Stock = stock;
            update.Price = price;
            db.SaveChanges();
        }

        public static Book cekref(int genid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Book genref = db.Books.Where(a => a.GenreID == genid).FirstOrDefault();
            return genref;
        }

        public static List<Book> getSearch(string name)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<Book> search = db.Books.Where(a => a.Name == name).ToList();
            if (search.Count != 0) return search;
            else return null;
        }

        public static List<Book> getSingle(int id)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<Book> single = db.Books.Where(a => a.BookID == id).ToList();
            return single;
        }

        public static Book find(int id)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            return db.Books.Find(id);
        }

        public static void decreaseStock(int id, int qty)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Book book = db.Books.Find(id);
            book.Stock -= qty;
            db.SaveChanges();
        }


    }
}