using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MovieDatabase.Data.Migrations;
using MovieDatabase.Models;
using NuGet.ContentModel;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MovieDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //SEED GENRES
            builder.Entity<Genre>().HasData(new Genre {Id=1, Name="Comedy" });
            builder.Entity<Genre>().HasData(new Genre {Id=2, Name= "Drama" });
            builder.Entity<Genre>().HasData(new Genre {Id=3, Name= "Action" });
            builder.Entity<Genre>().HasData(new Genre {Id=4, Name= "Romance" });
            builder.Entity<Genre>().HasData(new Genre {Id=5, Name= "Science Fiction" });
            builder.Entity<Genre>().HasData(new Genre {Id=6, Name= "Fantasy" });
            builder.Entity<Genre>().HasData(new Genre {Id=7, Name= "Children" });


            //SEED MOVIES

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Star Wars",
                    Description = "Luke Skywalker learns magic from a strange hermit in the desert, joins the rebels and fights the empire",
                    ReleaseDate = DateOnly.Parse("16 december 1977"),
                    GenreId = 5,
                    ImgFileName= "Star Wars.jpg"
                });

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 2,
                    Title = "Dune Part Two",
                    Description = "Paul Atreides starts a holy war",
                    ReleaseDate = DateOnly.Parse("2024-02-28"),
                    GenreId = 5,
                    ImgFileName = "Dune Part Two.jpg"
                });

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 3,
                    Title = "This is the end",
                    Description = "A bunch of famous actors face the apocalypse and die",
                    ReleaseDate = DateOnly.Parse("2013-06-03"),
                    GenreId = 1,
                    ImgFileName = "This-is-the-End-Film-Poster.jpg"
                });

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 4,
                    Title = "Ice Age",
                    Description = "A mammoth, a sloth and a saber-toothed tiger find a human baby and go on a journey to find its family.",
                    ReleaseDate = DateOnly.Parse("2002-03-15"),
                    GenreId = 7,
                    ImgFileName = "Ice Age.webp"
                });

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 5,
                    Title = "Lunana: A Yak in the Classroom",
                    Description = "A teacher who doesn't want to teach is transferred to the most remote school in the world.",
                    ReleaseDate = DateOnly.Parse("2019-10-05"),
                    GenreId = 2,
                    ImgFileName = "A Yak in the Classroom.jpg"
                });

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 6,
                    Title = "Parasite",
                    Description = "Greed and class discrimination threaten the newly-formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                    ReleaseDate = DateOnly.Parse("2019-05-30"),
                    GenreId = 1,
                    ImgFileName = "Parasite.jpg"
                });







            //Create an admin role and an admin user

            string ADMIN_ID = "02174cf0–9412–4cfe - afbf - 59f706d72cf6";
            string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

            //seed admin role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var user = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "admin@moviedatabase.com",
                EmailConfirmed = true,
                UserName = "admin@moviedatabase.com",
                NormalizedUserName = "ADMIN@MOVIEDATABASE.COM"
            };

            //set user password
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            user.PasswordHash = ph.HashPassword(user, "myPassword");

            //seed user
            builder.Entity<IdentityUser>().HasData(user);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }

    }
}
