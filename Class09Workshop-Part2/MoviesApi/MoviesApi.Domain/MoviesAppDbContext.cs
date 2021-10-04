using Microsoft.EntityFrameworkCore;
using MoviesApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApi.Domain
{
    public class MoviesAppDbContext : DbContext
    {

        public MoviesAppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>()
                .Property(x => x.Id)
                .HasMaxLength(30)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(x => x.Title)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(x => x.Description)
                .HasMaxLength(100);

            modelBuilder.Entity<Movie>()
                .Property(x => x.Year)
                .HasMaxLength(4);

            modelBuilder.Entity<Movie>()
                .Property(x => x.Genre)
                .HasMaxLength(30);
        }
    }
}
