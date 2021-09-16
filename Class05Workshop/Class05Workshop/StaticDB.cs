using Class05Workshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class05Workshop
{
    public static class StaticDB
    {
        public static List<Movie> ListOfMovies = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Title = "Dumb and Dumber",
                Description = "Starring Jim Carrey and Jeff Daniels, it tells the story of Lloyd Christmas (Carrey) and Harry Dunne (Daniels), two dumb but well-meaning friends from Providence",
                Year = 1994,
                Genre = "Comedy"
            },

            new Movie()
            {
                Id = 2,
                Title = "Taken",
                Description = "A retired CIA agent travels across Europe and relies on his old skills to save his estranged daughter, who has been kidnapped while on a trip to Paris.",
                Year = 2008,
                Genre = "Action"
            },

            new Movie()
            {
                Id = 3,
                Title = "The Irishman",
                Description = "The film follows Frank Sheeran (De Niro), a truck driver who becomes a hitman involved with mobster Russell Bufalino (Pesci) and his crime family",
                Year = 1997,
                Genre = "Drama"
            },

            new Movie()
            {
                Id = 4,
                Title = "Enola Holmes",
                Description = "Enola Holmes is the youngest sibling in the famous Holmes family. She is extremely intelligent, observant, and insightful, defying the social norms for women of the time.",
                Year = 2020,
                Genre = "Adventure"
            }

        };
    }
}
