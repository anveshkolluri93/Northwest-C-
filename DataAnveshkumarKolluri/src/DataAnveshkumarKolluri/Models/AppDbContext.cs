using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;


namespace DataAnveshkumarKolluri.Models
{
    public class AppDbContext : DbContext
    {
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }

}
