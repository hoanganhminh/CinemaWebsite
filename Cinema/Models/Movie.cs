using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Cinema.Models
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MM yyyy}")]
        public DateTime? Year { get; set; }
        public int? GenreId { get; set; }
        public string Image { get; set; }
    }
}
