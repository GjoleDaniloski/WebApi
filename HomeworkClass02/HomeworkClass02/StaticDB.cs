using HomeworkClass02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkClass02
{
    public static class StaticDB
    {
        public static List<User> ListOfUsers = new List<User>
        {
           
            new User()
            {
                Id = 1,
                FirstName = "Zoran",
                LastName = "Goranoski"
            },
            new User()
            {
                Id = 2,
                FirstName = "Goran",
                LastName = "Zoranoski"
            },
            new User()
            {
                Id = 3,
                FirstName = "Pero",
                LastName = "Peroski"
            },
            new User()
            {
                Id = 4,
                FirstName = "Trajko",
                LastName = "Rajkoski"
            }
            
        };
    }
}
