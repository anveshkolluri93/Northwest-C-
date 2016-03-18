using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;

namespace D08Kolluri.Models
{
    public static class AppSeedData { 
    public static void Initialize(IServiceProvider serviceProvider)
    {

        var context = serviceProvider.GetService<ApplicationDbContext>();
            
        if (context.Database == null)
        {
            throw new Exception("DB is null");
        }





            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new Movie() { MovieTitle = "Indra", MovieReviews = "4.5", MovieGenre = "Action", ActorName = "Chiru", ActressName = "Arthi" },
           new Movie() { MovieTitle = "Hitler", MovieReviews = "5", MovieGenre = "ExtremeAction", ActorName = "Rodruikruz", ActressName = "Kayla" },
           new Movie() { MovieTitle = "NapoleanBonaparte", MovieReviews = "5", MovieGenre = "Action", ActorName = "Cruise", ActressName = "Amy" },
           new Movie() { MovieTitle = "Troy", MovieReviews = "5", MovieGenre = "Action", ActorName = "BradPit", ActressName = "Jacky" },
           new Movie() { MovieTitle = "Eragon", MovieReviews = "4", MovieGenre = "Adventure", ActorName = "Harry", ActressName = "Hermione" },
           new Movie() { MovieTitle = "8Mile", MovieReviews = "5", MovieGenre = "Biography", ActorName = "Eminem", ActressName = "-" },
           new Movie() { MovieTitle = "Jobs", MovieReviews = "5", MovieGenre = "Biography", ActorName = "Steve", ActressName = "-"});




        }
        context.SaveChanges();

    }
}
    
    }