using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAnveshkumarKolluri.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DataAnveshkumarKolluri.Models
{
    public static class AppSeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {

            var context = serviceProvider.GetService<AppDbContext>();
            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Locations.Any())
            { return; }

                var l1 = context.Locations.Add(new Location() { Latitude = 40.3494179, Longitude = -94.9238399, Place = "Maryville", State = "Missouri", Country = "USA" }).Entity;
                var l2 = context.Locations.Add(new Location() { Latitude = 37.6991993, Longitude = -97.4843859, Place = "Wichita", State = "Kansas", Country = "USA" }).Entity;
                var l3 = context.Locations.Add(new Location() { Latitude = 40.3494179, Longitude = -94.9238399, Place = "Maryville", State = "Missouri", Country = "USA" }).Entity;
                var l4 = context.Locations.Add(new Location() { Latitude = 45.0993041, Longitude = -93.1007215, Place = "Whte Bear Lake", State = "Minnesota", Country = "USA" }).Entity;
                var l5 = context.Locations.Add(new Location() { Latitude = 17.4126272, Longitude = 78.2676166, Place = "Hyderabad", Country = "India" }).Entity;
                var l6 = context.Locations.Add(new Location() { Latitude = 25.9019385, Longitude = 84.6797775, Place = "Bihar", Country = "India" }).Entity;
                var l7 = context.Locations.Add(new Location() { Latitude = 36.8019385, Longitude = 44.6347775, Place = "Kent", Country = "USA" }).Entity;


            
                    if (!context.Movies.Any())
                    {
                context.Movies.AddRange(new Movie() { MovieTitle = "Indra", MovieReviews = "4.5", MovieGenre = "Action", ActorName = "Chiru", ActressName = "Arthi", Location = l1 },
           new Movie() { MovieTitle = "Hitler", MovieReviews = "5", MovieGenre = "ExtremeAction", ActorName = "Rodruikruz", ActressName = "Kayla", Location = l2 },
           new Movie() { MovieTitle = "NapoleanBonaparte", MovieReviews = "5", MovieGenre = "Action", ActorName = "Cruise", ActressName = "Amy", Location = l3 },
           new Movie() { MovieTitle = "Troy", MovieReviews = "5", MovieGenre = "Action", ActorName = "BradPit", ActressName = "Jacky", Location = l4 },
           new Movie() { MovieTitle = "Eragon", MovieReviews = "4", MovieGenre = "Adventure", ActorName = "Harry", ActressName = "Hermione", Location = l5 },
           new Movie() { MovieTitle = "8Mile", MovieReviews = "5", MovieGenre = "Biography", ActorName = "Eminem", ActressName = "-", Location = l6 },
           new Movie() { MovieTitle = "Jobs", MovieReviews = "5", MovieGenre = "Biography", ActorName = "Steve", ActressName = "-", Location = l7 });

                    
                   

                }
            context.SaveChanges();

        }





    }


    }


