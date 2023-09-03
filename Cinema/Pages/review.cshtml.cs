using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Cinema.Models.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Pages
{
    public class reviewModel : PageModel
    {
        public List<Movie> movies;
        public List<Genre> genres;
        public void OnGet(int? id, string searchString, string onShowing, string comingSoon, string hot, string all)
        {
            movies = MovieDAO.GetMoviesHot();
            genres = GenreDAO.GetGenres();
            if (id != null)
            {
                movies = MovieDAO.GetMoviesByGenre(int.Parse(id.ToString()));
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = MovieDAO.GetMoviesBySearch(searchString);
            }
            if (!String.IsNullOrEmpty(onShowing))
            {
                movies = MovieDAO.GetMoviesOnShowing();
            }
            if (!String.IsNullOrEmpty(comingSoon))
            {
                movies = MovieDAO.GetMoviesCommingSoon();
            }
            if (!String.IsNullOrEmpty(hot))
            {
                movies = MovieDAO.GetMoviesHot();
            }
            if (!String.IsNullOrEmpty(all))
            {
                movies = MovieDAO.GetMovies();
            }
        }
    }
}
