using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApi.Shared.CustomEntity
{
    public class AppSettings
    {
        public string ConnectionString { get; set; }
        public string SecretKey { get; set; }
    }
}
