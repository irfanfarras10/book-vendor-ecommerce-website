using BookVendor.Handler;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Controller
{
    public class GenreController
    {
        public static Genre GetGenre(int genreID)
        {
            return GenreHandler.GetGenre(genreID);
        }

        public static void UpdateGenre(int id, string name, string description)
        {
            GenreHandler.UpdateGenre(id, name, description);
        }

        public static void InsertGenre(string name, string description)
        {
            GenreHandler.InsertGenre(name, description);
        }

        public static List<Genre> GetGenre()
        {
            return GenreHandler.GetGenre();
        }

        public static void DeleteGenre(int GenreID)
        {
            GenreHandler.DeleteGenre(GenreID);
        }
    }
}