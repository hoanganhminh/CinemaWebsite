using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Models;

namespace Cinema.Pages.Admin.MemberManagement
{
    public class DetailsModel : PageModel
    {
        private readonly Cinema.Models.MovieDBContext _context;

        public DetailsModel(Cinema.Models.MovieDBContext context)
        {
            _context = context;
        }

        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Members.FirstOrDefaultAsync(m => m.MemberId == id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
