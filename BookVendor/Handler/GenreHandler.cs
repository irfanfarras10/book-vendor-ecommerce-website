using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Handler
{
    public class GenreHandler
    {
        public static Genre GetGenre(int genreID)
        {
            return GenreRepository.GetGenre(genreID);
        }

        public static void UpdateGenre(int id, string name, string description)
        {
            GenreRepository.UpdateGenre(id, name, description);
        }

        public static void InsertGenre(string name, string description)
        {
            GenreRepository.InsertGenre(name, description);
        }

        public static List<Genre> GetGenre()
        {
            return GenreRepository.GetGenre();
        }

        public static void DeleteGenre(int GenreID)
        {
            GenreRepository.DeleteGenre(GenreID);
        }
    }
}