using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovies.Data; 
using MVCMovies.Models;
using System;
using System.Linq;

namespace MVCMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            
            using (var context = new MVCMoviesContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCMoviesContext>>()))
            {

                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "The Dark Knight",
                        Genre = "Action",
                        Description = "Batman faces the Joker, who seeks to bring Gotham to its knees.",
                        ReleaseDate = new DateTime(2008, 7, 18),
                        Length = 152,
                        Price = 120
                    },
                    new Movie
                    {
                        Title = "The Godfather",
                        Genre = "Crime",
                        Description = "A crime family struggles with power and betrayal.",
                        ReleaseDate = new DateTime(1972, 3, 24),
                        Length = 175,
                        Price = 100
                    },
                    new Movie
                    {
                        Title = "Forrest Gump",
                        Genre = "Drama",
                        Description = "The life of a man with extraordinary luck and a remarkable journey.",
                        ReleaseDate = new DateTime(1994, 7, 6),
                        Length = 142,
                        Price = 80
                    },
                    new Movie
                    {
                        Title = "Inception",
                        Genre = "Sci-Fi",
                        Description = "A thief enters dreams to steal secrets, but faces an impossible task.",
                        ReleaseDate = new DateTime(2010, 7, 16),
                        Length = 148,
                        Price = 110
                    },
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        Genre = "Drama",
                        Description = "Two prisoners find hope and redemption in a brutal prison.",
                        ReleaseDate = new DateTime(1994, 9, 23),
                        Length = 142,
                        Price = 90
                    },
                    new Movie
                    {
                        Title = "Gladiator",
                        Genre = "Action",
                        Description = "A betrayed general seeks revenge against a corrupt emperor.",
                        ReleaseDate = new DateTime(2000, 5, 5),
                        Length = 155,
                        Price = 100
                    },
                    new Movie
                    {
                        Title = "Pulp Fiction",
                        Genre = "Crime",
                        Description = "Interconnected stories of crime and redemption.",
                        ReleaseDate = new DateTime(1994, 10, 14),
                        Length = 154,
                        Price = 95
                    },
                    new Movie
                    {
                        Title = "Titanic",
                        Genre = "Romance",
                        Description = "A romance blossoms aboard the ill-fated Titanic.",
                        ReleaseDate = new DateTime(1997, 12, 19),
                        Length = 195,
                        Price = 120
                    },
                    new Movie
                    {
                        Title = "Avatar",
                        Genre = "Sci-Fi",
                        Description = "A paraplegic marine explores a beautiful alien world.",
                        ReleaseDate = new DateTime(2009, 12, 18),
                        Length = 162,
                        Price = 110
                    },
                    new Movie
                    {
                        Title = "The Lion King",
                        Genre = "Animation",
                        Description = "A young lion prince learns the true meaning of leadership.",
                        ReleaseDate = new DateTime(1994, 6, 15),
                        Length = 88,
                        Price = 80
                    }
                );

                context.SaveChanges();


                var salons = new List<Salon>
                {
                    new Salon { SalonNr = 1, NumberOfSeats = 20 },
                    new Salon { SalonNr = 2, NumberOfSeats = 30 },
                    new Salon { SalonNr = 3, NumberOfSeats = 25 }
                };

                context.Salons.AddRange(salons);
                context.SaveChanges();


                var seats = new List<Seat>();
                foreach (var salon in salons)
                {
                    for (int i = 1; i <= salon.NumberOfSeats; i++)
                    {
                        seats.Add(new Seat
                        {
                            SalonId = salon.Id, 
                            SeatNr = i,
                            Status = "Available"
                        });
                    }
                }

                context.Seats.AddRange(seats);
                context.SaveChanges();


                context.Shows.AddRange(
                    new Show { MovieId = 1, SalonId = 1, Date = DateTime.Now.AddDays(1) },
                    new Show { MovieId = 2, SalonId = 2, Date = DateTime.Now.AddDays(2) },
                    new Show { MovieId = 3, SalonId = 3, Date = DateTime.Now.AddDays(3) },
                    new Show { MovieId = 4, SalonId = 1, Date = DateTime.Now.AddDays(4) },
                    new Show { MovieId = 5, SalonId = 2, Date = DateTime.Now.AddDays(5) },
                    new Show { MovieId = 6, SalonId = 3, Date = DateTime.Now.AddDays(6) },
                    new Show { MovieId = 7, SalonId = 1, Date = DateTime.Now.AddDays(7) },
                    new Show { MovieId = 8, SalonId = 2, Date = DateTime.Now.AddDays(8) },
                    new Show { MovieId = 9, SalonId = 3, Date = DateTime.Now.AddDays(9) },
                    new Show { MovieId = 10, SalonId = 1, Date = DateTime.Now.AddDays(10) }
                );

                context.SaveChanges();
            }
        }
    }
}