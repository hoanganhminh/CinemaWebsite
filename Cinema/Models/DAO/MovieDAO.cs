using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.DAO
{
    public class MovieDAO
    {
        public static List<Movie> GetMovies()
        {
            List<Movie> movies;
            try
            {
                using (var context = new MovieDBContext())
                {
                    movies = context.Movies.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return movies;
        }

        public static List<Movie> GetMoviesBySearch(string search)
        {
            List<Movie> movies;
            try
            {
                using (var context = new MovieDBContext())
                {
                    movies = context.Movies.Where(m => m.Title.Contains(search)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return movies;
        }

        public static List<Movie> GetMoviesByGenre(int id)
        {
            List<Movie> movies;
            try
            {
                using (var context = new MovieDBContext())
                {
                    movies = context.Movies.Where(m => m.GenreId == id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return movies;
        }

        public static Movie GetMovieById(int id)
        {
            Movie movie;
            try
            {
                using (var context = new MovieDBContext())
                {
                    movie = context.Movies.FirstOrDefault(m => m.MovieId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return movie;
        }

        public static List<Movie> GetMoviesOnShowing()
        {
            List<Movie> movies;
            try
            {
                using (var context = new MovieDBContext())
                {
                    movies = context.Movies.Where(m => m.Year <= DateTime.Now).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return movies;
        }

        public static List<Movie> GetMoviesCommingSoon()
        {
            List<Movie> movies;
            try
            {
                using (var context = new MovieDBContext())
                {
                    movies = context.Movies.Where(m => m.Year > DateTime.Now).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return movies;
        }
        public static List<Movie> GetMoviesHot()
        {
            List<Movie> movies;
            try
            {
                using (var context = new MovieDBContext())
                {
                    movies = context.Movies.FromSqlRaw("Select DISTINCT Movies.MovieID, Title, Year, GenreId, Image from Movies join Rates on Movies.MovieId = Rates.MovieID").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return movies;
        }
    }
}
