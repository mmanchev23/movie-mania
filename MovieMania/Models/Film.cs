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
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string TrailerUrl { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
