using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApiShared.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
