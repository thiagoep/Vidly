using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime Release { get; set; }

        public DateTime Added { get; set; } = DateTime.Now;

        [Display(Name = "Number in Stock")]
        public short NumberInStock { get; set; }
    }
}