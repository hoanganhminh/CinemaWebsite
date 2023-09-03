using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Helpers;
using Cinema.Models;
using Cinema.Models.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Pages
{
    public class LoginModel : PageModel
    {
        public string mes;
        public void OnGet()
        {
            mes = "";
            HttpContext.Session.Remove("user");
            HttpContext.Session.Remove("memberId");
            HttpContext.Session.Remove("logined");
            HttpContext.Session.Remove("admin");
        }

        public IActionResult OnPost()
        {
            Member a = MemberDAO.checkLogin(Request.Form["email"], Request.Form["password"]);
            if (a != null)
            {
                if (a.Type != 1)
                {
                    if (a.Type == 2)
                    {
                        mes = "Tài khoản của bạn đã bị chặn do vi phạm chính sách";
                        return Page();
                    }
                    else
                    {
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "user", a);
                        HttpContext.Session.SetString("logined", "logined");
                        return RedirectToPage("/Index");
                    }
                }
                else
                {
                    HttpContext.Session.SetString("admin", "admin");
                    return RedirectToPage("/Index");
                }
            }
            mes = "Sai tài khoản hoặc mật khẩu";
            return Page();
        }
    }
}

