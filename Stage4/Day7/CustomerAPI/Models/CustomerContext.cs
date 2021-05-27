using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Models
{
    public class CustomerContext :DbContext
    {
        public CustomerContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer()
            {
                Id = 101,
                Name = "Ramu",
                Age = 22
            });
        }
    }
}
