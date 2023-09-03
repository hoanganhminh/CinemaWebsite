using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.DAO
{
    public class GenreDAO
    {
        public static List<Genre> GetGenres()
        {
            List<Genre> genres;
            try
            {
                using (var context = new MovieDBContext())
                {
                    genres = context.Genres.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return genres;
        }

        public static Genre GetGenreById(int id)
        {
            Genre genre;
            try
            {
                using (var context = new MovieDBContext())
                {
                    genre = context.Genres.FirstOrDefault(g => g.GenreId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return genre;
        }
    }
}
