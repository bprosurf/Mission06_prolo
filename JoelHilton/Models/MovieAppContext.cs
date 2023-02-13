using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHilton.Models
{
    public class MovieAppContext : DbContext
    {
        //Constructor
        public MovieAppContext (DbContextOptions<MovieAppContext> options): base(options)
        {
            //Leave Blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                
                new ApplicationResponse
                {
                    MovieId = 1,
                    Category = "Adventure/Drama/Sci-Fi",
                    Title = "Intersteller",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""


                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    Category = "Mystery/Thiller",
                    Title = "Shutter Island",
                    Year = 2010,
                    Director = "Martin Scorsese",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""


                },
                new ApplicationResponse
                {
                MovieId = 3,
                    Category = "Drama/Mystery/Sci-Fi",
                    Title = "The Prestige",
                    Year = 2006,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""


                }
            );
        }
    }
}
