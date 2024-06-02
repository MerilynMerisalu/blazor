using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [DataType(DataType.Date)]

        public DateTime? ReleaseDate { get; set; }
        public string? Genre { get; set; }
        [Precision(18, 2)]
        [Range(0, 100)]
        public decimal Price { get; set; }
    }
}
