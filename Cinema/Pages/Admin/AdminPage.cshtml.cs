using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Cinema.Models.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Pages.Admin
{
    public class AdminPageModel : PageModel
    {
        public List<Movie> movies;
        public int rate;
        public int genre;
        public int movie;
        public int mem;
        public IActionResult OnGet()
        {
            if(HttpContext.Session.GetString("admin")!= null)
            {
movies = MovieDAO.GetMoviesHot();
            rate = RateDAO.GetRates().Count;
            genre = GenreDAO.GetGenres().Count;
            movie = MovieDAO.GetMovies().Count;
            mem = MemberDAO.GetMembers().Count;
                return Page();
            }
            else
            {
                return RedirectToPage("/Login");
            }
            
        }
    }
}
