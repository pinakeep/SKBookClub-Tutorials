using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SKBookClub.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed genres
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 1, GenreName = "Horror" });
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 2, GenreName = "Supernatural" });
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 3, GenreName = "Thriller" });

            //seed books

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 1,
                Title = "The Shining",
                Price = 9.99M,
                ShortDescription = "A Stephen King Horror Novel",
                LongDescription = "The Shining is a horror novel by American author Stephen King. Published in 1977. It is Kings third published novel and first hardback bestseller",
                GenreId = 1,
                ImageUrl = "https://i.ibb.co/GMT7m40/theshinning.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "https://i.ibb.co/9Z1011p/theshinning-small.jpg",
            });
            
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 2,
                Title = "The Institute",
                Price = 7.99M,
                ShortDescription = "A Sci-Fi Thriller",
                LongDescription = "The Institute is a science fiction-horror thriller novel by American author Stephen King",
                GenreId = 3,
                ImageUrl = "https://i.ibb.co/ngj9Xgy/theinstitute.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://i.ibb.co/BtvKCFz/theinstitute-small.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 3,
                Title = "IT",
                Price = 7.99M,
                ShortDescription = "Stephen King Bestselling Horror",
                LongDescription = "It is a 1986 horror novel by American author Stephen King. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey",
                GenreId = 2,
                ImageUrl = "https://i.ibb.co/NKVYZK4/it.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://i.ibb.co/f06Lxjv/it-small.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 4,
                Title = "Pet Sematary",
                Price = 4.99M,
                ShortDescription = "A Stephen King Horror",
                LongDescription = "Pet Sematary is a 1983 horror novel by American writer Stephen King. The novel was nominated for a World Fantasy Award for Best Novel in 1986, and adapted into two films: one in 1989 and another in 2019",
                GenreId = 1,
                ImageUrl = "https://i.ibb.co/F3Jyvbm/petsematary.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://i.ibb.co/nCQbJwF/petsematary-small.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 5,
                Title = "If It Bleeds",
                Price = 12.99M,
                ShortDescription = "Latest from Stephen King",
                LongDescription = "If It Bleeds is a 2020 collection of four previously unpublished novellas by American writer Stephen King. The stories in the collection are titled If It Bleeds Mr Harrigans Phone The Life of Chuck and Rat",
                GenreId = 1,
                ImageUrl = "https://i.ibb.co/GRkqJXk/ifitbleeds.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://i.ibb.co/6g9VYhk/ifitbleeds-small.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 6,
                Title = "Finders Keepers",
                Price = 4.99M,
                ShortDescription = "Second in Bill Hodges Trilogy",
                LongDescription = "Finders Keepers is a crime novel by American writer Stephen King published on June 2 2015. It is the second volume in a trilogy focusing on Detective Bill Hodges following Mr Mercedes",
                GenreId = 3,
                ImageUrl = "https://i.ibb.co/3Yy2YnP/finderskeepers.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://i.ibb.co/31hd6Xh/finderskeepers-small.jpg",
            });
        }
    }

}
