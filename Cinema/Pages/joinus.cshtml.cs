using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Helpers;
using Cinema.Models;
using Cinema.Models.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Pages
{
    public class joinusModel : PageModel
    {
        public Member member;
        public IActionResult OnGet(int? id)
        {
            member = SessionHelper.GetObjectFromJson<Member>(HttpContext.Session, "user");
            if(id != null)
            {
                MemberDAO.ChangeType(member.MemberId, int.Parse(id.ToString()));
            }
            Member a = MemberDAO.checkExits(member.Email);
            HttpContext.Session.Remove("user");
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", a);
            member = SessionHelper.GetObjectFromJson<Member>(HttpContext.Session, "user");
            return Page();
        }
    }
}
