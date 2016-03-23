using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Schedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
            [Key]            
            public int ScheduleId { get; set; }
           
            [Display(Name = "Date")]
            [DataType(DataType.Date)]
            public DateTime date { get; set; }


        public int FacultyId { get; set; }
        public virtual Faculty Faculties { get; set; }

        public int CoursesId { get; set; }
        public virtual Courses Courses { get; set; }
            
       // public int SectionId { get; set; }
       // public virtual Section Sections { get; set; }

        public int LocationId { get; set; }
        public virtual Location Locations { get; set; }


        public static List<Schedule> ReadAllFromCSV(string filepath)
        {
            List<Schedule> lst = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => Schedule.OneFromCsv(v))
                                         .ToList();
            return lst;
        }
        public static Schedule OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Schedule item = new Schedule();

            int i = 0;
            item.ScheduleId = Convert.ToInt32(values[i++]);            
            item.date = Convert.ToDateTime(values[i++]);
            item.FacultyId = Convert.ToInt32(values[i++]);
            item.CoursesId = Convert.ToInt32(values[i++]);
            //item.SectionId = Convert.ToInt32(values[i++]);
            item.LocationId = Convert.ToInt32(values[i++]);

            return item;
        }

    }
}
