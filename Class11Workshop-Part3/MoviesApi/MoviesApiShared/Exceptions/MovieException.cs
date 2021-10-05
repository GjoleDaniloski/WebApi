using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApiShared.Exceptions
{
    public class MovieException : Exception
    {
        public MovieException(string message) : base(message)
        {

        }
    }
}
