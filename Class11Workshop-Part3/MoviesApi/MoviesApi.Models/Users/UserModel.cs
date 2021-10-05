using MoviesApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApi.Models.Users
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
