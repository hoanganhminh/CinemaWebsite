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
    public class MemberProfileModel : PageModel
    {
        public Member member; 
        public void OnGet()
        {
            member = SessionHelper.GetObjectFromJson<Member>(HttpContext.Session, "user");
        }

        public IActionResult OnPost()
        {
            if (!Request.Form["oldPassword"].Equals("") && !Request.Form["newPassword"].Equals(""))
            {
                Member a = SessionHelper.GetObjectFromJson<Member>(HttpContext.Session, "user");
                if (a.Password == Request.Form["oldPassword"])
                {
                    MemberDAO.ChangePassword(a.MemberId, Request.Form["newPassword"]);
                    OnGet();
                }
            }
            return Page();
        }
    }
}
