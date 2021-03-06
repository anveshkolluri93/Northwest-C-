﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

using Team01_Project01.Models;


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
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
       
    }
}
