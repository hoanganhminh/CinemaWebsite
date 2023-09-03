using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Models;
using Cinema.Models.DAO;

namespace Cinema.Pages.Admin.MovieManagement
{
    public class IndexModel : PageModel
    {
        private readonly Cinema.Models.MovieDBContext _context;

        public IndexModel(Cinema.Models.MovieDBContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync(string? search)
        {
            Movie = await _context.Movies.ToListAsync();
            if (!String.IsNullOrEmpty(search))
            {
                Movie = MovieDAO.GetMoviesBySearch(search);
            }
        }
    }
}
