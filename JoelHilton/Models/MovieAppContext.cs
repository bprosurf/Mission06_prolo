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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName="Adventure"},
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Sci-FI" },
                new Category { CategoryId = 4, CategoryName = "Comedy" },
                new Category { CategoryId = 5, CategoryName = "Drama" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Horror" },
                new Category { CategoryId = 8, CategoryName = "Sci-FI" }
            );

            mb.Entity<ApplicationResponse>().HasData(
                
                new ApplicationResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
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
                    CategoryId = 2,
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
                    CategoryId = 3,
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
