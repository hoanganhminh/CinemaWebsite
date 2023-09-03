using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cinema.Models;

namespace Cinema.Pages
{
    public class wiriwrModel : PageModel
    {
        private readonly Cinema.Models.MovieDBContext _context;

        public wiriwrModel(Cinema.Models.MovieDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rate Rate { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rates.Add(Rate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
