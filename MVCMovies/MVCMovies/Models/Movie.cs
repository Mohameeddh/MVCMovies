using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(55)]
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        public string?  Genre { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }

        [Range(1, 200)]
        public int Length { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public ICollection<Salon> Salons { get; set; }
        public ICollection<Show> Shows { get; set; }

    }   
}       
