using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;


namespace DataKolluri.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Location> Locations { get; set; }
    }

}
