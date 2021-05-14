using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIApplication.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {

        }
        public CompanyContext(DbContextOptions opts):base(opts)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { UserId="Ramu",Password="1234",Role="Admin"},
                new User() { UserId = "Somu", Password = "4321", Role = "User" }
                );
        }
        public DbSet<User> Users { get; set; }
    }
}
