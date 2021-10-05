﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApi.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string FavoriteGenre { get; set; }
        public List<Movie> Movies { get; set; }

    }
}