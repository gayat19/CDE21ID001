using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationProject.Models
{
    public class WeatherContext :DbContext
    {
        public WeatherContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> users { get; set; }
    }
}
