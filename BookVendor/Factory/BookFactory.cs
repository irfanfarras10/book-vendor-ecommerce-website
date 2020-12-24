using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Factory
{
    public class BookFactory
    {
        public static Book CreateBook(int genreid,string name,int stock,int price,string desctription)
        {
            Book book = new Book();
            book.GenreID = genreid;
            book.Name = name;
            book.Stock = stock;
            book.Price = price;
            book.Description = desctription;
            return book;
        }

        public static Genre CreateGenre(string nama,string description)
        {
            Genre genre = new Genre();
            genre.GenreName = nama;
            genre.Description = description;
            return genre;
        }
    }
}