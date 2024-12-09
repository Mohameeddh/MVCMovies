using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public int ShowId { get; set; }

        [Required]
        public Show? Show { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int SeatNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string? CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string? CustomerEmail { get; set; }

        [Required]
        public int SalonId { get; set; }

        
        public Salon? Salon { get; set; }
    }
}



/*public IActionResult Confirmation(string bookingNr)
{
    var booking = _context.Bookings
        .Include(b => b.Shows)
        .ThenInclude(s => s.Movies)
        .Include(b => b.Shows.Salons)
        .FirstOrDefault(b => b.BookingNr == bookingNr);

    if (booking == null)
        return NotFound();

    return View(booking);
}*/