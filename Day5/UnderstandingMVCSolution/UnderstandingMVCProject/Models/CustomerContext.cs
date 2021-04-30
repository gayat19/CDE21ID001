using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingMVCProject.Models
{
    public class CustomerContext :DbContext
    {
        public CustomerContext()
        {

        }
        public CustomerContext(DbContextOptions opt):base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 101, Name = "Ramu", Phone = "1234567890" },
                new Customer() { Id = 102, Name = "Somu", Phone = "6789012345" }
                );
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
