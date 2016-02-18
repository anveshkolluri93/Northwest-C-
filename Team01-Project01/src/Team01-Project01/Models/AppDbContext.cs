using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace Team01_Project01.Models
{
    //deleted this super class IdentityDbContext<ApplicationUser>, 
    public class AppDbContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Students> Students { get; set; } 
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
