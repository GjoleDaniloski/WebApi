using Microsoft.EntityFrameworkCore;
using MoviesApi.Domain;
using MoviesApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesApi.DataAccess.Inplementations
{
    public class MovieRepository : IRepository<Movie>
    {
        private MoviesAppDbContext _movieAppDbContext;
        public MovieRepository(MoviesAppDbContext moviesAppDbContext)
        {
            _movieAppDbContext = moviesAppDbContext;
        }
        public void Add(Movie entity)
        {
            _movieAppDbContext.Add(entity);
            _movieAppDbContext.SaveChanges();
        }

        public void Delete(Movie entity)
        {
            _movieAppDbContext.Remove(entity);
            _movieAppDbContext.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _movieAppDbContext
                  .Movies
                  .Include(x => x.Id)
                  .ToList();
        }

        public Movie GetById(int id)
        {
            return _movieAppDbContext
                .Movies
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Movie entity)
        {
            _movieAppDbContext.Movies.Update(entity);
            _movieAppDbContext.SaveChanges();
        }
    }
}
