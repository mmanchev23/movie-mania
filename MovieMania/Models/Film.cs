using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMania.Models
{
    public class Film
    {
        [Key]
        public string FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; }
        public string TrailerUrl { get; set; }
    }
}
