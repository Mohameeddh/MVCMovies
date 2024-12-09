using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class Show
    {
        public int Id { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public Movie Movie { get; set; }

        [Required]
        public int SalonId { get; set; }

        [Required]
        public Salon Salon { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } 

        public ICollection<Booking>? Bookings { get; set; }


    }
}
    