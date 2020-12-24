using BookVendor.Factory;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Repository
{
    public class GenreRepository
    {
        public static Genre GetGenre(int genreID)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Genre genre = db.Genres.Find(genreID);
            return genre;
        }

        public static void UpdateGenre(int id, string name, string description)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Genre update = db.Genres.Find(id);
            update.GenreID = id;
            update.GenreName = name;
            update.Description = description;
            db.SaveChanges();
        }

        public static void InsertGenre(string name, string description)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Genre genre = BookFactory.CreateGenre(name, description);
            db.Genres.Add(genre);
            db.SaveChanges();
        }

        public static List<Genre> GetGenre()
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<Genre> genre = new List<Genre>();
            genre = db.Genres.ToList();
            return genre;
        }

        public static void DeleteGenre(int GenreID)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            Genre toBeDeleted = db.Genres
                .Where(a => a.GenreID == GenreID)
                .First();
            db.Genres.Remove(toBeDeleted);
            db.SaveChanges();
        }

      
    }
}