using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Cinema.Models.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Pages
{
    public class RegisterModel : PageModel
    {
        public string mes;
        public void OnGet()
        {
            mes = "";
        }
        public IActionResult OnPost()
        {
            if (Request.Form["password"] == Request.Form["re-password"])
            {
                Member c = MemberDAO.checkExits(Request.Form["email"]);
                if (c == null)
                {
                    string fullname = Request.Form["fullname"];
                    string gender = Request.Form["gender"];
                    string email = Request.Form["email"];
                    string password = Request.Form["password"];
                    MemberDAO.Register(fullname, gender, email, password);
                    return RedirectToPage("/Login");
                }
                mes = "Tài khoản hiện đã tồn tại";
                return Page();
            }
            mes = "Vui lòng nhập mật khẩu giống với mật khẩu điền lại!";
            return Page();
        }
    }
}
