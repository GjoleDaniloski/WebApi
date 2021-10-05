using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesApi.DataAccess;
using MoviesApi.DataAccess.Inplementations;
using MoviesApi.DataAccess.Interfaces;
using MoviesApi.Domain;
using MoviesApi.Domain.Models;
using MoviesApi.Services.Implementations;
using MoviesApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApi.Helpers
{
    public class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MoviesAppDbContext>(x =>
                x.UseSqlServer(connectionString));
        }

        public static void InjectRepository(IServiceCollection services)
        {
            services.AddTransient<IRepository<Movie>, MovieRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
