using System;
using System.Linq;
using linq.Models;
using Microsoft.EntityFrameworkCore;


namespace linq.Data
{
    public class AnimalDbContext : DbContext
    {
        public AnimalDbContext()
        {
        }

        public AnimalDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }

    }
}
