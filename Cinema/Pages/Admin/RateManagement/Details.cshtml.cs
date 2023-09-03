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
    public class DetailsModel : PageModel
    {
        private readonly Cinema.Models.MovieDBContext _context;

        public DetailsModel(Cinema.Models.MovieDBContext context)
        {
            _context = context;
        }

        public Rate Rate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rate = await _context.Rates.FirstOrDefaultAsync(m => m.MovieId == id);

            if (Rate == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
