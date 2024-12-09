using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class Seat
    {
        public int Id { get; set; }

        [Required]
        public int SalonId { get; set; }

        [Range(1, int.MaxValue)]
        public int SeatNr { get; set; }


        [Required]
        [RegularExpression("^(Available|Booked|Reserved)$", ErrorMessage = "Invalid seat status.")]
        public string? Status { get; set; }

        public Salon? Salon { get; set; }
    }
}
