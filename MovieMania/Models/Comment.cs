using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMania.Models
{
    public class Comment
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        [ForeignKey("FilmId")]
        public string FilmId { get; set; }
        public DateTime Time { get; set; }
        public string Content { get; set; }
    }
}
