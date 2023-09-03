using System;
using System.Collections.Generic;

#nullable disable

namespace Cinema.Models
{
    public partial class Rate
    {
        public int MovieId { get; set; }
        public int MemberId { get; set; }
        public string Comment { get; set; }
        public double? Rating { get; set; }
        public DateTime? Time { get; set; }
    }
}
