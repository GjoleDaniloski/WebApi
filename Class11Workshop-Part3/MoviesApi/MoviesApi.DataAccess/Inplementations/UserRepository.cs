using MoviesApi.DataAccess.Interfaces;
using MoviesApi.Domain;
using MoviesApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesApi.DataAccess.Inplementations
{
    public class UserRepository : IUserRepository
    {
        private MoviesAppDbContext _movieAppDbContext;
        public UserRepository(MoviesAppDbContext moviesAppDbContext)
        {
            _movieAppDbContext = moviesAppDbContext;
        }

        public void Add(User entity)
        {
            _movieAppDbContext.Add(entity);
            _movieAppDbContext.SaveChanges();
        }

        public void Delete(User entity)
        {
            _movieAppDbContext.Remove(entity);
            _movieAppDbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _movieAppDbContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return _movieAppDbContext
                .Users
                .FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByUsername(string username)
        {
            return _movieAppDbContext.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public User LoginUser(string username, string password)
        {
            return _movieAppDbContext.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == password);
        }

        public void Update(User entity)
        {
            _movieAppDbContext.Users.Update(entity);
            _movieAppDbContext.SaveChanges();
        }

        
    }
}
