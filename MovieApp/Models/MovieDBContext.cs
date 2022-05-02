using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("MovieDBContext")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<MovieGenre> MovieGenres { get; set; }
        //public DbSet<MoviePerson> MoviePersons { get; set; }
        //public DbSet<PersonRole> PersonRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder.Entity<MovieGenre>()
        //.HasKey(bc => new { bc.MovieId, bc.GenreId });
        //    modelBuilder.Entity<MovieGenre>()
        //        .HasOne(bc => bc.Movie)
        //        .WithMany(b => b.MovieGenres)
        //        .HasForeignKey(bc => bc.MovieId);
        //    modelBuilder.Entity<MovieGenre>()
        //        .HasOne(bc => bc.Genre)
        //        .WithMany(c => c.MovieGenres)
        //        .HasForeignKey(bc => bc.GenreId);


            //    modelBuilder.Entity<MoviePerson>()
            //.HasKey(bc => new { bc.MovieId, bc.PersonId });
            //    modelBuilder.Entity<MovieGenre>()
            //        .HasOne(bc => bc.Movie)
            //        .WithMany(b => b.MoviePersons)
            //        .HasForeignKey(bc => bc.MovieId);
            //    modelBuilder.Entity<MoviePerson>()
            //        .HasOne(bc => bc.Person)
            //        .WithMany(c => c.MoviePersons)
            //        .HasForeignKey(bc => bc.PersonId);
        }
    }
}