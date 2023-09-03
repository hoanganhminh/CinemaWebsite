using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Models;

namespace Cinema.Pages.Admin.RateManagement
{
    public class IndexModel : PageModel
    {
        private readonly Cinema.Models.MovieDBContext _context;

        public IndexModel(Cinema.Models.MovieDBContext context)
        {
            _context = context;
        }

        public IList<Rate> Rate { get;set; }

        public async Task OnGetAsync()
        {
            Rate = await _context.Rates.ToListAsync();
        }
    }
}
