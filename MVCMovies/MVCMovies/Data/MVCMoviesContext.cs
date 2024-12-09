using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovies.Models;

namespace MVCMovies.Data
{
    public class MVCMoviesContext : DbContext
    {
        public MVCMoviesContext (DbContextOptions<MVCMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovies.Models.Booking> Bookings { get; set; } = default!;
        public DbSet<MVCMovies.Models.Movie> Movies { get; set; } = default!;
        public DbSet<MVCMovies.Models.Salon> Salons { get; set; } = default!;
        public DbSet<MVCMovies.Models.Seat> Seats { get; set; } = default!;
        public DbSet<MVCMovies.Models.Show> Shows { get; set; } = default!;
    }
}
