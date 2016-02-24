using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace Team01_Project01.Models
{
    public class AppSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider, string appPath)
        {
            string relPath = appPath + "//Models//SeedData//";
            var context = serviceProvider.GetService<AppDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }
            context.Courses.RemoveRange(context.Courses);
            context.Schedule.RemoveRange(context.Schedule);
            context.SaveChanges();
            SeedCoursesFromCsv(relPath, context);
            SeedScheduleFromCsv(relPath, context);

        }
        private static void SeedCoursesFromCsv(string relPath, AppDbContext context)
        {
           
                string source = relPath + "Courses.csv";
                if (!File.Exists(source))
                {
                    throw new Exception("Cannot find file " + source);
                }
                //Courses.ReadAllFromCSV(source);
                List<Courses> lst = Courses.ReadAllFromCSV(source);
                context.Courses.AddRange(lst.ToArray());

                context.SaveChanges();
         }
        private static void SeedScheduleFromCsv(string relPath, AppDbContext context)
        {
            string source = relPath + "Schedules.csv";
            if (!File.Exists(source))
            {
                throw new Exception("Cannot find file " + source);
            }
            List<Schedule> lst = Schedule.ReadAllFromCSV(source);
            context.Schedule.AddRange(lst.ToArray());
            context.SaveChanges();
        }

    }
    }
