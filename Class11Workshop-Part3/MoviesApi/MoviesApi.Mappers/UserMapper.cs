using MoviesApi.Domain.Models;
using MoviesApi.Models.Users;
using MoviesApi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApi.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this UserModel userModel)
        {
            return new User
            {
                Id = userModel.Id,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Username = userModel.Username,
                Address = userModel.Address,
                Age = userModel.Age
            };
        }
        public static UserModel ToUserModel(this User user)
        {
            return new UserModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Address = user.Address,
                Age = user.Age


            };
        }
    }
}
