using System;
using System.Collections.Generic;

#nullable disable

namespace Cinema.Models
{
    public partial class Member
    {
        public int MemberId { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Type { get; set; }
    }
}
