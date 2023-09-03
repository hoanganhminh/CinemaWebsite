using Cinema.Models;
using Cinema.Models.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Movie> movies;
        public List<Movie> moviesOnShow;
        public List<Movie> moviesComingSoon;
        public List<Movie> moviesHot;
        public void OnGet()
        {
            movies = MovieDAO.GetMovies();
            moviesOnShow = MovieDAO.GetMoviesOnShowing();
            moviesComingSoon = MovieDAO.GetMoviesCommingSoon();
            moviesHot = MovieDAO.GetMoviesHot();
        }
    }
}
