using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime Release { get; set; }

        public DateTime Added { get; set; } = DateTime.Now;

        [Range(1, 20)]
        public short NumberInStock { get; set; }
    }
}