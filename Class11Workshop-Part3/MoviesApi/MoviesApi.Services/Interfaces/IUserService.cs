using Microsoft.ServiceFabric.Services.Remoting;
using MoviesApi.Domain.Models;
using MoviesApi.Models.Users;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;


namespace MoviesApi.Services.Interfaces
{
    public interface IUserService
    {

        void Register(RegisterUserModel registerUserModel);
        string Login(LoginUserModel loginUserModel);
    }
}
