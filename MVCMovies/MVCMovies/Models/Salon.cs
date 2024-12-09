using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class Salon
    {
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int SalonNr { get; set; }

        [Range(1, 20)]
        public int NumberOfSeats { get; set; }

        public ICollection<Seat>? Seats { get; set; }

        public ICollection<Show>? Shows { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
